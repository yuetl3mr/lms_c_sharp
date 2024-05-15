using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryapp
{
    public partial class AdminPanel : Form
    {
        bool sidebarExpand;
        bool homeContainerExpand;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public AdminPanel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.formLoader.Controls.Clear();
            frmDashboard dashboard = new frmDashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
            if (homeContainerExpand)
            {
                LoanTimer.Start();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            LoanTimer.Start();
        }

        private void LoanTimer_Tick(object sender, EventArgs e)
        {
            if (homeContainerExpand)
            {
                LoanContainer.Height -= 5;
                if (LoanContainer.Height == LoanContainer.MinimumSize.Height)
                {
                    homeContainerExpand = false;
                    LoanTimer.Stop();
                }
            }
            else
            {
                LoanContainer.Height += 5;
                if (LoanContainer.Height == LoanContainer.MaximumSize.Height)
                {
                    homeContainerExpand = true;
                    LoanTimer.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.formLoader.Controls.Clear();
            frmDashboard dashboard = new frmDashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.formLoader.Controls.Clear();
            frmBorrow borrowform = new frmBorrow()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            borrowform.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(borrowform);
            borrowform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.formLoader.Controls.Clear();
            frmReturn returnform = new frmReturn()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            returnform.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(returnform);
            returnform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.formLoader.Controls.Clear();
            frmLoanList loanlistform = new frmLoanList()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            loanlistform.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(loanlistform);
            loanlistform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.formLoader.Controls.Clear();
            frmUserManage usermanageform = new frmUserManage()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            usermanageform.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(usermanageform);
            usermanageform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.formLoader.Controls.Clear();
            frmBookManage bookmanageform = new frmBookManage()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            bookmanageform.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(bookmanageform);
            bookmanageform.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show(); 
        }
    }
}
