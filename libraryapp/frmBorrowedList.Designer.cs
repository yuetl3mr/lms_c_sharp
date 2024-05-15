namespace libraryapp
{
    partial class frmBorrowedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrowedList));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtLoanSearch = new TextBox();
            borrowedTable = new DataGridView();
            LoanIdColumn = new DataGridViewTextBoxColumn();
            BookIdColumn = new DataGridViewTextBoxColumn();
            BorrowTimeColumn = new DataGridViewTextBoxColumn();
            DueTimeColumn = new DataGridViewTextBoxColumn();
            ReturnTimeColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borrowedTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(43, 44);
            label2.Name = "label2";
            label2.Size = new Size(283, 54);
            label2.TabIndex = 17;
            label2.Text = "Borrowed List";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(692, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtLoanSearch
            // 
            txtLoanSearch.Location = new Point(494, 124);
            txtLoanSearch.Name = "txtLoanSearch";
            txtLoanSearch.Size = new Size(182, 27);
            txtLoanSearch.TabIndex = 32;
            // 
            // borrowedTable
            // 
            borrowedTable.AllowUserToAddRows = false;
            borrowedTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle5.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(224, 224, 224);
            borrowedTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            borrowedTable.BackgroundColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle6.Font = new Font("0xProto Nerd Font Mono", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 255);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            borrowedTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            borrowedTable.ColumnHeadersHeight = 29;
            borrowedTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            borrowedTable.Columns.AddRange(new DataGridViewColumn[] { LoanIdColumn, BookIdColumn, BorrowTimeColumn, DueTimeColumn, ReturnTimeColumn });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle7.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            borrowedTable.DefaultCellStyle = dataGridViewCellStyle7;
            borrowedTable.EnableHeadersVisualStyles = false;
            borrowedTable.Location = new Point(85, 169);
            borrowedTable.Name = "borrowedTable";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            borrowedTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            borrowedTable.RowHeadersVisible = false;
            borrowedTable.RowHeadersWidth = 51;
            borrowedTable.Size = new Size(639, 176);
            borrowedTable.TabIndex = 31;
            // 
            // LoanIdColumn
            // 
            LoanIdColumn.Frozen = true;
            LoanIdColumn.HeaderText = "Loan";
            LoanIdColumn.MinimumWidth = 6;
            LoanIdColumn.Name = "LoanIdColumn";
            LoanIdColumn.ReadOnly = true;
            LoanIdColumn.Resizable = DataGridViewTriState.False;
            LoanIdColumn.Width = 55;
            // 
            // BookIdColumn
            // 
            BookIdColumn.Frozen = true;
            BookIdColumn.HeaderText = "Book";
            BookIdColumn.MinimumWidth = 6;
            BookIdColumn.Name = "BookIdColumn";
            BookIdColumn.ReadOnly = true;
            BookIdColumn.Resizable = DataGridViewTriState.False;
            BookIdColumn.Width = 175;
            // 
            // BorrowTimeColumn
            // 
            BorrowTimeColumn.Frozen = true;
            BorrowTimeColumn.HeaderText = "BorrowTime";
            BorrowTimeColumn.MinimumWidth = 6;
            BorrowTimeColumn.Name = "BorrowTimeColumn";
            BorrowTimeColumn.ReadOnly = true;
            BorrowTimeColumn.Resizable = DataGridViewTriState.False;
            BorrowTimeColumn.Width = 125;
            // 
            // DueTimeColumn
            // 
            DueTimeColumn.Frozen = true;
            DueTimeColumn.HeaderText = "DueTime";
            DueTimeColumn.MinimumWidth = 6;
            DueTimeColumn.Name = "DueTimeColumn";
            DueTimeColumn.ReadOnly = true;
            DueTimeColumn.Resizable = DataGridViewTriState.False;
            DueTimeColumn.Width = 125;
            // 
            // ReturnTimeColumn
            // 
            ReturnTimeColumn.Frozen = true;
            ReturnTimeColumn.HeaderText = "ReturnTime";
            ReturnTimeColumn.MinimumWidth = 6;
            ReturnTimeColumn.Name = "ReturnTimeColumn";
            ReturnTimeColumn.ReadOnly = true;
            ReturnTimeColumn.Resizable = DataGridViewTriState.False;
            ReturnTimeColumn.Width = 125;
            // 
            // frmBorrowedList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtLoanSearch);
            Controls.Add(borrowedTable);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBorrowedList";
            Text = "frmBorrowedList";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)borrowedTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtLoanSearch;
        private DataGridView borrowedTable;
        private DataGridViewTextBoxColumn LoanIdColumn;
        private DataGridViewTextBoxColumn BookIdColumn;
        private DataGridViewTextBoxColumn BorrowTimeColumn;
        private DataGridViewTextBoxColumn DueTimeColumn;
        private DataGridViewTextBoxColumn ReturnTimeColumn;
    }
}