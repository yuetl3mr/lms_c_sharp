﻿namespace libraryapp
{
    partial class frmReturn
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturn));
            label2 = new Label();
            bookTable = new DataGridView();
            LoanIdColumn = new DataGridViewTextBoxColumn();
            BookIdColumn = new DataGridViewTextBoxColumn();
            UserIdColumn = new DataGridViewTextBoxColumn();
            DueTimeColumn = new DataGridViewTextBoxColumn();
            LoanSelect = new DataGridViewCheckBoxColumn();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            txtUserSearch = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bookTable).BeginInit();
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
            label2.Size = new Size(317, 54);
            label2.TabIndex = 17;
            label2.Text = "Book Returning";
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
            bookTable.Columns.AddRange(new DataGridViewColumn[] { LoanIdColumn, BookIdColumn, UserIdColumn, DueTimeColumn, LoanSelect });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle11.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            bookTable.DefaultCellStyle = dataGridViewCellStyle11;
            bookTable.EnableHeadersVisualStyles = false;
            bookTable.Location = new Point(98, 203);
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
            bookTable.Size = new Size(542, 148);
            bookTable.TabIndex = 20;
            // 
            // LoanIdColumn
            // 
            LoanIdColumn.Frozen = true;
            LoanIdColumn.HeaderText = "Loan";
            LoanIdColumn.MinimumWidth = 6;
            LoanIdColumn.Name = "LoanIdColumn";
            LoanIdColumn.Resizable = DataGridViewTriState.False;
            LoanIdColumn.Width = 55;
            // 
            // BookIdColumn
            // 
            BookIdColumn.Frozen = true;
            BookIdColumn.HeaderText = "Book";
            BookIdColumn.MinimumWidth = 6;
            BookIdColumn.Name = "BookIdColumn";
            BookIdColumn.Resizable = DataGridViewTriState.False;
            BookIdColumn.Width = 175;
            // 
            // UserIdColumn
            // 
            UserIdColumn.Frozen = true;
            UserIdColumn.HeaderText = "User";
            UserIdColumn.MinimumWidth = 6;
            UserIdColumn.Name = "UserIdColumn";
            UserIdColumn.Resizable = DataGridViewTriState.False;
            UserIdColumn.Width = 130;
            // 
            // DueTimeColumn
            // 
            DueTimeColumn.Frozen = true;
            DueTimeColumn.HeaderText = "DueTime";
            DueTimeColumn.MinimumWidth = 6;
            DueTimeColumn.Name = "DueTimeColumn";
            DueTimeColumn.Resizable = DataGridViewTriState.False;
            DueTimeColumn.Width = 125;
            // 
            // LoanSelect
            // 
            LoanSelect.Frozen = true;
            LoanSelect.HeaderText = "-";
            LoanSelect.MinimumWidth = 6;
            LoanSelect.Name = "LoanSelect";
            LoanSelect.Width = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("0xProto Nerd Font Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 255);
            label6.ForeColor = Color.FromArgb(0, 173, 181);
            label6.Location = new Point(142, 152);
            label6.Name = "label6";
            label6.Size = new Size(179, 24);
            label6.TabIndex = 26;
            label6.Text = "Borrowed List";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUserSearch
            // 
            txtUserSearch.Location = new Point(384, 152);
            txtUserSearch.Name = "txtUserSearch";
            txtUserSearch.Size = new Size(153, 27);
            txtUserSearch.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(57, 62, 70);
            button1.Font = new Font("0xProto Nerd Font", 10.7999992F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(259, 406);
            button1.Name = "button1";
            button1.Size = new Size(217, 36);
            button1.TabIndex = 27;
            button1.Text = "Confirm Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(744, 474);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(txtUserSearch);
            Controls.Add(bookTable);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReturn";
            Text = "frmReturn";
            ((System.ComponentModel.ISupportInitialize)bookTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView bookTable;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox txtUserSearch;
        private Button button1;
        private DataGridViewTextBoxColumn LoanIdColumn;
        private DataGridViewTextBoxColumn BookIdColumn;
        private DataGridViewTextBoxColumn UserIdColumn;
        private DataGridViewTextBoxColumn DueTimeColumn;
        private DataGridViewCheckBoxColumn LoanSelect;
    }
}