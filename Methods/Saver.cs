using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CSGO_Server_Launcher.Methods
{
    public class Saver
    {
        public static string[] FavoriteCollections;
        public static string[] Config;
        public static void CheckConfig()
        {
            string ConfigPath = Path.Combine(Directory.GetCurrentDirectory(), "Config.txt");
            string CollectionsPath = Path.Combine(Directory.GetCurrentDirectory(), "Collections.txt");
            if (!File.Exists(ConfigPath))
            {
                File.Create(ConfigPath).Close();
            }
            if (!File.Exists(CollectionsPath))
            {
                File.Create(ConfigPath).Close();
            }
            GetFavoriteCollectionsList(CollectionsPath);
            GetConfig(ConfigPath);
        }
        public static void GetFavoriteCollectionsList(string path)
        {
            FavoriteCollections = File.ReadAllLines(path);
        }
        public static void GetConfig(string path)
        {
            Config = File.ReadAllLines(path);
        }
    }
}
