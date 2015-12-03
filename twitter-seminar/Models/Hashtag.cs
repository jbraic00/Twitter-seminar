using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace twitter_seminar.Models
{
    public class Hashtag
    {
        public int ID { get; set; }
        [RegularExpression(@"(?:^|\s)\s*(#[A-Za-z][A-Za-z0-9-_]+)")]
        //[RegularExpression(@"(?<=\s|^)#(\w*[A-Za-z_]+\w*)")]
        public string Text { get; set; }

        public virtual Tweet Tweet { get; set; }
    }
}