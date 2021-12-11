using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using CSGO_Server_Launcher;
using static CSGO_Server_Launcher.Methods.CollectionsList;

namespace CSGO_Server_Launcher.Methods
{
    public class Saver
    {
        public static string ConfigPath = Path.Combine(Directory.GetCurrentDirectory(), "Config.txt");
        public static string FavoritePath = Path.Combine(Directory.GetCurrentDirectory(), "Collections.txt");
        public static string GLST;
        public static string authkey;
        public static void CheckConfig()
        {
            if (!File.Exists(ConfigPath))
            {
                File.Create(ConfigPath).Close();
                File.AppendAllText(ConfigPath, "GSLT: ");
                File.AppendAllText(ConfigPath, Environment.NewLine+ "authkey: ");
            }
            if (!File.Exists(FavoritePath))
            {
                File.Create(FavoritePath).Close();
            }
        }
        public static void GetFavoriteCollectionsList(string path)
        {
            foreach(string str in File.ReadAllLines(path))
            {
                Collections.Add(str.Split('|').ElementAt(0), str.Split('|').ElementAt(1));
            }
        }
        public static void GetConfig(string path)
        {
            foreach(string str in File.ReadAllLines(path))
            {
                if(str.Split(':').ElementAt(0) == "GSLT" && str.Split(':').ElementAt(1) != null)
                {
                    GLST = str.Split(':').ElementAt(1);
                }
                else if(str.Split(':').ElementAt(0) == "authkey" && str.Split(':').ElementAt(1) != null)
                {
                    authkey = str.Split(':').ElementAt(1);
                }
            }
        }
        public static void OnStart()
        {
            CheckConfig();
            GetConfig(ConfigPath);
            GetFavoriteCollectionsList(FavoritePath);
        }
        public static void AddToFavorite(string title, string arguments)
        {
            File.AppendAllText(FavoritePath, title + "|" + arguments);
        }

    }
}
