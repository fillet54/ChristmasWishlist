using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChristmasWishlist.Models
{
    public class WishlistItem
    {
        public String Title { get; set; }
        public String Url { get; set; }
        public String Note { get; set; }
        public String Description { get; set; }
        public String ImageUrl { get; set; }
    }
}