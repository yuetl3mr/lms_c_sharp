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
    public partial class frmBorrowedList : Form
    {
        public frmBorrowedList()
        {
            InitializeComponent();
            AddDataTable();
        }
        private void AddDataTable()
        {
            borrowedTable.Rows.Clear();
            var filteredLoans = EX.loans.Where(l => l.UserID.ToString() == EX.currentID.ToString());
            foreach (var loan in filteredLoans)
            {
                borrowedTable.Rows.Add(loan.LoanID, loan.BookID, loan.BorrowTime.Date, loan.DueTime.Date, loan.ReturnTime);
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtLoanSearch != null)
            {
                borrowedTable.Rows.Clear();
                var filteredLoans = EX.loans.Where(l => ((l.BookID.ToString() == txtLoanSearch.Text ||
                                         l.LoanID.ToString() == txtLoanSearch.Text) &&
                                         l.UserID.ToString() == EX.currentID.ToString()));
                foreach (var loan in filteredLoans)
                {
                    borrowedTable.Rows.Add(loan.LoanID, loan.BookID, loan.BorrowTime.Date, loan.DueTime.Date, loan.ReturnTime);
                }

            }
            else AddDataTable();
        }
    }
}
