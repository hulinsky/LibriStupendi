using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibriStupendi
{
    public class MenuItem
    {
        public string ItemDescription { get; }
        public Action ItemHandler { get; }
        public bool ItemExitOption { get; }

        public MenuItem(string itemDescription, Action itemHandler, bool itemExitOption = false)
        {
            // maybe better with this.
            ItemDescription = itemDescription;
            ItemHandler = itemHandler;
            ItemExitOption = itemExitOption;
        }
    }

}