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
        public Loans(int loanID, int userID, int bookID)
        {
            LoanID = loanID;
            UserID = userID;
            BookID = bookID;
            BorrowTime = DateTime.Now; 
            DueTime = DateTime.Now.AddDays(60); 
        }
        public int LoanID { get; set; }
        public int UserID { get; set;}
        public int BookID { get; set; }
        public DateTime BorrowTime { get; set; }
        public DateTime DueTime { get; set;}
        public DateTime? ReturnTime { get; set; }
    }
}
