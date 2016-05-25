using System.Collections.Generic;
using PluralSightMVC.Models;

namespace PluralSightMVC.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DataStoreDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PluralSightMVC.Models.DataStoreDb";
        }

        protected override void Seed(DataStoreDb context)
        {
            context.Resturants.AddOrUpdate(r => r.Name,
                new Resturant {Name = "Smash Burger", City = "Washington, D.C.", Country = "USA"},
                new Resturant {Name = "Vlad's", City = "Crimea", Country = "Ukraine"},
                new Resturant
                {
                    Name = "Martian Kitchen",
                    City = "Eros",
                    Country = "The Belt",
                    Reviews =
                        new List<ResturantReview>
                        {
                            new ResturantReview {Rating = 7, Body = "Ok service, great freeze dried krill patties."}
                        }
                });
        }
    }
}
