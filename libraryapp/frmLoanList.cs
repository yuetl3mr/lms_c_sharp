﻿using System;
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
    public partial class frmLoanList : Form
    {
        public frmLoanList()
        {
            InitializeComponent();
            AddDataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtLoanSearch != null)
            {
                loanTable.Rows.Clear();
                var filteredLoans = EX.loans.Where(l => (l.BookID.ToString() == txtLoanSearch.Text ||
                                         l.LoanID.ToString() == txtLoanSearch.Text ||
                                         l.UserID.ToString() == txtLoanSearch.Text));
                foreach (var loan in filteredLoans)
                {
                    loanTable.Rows.Add(loan.LoanID, loan.BookID, loan.UserID, loan.BorrowTime.Date, loan.ReturnTime);
                }

            }
            else AddDataTable();

        }

        private void AddDataTable()
        {
            loanTable.Rows.Clear();
            foreach (var loan in EX.loans)
            {
                loanTable.Rows.Add(loan.LoanID, loan.BookID, loan.UserID, loan.BorrowTime.Date, loan.ReturnTime);
            }

        }
    }
}
