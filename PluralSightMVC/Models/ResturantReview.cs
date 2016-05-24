using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightMVC.Models
{
    public class ResturantReview
    {
        
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }
        public int RestaurantId { get; set; }
        
    }
}
