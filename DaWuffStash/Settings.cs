using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DaWuffStash
{
    public static class Settings
    {
        private static Preferences p_preferences;
        public static Preferences preferences
        {
            get
            {
                p_preferences = p_preferences == null ? FetchPreferences() : p_preferences;
                return p_preferences;
            }
            set
            {
                p_preferences = value;
                ForceSave();
            }
        }

        public static string GetPostsPath()
        {
            if (preferences.nativePath)
                return Path.GetFullPath("Posts");
            else
                return preferences.savePath;
        }
        public static string GetPreviewPostsPath()
        {
            if (preferences.nativePath)
                return Path.GetFullPath("Posts/Preview");
            else
                return Path.Combine(preferences.savePath, "Preview");
        }
        const string p = "preferences.json";

        public static void ForceLoad()
        {
            p_preferences = FetchPreferences();
        }

        public static void ForceSave()
        {
            File.WriteAllText(p, JsonConvert.SerializeObject(preferences, Formatting.Indented));
        }

        public static Preferences FetchPreferences()
        {
            if(File.Exists(p))
            {
                return JsonConvert.DeserializeObject<Preferences>(File.ReadAllText(p));
            }
            return new Preferences();
        }

        #region History
        private static History p_history;
        public static History history
        {
            get
            {
                p_history = p_history == null ? FetchHistory() : p_history;
                return p_history;
            }
            set
            {
                p_history = value;
                ForceSave();
            }
        }
        const string h = "history.json";

        public static void HistorySave()
        {
            File.WriteAllText(h, JsonConvert.SerializeObject(history, Formatting.Indented));
        }

        public static History FetchHistory()
        {
            if (File.Exists(h))
            {
                return JsonConvert.DeserializeObject<History>(File.ReadAllText(h));
            }
            return new History();
        }
        #endregion
    }

    public class Preferences
    {
        // General
        public int hostType;
        public int imageViewType;
        public bool hideToTray = true;

        // Storage
        public string savePath = Path.GetFullPath("Posts");
        public bool nativePath = true;
    }

    public class History
    {
        public string searchTag;
        public int page = 1;
        public List<string> searchedTags = new List<string>();

        public bool bubbleShowed;
        public eData.Posts postsData;
    }
}
