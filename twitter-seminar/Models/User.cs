using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace twitter_seminar.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string PictureUrl { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Location { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Tweet> UserTweets { get; set; }
        [InverseProperty("UsersFavorited")]
        public virtual ICollection<Tweet> FavoritedTweets { get; set; }
        public virtual ICollection<User> FollowedUsers { get; set; }
        public virtual ICollection<Comment> UserComments { get; set; }
    }
}