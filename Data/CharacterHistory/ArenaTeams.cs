using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WotLKOnlineSimmingToolServer.Data.CharacterHistory
{
    public class ArenaTeams
    {
        public int id { get; set; }
        public int server_id { get; set; }
        public int server_uid { get; set; }
        public enum ArenaTeamSizeType { Size2v2 , Size3v3 , Size5v5 , Undefined }
        public string team_name { get; set; }
    }
}
