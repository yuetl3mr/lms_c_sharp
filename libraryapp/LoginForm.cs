using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class LoginForm : Form
    {
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
        public LoginForm()
        {
            InitializeComponent();
            txtUserPassword.UseSystemPasswordChar = true;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtUserPassword.Text;
            string username = txtUserName.Text;
            var user = EX.users.FirstOrDefault(u => u.UserLogin == username);

            if (user != null && PasswordManager.VerifyPassword(password, user.Password))
            {

                if(EX.isAdmin(username))
                {
                    this.Hide();
                    EX.currentID = EX.GetID(username);
                    new AdminPanel().Show();
                }
                else
                {
                    this.Hide();
                    EX.currentID = EX.GetID(username);
                    new ReaderPanel().Show();
                }

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Signup().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
