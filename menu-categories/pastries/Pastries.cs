using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class Pastries : MenuItem
    {
        public bool IsGlutenFree { get; set; }

        public Pastries(int id, string name, double price, string image, bool isGlutenFree, bool isInStock = true, string description = "")
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