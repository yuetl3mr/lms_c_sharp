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
    }
}
