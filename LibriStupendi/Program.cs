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
        public const string SAMPLE_FILENAME = "sample-books.json";

        static void Main(string[] args)
        {
            Console.WriteLine("--- Libri Stupendi ---");

            ListOfBooks myBooks = new ListOfBooks();

            using (StreamReader sr = new StreamReader(@SAMPLE_FILENAME))
            {
                string json = sr.ReadToEnd();
                myBooks = JsonConvert.DeserializeObject<ListOfBooks>(json);
            }

            string jsonListOutput = myBooks.ToJson();
            Console.WriteLine(jsonListOutput);
            ListOfBooks deserializeBooks = JsonConvert.DeserializeObject<ListOfBooks>(jsonListOutput);
            //deserializeBooks.PrintList();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("save.json"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, myBooks);
                }
            }

            Console.ReadKey();

        }
    }
}
