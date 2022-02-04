using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WotLKOnlineSimmingToolServer.Data.CharacterHistory.CharacterInfo
{
    public class CharacterInfo
    {
        public CharacterGear gear { get; set; }
        public bool gender { get; set; }
        public int hero_class_id { get; set; }
        public int id { get; set; }
        public int level { get; set; }
        public int? profession1 { get; set; }
        public int? profession2 { get; set; }
        public int race_id { get; set; }
        public string talent_specialization { get; set; }
    }
}
