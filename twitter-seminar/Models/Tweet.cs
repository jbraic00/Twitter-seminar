using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace twitter_seminar.Models
{
    public class Tweet
    {
        public int ID { get; set; }
        [StringLength(140)]
        public string Text { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime TimeTweeted { get; set; }

        public virtual User User { get; set; }
        [InverseProperty("FavoritedTweets")]
        public virtual ICollection<User> UsersFavorited { get; set; }
        public virtual ICollection<Hashtag> Hashtags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}