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

    public partial class Dashboard : Form
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

        public Dashboard()
        {
            InitializeComponent();
            bookTotalLabel.Text = EX.BookTotal().ToString();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void LoanTimer_Tick(object sender, EventArgs e)
        {
            if (homeContainerExpand)
            {
                homeContainer.Height -= 5;
                if (homeContainer.Height == homeContainer.MinimumSize.Height)
                {
                    homeContainerExpand = false;
                    LoanTimer.Stop();
                }
            }
            else
            {
                homeContainer.Height += 5;
                if (homeContainer.Height == homeContainer.MaximumSize.Height)
                {
                    homeContainerExpand = true;
                    LoanTimer.Stop();
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LoanTimer.Start();
        }
    }
}
