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
        public int BookID { get; set; }
        public string? Name { get; set; }
        public int? CategoryID { get; set; }
        public string? Author { get; set; }
        public DateTime? Publication {  get; set; }
    }
}
