using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace libraryapp
{
    public class EX
    {
        public static bool Admin = false;
        public static List<Books> books = DBConnect.GetBooks();
        public static List<User> users = DBConnect.GetUsers();
        public static List<Loans> loans = DBConnect.GetLoans();
        public static List<string> bookCategories = new List<string>
        {
            "Fiction",
            "Non-fiction",
            "Science Fiction",
            "Fantasy",
            "Mystery",
            "Thriller",
            "Biography",
            "History",
            "Self-help",
            "Romance"
        };

        public static int NewUserId()
        {
            int maxid = 0;
            foreach (var user in users)
            {
                maxid = Math.Max(maxid, user.Uid);
            }
            return maxid + 1;
        }

        public static int NewLoanId()
        {
            int maxid = 0;
            foreach (var loan in loans)
            {
                maxid = Math.Max(maxid, loan.LoanID);
            }
            return maxid + 1;
        }

        public static int NewBookId()
        {
            int maxid = 0;
            foreach (var book in books)
            {
                maxid = Math.Max(maxid, book.BookID);
            }
            return maxid + 1;
        }



        public static bool ValidUsername(string userName) { 
            foreach (var user in users)
            {
                if (userName == user.UserLogin) return false;
            }
            return true;
        }
        public static bool isAdmin(string username)
        {
            foreach (var user in users)
            {
                if (user.UserLogin == username && user.Role == 1) return true;
            }
            return false;
        }
        public static int BookTotal()
        {
            return books.Count;
            
        }
        public static int UserTotal()
        {
            return users.Count;
            
        }
        public static int UserIndex(int uid)
        {
            int index = 0;
            foreach (var user in users)
            {
                if (user.Uid == uid)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public static int LoanIndex(int loanid)
        {
            int index = 0;
            foreach (var loan in loans)
            {
                if (loan.LoanID == loanid)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public static int BookIndex(int bookid)
        {
            int index = 0;
            foreach (var book in books)
            {
                if (book.BookID == bookid)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        public static void addLoan(int bookid, int userid) {
            loans.Add(new Loans(NewLoanId(), userid, bookid));
            books[BookIndex(bookid)].Number = books[BookIndex(bookid)].Number - 1;
            DBConnect.AddLoans(loans.Last());
        }
        public static void addReturn(int loanid, int bookid)
        {
            int index = LoanIndex(loanid);
            if (index != -1)
            {
                books[BookIndex(bookid)].Number = books[BookIndex(bookid)].Number + 1;
                loans[index].ReturnTime = DateTime.Now;
                DBConnect.AddReturn(loanid);
            }
          
           
        }
        public static void UpdateUser(int userid,string name, string addr)
        {
            users[UserIndex(userid)].Name = name;
            users[UserIndex(userid)].Addr = addr;
            DBConnect.UpdateUser(users[UserIndex(userid)]);
        }
        public static void DeleteUser(int userid)
        {
            users.RemoveAt(UserIndex(userid));
            DBConnect.DeleteUser(userid);
        }
        public static void UpdateBook(int bookid, string tile, string author, int cate, int total)
        {
            books[BookIndex(bookid)].CategoryID = cate;
            books[BookIndex(bookid)].Name = tile;
            books[BookIndex(bookid)].Author = author;
            books[BookIndex(bookid)].Number = total;
            DBConnect.UpdateBook(books[BookIndex(bookid)]);
        }
        public static void DeleteBook(int BookID)
        {
            books.RemoveAt(BookIndex(BookID));
            DBConnect.DeleteBook(BookID);
        }
    }
}
