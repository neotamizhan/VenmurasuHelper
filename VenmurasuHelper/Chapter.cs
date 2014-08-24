using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenmurasuHelper
{
    class Chapter
    {
        public int novelno { get; set; }
        public string novelname { get; set; }
        public int sectionno { get; set; }
        public string sectionname { get; set; }
        public int chapter { get; set; }
        public string published_on { get; set; }
        public string url { get; set; }
        public string image { get; set; }
        public List<string> tags { get; set; }
    }
}
