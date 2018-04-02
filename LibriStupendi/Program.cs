using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LibriStupendi
{
    class Program
    {

        static void Main(string[] args)
        {

            BookList myBookList = new BookList();
            Librarian myLibrarian = new Librarian(myBookList);

            Menu myMenu = new Menu("--- Libri Stupendi ---");
            myMenu.AddMenuItem(new MenuItem("Add a new book", myLibrarian.NewBook));
            myMenu.AddMenuItem(new MenuItem("Remove a book", myLibrarian.RemoveBook));
            myMenu.AddMenuItem(new MenuItem("Show all books", myLibrarian.ShowAllBooks));
            myMenu.AddMenuItem(new MenuItem("Generate sample", myLibrarian.LoadSamples));
            myMenu.AddMenuItem(new MenuItem("Load list of books", myLibrarian.LoadBookList));
            myMenu.AddMenuItem(new MenuItem("Save list of books", myLibrarian.SaveBookList));
            myMenu.AddMenuItem(new MenuItem("Exit", myLibrarian.Exit, true));
            myMenu.ShowMenu();

            myMenu.MenuItems[3].Handler.Invoke();
            myMenu.MenuItems[2].Handler.Invoke();

            Console.ReadKey();

        }
    }
}
