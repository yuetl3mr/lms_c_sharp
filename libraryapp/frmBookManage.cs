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
    public partial class frmBookManage : Form
    {
        public frmBookManage()
        {
            InitializeComponent();
            AddDataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtBookSearch != null)
            {
                BookTable.Rows.Clear();
                var filteredBooks = EX.books.Where(b => (b.BookID.ToString() == txtBookSearch.Text ||
                                         b.Name.Contains(txtBookSearch.Text) ||
                                         b.Author.Contains(txtBookSearch.Text)));
                foreach (var book in filteredBooks)
                {
                    BookTable.Rows.Add(book.BookID, book.Name, book.Author, book.CategoryID);
                }
            }
            else AddDataTable();
        }
        private void AddDataTable()
        {
            BookTable.Rows.Clear();
            foreach (var book in EX.books)
            {
                BookTable.Rows.Add(book.BookID, book.Name, book.Author, book.CategoryID, book.Publication.Date, book.Number);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach (DataGridViewRow row in BookTable.Rows)
            {
                success = false;
                bool isSelected = Convert.ToBoolean(row.Cells[5].Value);
                if (isSelected)
                {
                    int bookId = Convert.ToInt32(row.Cells[0].Value);
                    string? tile = row.Cells[1].Value?.ToString();
                    string? author = row.Cells[2].Value?.ToString();
                    int cate = Convert.ToInt32(row.Cells[3].Value);
                    int number = 0;
                    if (row.Cells[5].Value != null && row.Cells[5].Value != DBNull.Value)
                    {
                        number = Convert.ToInt32(row.Cells[5].Value);
                        success = true;
                    }
                    else
                    {
                        MessageBox.Show("Please do not leave columns blank!");
                    }
                    if (tile != null && author != null && success)
                    {
                        EX.UpdateBook(bookId, tile, author, number, cate);
                        success = true;
                    }
                    else
                    {
                        success = false;
                        MessageBox.Show("Please do not leave columns blank!");
                    }
                }
            }
            if (success)
            {
                MessageBox.Show("Edit Success!");
            }
            AddDataTable();
        }
    }
}
