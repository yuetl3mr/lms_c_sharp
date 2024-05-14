namespace libraryapp
{
    partial class AdminDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            homeContainer = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            LoanTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            bookTotalLabel = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            bookTable = new DataGridView();
            BookIdColumn = new DataGridViewTextBoxColumn();
            BookNameColumn = new DataGridViewTextBoxColumn();
            BookAuthorColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            txtBookSearch = new TextBox();
            pictureBox4 = new PictureBox();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            homeContainer.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(34, 40, 49);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(homeContainer);
            sidebar.Controls.Add(panel4);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(4, 3, 4, 3);
            sidebar.MaximumSize = new Size(210, 474);
            sidebar.MinimumSize = new Size(80, 474);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(210, 474);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("0xProto Nerd Font Mono", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 255);
            label1.ForeColor = Color.White;
            label1.Location = new Point(83, 28);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.list__1_;
            pictureBox1.Location = new Point(18, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(4, 80);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 36);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 40, 49);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("BIZ UDGothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-4, -8);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(339, 52);
            button1.TabIndex = 2;
            button1.Text = "       Home";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(4, 122);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(264, 36);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 40, 49);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("BIZ UDGothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Image = Properties.Resources.open_book;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-4, -8);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(339, 52);
            button2.TabIndex = 2;
            button2.Text = "       Book List";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // homeContainer
            // 
            homeContainer.BackColor = Color.FromArgb(35, 40, 45);
            homeContainer.Controls.Add(button7);
            homeContainer.Controls.Add(button6);
            homeContainer.Controls.Add(button5);
            homeContainer.Controls.Add(button4);
            homeContainer.Location = new Point(4, 164);
            homeContainer.Margin = new Padding(4, 3, 4, 3);
            homeContainer.MaximumSize = new Size(264, 174);
            homeContainer.MinimumSize = new Size(264, 36);
            homeContainer.Name = "homeContainer";
            homeContainer.Size = new Size(264, 36);
            homeContainer.TabIndex = 3;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(50, 60, 65);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("BIZ UDGothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Transparent;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 128);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Padding = new Padding(30, 0, 0, 0);
            button7.Size = new Size(339, 47);
            button7.TabIndex = 5;
            button7.Text = "       Books Return";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(50, 60, 65);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("BIZ UDGothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Transparent;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 88);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Padding = new Padding(30, 0, 0, 0);
            button6.Size = new Size(339, 47);
            button6.TabIndex = 4;
            button6.Text = "       Books Borrow";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(50, 60, 65);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("BIZ UDGothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Transparent;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 45);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 0);
            button5.Size = new Size(264, 46);
            button5.TabIndex = 3;
            button5.Text = "       Loans List";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(34, 40, 49);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("BIZ UDGothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Image = Properties.Resources.open_book;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-4, -7);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(339, 52);
            button4.TabIndex = 2;
            button4.Text = "       Loan Manage";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(4, 206);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(264, 36);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 40, 49);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("BIZ UDGothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Image = Properties.Resources.profile__1_;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-4, -8);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(339, 52);
            button3.TabIndex = 2;
            button3.Text = "       User Manage";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += timer1_Tick;
            // 
            // LoanTimer
            // 
            LoanTimer.Interval = 2;
            LoanTimer.Tick += LoanTimer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("0xProto Nerd Font Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 255);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(240, 46);
            label2.Name = "label2";
            label2.Size = new Size(254, 48);
            label2.TabIndex = 1;
            label2.Text = "Wellcome!";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 55, 63);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(bookTotalLabel);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(244, 130);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 2;
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
            // bookTotalLabel
            // 
            bookTotalLabel.AutoSize = true;
            bookTotalLabel.Font = new Font("BIZ UDPGothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookTotalLabel.ForeColor = Color.FromArgb(0, 173, 181);
            bookTotalLabel.Location = new Point(12, 41);
            bookTotalLabel.Name = "bookTotalLabel";
            bookTotalLabel.Size = new Size(101, 37);
            bookTotalLabel.TabIndex = 1;
            bookTotalLabel.Text = "000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 13);
            label3.Name = "label3";
            label3.Size = new Size(118, 18);
            label3.TabIndex = 0;
            label3.Text = "Books Total";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 55, 63);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(535, 130);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 125);
            panel6.TabIndex = 4;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("BIZ UDPGothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 173, 181);
            label6.Location = new Point(12, 41);
            label6.Name = "label6";
            label6.Size = new Size(101, 37);
            label6.TabIndex = 1;
            label6.Text = "000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 13);
            label7.Name = "label7";
            label7.Size = new Size(118, 18);
            label7.TabIndex = 0;
            label7.Text = "Users Total";
            // 
            // bookTable
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle5.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            bookTable.BackgroundColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle6.Font = new Font("0xProto Nerd Font Mono", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 255);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            bookTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            bookTable.ColumnHeadersHeight = 29;
            bookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            bookTable.Columns.AddRange(new DataGridViewColumn[] { BookIdColumn, BookNameColumn, BookAuthorColumn, CategoryColumn });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle7.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            bookTable.DefaultCellStyle = dataGridViewCellStyle7;
            bookTable.EnableHeadersVisualStyles = false;
            bookTable.Location = new Point(241, 275);
            bookTable.Name = "bookTable";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            bookTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            bookTable.RowHeadersVisible = false;
            bookTable.RowHeadersWidth = 51;
            bookTable.Size = new Size(562, 152);
            bookTable.TabIndex = 5;
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
            // txtBookSearch
            // 
            txtBookSearch.Location = new Point(562, 68);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(164, 25);
            txtBookSearch.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(732, 62);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(822, 474);
            Controls.Add(pictureBox4);
            Controls.Add(txtBookSearch);
            Controls.Add(bookTable);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(label2);
            Controls.Add(sidebar);
            Font = new Font("0xProto Nerd Font Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, 255);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            homeContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel homeContainer;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button button6;
        private Button button5;
        private System.Windows.Forms.Timer LoanTimer;
        private Button button7;
        private Label label2;
        private Panel panel5;
        private Label label5;
        private Label bookTotalLabel;
        private Label label3;
        private PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label6;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private DataGridView bookTable;
        private DataGridViewTextBoxColumn BookIdColumn;
        private DataGridViewTextBoxColumn BookNameColumn;
        private DataGridViewTextBoxColumn BookAuthorColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
        private TextBox txtBookSearch;
        private PictureBox pictureBox4;
    }
}