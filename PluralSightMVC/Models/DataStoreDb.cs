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
        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<ResturantReview> Reviews { get; set; }

    }
}
