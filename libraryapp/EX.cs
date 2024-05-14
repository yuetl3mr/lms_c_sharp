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
        
    }
}
