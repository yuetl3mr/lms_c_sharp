namespace libraryapp
{
    partial class frmBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrow));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            txtBookSearch = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            UserNameLabel = new Label();
            bookTable = new DataGridView();
            BookIdColumn = new DataGridViewTextBoxColumn();
            BookNameColumn = new DataGridViewTextBoxColumn();
            BookAuthorColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            BookSelect = new DataGridViewCheckBoxColumn();
            label4 = new Label();
            NameLabel = new Label();
            txtUserSearch = new TextBox();
            label6 = new Label();
            button1 = new Button();
            btConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookTable).BeginInit();
            SuspendLayout();
            // 
            // txtBookSearch
            // 
            txtBookSearch.Location = new Point(445, 124);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(153, 27);
            txtBookSearch.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(604, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(43, 44);
            label2.Name = "label2";
            label2.Size = new Size(327, 54);
            label2.TabIndex = 16;
            label2.Text = "Book Borrowing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(278, 334);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 17;
            label1.Text = "Username : ";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Nirmala UI", 9F);
            UserNameLabel.ForeColor = Color.White;
            UserNameLabel.Location = new Point(385, 334);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(0, 20);
            UserNameLabel.TabIndex = 18;
            // 
            // bookTable
            // 
            bookTable.AllowUserToAddRows = false;
            bookTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle9.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(224, 224, 224);
            bookTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            bookTable.BackgroundColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle10.Font = new Font("0xProto Nerd Font Mono", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 255);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            bookTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            bookTable.ColumnHeadersHeight = 29;
            bookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            bookTable.Columns.AddRange(new DataGridViewColumn[] { BookIdColumn, BookNameColumn, BookAuthorColumn, CategoryColumn, BookSelect });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle11.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            bookTable.DefaultCellStyle = dataGridViewCellStyle11;
            bookTable.EnableHeadersVisualStyles = false;
            bookTable.Location = new Point(94, 169);
            bookTable.Name = "bookTable";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            bookTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            bookTable.RowHeadersVisible = false;
            bookTable.RowHeadersWidth = 51;
            bookTable.Size = new Size(555, 152);
            bookTable.TabIndex = 19;
            // 
            // BookIdColumn
            // 
            BookIdColumn.Frozen = true;
            BookIdColumn.HeaderText = "ID";
            BookIdColumn.MinimumWidth = 6;
            BookIdColumn.Name = "BookIdColumn";
            BookIdColumn.Resizable = DataGridViewTriState.False;
            BookIdColumn.Width = 55;
            // 
            // BookNameColumn
            // 
            BookNameColumn.Frozen = true;
            BookNameColumn.HeaderText = "Book Tile";
            BookNameColumn.MinimumWidth = 6;
            BookNameColumn.Name = "BookNameColumn";
            BookNameColumn.Resizable = DataGridViewTriState.False;
            BookNameColumn.Width = 175;
            // 
            // BookAuthorColumn
            // 
            BookAuthorColumn.Frozen = true;
            BookAuthorColumn.HeaderText = "Author";
            BookAuthorColumn.MinimumWidth = 6;
            BookAuthorColumn.Name = "BookAuthorColumn";
            BookAuthorColumn.Resizable = DataGridViewTriState.False;
            BookAuthorColumn.Width = 130;
            // 
            // CategoryColumn
            // 
            CategoryColumn.Frozen = true;
            CategoryColumn.HeaderText = "Category";
            CategoryColumn.MinimumWidth = 6;
            CategoryColumn.Name = "CategoryColumn";
            CategoryColumn.Resizable = DataGridViewTriState.False;
            CategoryColumn.Width = 125;
            // 
            // BookSelect
            // 
            BookSelect.Frozen = true;
            BookSelect.HeaderText = "-";
            BookSelect.MinimumWidth = 6;
            BookSelect.Name = "BookSelect";
            BookSelect.Width = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(278, 371);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 20;
            label4.Text = "Name : ";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Nirmala UI", 9F);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(355, 371);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(0, 20);
            NameLabel.TabIndex = 21;
            // 
            // txtUserSearch
            // 
            txtUserSearch.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserSearch.Location = new Point(94, 334);
            txtUserSearch.Name = "txtUserSearch";
            txtUserSearch.Size = new Size(125, 25);
            txtUserSearch.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("0xProto Nerd Font Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 255);
            label6.ForeColor = Color.FromArgb(0, 173, 181);
            label6.Location = new Point(164, 127);
            label6.Name = "label6";
            label6.Size = new Size(257, 24);
            label6.TabIndex = 23;
            label6.Text = "Avalible Books List";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(57, 62, 70);
            button1.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            button1.ForeColor = Color.White;
            button1.Location = new Point(94, 371);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 24;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btConfirm
            // 
            btConfirm.BackColor = Color.FromArgb(57, 62, 70);
            btConfirm.Font = new Font("0xProto Nerd Font", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 255);
            btConfirm.ForeColor = Color.White;
            btConfirm.Location = new Point(262, 412);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new Size(217, 36);
            btConfirm.TabIndex = 25;
            btConfirm.Text = "Confirm";
            btConfirm.UseVisualStyleBackColor = false;
            btConfirm.Click += btConfirm_Click;
            // 
            // frmBorrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(744, 474);
            Controls.Add(btConfirm);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtUserSearch);
            Controls.Add(NameLabel);
            Controls.Add(label4);
            Controls.Add(bookTable);
            Controls.Add(UserNameLabel);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtBookSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBorrow";
            Text = "frmBorrow";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBookSearch;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label UserNameLabel;
        private DataGridView bookTable;
        private DataGridViewTextBoxColumn BookIdColumn;
        private DataGridViewTextBoxColumn BookNameColumn;
        private DataGridViewTextBoxColumn BookAuthorColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
        private DataGridViewCheckBoxColumn BookSelect;
        private Label label4;
        private Label NameLabel;
        private TextBox txtUserSearch;
        private Label label6;
        private Button button1;
        private Button btConfirm;
    }
}