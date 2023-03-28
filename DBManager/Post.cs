using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public class Post
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public user user { get; set; }
    }
}
