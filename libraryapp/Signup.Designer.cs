namespace libraryapp
{
    partial class Signup
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
            txtUserName = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            maleButton = new RadioButton();
            femaleButton = new RadioButton();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("0xProto Nerd Font Mono", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 255);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 89);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("0xProto Nerd Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 255);
            txtUserName.Location = new Point(36, 109);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(224, 25);
            txtUserName.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Font = new Font("0xProto Nerd Font", 9F);
            txtName.Location = new Point(36, 169);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 25);
            txtName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 149);
            label3.Name = "label3";
            label3.Size = new Size(40, 17);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("0xProto Nerd Font", 9F);
            txtPassword.Location = new Point(36, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 25);
            txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.ForeColor = Color.White;
            label4.Location = new Point(36, 211);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("0xProto Nerd Font", 9F);
            txtConfirmPassword.Location = new Point(36, 291);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(224, 25);
            txtConfirmPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, 271);
            label5.Name = "label5";
            label5.Size = new Size(136, 17);
            label5.TabIndex = 7;
            label5.Text = "Confirm Password";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("0xProto Nerd Font", 9F);
            txtAddress.Location = new Point(36, 350);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(224, 25);
            txtAddress.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 330);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 9;
            label6.Text = "Adderss";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(57, 62, 70);
            button1.Font = new Font("UD Digi Kyokasho N-B", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(49, 437);
            button1.Name = "button1";
            button1.Size = new Size(200, 29);
            button1.TabIndex = 11;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label7.ForeColor = Color.White;
            label7.Location = new Point(36, 395);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            label7.Click += label7_Click;
            // 
            // maleButton
            // 
            maleButton.AutoSize = true;
            maleButton.Font = new Font("UD Digi Kyokasho N-B", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            maleButton.ForeColor = Color.White;
            maleButton.Location = new Point(116, 395);
            maleButton.Name = "maleButton";
            maleButton.Size = new Size(56, 19);
            maleButton.TabIndex = 13;
            maleButton.TabStop = true;
            maleButton.Text = "Male";
            maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            femaleButton.Font = new Font("UD Digi Kyokasho N-B", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            femaleButton.ForeColor = Color.White;
            femaleButton.Location = new Point(179, 395);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(70, 19);
            femaleButton.TabIndex = 14;
            femaleButton.TabStop = true;
            femaleButton.Text = "Female";
            femaleButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(272, -1);
            label8.Name = "label8";
            label8.Size = new Size(30, 33);
            label8.TabIndex = 15;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(303, 491);
            Controls.Add(label8);
            Controls.Add(femaleButton);
            Controls.Add(maleButton);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtName;
        private Label label3;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtConfirmPassword;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private Button button1;
        private Label label7;
        private RadioButton maleButton;
        private RadioButton femaleButton;
        private Label label8;
    }
}