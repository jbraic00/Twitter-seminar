using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace twitter_seminar.DAL
{
    public class TwitterInitializer : DropCreateDatabaseAlways<TwitterContext>
    {
        protected override void Seed(TwitterContext context)
        {
            
        }
    }
}