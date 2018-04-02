using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LibriStupendi
{
    class Librarian
    {
        public const string SAMPLE_FILENAME = "sample-books.json";
        public const string USER_FILENAME = "mybooks.json";

        BookList books;

        public Librarian(BookList books)
        {
            this.books = books;
        }

        public void NewBook()
        {
            Console.WriteLine("This is a NewBook action.");
        }

        public void RemoveBook()
        {
            Console.WriteLine("This is a RemoveBook action");
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("This is a ShowAllBooks action");
            this.books.ShowAllBooks();
        }

        private void _loadBookList(string filename)
        {
            using (StreamReader sr = new StreamReader(@filename))
            {
                string json = sr.ReadToEnd();
                this.books = JsonConvert.DeserializeObject<BookList>(json);
            }
        }

        private void _writeBookList(string filename)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@filename))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, this.books);
                }
            }
        }

        public void ReadBookList()
        {
            _loadBookList(SAMPLE_FILENAME);
        }

        public void SaveBookList()
        {
            _writeBookList(USER_FILENAME);
        }

    }
}
