using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryapp
{
    public partial class Signup : Form
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
        public Signup()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gender = maleButton.Checked ? 1 : 0;
            Regex regex = new Regex("^[a-zA-Z0-9]*$");
            if (EX.ValidUsername(txtUserName.Text) && regex.IsMatch(txtUserName.Text) && txtAddress.Text != "")
            {
                if (txtConfirmPassword.Text == txtPassword.Text)
                {
                    EX.users.Add(new User (EX.NewUserId(), txtName.Text, gender, txtAddress.Text, 
                                 txtUserName.Text,
                                 PasswordManager.HashPassword(txtPassword.Text)
                                 , 0));
                    DatabaseHandler.AddUsers(EX.users.Last());
                    MessageBox.Show("Success! Please Login to continue!");
                    this.Hide();
                    new LoginForm().Show();
                }
                else
                {
                    MessageBox.Show("Please Confirm Password!");
                }
            } else
            {
                MessageBox.Show("Username is not in the correct format or has already been used, please try again!");
            }
        }
    }
}
