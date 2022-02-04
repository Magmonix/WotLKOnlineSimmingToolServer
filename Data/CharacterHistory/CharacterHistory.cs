using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WotLKOnlineSimmingToolServer.Data.CharacterHistory.CharacterInfo
{
    public class CharacterHistory
    {
        public ArenaTeams[] arena_teams { get; set; }
        public Character_Guild character_guild { get; set; }
        public int character_id { get; set; }
        public CharacterInfo character_info { get; set; } 
        public string character_name { get; set; }
        public int? character_title { get; set; }
        public Facial facial { get; set; } 
        public int id { get; set; }
        public int? profession_skill_points1 { get; set; }
        public int? profession_skill_points2 { get; set; }
        public int timestamp { get; set; }
    }
}
