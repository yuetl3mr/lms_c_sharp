namespace libraryapp
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox4 = new PictureBox();
            txtBookSearch = new TextBox();
            bookTable = new DataGridView();
            BookIdColumn = new DataGridViewTextBoxColumn();
            BookNameColumn = new DataGridViewTextBoxColumn();
            BookAuthorColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            UserTotalLb = new Label();
            label7 = new Label();
            panel5 = new Panel();
            bookTotalLabel = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookTable).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(577, 55);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // txtBookSearch
            // 
            txtBookSearch.Location = new Point(407, 61);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(164, 27);
            txtBookSearch.TabIndex = 12;
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
            bookTable.Columns.AddRange(new DataGridViewColumn[] { BookIdColumn, BookNameColumn, BookAuthorColumn, CategoryColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle3.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            bookTable.DefaultCellStyle = dataGridViewCellStyle3;
            bookTable.EnableHeadersVisualStyles = false;
            bookTable.Location = new Point(86, 268);
            bookTable.Name = "bookTable";
            bookTable.ReadOnly = true;
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
            bookTable.Size = new Size(562, 152);
            bookTable.TabIndex = 11;
            // 
            // BookIdColumn
            // 
            BookIdColumn.HeaderText = "ID";
            BookIdColumn.MinimumWidth = 6;
            BookIdColumn.Name = "BookIdColumn";
            BookIdColumn.ReadOnly = true;
            BookIdColumn.Resizable = DataGridViewTriState.False;
            BookIdColumn.Width = 55;
            // 
            // BookNameColumn
            // 
            BookNameColumn.HeaderText = "Book Tile";
            BookNameColumn.MinimumWidth = 6;
            BookNameColumn.Name = "BookNameColumn";
            BookNameColumn.ReadOnly = true;
            BookNameColumn.Resizable = DataGridViewTriState.False;
            BookNameColumn.Width = 200;
            // 
            // BookAuthorColumn
            // 
            BookAuthorColumn.HeaderText = "Author";
            BookAuthorColumn.MinimumWidth = 6;
            BookAuthorColumn.Name = "BookAuthorColumn";
            BookAuthorColumn.ReadOnly = true;
            BookAuthorColumn.Resizable = DataGridViewTriState.False;
            BookAuthorColumn.Width = 150;
            // 
            // CategoryColumn
            // 
            CategoryColumn.HeaderText = "Category";
            CategoryColumn.MinimumWidth = 6;
            CategoryColumn.Name = "CategoryColumn";
            CategoryColumn.ReadOnly = true;
            CategoryColumn.Resizable = DataGridViewTriState.False;
            CategoryColumn.Width = 130;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 55, 63);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(UserTotalLb);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(380, 123);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 125);
            panel6.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(144, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 173, 181);
            label4.Location = new Point(19, 86);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 2;
            label4.Text = "Users";
            // 
            // UserTotalLb
            // 
            UserTotalLb.AutoSize = true;
            UserTotalLb.Font = new Font("BIZ UDPGothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserTotalLb.ForeColor = Color.FromArgb(0, 173, 181);
            UserTotalLb.Location = new Point(12, 41);
            UserTotalLb.Name = "UserTotalLb";
            UserTotalLb.Size = new Size(101, 37);
            UserTotalLb.TabIndex = 1;
            UserTotalLb.Text = "000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 13);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 0;
            label7.Text = "Users Total";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 55, 63);
            panel5.Controls.Add(bookTotalLabel);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(89, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 9;
            // 
            // bookTotalLabel
            // 
            bookTotalLabel.AutoSize = true;
            bookTotalLabel.Font = new Font("BIZ UDPGothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTotalLabel.ForeColor = Color.FromArgb(0, 173, 181);
            bookTotalLabel.Location = new Point(19, 41);
            bookTotalLabel.Name = "bookTotalLabel";
            bookTotalLabel.Size = new Size(101, 37);
            bookTotalLabel.TabIndex = 4;
            bookTotalLabel.Text = "000";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(144, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("BIZ UDPGothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 173, 181);
            label5.Location = new Point(19, 86);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 2;
            label5.Text = "Books";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 13);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 0;
            label3.Text = "Books Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(85, 39);
            label2.Name = "label2";
            label2.Size = new Size(221, 54);
            label2.TabIndex = 8;
            label2.Text = "Wellcome!";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(744, 474);
            Controls.Add(pictureBox4);
            Controls.Add(txtBookSearch);
            Controls.Add(bookTable);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDashboard";
            Text = "frmDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookTable).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private TextBox txtBookSearch;
        private DataGridView bookTable;
        private DataGridViewTextBoxColumn BookIdColumn;
        private DataGridViewTextBoxColumn BookNameColumn;
        private DataGridViewTextBoxColumn BookAuthorColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label label4;
        private Label UserTotalLb;
        private Label label7;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label bookTotalLabel;
    }
}