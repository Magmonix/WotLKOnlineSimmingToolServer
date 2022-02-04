using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WotLKOnlineSimmingToolServer.Data.CVGear;

namespace WotLKOnlineSimmingToolServer.Data
{
    public class CharacterViewerGear
    {
        public Back back { get; set; }
        public Belt belt { get; set; }
        public Boot boot { get; set; }
        public Chest chest { get; set; }
        public int gear_id { get; set; }
        public Glove glove { get; set; }
        public Head head { get; set; }
        public Leg leg { get; set; }
        public Main_hand main_hand { get; set; }
        public Neck neck { get; set; }
        public Off_hand off_hand { get; set; }
        public Ring1 ring1 { get; set; }
        public Ring2 ring2 { get; set; }
        public Shirt shirt { get; set; }
        public Shoulder shoulder { get; set; }
        public Tabard tabard { get; set; }
        public Ternary_hand ternary_Hand { get; set; }
        public Trinket1 trinket1 { get; set; }
        public Trinket2 trinket2 { get; set; }
        public Wrist wrist { get; set; }
    }
}
