using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibriStupendi
{

    public class Menu
    {
        public List<MenuItem> MenuItems;
        private string Title;

        public Menu(string title)
        {
            this.Title = title;
            this.MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Add(menuItem);
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(this.Title);
            int itemCount = 1;
            foreach (var item in this.MenuItems)
            {
                Console.WriteLine($"{itemCount++}. {item.Description}");
            }

        }

        public void GetSelection (List<MenuItem> MainMenu)
        {

        }
    }


}
