using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibriStupendi
{
    public class MenuItem
    {
        public string Description { get; }
        public Action Handler { get; }
        public bool ExitOption { get; }

        public MenuItem(string description, Action handler, bool exitOption = false)
        {
            // maybe better with this.
            this.Description = description;
            this.Handler = handler;
            this.ExitOption = exitOption;
        }
    }

}