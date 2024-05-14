namespace libraryapp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(4, 3, 4, 3);
            sidebar.MaximumSize = new Size(210, 450);
            sidebar.MinimumSize = new Size(80, 450);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(210, 450);
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
            button1.BackColor = Color.FromArgb(35, 40, 45);
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
            button2.BackColor = Color.FromArgb(35, 40, 45);
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(4, 164);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(264, 36);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(35, 40, 45);
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
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 128);
            panel5.Controls.Add(button4);
            panel5.Location = new Point(4, 206);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(264, 36);
            panel5.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(35, 40, 45);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("BIZ UDGothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Image = Properties.Resources.execution;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-4, -8);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(339, 52);
            button4.TabIndex = 2;
            button4.Text = "       Book Manage";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += timer1_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(887, 450);
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
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel panel5;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}