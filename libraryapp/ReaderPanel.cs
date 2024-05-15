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
    public partial class ReaderPanel : Form
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
        public ReaderPanel()
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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            new frmAccount().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.formLoader.Controls.Clear();
            frmBorrowedList bredlist = new frmBorrowedList()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            bredlist.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(bredlist);
            bredlist.Show();
        }
    }
}
