using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VD.Models.BasicItm
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
