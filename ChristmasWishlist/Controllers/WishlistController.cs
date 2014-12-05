using ChristmasWishlist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChristmasWishlist.Controllers
{
    public class WishlistController : Controller
    {
        private List<WishlistItem> WishlistItems = new List<WishlistItem>
        {
            new WishlistItem
            {
               Title="MagBak",
               Description = "Mounts your iPad to your car, kitchen & anywhere else. provides the perfect grip. protects your ipad. snaps the smartcover to the back.",
               Url = "http://amzn.com/b00heumbba",
               ImageUrl = "images/2014/pic01-magbak.jpg"
            },
            new WishlistItem
            {
                Title = "Speaker Binding Posts",
                Description = "superior design, materials, and construction, at a sensible price—the dayton audio bpa-38g heavy-duty binding post pair is the low cost/high fidelity option!",
                Url = "http://www.parts-express.com/dayton-audio-bpa-38g-hd-binding-post-pair-gold--091-1245",
                ImageUrl = "images/2014/pic02-posts.jpg"
            },
            new WishlistItem
            {
                Title = "DTA-120 Amplifier",
                Note = "Pick this up while getting the binding posts and save on shipping!!",
                Description = "The small and powerful class t amplifier installs virtually anywhere. it produces big-amp sound while occupying minimal space on your desk or a/v cabinet.",
                Url = "http://www.parts-express.com/dayton-audio-dta-120-class-t-digital-mini-amplifier-60-wpc--300-3800",
                ImageUrl ="images/2014/pic03-amp.jpg"
            },
            new WishlistItem
            {
                Title = "16-Gauge Speaker Wire",
                Description = "not much to describe here. just plain old speaker wire so i can finish the speakers jess got me last year! oh and hide the wire thats been showing for two years! really this is a gift for jess.",
                Url = "http://amzn.com/b006lw0wdq",
                ImageUrl = "images/2014/pic04-wire.jpg"
            },
            new WishlistItem
            {
                Title = "Kester Pocker Solder",
                Description = "Basic solder to help me complete my speakers. Jessie says yes!!!!",
                Url = "http://amzn.com/b00068ijnq",
                ImageUrl = "images/2014/pic05-solder.jpg"
            },
            new WishlistItem
            {
                Title = "xkcd Volume 0",
                Note = "I actually want this book in paper form! I know crazy huh?",
                Description = "Randall Munroe describes xkcd as a webcomic of romance, sarcasm, math, and language.",
                Url = "http://amzn.com/0615314465",
                ImageUrl = "images/2014/pic06-xkcd.jpg"
            },
            new WishlistItem
            {
                Title = "Ubiquity Unifi AP",
                Description = "A new wireless access point because you know how cranky i get when i don't get my wifi!!!",
                Url = "http://amzn.com/b004xxmucq",
                ImageUrl = "images/2014/pic07-ap.jpg"
            },
            new WishlistItem
            {
                Title = "iFixit Geek Toolset",
                Description = "You guys know I love fixing, err, taking stuff apart. Make my, and your life easier by getting me the proper tools to do so.",
                Url = "http://amzn.com/B007XGWQ2Y",
                ImageUrl = "images/2014/pic08-ifixit.jpg"
            }
        };

        // GET: Wishlist
        public ActionResult Index()
        {
            return View(WishlistItems);
        }
    }
}