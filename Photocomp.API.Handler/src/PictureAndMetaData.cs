using System;
using System.Collections.Generic;
using System.Text;

namespace Photocomp.API.Handler
{
    class PictureAndMetaData
    {
        public int id { get; set; }
        public string url { get; set; }
        public int score { get; set; }
        public string author { get; set; }
        public string name { get; set; }
        public string license { get; set; }
        public string thumbnail { get; set; }
    }
}
