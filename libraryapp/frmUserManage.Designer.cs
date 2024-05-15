namespace libraryapp
{
    partial class frmUserManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManage));
            label2 = new Label();
            userTable = new DataGridView();
            UserIDColumn = new DataGridViewTextBoxColumn();
            UserNameColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            AddrColumn = new DataGridViewTextBoxColumn();
            GenderColumn = new DataGridViewTextBoxColumn();
            selectedColumn = new DataGridViewCheckBoxColumn();
            pictureBox1 = new PictureBox();
            txtUserSearch = new TextBox();
            btEdit = new Button();
            btDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)userTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(43, 44);
            label2.Name = "label2";
            label2.Size = new Size(290, 54);
            label2.TabIndex = 19;
            label2.Text = "Users Manage";
            // 
            // userTable
            // 
            userTable.AllowUserToAddRows = false;
            userTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle1.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            userTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            userTable.BackgroundColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle2.Font = new Font("Arial", 7.8F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            userTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            userTable.ColumnHeadersHeight = 29;
            userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            userTable.Columns.AddRange(new DataGridViewColumn[] { UserIDColumn, UserNameColumn, NameColumn, AddrColumn, GenderColumn, selectedColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle3.Font = new Font("Arial", 7.8F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            userTable.DefaultCellStyle = dataGridViewCellStyle3;
            userTable.EnableHeadersVisualStyles = false;
            userTable.Location = new Point(67, 172);
            userTable.Name = "userTable";
            userTable.RowHeadersVisible = false;
            userTable.RowHeadersWidth = 51;
            userTable.Size = new Size(618, 176);
            userTable.TabIndex = 29;
            // 
            // UserIDColumn
            // 
            UserIDColumn.Frozen = true;
            UserIDColumn.HeaderText = "ID";
            UserIDColumn.MinimumWidth = 6;
            UserIDColumn.Name = "UserIDColumn";
            UserIDColumn.ReadOnly = true;
            UserIDColumn.Resizable = DataGridViewTriState.False;
            UserIDColumn.Width = 55;
            // 
            // UserNameColumn
            // 
            UserNameColumn.Frozen = true;
            UserNameColumn.HeaderText = "UserName";
            UserNameColumn.MinimumWidth = 6;
            UserNameColumn.Name = "UserNameColumn";
            UserNameColumn.ReadOnly = true;
            UserNameColumn.Resizable = DataGridViewTriState.False;
            UserNameColumn.Width = 125;
            // 
            // NameColumn
            // 
            NameColumn.Frozen = true;
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.Resizable = DataGridViewTriState.False;
            NameColumn.Width = 150;
            // 
            // AddrColumn
            // 
            AddrColumn.Frozen = true;
            AddrColumn.HeaderText = "Address";
            AddrColumn.MinimumWidth = 6;
            AddrColumn.Name = "AddrColumn";
            AddrColumn.Resizable = DataGridViewTriState.False;
            AddrColumn.Width = 150;
            // 
            // GenderColumn
            // 
            GenderColumn.Frozen = true;
            GenderColumn.HeaderText = "Gender";
            GenderColumn.MinimumWidth = 6;
            GenderColumn.Name = "GenderColumn";
            GenderColumn.ReadOnly = true;
            GenderColumn.Resizable = DataGridViewTriState.False;
            GenderColumn.Width = 60;
            // 
            // selectedColumn
            // 
            selectedColumn.HeaderText = "-";
            selectedColumn.MinimumWidth = 6;
            selectedColumn.Name = "selectedColumn";
            selectedColumn.Width = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(642, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUserSearch
            // 
            txtUserSearch.Location = new Point(444, 130);
            txtUserSearch.Name = "txtUserSearch";
            txtUserSearch.Size = new Size(182, 27);
            txtUserSearch.TabIndex = 31;
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.FromArgb(57, 62, 70);
            btEdit.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            btEdit.ForeColor = Color.White;
            btEdit.Location = new Point(239, 372);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 29);
            btEdit.TabIndex = 33;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += button1_Click;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.FromArgb(57, 62, 70);
            btDelete.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            btDelete.ForeColor = Color.White;
            btDelete.Location = new Point(383, 372);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 34;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // frmUserManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(744, 474);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(pictureBox1);
            Controls.Add(txtUserSearch);
            Controls.Add(userTable);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUserManage";
            Text = "frmUserManage";
            ((System.ComponentModel.ISupportInitialize)userTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView userTable;
        private PictureBox pictureBox1;
        private TextBox txtUserSearch;
        private Button btEdit;
        private Button btDelete;
        private DataGridViewTextBoxColumn UserIDColumn;
        private DataGridViewTextBoxColumn UserNameColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AddrColumn;
        private DataGridViewTextBoxColumn GenderColumn;
        private DataGridViewCheckBoxColumn selectedColumn;
    }
}