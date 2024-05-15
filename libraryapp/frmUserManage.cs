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
    public partial class frmUserManage : Form
    {
        public frmUserManage()
        {
            InitializeComponent();
            AddDataTable();
        }

        private void AddDataTable()
        {
            userTable.Rows.Clear();
            foreach (var user in EX.users)
            {
                userTable.Rows.Add(user.Uid, user.UserLogin, user.Name, user.Addr, user.Gender);
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtUserSearch != null)
            {
                userTable.Rows.Clear();
                var filteredUsers = EX.users.Where(u => (u.Uid.ToString() == txtUserSearch.Text ||
                                                    u.Name.Contains(txtUserSearch.Text) ||
                                                    u.UserLogin.Contains(txtUserSearch.Text)));
                foreach (var user in filteredUsers)
                {
                    userTable.Rows.Add(user.Uid, user.UserLogin, user.Name, user.Addr, user.Gender);
                }
            }
            else AddDataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach (DataGridViewRow row in userTable.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[5].Value);
                if (isSelected)
                {
                    int userid = Convert.ToInt32(row.Cells[0].Value);
                    string? Name = row.Cells[2].Value?.ToString();
                    string? Addr = row.Cells[3].Value?.ToString();
                    if (Name != null && Addr != null)
                    {
                        EX.UpdateUser(userid, Name, Addr);
                        success = true;
                    }
                    else
                    {
                        success = false;
                        MessageBox.Show("Please do not leave columns blank!");
                    }
                }
            }
            if (success)
            {
                MessageBox.Show("Edit Success!");
            }
            AddDataTable();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            bool success = false;
            foreach (DataGridViewRow row in userTable.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells[5].Value);
                if (isSelected)
                {
                    int userid = Convert.ToInt32(row.Cells[0].Value);
                    EX.DeleteUser(userid);
                    success = true;

                }
            }
            if (success)
            {
                MessageBox.Show("Delete Success!");
            }
            AddDataTable();
        }
    }
}
