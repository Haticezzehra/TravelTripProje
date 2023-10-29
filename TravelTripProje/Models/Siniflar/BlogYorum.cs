using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Blog { get; set; }
        public IEnumerable<Yorumlar> Yorum {get;set;}
        public IEnumerable<Blog> Son3Blog { get; set; }
    }
}