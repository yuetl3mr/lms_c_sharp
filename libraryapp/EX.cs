using System;
using System.Collections.Generic;
using System.Linq;
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
        public static List<double> CountBookByCate()
        {
            List<double> counts = new List<double>(new double[10]);
            foreach (var book in books)
            {
                counts[book.CategoryID - 1]++;
            }
            return counts;
        }
    }
}
