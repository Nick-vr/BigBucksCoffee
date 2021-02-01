using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class Coffee : IMenuItem
    {
        public int Caffeine { get; set; }
        public bool IsHot { get; set; }
        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private bool _isInStock;

        public bool IsInStock
        {
            get { return _isInStock; }
            set { _isInStock = value; }
        }

        public Coffee(int caffeine, bool isHot, bool hasMilk, bool hasSugar, string description, int id, string image, string name, double price, bool isInStock)
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

        public override string ToString()
        {
            return null;
        }
    }
}