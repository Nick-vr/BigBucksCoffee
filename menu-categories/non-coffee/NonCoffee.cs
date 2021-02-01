using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee.menu_categories.non_coffee
{
    internal abstract class NonCoffee : MenuItem
    {
        public bool IsHot { get; set; }
        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }

        public NonCoffee(int id, string name, double price, string image, bool isHot, bool hasMilk, bool hasSugar, bool isInStock = true, string description = "")
            : base(id, name, price, image, isInStock, description)
        {
            IsHot = isHot;
            HasMilk = hasMilk;
            HasSugar = hasSugar;
            Description = description;
            Id = id;
            Image = image;
            Name = name;
            Price = price;
            IsInStock = isInStock;
        }
    }
}