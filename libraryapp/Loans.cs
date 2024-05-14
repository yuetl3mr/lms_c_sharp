using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryapp
{
    public class Loans
    {
        public Loans() { }
        public int LoanID { get; set; }
        public int UserID { get; set;}
        public int BookID { get; set; }
        public DateTime BorrowTime { get; set; }
        public DateTime DueTime { get; set;}
        public DateTime ReturnTime { get; set; }
    }
}
