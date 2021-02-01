using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal abstract class Coffee : MenuItem
    {
        public int Caffeine { get; set; }
        public bool IsHot { get; set; }
        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }

        public Coffee(int id, string name, double price, string image, int caffeine, bool isHot, bool hasMilk, bool hasSugar, bool isInStock = true, string description = "")
            : base(id, name, price, image, isInStock, description)
        {
            Caffeine = caffeine;
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