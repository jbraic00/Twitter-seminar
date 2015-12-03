using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace twitter_seminar.Models
{
    public class Hashtag
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public virtual Tweet Tweet { get; set; }
    }
}