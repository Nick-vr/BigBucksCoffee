using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal class PastriesRepo : IMenuItemRepo
    {
        public List<IMenuItem> GetMenuItems()
        {
            var menuItems = new List<IMenuItem>
            {
                new MenuItem(7, "Muffin", 3, "/images/muffin.jpg"),
                new MenuItem(8, "Bagel", 4.5, "/images/bagel.jpg"),
                new MenuItem(9, "Cinnamonroll", 5, "/images/cinnamonroll.jpg"),
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