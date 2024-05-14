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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            label2.Font = new Font("0xProto Nerd Font Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 255);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(37, 33);
            label2.Name = "label2";
            label2.Size = new Size(384, 48);
            label2.TabIndex = 16;
            label2.Text = "Book Borrowing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            label1.ForeColor = Color.White;
            label1.Location = new Point(271, 333);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 17;
            label1.Text = "Username : ";
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("0xProto Nerd Font", 9F);
            UserNameLabel.ForeColor = Color.White;
            UserNameLabel.Location = new Point(378, 333);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(0, 18);
            UserNameLabel.TabIndex = 18;
            // 
            // bookTable
            // 
            bookTable.AllowUserToAddRows = false;
            bookTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle1.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            bookTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bookTable.BackgroundColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle2.Font = new Font("0xProto Nerd Font Mono", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 255);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            bookTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            bookTable.ColumnHeadersHeight = 29;
            bookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            bookTable.Columns.AddRange(new DataGridViewColumn[] { BookIdColumn, BookNameColumn, BookAuthorColumn, CategoryColumn, BookSelect });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle3.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            bookTable.DefaultCellStyle = dataGridViewCellStyle3;
            bookTable.EnableHeadersVisualStyles = false;
            bookTable.Location = new Point(107, 169);
            bookTable.Name = "bookTable";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            bookTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            bookTable.RowHeadersVisible = false;
            bookTable.RowHeadersWidth = 51;
            bookTable.Size = new Size(542, 148);
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
            label4.Font = new Font("0xProto Nerd Font", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(464, 333);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 20;
            label4.Text = "Name : ";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("0xProto Nerd Font", 9F);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(541, 333);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(0, 18);
            NameLabel.TabIndex = 21;
            // 
            // txtUserSearch
            // 
            txtUserSearch.Location = new Point(107, 333);
            txtUserSearch.Name = "txtUserSearch";
            txtUserSearch.Size = new Size(125, 27);
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
            button1.Location = new Point(107, 366);
            button1.Name = "button1";
            button1.Size = new Size(61, 29);
            button1.TabIndex = 24;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btConfirm
            // 
            btConfirm.BackColor = Color.FromArgb(57, 62, 70);
            btConfirm.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            btConfirm.ForeColor = Color.White;
            btConfirm.Location = new Point(204, 418);
            btConfirm.Name = "btConfirm";
            btConfirm.Size = new Size(193, 29);
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