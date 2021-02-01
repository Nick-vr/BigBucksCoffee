using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal interface IMenuItem
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        bool IsInStock { get; set; }
        string Image { get; set; }
        string Description { get; set; }

        string ToString();
    }
}