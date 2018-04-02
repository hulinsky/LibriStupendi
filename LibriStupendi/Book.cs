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
        // public string ISBN { get; set; }

        public Guid id { get; }

        public Book(string title, string author, int published)
        {
            id = Guid.NewGuid();
            Title = title;
            Author = author;
            Published = published;
        }

        public override string ToString()
        {
            object[] values = { Title, Author, Published };
            string s =
                "Title: {0}\n" +
                "Author: {1}\n" +
                "Published: {2}\n";
            return String.Format(s, values);
        }

        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
