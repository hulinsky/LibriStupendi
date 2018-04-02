using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibriStupendi
{

    public class Menu
    {
        public List<MenuItem> menu;
        private string Title;

        public Menu(string title)
        {
            this.Title = title;
            this.menu = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            this.menu.Add(menuItem);
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(this.Title);
            int itemCount = 1;
            foreach (var item in this.menu)
            {
                Console.WriteLine($"{itemCount++}. {item.ItemDescription}");
            }

        }

        public void GetSelection (List<MenuItem> MainMenu)
        {

        }
    }


}
