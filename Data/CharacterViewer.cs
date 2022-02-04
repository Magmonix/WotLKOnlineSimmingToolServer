using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WotLKOnlineSimmingToolServer.Data
{
    public class CharacterViewer
    {
        public int character_id { get; set; }
        public bool faction { get; set; }
        public CharacterViewerGear gear { get; set; }
        public bool gender { get; set; }
        public Guild guild { get; set; }
        public int hero_class_id { get; set; }
        public History[] history { get; set; }
        public int history_id { get; set; }
        public int level { get; set; }
        public string name { get; set; }
        public Profession profession1 { get; set; } 
        public Profession profession2 { get; set; } 
        public int race_id { get; set; }
        public int server_id { get; set; }
        public string server_name { get; set; }
        public Stats[] stats { get; set; } 
        public Talent_specialization talent_specialization { get; set; }
    }
}
