using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WotLKOnlineSimmingToolServer.Data
{
    public class Server
    {
        public int id { get; set; }
        public int expansion_id { get; set; }
        public string name { get; set; }
        public string patch { get; set; }
        public bool is_retail { get; set; }
        public bool archived { get; set; }
    }
}
