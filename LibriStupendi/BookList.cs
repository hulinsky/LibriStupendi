using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibriStupendi
{
    class BookList
    {
        [JsonProperty("books")]
        private List<Book> books;

        public BookList()
        {
            this.books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public void RemoveBook(Guid id)
        {
            this.books.Remove(this.books.Find(Id => Id.Equals(id)));
        }

        public void ShowAllBooks()
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
