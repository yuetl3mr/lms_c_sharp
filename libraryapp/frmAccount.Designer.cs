namespace libraryapp
{
    partial class frmAccount
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
            label1 = new Label();
            label2 = new Label();
            txtUserName = new Label();
            txtUserID = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            button1 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(245, 38);
            label1.TabIndex = 1;
            label1.Text = "Change Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 105);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 2;
            label2.Text = "UserName : ";
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(167, 104);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(20, 24);
            txtUserName.TabIndex = 3;
            txtUserName.Text = "_";
            // 
            // txtUserID
            // 
            txtUserID.AutoSize = true;
            txtUserID.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            txtUserID.ForeColor = Color.White;
            txtUserID.Location = new Point(148, 142);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(20, 24);
            txtUserID.TabIndex = 5;
            txtUserID.Text = "_";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 142);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 4;
            label4.Text = "UserID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 198);
            label3.Name = "label3";
            label3.Size = new Size(130, 24);
            label3.TabIndex = 6;
            label3.Text = "Old Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 264);
            label5.Name = "label5";
            label5.Size = new Size(130, 24);
            label5.TabIndex = 7;
            label5.Text = "New Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 332);
            label6.Name = "label6";
            label6.Size = new Size(170, 24);
            label6.TabIndex = 8;
            label6.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold);
            txtConfirmPassword.Location = new Point(40, 359);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(205, 25);
            txtConfirmPassword.TabIndex = 9;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold);
            txtNewPassword.Location = new Point(40, 291);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(205, 25);
            txtNewPassword.TabIndex = 10;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            txtOldPassword.Location = new Point(40, 225);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(205, 25);
            txtOldPassword.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(57, 62, 70);
            button1.Font = new Font("0xProto Nerd Font", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 255);
            button1.ForeColor = Color.White;
            button1.Location = new Point(52, 422);
            button1.Name = "button1";
            button1.Size = new Size(181, 29);
            button1.TabIndex = 12;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(272, 0);
            label8.Name = "label8";
            label8.Size = new Size(30, 33);
            label8.TabIndex = 16;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(303, 491);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(txtOldPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtUserID);
            Controls.Add(label4);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label txtUserName;
        private Label txtUserID;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private TextBox txtOldPassword;
        private Button button1;
        private Label label8;
    }
}