using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();
            AddDataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bookTable.Rows.Clear();
            var filteredLoans = EX.loans.Where(b => (b.ReturnTime == null) &&
                                                     b.UserID == int.Parse(txtUserSearch.Text));
            foreach (var loan in filteredLoans)
            {
                bookTable.Rows.Add(loan.BookID, loan.BookID, loan.UserID, loan.DueTime.Date);
            }
        }

        private void AddDataTable()
        {
            bookTable.Rows.Clear();
            var filteredLoans = EX.loans.Where(b => b.ReturnTime == null);

            foreach (var loan in filteredLoans)
            {
                bookTable.Rows.Add(loan.LoanID, loan.BookID, loan.UserID, loan.DueTime);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in bookTable.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["LoanSelect"].Value);
                if (isSelected)
                {
                    int loanid = Convert.ToInt32(row.Cells["LoanIdColumn"].Value);
                    EX.addReturn(loanid);
                }
            }
            MessageBox.Show("Success");
            AddDataTable();
        }
    }
}
