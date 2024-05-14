using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace libraryapp
{
    public class DBConnect
    {
        static string connectionString = "Data Source=YUE_TL;Initial Catalog=libraryapp;Integrated Security=True";
        
        // -- get from db
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Uid = Convert.ToInt32(reader["UserID"]),
                        Name = reader["uName"].ToString(),
                        Gender = Convert.ToInt32(reader["Gender"]),
                        Addr = reader["Addrs"].ToString(),
                        UserLogin = reader["UserLogin"].ToString(),
                        Password = reader["UserPassword"].ToString(),
                        Role = Convert.ToInt32(reader["uRole"]),
                    };
                    users.Add(user);
                }
                reader.Close();
            }
            return users;
        }

        public static List<Books> GetBooks()
        {
            List<Books> books = new List<Books>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Books";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Books book = new Books
                    {
                        BookID = Convert.ToInt32(reader["BookID"]),
                        Name = reader["bName"].ToString(),
                        CategoryID = Convert.ToInt32(reader["CategoryID"]),
                        Author = reader["bAuthor"].ToString(),
                        Publication = reader.GetDateTime(reader.GetOrdinal("bPublication")).Date
                    };
                    books.Add(book);
                }
                reader.Close();
            }
            return books;
        }
        public static List<Loans> GetLoans()
        {
            List<Loans> loans = new List<Loans>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Loans";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Loans loan = new Loans
                    {
                        LoanID = Convert.ToInt32(reader["LoanID"]),
                        BookID = Convert.ToInt32(reader["BookID"]),
                        UserID = Convert.ToInt32(reader["UserID"]),
                        BorrowTime = reader.GetDateTime(reader.GetOrdinal("BorrowTime")).Date,
                        DueTime = reader.GetDateTime(reader.GetOrdinal("DueTime")).Date,
                        ReturnTime = reader.GetDateTime(reader.GetOrdinal("ReturnTime")).Date
                    };
                    loans.Add(loan);
                }
                reader.Close();
            }
            return loans;
        }


        // -- add to db

        public static void AddUsers(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                    connection.Open();
                    string query = "INSERT INTO Users (UserID, uName, Gender, Addrs, UserLogin, UserPassword, uRole) VALUES (@UID ,@Name, @Gender, @Addr, @UserLogin, @Password, @Role)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UID", user.Uid);
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@Gender", user.Gender);
                    command.Parameters.AddWithValue("@Addr", user.Addr);
                    command.Parameters.AddWithValue("@UserLogin", user.UserLogin);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role);
                    command.ExecuteNonQuery();
                
            }
        }

        public static void AddBooks(List<Books> books)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (Books book in books)
                {
                    string query = "INSERT INTO Books (bName, CategoryID, bAuthor, bPublication) VALUES (@Name, @CategoryID, @Author, @Publication)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", book.Name);
                    command.Parameters.AddWithValue("@CategoryID", book.CategoryID);
                    command.Parameters.AddWithValue("@Author", book.Author);
                    command.Parameters.AddWithValue("@Publication", book.Publication);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddLoans(List<Loans> loans)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (Loans loan in loans)
                {
                    string query = "INSERT INTO Loans (BookID, UserID, BorrowTime, DueTime, ReturnTime) VALUES (@BookID, @UserID, @BorrowTime, @DueTime, @ReturnTime)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookID", loan.BookID);
                    command.Parameters.AddWithValue("@UserID", loan.UserID);
                    command.Parameters.AddWithValue("@BorrowTime", loan.BorrowTime);
                    command.Parameters.AddWithValue("@DueTime", loan.DueTime);
                    command.Parameters.AddWithValue("@ReturnTime", loan.ReturnTime);
                    command.ExecuteNonQuery();
                }
            }
        }

        


    }
}
