//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BigBucksCoffee
//{
//    internal class MenuItemRepo : IMenuItemRepo
//    {
//        public List<IMenuItem> GetMenuItems()
//        {
//            var menuItems = new List<IMenuItem>
//            {
//                new MenuItem(1, "Espresso", 3.5, "/images/espresso.png"),
//                new MenuItem(2, "Iced Coffee", 4.5, "/images/icedcoffee.jpg"),
//                new MenuItem(3, "Cappuccino", 4, "/images/cappuccino.jpg"),
//            };
//            return menuItems;
//        }

//        public IMenuItem GetMenuItem(int id)
//        {
//            List<IMenuItem> allMenuItems = GetMenuItems();

//            // LAMBDA Expression. Return the first object in which the ID property equals user input
//            return allMenuItems.Where(x => x.Id == id).FirstOrDefault();
//        }
//    }
//}