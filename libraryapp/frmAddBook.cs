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
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cate = Convert.ToInt32(txtCate.Text);
            string dateString = txtPub.Text;
            string format = "dd/MM/yyyy";
            int number;
            DateTime date;

            if (int.TryParse(txtQuan.Text, out number))
            {
            }
            else
            {
                MessageBox.Show("Please re-check data!");
            }
            if (DateTime.TryParseExact(dateString, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
            {
            }
            else
            {
                MessageBox.Show("Please re-check data!");
            }
            if (cate > 10 && cate < 0)
            {
                MessageBox.Show("Please re-check data!");
            }
            else
            {
                EX.books.Add(new Books(EX.NewBookId(), txtTitle.Text, cate, number, txtAuthor.Text, date));
                DBConnect.AddBooks(EX.books.Last());
                this.Hide();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
