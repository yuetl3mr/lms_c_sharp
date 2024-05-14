using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryapp
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            bookTotalLabel.Text = EX.BookTotal().ToString();
            UserTotalLb.Text = EX.UserTotal().ToString();
            AddDataTable();
        }
        private void AddDataTable()
        {
            foreach (var book in EX.books)
            {
                bookTable.Rows.Add(book.BookID, book.Name, book.Author, EX.bookCategories[book.CategoryID - 1]);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtBookSearch != null)
            {
                bookTable.Rows.Clear();
                var filteredBooks = EX.books.Where(b => b.BookID.ToString() == txtBookSearch.Text ||
                                                 b.Name.Contains(txtBookSearch.Text) ||
                                                 b.Author.Contains(txtBookSearch.Text));
                foreach (var book in filteredBooks)
                {
                    bookTable.Rows.Add(book.BookID, book.Name, book.Author, EX.bookCategories[book.CategoryID - 1]);
                }
            }
            else AddDataTable();
        }
    }
}
