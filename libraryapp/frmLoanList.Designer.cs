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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtLoanSearch = new TextBox();
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
            // txtLoanSearch
            // 
            txtLoanSearch.Location = new Point(470, 162);
            txtLoanSearch.Name = "txtLoanSearch";
            txtLoanSearch.Size = new Size(182, 27);
            txtLoanSearch.TabIndex = 29;
            // 
            // loanTable
            // 
            loanTable.AllowUserToAddRows = false;
            loanTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle1.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            loanTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            loanTable.BackgroundColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle2.Font = new Font("0xProto Nerd Font Mono", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 255);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            loanTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            loanTable.ColumnHeadersHeight = 29;
            loanTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            loanTable.Columns.AddRange(new DataGridViewColumn[] { LoanIdColumn, BookIdColumn, UserIdColumn, BorrowTimeColumn, ReturnTimeColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle3.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            loanTable.DefaultCellStyle = dataGridViewCellStyle3;
            loanTable.EnableHeadersVisualStyles = false;
            loanTable.Location = new Point(61, 207);
            loanTable.Name = "loanTable";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            loanTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            loanTable.RowHeadersVisible = false;
            loanTable.RowHeadersWidth = 51;
            loanTable.Size = new Size(639, 176);
            loanTable.TabIndex = 28;
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
            Controls.Add(txtLoanSearch);
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
        private TextBox txtLoanSearch;
        private DataGridView loanTable;
        private DataGridViewTextBoxColumn LoanIdColumn;
        private DataGridViewTextBoxColumn BookIdColumn;
        private DataGridViewTextBoxColumn UserIdColumn;
        private DataGridViewTextBoxColumn BorrowTimeColumn;
        private DataGridViewTextBoxColumn ReturnTimeColumn;
    }
}