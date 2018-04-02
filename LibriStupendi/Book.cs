using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibriStupendi
{
    class Book
    {
        [JsonProperty("Title")]
        public string Title { get; }

        [JsonProperty("Author")]
        public string Author { get; }

        [JsonProperty("Published")]
        public int Published { get; }

        // public string Genre { get; set; }

        [JsonProperty("Id")]
        public Guid Id { get; }

        public Book(string title, string author, int published, Guid id)
        {
            if (id == Guid.Empty)
            {
                this.Id = Guid.NewGuid();
            }
            else
            {
                this.Id = id;
            }
            this.Title = title;
            this.Author = author;
            this.Published = published;
        }

        public override string ToString()
        {
            object[] values = { Title, Author, Published, Id };
            string s =
                "Title: {0}\n" +
                "Author: {1}\n" +
                "Published: {2}\n" +
                "Guid: {3}\n";
            return String.Format(s, values);
        }

        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
