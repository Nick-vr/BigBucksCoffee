using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class CoffeeRepo : IMenuItemRepo
    {
        public List<IMenuItem> GetMenuItems()
        {
            var menuItems = new List<IMenuItem>
            {
                new Coffee(1, "Espresso", 3.5, "/images/espresso.png", 221, true, false, true),
                new Coffee(2, "Iced Coffee", 4.5, "/images/icedcoffee.jpg", 180, true, false, true),
                new Coffee(3, "Cappuccino", 4, "/images/cappuccino.jpg", 150, true, false, true),
            };
            return menuItems;
        }

        public IMenuItem GetMenuItem(int id)
        {
            List<IMenuItem> allMenuItems = GetMenuItems();

            // LAMBDA Expression. Return the first object in which the ID property equals user input
            return allMenuItems.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}