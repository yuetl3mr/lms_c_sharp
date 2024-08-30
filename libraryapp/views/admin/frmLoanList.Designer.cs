namespace libraryapp
{
    partial class frmLoanList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanList));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            loanTable = new DataGridView();
            LoanIdColumn = new DataGridViewTextBoxColumn();
            BookIdColumn = new DataGridViewTextBoxColumn();
            UserIdColumn = new DataGridViewTextBoxColumn();
            BorrowTimeColumn = new DataGridViewTextBoxColumn();
            ReturnTimeColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(43, 44);
            label2.Name = "label2";
            label2.Size = new Size(188, 54);
            label2.TabIndex = 18;
            label2.Text = "Loan List";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(668, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(470, 162);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(182, 27);
            txtSearch.TabIndex = 29;
            // 
            // loanTable
            // 
            loanTable.AllowUserToAddRows = false;
            loanTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle5.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(224, 224, 224);
            loanTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            loanTable.BackgroundColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle6.Font = new Font("0xProto Nerd Font Mono", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 255);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            loanTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            loanTable.ColumnHeadersHeight = 29;
            loanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            loanTable.Columns.AddRange(new DataGridViewColumn[] { LoanIdColumn, BookIdColumn, UserIdColumn, BorrowTimeColumn, ReturnTimeColumn });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle7.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            loanTable.DefaultCellStyle = dataGridViewCellStyle7;
            loanTable.EnableHeadersVisualStyles = false;
            loanTable.Location = new Point(61, 207);
            loanTable.Name = "loanTable";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            loanTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            loanTable.RowHeadersVisible = false;
            loanTable.RowHeadersWidth = 51;
            loanTable.Size = new Size(639, 176);
            loanTable.TabIndex = 28;
            loanTable.CellContentClick += loanTable_CellContentClick;
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
            // BorrowTimeColumn
            // 
            BorrowTimeColumn.Frozen = true;
            BorrowTimeColumn.HeaderText = "BorrowTime";
            BorrowTimeColumn.MinimumWidth = 6;
            BorrowTimeColumn.Name = "BorrowTimeColumn";
            BorrowTimeColumn.Resizable = DataGridViewTriState.False;
            BorrowTimeColumn.Width = 125;
            // 
            // ReturnTimeColumn
            // 
            ReturnTimeColumn.Frozen = true;
            ReturnTimeColumn.HeaderText = "ReturnTime";
            ReturnTimeColumn.MinimumWidth = 6;
            ReturnTimeColumn.Name = "ReturnTimeColumn";
            ReturnTimeColumn.ReadOnly = true;
            ReturnTimeColumn.Width = 125;
            // 
            // frmLoanList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(744, 474);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearch);
            Controls.Add(loanTable);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoanList";
            Text = "frmLoanList";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private DataGridView loanTable;
        private DataGridViewTextBoxColumn LoanIdColumn;
        private DataGridViewTextBoxColumn BookIdColumn;
        private DataGridViewTextBoxColumn UserIdColumn;
        private DataGridViewTextBoxColumn BorrowTimeColumn;
        private DataGridViewTextBoxColumn ReturnTimeColumn;
    }
}