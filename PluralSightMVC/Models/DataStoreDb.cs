using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightMVC.Models
{
    class DataStoreDb : DbContext
    {
        public DataStoreDb() : base("name=DefaultConnection")
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }

    }
}
