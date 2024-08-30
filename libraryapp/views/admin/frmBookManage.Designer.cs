namespace libraryapp
{
    partial class frmBookManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookManage));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            btDelete = new Button();
            btEdit = new Button();
            pictureBox1 = new PictureBox();
            txtBookSearch = new TextBox();
            BookTable = new DataGridView();
            BookIDColumn = new DataGridViewTextBoxColumn();
            BookNameColumn = new DataGridViewTextBoxColumn();
            AuthorColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            NumberColumn = new DataGridViewTextBoxColumn();
            selectedColumn = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(43, 44);
            label2.Name = "label2";
            label2.Size = new Size(283, 54);
            label2.TabIndex = 20;
            label2.Text = "Book Manage";
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.FromArgb(57, 62, 70);
            btDelete.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            btDelete.ForeColor = Color.White;
            btDelete.Location = new Point(315, 365);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 39;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.FromArgb(57, 62, 70);
            btEdit.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            btEdit.ForeColor = Color.White;
            btEdit.Location = new Point(158, 365);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 29);
            btEdit.TabIndex = 38;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += btEdit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(639, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtBookSearch
            // 
            txtBookSearch.Location = new Point(441, 123);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(182, 27);
            txtBookSearch.TabIndex = 36;
            // 
            // BookTable
            // 
            BookTable.AllowUserToAddRows = false;
            BookTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle1.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            BookTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            BookTable.BackgroundColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle2.Font = new Font("Arial", 7.8F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BookTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BookTable.ColumnHeadersHeight = 29;
            BookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BookTable.Columns.AddRange(new DataGridViewColumn[] { BookIDColumn, BookNameColumn, AuthorColumn, CategoryColumn, NumberColumn, selectedColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 55, 63);
            dataGridViewCellStyle3.Font = new Font("Arial", 7.8F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            BookTable.DefaultCellStyle = dataGridViewCellStyle3;
            BookTable.EnableHeadersVisualStyles = false;
            BookTable.Location = new Point(58, 166);
            BookTable.Name = "BookTable";
            BookTable.RowHeadersVisible = false;
            BookTable.RowHeadersWidth = 51;
            BookTable.Size = new Size(636, 176);
            BookTable.TabIndex = 35;
            // 
            // BookIDColumn
            // 
            BookIDColumn.Frozen = true;
            BookIDColumn.HeaderText = "ID";
            BookIDColumn.MinimumWidth = 6;
            BookIDColumn.Name = "BookIDColumn";
            BookIDColumn.ReadOnly = true;
            BookIDColumn.Resizable = DataGridViewTriState.False;
            BookIDColumn.Width = 55;
            // 
            // BookNameColumn
            // 
            BookNameColumn.Frozen = true;
            BookNameColumn.HeaderText = "Tile";
            BookNameColumn.MinimumWidth = 6;
            BookNameColumn.Name = "BookNameColumn";
            BookNameColumn.Resizable = DataGridViewTriState.False;
            BookNameColumn.Width = 125;
            // 
            // AuthorColumn
            // 
            AuthorColumn.Frozen = true;
            AuthorColumn.HeaderText = "Author";
            AuthorColumn.MinimumWidth = 6;
            AuthorColumn.Name = "AuthorColumn";
            AuthorColumn.Resizable = DataGridViewTriState.False;
            AuthorColumn.Width = 150;
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
            // NumberColumn
            // 
            NumberColumn.HeaderText = "Total";
            NumberColumn.MinimumWidth = 6;
            NumberColumn.Name = "NumberColumn";
            NumberColumn.Width = 120;
            // 
            // selectedColumn
            // 
            selectedColumn.HeaderText = "-";
            selectedColumn.MinimumWidth = 6;
            selectedColumn.Name = "selectedColumn";
            selectedColumn.Width = 50;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(57, 62, 70);
            button1.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            button1.ForeColor = Color.White;
            button1.Location = new Point(473, 365);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 40;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmBookManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(744, 474);
            Controls.Add(button1);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(pictureBox1);
            Controls.Add(txtBookSearch);
            Controls.Add(BookTable);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBookManage";
            Text = "frmBookManage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btDelete;
        private Button btEdit;
        private PictureBox pictureBox1;
        private TextBox txtBookSearch;
        private DataGridView BookTable;
        private Button button1;
        private DataGridViewTextBoxColumn BookIDColumn;
        private DataGridViewTextBoxColumn BookNameColumn;
        private DataGridViewTextBoxColumn AuthorColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewCheckBoxColumn selectedColumn;
    }
}