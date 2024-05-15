using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace libraryapp
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
            txtUserName.Text = EX.users[EX.UserIndex(EX.currentID)].UserLogin;
            txtUserID.Text = EX.currentID.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = EX.users.FirstOrDefault(u => u.UserLogin == EX.users[EX.UserIndex(EX.currentID)].UserLogin);

            if (user != null && PasswordManager.VerifyPassword(txtOldPassword.Text, user.Password))
            {
                if(txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    string pass = PasswordManager.HashPassword(txtNewPassword.Text);
                    EX.updatePassword(pass);
                    MessageBox.Show("Success!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Confirm Password does not match!");
                }
            }
            else
            {
                MessageBox.Show("Old Password Wrong!");
            }
        }
    }
}
