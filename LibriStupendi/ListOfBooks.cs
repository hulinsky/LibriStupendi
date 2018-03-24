using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibriStupendi
{
    class ListOfBooks
    {
        [JsonProperty("books")]
        private List<Book> books;

        public ListOfBooks()
        {
            this.books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public void PrintList()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public void PrintTitlesByAuthor(string author)
        {

        }

        public void PrintBooksInYears(int startYear, int endYear)
        {

        }

        public void PrintBooksByGenre(string genre)
        {

        }
    }

}
