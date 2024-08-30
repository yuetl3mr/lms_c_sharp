using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryapp
{
    public class Books
    {
        public Books() { }
        public Books(int bookID, string name, int categoryID, int number, string author, DateTime publication)
        {
            BookID = bookID;
            Name = name;
            CategoryID = categoryID;
            Number = number;
            Author = author;
            Publication = publication;
        }
        public int BookID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int Number { get; set; }
        public string Author { get; set; }
        public DateTime Publication {  get; set; }
    }
}
