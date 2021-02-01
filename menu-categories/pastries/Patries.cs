using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal abstract class Patries : MenuItem
    {
        public bool IsGlutenFree { get; set; }

        public Patries(int id, string name, double price, string image, bool isGlutenFree, bool isInStock = true, string description = "")
            : base(id, name, price, image, isInStock, description)
        {
            IsGlutenFree = isGlutenFree;
            Description = description;
            Id = id;
            Image = image;
            Name = name;
            Price = price;
            IsInStock = isInStock;
        }
    }
}