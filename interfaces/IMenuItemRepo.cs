﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksCoffee
{
    internal interface IMenuItemRepo
    {
        List<IMenuItem> GetMenuItems();

        IMenuItem GetMenuItem(int id);
    }
}