using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class NonCoffeeRepo : IMenuItemRepo
    {
        public List<IMenuItem> GetMenuItems()
        {
            var menuItems = new List<IMenuItem>
            {
                new MenuItem(4, "Hot Tea", 3, "/images/hottea.jpg"),
                new MenuItem(5, "Chai", 5.5, "/images/chai.jpg"),
                new MenuItem(6, "Lemonade", 3.5, "/images/lemonade.jpg"),
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