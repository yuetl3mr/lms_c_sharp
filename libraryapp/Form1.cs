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
    public partial class Form1 : Form
    {
        private DataGridView dataGridView1;
        public Form1()
        {
            InitializeComponent();
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            Controls.Add(dataGridView1);
            ShowData();
        }
        private void ShowData()
        {

            List<User> userList = EX.users;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Uid", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            foreach (var user in userList)
            {
                dataTable.Rows.Add(user.Uid, user.Name);
            }
            dataGridView1.DataSource = dataTable;
        }

    }
}
