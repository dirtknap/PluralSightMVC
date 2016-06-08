using System.Collections.Generic;
using PluralSightMVC.Models;

namespace PluralSightMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataStoreDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PluralSightMVC.Models.DataStoreDb";
        }

        protected override void Seed(DataStoreDb context)
        {

            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant {Name = "Tasty Ghoul", City = "Baltimore", Country = "USA"},
                new Restaurant {Name = "Stuffer Shack", City = "Seattle", Country = "USA"},
                new Restaurant
                {
                    Name = "McDowels",
                    City = "Detroit",
                    Country = "USA",
                    Reviews = new List<RestaurantReview>
                    {
                        new RestaurantReview() {Rating = 9, Body = "That stuff is G-U-D!", ReviewerName = "Eddie"}
                    }
                });
        }
    }
}
