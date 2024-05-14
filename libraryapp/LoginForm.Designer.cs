namespace libraryapp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            txtUserName = new TextBox();
            txtUserPassword = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("0xProto Nerd Font Propo", 24F, FontStyle.Bold, GraphicsUnit.Point, 255);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(76, 99);
            label1.Name = "label1";
            label1.Size = new Size(150, 48);
            label1.TabIndex = 1;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 277);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Location = new Point(46, 307);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 1);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("UD Digi Kyokasho N-B", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(29, 337);
            button1.Name = "button1";
            button1.Size = new Size(236, 33);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("0xProto Nerd Font", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 255);
            txtUserName.ForeColor = Color.FromArgb(255, 128, 0);
            txtUserName.Location = new Point(58, 197);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(207, 29);
            txtUserName.TabIndex = 8;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserPassword.ForeColor = Color.FromArgb(255, 128, 0);
            txtUserPassword.Location = new Point(58, 272);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(207, 28);
            txtUserPassword.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Location = new Point(46, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 1);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(46, 383);
            label2.Name = "label2";
            label2.Size = new Size(125, 17);
            label2.TabIndex = 10;
            label2.Text = "Don't have account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 192, 128);
            label3.Location = new Point(177, 383);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 11;
            label3.Text = "Sign up";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(262, -1);
            label4.Name = "label4";
            label4.Size = new Size(30, 33);
            label4.TabIndex = 12;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(290, 439);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Button button1;
        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}