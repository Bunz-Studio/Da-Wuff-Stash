using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DaWuffStash
{
    public class APICenter
    {
        public static string mainDomainSFW = "https://e926.net/";
        public static string mainDomainNSFW = "https://e621.net/";
        public static string getPost = "posts.json";
        public static string tagSearch = "?tags=";

        public static NetworkRequest<eData.Posts> GetPosts(HostType host, string tags, string page, string limit)
        {
            string mainDomain = host == HostType.NSFW ? mainDomainNSFW : mainDomainSFW;
            string urlRequest = null;
            if (!string.IsNullOrEmpty(tags))
            {
                if (string.IsNullOrEmpty(urlRequest)) urlRequest += "?";
                urlRequest += "tags=" + tags.Replace(' ', '+');
            }
            if (!string.IsNullOrEmpty(limit))
            {
                if (string.IsNullOrEmpty(urlRequest)) urlRequest += "?"; else urlRequest += "&";
                urlRequest += "limit=" + limit;
            }
            if (!string.IsNullOrEmpty(page))
            {
                if (string.IsNullOrEmpty(urlRequest)) urlRequest += "?"; else urlRequest += "&";
                urlRequest += "page=" + page;
            }

            var netReq = new NetworkRequest<eData.Posts>();
            netReq.preparedUrl = mainDomain + getPost + urlRequest;
            // netReq.Start(mainDomain + getPost + urlRequest);
            return netReq;
        }

        public enum HostType
        {
            SFW,
            NSFW
        }
    }

    public static class ImageCollectionCenter
    {
        public static List<CachedImageRequest> requests = new List<CachedImageRequest>();

        public static ImageRequest GetImage(eData.Post post, bool preview)
        {
            Console.WriteLine("Getting image of post: " + post.id);
            var r = new CachedImageRequest(post, preview, null);

            var imgReq = new ImageRequest();
            imgReq.PrepareAll(post, preview);
            Console.WriteLine("Url defined: " + imgReq.url);

            var req = requests.Find(val => val.request.url == imgReq.url);
            if(req != null)
            {
                Console.WriteLine("Found similar request: " + req.request.url);
                return req.request;
            }
            r.request = imgReq;
            requests.Add(r);
            return imgReq;
        }

        public static void RemoveRequest(ImageRequest req)
        {
            var y = requests.Find(val => val.request == req);
            if(y != null)
            {
                requests.Remove(y);
            }
        }
    }

    public class CachedImageRequest
    {
        public eData.Post post;
        public bool preview;
        public ImageRequest request;

        public CachedImageRequest(eData.Post p, bool pr, ImageRequest re)
        {
            post = p;
            preview = pr;
            request = re;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var p = (CachedImageRequest)obj;
            return (post == p.post) && (preview == p.preview);
        }
    }
    
    public class ImageRequest
    {
        public Action<ImageResult> onSuccess;
        public Action<DownloadProgressChangedEventArgs> onProgress;
        public Action<Exception> onError;
        public ImageResult imageResult;

        public string url;
        public WebClient client;
        public string fileName;
        public string directory;
        public bool isVideo;

        public void PrepareAll(eData.Post post, bool preview)
        {
            url = preview ? post.preview.url : post.file.url;
            if (string.IsNullOrWhiteSpace(url)) return;

            fileName = Path.GetFileName(url);
            isVideo = Path.GetExtension(url).Contains("webm") || Path.GetExtension(url).Contains("mp4");
            directory = preview ? "Posts/Preview" : "Posts";
        }

        public void Start(eData.Post post, bool preview)
        {
            if(imageResult != null)
            {
                onSuccess.TryInvoke(imageResult);
            }

            url = preview ? post.preview.url : post.file.url;

            if (string.IsNullOrWhiteSpace(url))
            {
                onError.TryInvoke(new Exception("Invalid url associated with: " + post.id));
                return;
            }
            fileName = Path.GetFileName(url);
            isVideo = Path.GetExtension(url).Contains("webm") || Path.GetExtension(url).Contains("mp4");
            string previewPath = Settings.GetPreviewPostsPath();
            directory = preview ? previewPath : Settings.GetPostsPath();
            Console.WriteLine("Getting image for: " + url);
            if (!Directory.Exists(previewPath)) Directory.CreateDirectory(previewPath);
            string savePath = Path.Combine(directory, fileName);
            Console.WriteLine("Is preview: " + preview);
            Console.WriteLine("With path: " + savePath);

            if (File.Exists(savePath))
            {
                // ReadImageAsync(savePath);
                try
                {
                    if (isVideo)
                        imageResult = new ImageResult(null, savePath, true);
                    else
                        imageResult = new ImageResult(Image.FromFile(savePath), savePath, false);
                    onSuccess.TryInvoke(imageResult);
                }
                catch (Exception e)
                {
                    onError.TryInvoke(e);
                }
            }
            else
            {
                client = new WebClient();
                client.DownloadDataCompleted += Client_DownloadDataCompleted;
                client.DownloadProgressChanged += (sen, val) => { if (onProgress != null) onProgress.Invoke(val); };
                client.DownloadDataAsync(new Uri(url));
            }
        }

        private void Client_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                onError.TryInvoke(e.Error);
                return;
            }

            // WriteAndGetImageAsync(e.Result);
            try
            {
                string savePath = Path.Combine(directory, fileName);
                File.WriteAllBytes(savePath, e.Result);

                if (isVideo)
                    imageResult = new ImageResult(null, savePath, true);
                else
                    imageResult = new ImageResult(Image.FromFile(savePath), savePath, false);
                onSuccess.TryInvoke(imageResult);
            }
            catch (Exception ee)
            {
                onError.TryInvoke(ee);
            }
        }

        #region Legacy
        /*public async void WriteAndGetImageAsync(byte[] bytes)
        {
            await Task.Run(() => WriteAndGetImageAsync(bytes));
        }

        public async Task WriteAndGetImageTask(byte[] bytes)
        {
            try
            {
                string savePath = Path.Combine(directory, fileName);
                File.WriteAllBytes(savePath, bytes);

                imageResult = Image.FromFile(savePath);
                onSuccess.TryInvoke(imageResult);
            }
            catch (Exception e)
            {
                onError.TryInvoke(e);
            }
        }

        public async void ReadImageAsync(string path)
        {
            await Task.Run(() => ReadImageTask(path));
        }

        public async Task ReadImageTask(string path)
        {
            System.Threading.Thread.Sleep(100);
            try
            {
                imageResult = Image.FromFile(path);
                onSuccess.TryInvoke(imageResult);
            }
            catch (Exception e)
            {
                onError.TryInvoke(e);
            }
        }*/
        #endregion

        public void Cancel()
        {
            onSuccess = null;
            onProgress = null;
            onError = null;
            if (client != null)
            {
                client.CancelAsync();
                client.Dispose();
            }
            ImageCollectionCenter.RemoveRequest(this);
        }

        public class ImageResult
        {
            public Image image;
            public string path;
            public bool isVideo;
            
            public ImageResult(Image img, string pth, bool video)
            {
                image = img;
                path = pth;
                isVideo = video;
            }
        }
    }

    public class NetworkRequestBase
    {
        public virtual void Start(string url)
        {

        }

        public virtual void Cancel()
        {

        }
    }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
    public class NetworkRequest<T> : NetworkRequestBase
    {
        public Action<T> onSuccess;
        public Action<Exception> onError;
        public string userAgent = "BunzhidaWinForm";
        public HttpWebResponse resp;
        public HttpWebRequest request;
        public string preparedUrl;

        bool isCancelled;
        
        public override void Start(string url)
        {
            StartTask(url);
        }

        public async void StartTask(string url)
        {
            await Task.Run(() => StartAsync(url));
        }

        public async Task StartAsync(string url)
        {
            string html = string.Empty;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;
                request.UserAgent = userAgent;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    resp = response;
                    using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        html = reader.ReadToEnd();
                        if (isCancelled) return;
                    }

                    try
                    {
                        var item = JsonConvert.DeserializeObject(html, typeof(T));
                        if(item != null)
                        {
                            if(onSuccess != null) onSuccess.Invoke((T)item);
                        }
                        else
                        {
                            if (onError != null) onError.Invoke(new Exception("Failed to deserialize parse object: " + html));
                        }
                    }
                    catch (Exception e)
                    {
                        if (onError != null) onError.Invoke(e);
                    }
                }
            }
            catch (Exception e)
            {
                if(onError != null) onError.Invoke(e);
            }
        }

        public override void Cancel()
        {
            onSuccess = null;
            onError = null;
            if (request != null)
            {
                request.Abort();
                request = null;
                if (resp != null)
                {
                    resp.Close();
                    resp = null;
                }
            }
            isCancelled = true;
        }
    }
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously

    public class eData
    {
        [Serializable]
        public class Posts
        {
            public List<Post> posts { get; set; }
        }

        public class Post
        {
            public int? approver_id { get; set; }
            public int change_seq { get; set; }
            public int comment_count { get; set; }
            public string created_at { get; set; }
            public string description { get; set; }
            public object duration { get; set; }
            public int fav_count { get; set; }
            public FileInfo file { get; set; }
            public Flags flags { get; set; }
            public bool has_notes { get; set; }
            public int id { get; set; }
            public bool is_favorited { get; set; }
            public List<object> locked_tags { get; set; }
            public List<int> pools { get; set; }
            public Preview preview { get; set; }
            public string rating { get; set; }
            public Relationships relationships { get; set; }
            public Sample sample { get; set; }
            public Score score { get; set; }
            public List<string> sources { get; set; }
            public Tags tags { get; set; }
            public string updated_at { get; set; }
            public int uploader_id { get; set; }

            [JsonIgnore]
            public Image previewImage;
        }
        [Serializable]
        public class FileInfo
        {
            public string ext { get; set; }
            public int height { get; set; }
            public string md5 { get; set; }
            public int size { get; set; }
            public string url { get; set; }
            public int width { get; set; }
        }
        [Serializable]
        public class Flags
        {
            public bool deleted { get; set; }
            public bool flagged { get; set; }
            public bool note_locked { get; set; }
            public bool pending { get; set; }
            public bool rating_locked { get; set; }
            public bool status_locked { get; set; }
        }
        [Serializable]
        public class Preview
        {
            public int height { get; set; }
            public string url { get; set; }
            public int width { get; set; }
        }
        [Serializable]
        public class Relationships
        {
            public List<int> children { get; set; }
            public bool has_active_children { get; set; }
            public bool has_children { get; set; }
            public int? parent_id { get; set; }
        }
        [Serializable]
        public class Sample
        {
            public Alternates alternates { get; set; }
            public bool has { get; set; }
            public int height { get; set; }
            public string url { get; set; }
            public int width { get; set; }
        }
        [Serializable]
        public class Alternates
        {
        }

        [Serializable]
        public class Score
        {
            public int down { get; set; }
            public int total { get; set; }
            public int up { get; set; }
        }
        [Serializable]
        public class Tags
        {
            public List<string> artist { get; set; }
            public List<string> character { get; set; }
            public List<string> copyright { get; set; }
            public List<string> general { get; set; }
            public List<string> invalid { get; set; }
            public List<object> lore { get; set; }
            public List<string> meta { get; set; }
            public List<string> species { get; set; }
        }
        public static Posts GetExamplePosts()
        {
            var postss = new Posts();
            postss.posts = new List<Post>();
            postss.posts.Add(GetExamplePost());
            postss.posts.Add(GetExamplePost());
            postss.posts.Add(GetExamplePost());
            return postss;
        }
        public static Post GetExamplePost()
        {
            Post post = new Post();
            post.approver_id = null;
            post.change_seq = 34824485;
            post.comment_count = 0;
            post.description = "[color=#ff6600]\"https://www.furaffinity.net/user/moomis/\":https://www.furaffinity.net/user/moomis/[/color]\n[color=#00ffff]\"https://twitter.com/MoomisMoomis\":https://twitter.com/MoomisMoomis[/color]\n\u003c3 - Moomis";
            post.duration = 0;
            post.fav_count = 0;
            post.file = new FileInfo();
            post.file.ext = "jpg";
            post.file.height = 4995;
            post.file.md5 = "6d29c8418473172651ff3e908aaea60a";
            post.file.size = 3943641;
            post.file.url = null;
            post.file.width = 6168;
            return post;
        }
    }
}