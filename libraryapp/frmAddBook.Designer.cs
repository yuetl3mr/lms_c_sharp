namespace libraryapp
{
    partial class frmAddBook
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
            label8 = new Label();
            button1 = new Button();
            txtQuan = new TextBox();
            txtPub = new TextBox();
            label5 = new Label();
            txtCate = new TextBox();
            label4 = new Label();
            txtAuthor = new TextBox();
            label3 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(261, 9);
            label8.Name = "label8";
            label8.Size = new Size(30, 33);
            label8.TabIndex = 31;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(57, 62, 70);
            button1.Font = new Font("UD Digi Kyokasho N-B", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(55, 434);
            button1.Name = "button1";
            button1.Size = new Size(200, 29);
            button1.TabIndex = 27;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtQuan
            // 
            txtQuan.Font = new Font("0xProto Nerd Font", 9F);
            txtQuan.Location = new Point(123, 377);
            txtQuan.Name = "txtQuan";
            txtQuan.Size = new Size(146, 25);
            txtQuan.TabIndex = 26;
            // 
            // txtPub
            // 
            txtPub.Font = new Font("0xProto Nerd Font", 9F);
            txtPub.Location = new Point(45, 335);
            txtPub.Name = "txtPub";
            txtPub.Size = new Size(224, 25);
            txtPub.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 312);
            label5.Name = "label5";
            label5.Size = new Size(200, 17);
            label5.TabIndex = 23;
            label5.Text = "Publication (dd/mm/yyyy)";
            // 
            // txtCate
            // 
            txtCate.Font = new Font("0xProto Nerd Font", 9F);
            txtCate.Location = new Point(45, 263);
            txtCate.Name = "txtCate";
            txtCate.Size = new Size(224, 25);
            txtCate.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 236);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 21;
            label4.Text = "CategoryID";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("0xProto Nerd Font", 9F);
            txtAuthor.Location = new Point(45, 194);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(224, 25);
            txtAuthor.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 169);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 19;
            label3.Text = "Author";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            txtTitle.Location = new Point(45, 126);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(224, 25);
            txtTitle.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 100);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 17;
            label2.Text = "Book Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(162, 41);
            label1.TabIndex = 16;
            label1.Text = "New Book";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 385);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 25;
            label6.Text = "Quantity";
            // 
            // frmAddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(303, 491);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(txtQuan);
            Controls.Add(label6);
            Controls.Add(txtPub);
            Controls.Add(label5);
            Controls.Add(txtCate);
            Controls.Add(label4);
            Controls.Add(txtAuthor);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button button1;
        private TextBox txtQuan;
        private TextBox txtPub;
        private Label label5;
        private TextBox txtCate;
        private Label label4;
        private TextBox txtAuthor;
        private Label label3;
        private TextBox txtTitle;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}