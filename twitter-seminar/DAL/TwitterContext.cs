using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using twitter_seminar.Models;

namespace twitter_seminar.DAL
{
    public class TwitterContext : DbContext
    {
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}