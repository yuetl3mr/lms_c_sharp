using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryapp
{
    public partial class frmBorrow : Form
    {
        public frmBorrow()
        {
            InitializeComponent();
            AddDataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtBookSearch != null)
            {
                bookTable.Rows.Clear();
                var filteredBooks = EX.books.Where(b => (b.BookID.ToString() == txtBookSearch.Text ||
                                         b.Name.Contains(txtBookSearch.Text) ||
                                         b.Author.Contains(txtBookSearch.Text)) &&
                                         b.Number > 0);
                foreach (var book in filteredBooks)
                {
                    bookTable.Rows.Add(book.BookID, book.Name, book.Author, EX.bookCategories[book.CategoryID - 1]);
                }
            }
            else AddDataTable();
        }

        private void AddDataTable()
        {
            bookTable.Rows.Clear();
            var filteredBooks = EX.books.Where(b => b.Number > 0);

            foreach (var book in filteredBooks)
            {
                bookTable.Rows.Add(book.BookID, book.Name, book.Author, EX.bookCategories[book.CategoryID - 1]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBookSearch != null)
            {
                int UserIndex = EX.UserIndex(int.Parse(txtUserSearch.Text));
                if (UserIndex != -1)
                {
                    UserNameLabel.Text = EX.users[UserIndex].UserLogin;
                    NameLabel.Text = EX.users[UserIndex].Name;
                }
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txtUserSearch.Text);
            foreach (DataGridViewRow row in bookTable.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["BookSelect"].Value);
                if (isSelected)
                {
                    int BookId = Convert.ToInt32(row.Cells["BookIdColumn"].Value);
                    EX.addLoan(BookId, userId);
                }
            }
            MessageBox.Show("Success");
            AddDataTable();
        }
    }
}
