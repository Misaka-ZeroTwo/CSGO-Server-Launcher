using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_Server_Launcher.Methods
{
    class GamemodeList
    {
        public static Dictionary<string, string> Gamemodes = new Dictionary<string, string>
        {
            { "休闲模式"," +game_type 0 +game_mode 0" },
            { "团队死斗"," +game_type 1 +game_mode 2" },
            { "个人死斗"," +game_type 1 +game_mode 2 + sv_skirmish_id 2" },
            { "竞技模式"," +game_type 0 +game_mode 2" },
            { "军备竞赛"," +game_type 1 +game_mode 0" },
            { "自定义模式", " +game_type 3 +game_mode 0" }
        };
    }
}
