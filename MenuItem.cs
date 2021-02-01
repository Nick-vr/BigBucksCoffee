using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class MenuItem : IMenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsInStock { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public MenuItem(int id, string name, double price, string image, bool isInStock = true, string description = "")
        {
            Id = id;
            Name = name;
            Price = price;
            IsInStock = isInStock;
            Image = image;
            Description = description;
        }
    }
}