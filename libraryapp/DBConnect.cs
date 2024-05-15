using Microsoft.VisualBasic.ApplicationServices;
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
                        Number = Convert.ToInt32(reader["Number"]),
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
                    bool isNull = reader.IsDBNull(reader.GetOrdinal("ReturnTime"));
                    if (isNull) { 
                        Loans loan = new Loans
                        {
                            LoanID = Convert.ToInt32(reader["LoanID"]),
                            BookID = Convert.ToInt32(reader["BookID"]),
                            UserID = Convert.ToInt32(reader["UserID"]),
                            BorrowTime = reader.GetDateTime(reader.GetOrdinal("BorrowTime")).Date,
                            DueTime = reader.GetDateTime(reader.GetOrdinal("DueTime")).Date,
                            //ReturnTime = reader.GetDateTime(reader.GetOrdinal("ReturnTime")).Date
                        };
                        loans.Add(loan);
                    }
                    else
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

        public static void AddBooks(Books book)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                    string query = "INSERT INTO Books (BookID ,bName, CategoryID, bAuthor, Number, bPublication) VALUES (@BookID ,@Name, @CategoryID, @Author, @Number, @Publication)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BookID", book.BookID);
                    command.Parameters.AddWithValue("@Name", book.Name);
                    command.Parameters.AddWithValue("@CategoryID", book.CategoryID);                    
                    command.Parameters.AddWithValue("@Number", book.Number);
                    command.Parameters.AddWithValue("@Author", book.Author);
                    command.Parameters.AddWithValue("@Publication", book.Publication);
                    command.ExecuteNonQuery();
               
            }
        }

        public static void AddLoans(Loans loan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                    connection.Open();
                    string query = "INSERT INTO Loans (LoanID ,BookID, UserID, BorrowTime, DueTime) VALUES (@LoanID ,@BookID, @UserID, @BorrowTime, @DueTime)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@LoanID", loan.LoanID);
                    command.Parameters.AddWithValue("@BookID", loan.BookID);
                    command.Parameters.AddWithValue("@UserID", loan.UserID);
                    command.Parameters.AddWithValue("@BorrowTime", loan.BorrowTime);
                    command.Parameters.AddWithValue("@DueTime", loan.DueTime);
                    //command.Parameters.AddWithValue("@ReturnTime", loan.ReturnTime);
                    command.ExecuteNonQuery();
            }
        }
        
        public static void AddReturn(int loanid)
        {
            DateTime returntime = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Loans SET ReturnTime = @ReturnTime WHERE LoanID = @LoanID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReturnTime", returntime);
                command.Parameters.AddWithValue("@LoanID", loanid);
                command.ExecuteNonQuery();
            }
        }

        public static void UpdateUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Users SET uName = @Name, Addrs = @Addr WHERE UserID = @Uid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Uid", user.Uid);
                command.Parameters.AddWithValue("@Addr", user.Addr);
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateBook(Books book)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Books SET bName = @Name, CategoryID = @Category, bAuthor = @Author, Number = @Number WHERE BookID = @BookId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookId", book.BookID);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Category", book.CategoryID);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Number", book.Number);
                command.ExecuteNonQuery();
            }
        }
        public static void DeleteUser(int uid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Users WHERE UserID = @Uid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Uid", uid);
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteBook(int bookid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Books WHERE BookID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", bookid);
                command.ExecuteNonQuery();
            }
        }

    }
}
