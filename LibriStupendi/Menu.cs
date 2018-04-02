using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibriStupendi
{

    public class Menu
    {
        private List<MenuItem> MainMenu;
        private string Title;

        public Menu(string title)
        {
            this.Title = title;
            this.MainMenu = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            this.MainMenu.Add(menuItem);
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(this.Title);
            int itemCount = 1;
            foreach (var item in this.MainMenu)
            {
                Console.WriteLine($"{itemCount++}. {item.ItemDescription}");
            }

        }

        public void GetSelection (List<MenuItem> MainMenu)
        {

        }
    }


}
