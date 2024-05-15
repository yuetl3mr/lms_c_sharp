namespace libraryapp
{
    partial class ReaderPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderPanel));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button8 = new Button();
            formLoader = new Panel();
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
            sidebar.BackColor = Color.FromArgb(34, 40, 49);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(4, 3, 4, 3);
            sidebar.MaximumSize = new Size(210, 474);
            sidebar.MinimumSize = new Size(80, 474);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(80, 474);
            sidebar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 71);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.list__1_;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(18, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("0xProto Nerd Font Mono", 10.7999992F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(75, 24);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(4, 80);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 36);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 40, 49);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("BIZ UDGothic", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImeMode = ImeMode.NoControl;
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
            button2.BackColor = Color.FromArgb(34, 40, 49);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("BIZ UDGothic", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(-4, -8);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(339, 52);
            button2.TabIndex = 2;
            button2.Text = "       Borrowed List";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button3.BackColor = Color.FromArgb(34, 40, 49);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("BIZ UDGothic", 9F, FontStyle.Bold);
            button3.ForeColor = Color.Transparent;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(-4, -8);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(339, 52);
            button3.TabIndex = 2;
            button3.Text = "       Account";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 128);
            panel5.Controls.Add(button8);
            panel5.Location = new Point(4, 206);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(264, 36);
            panel5.TabIndex = 5;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(34, 40, 49);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("BIZ UDGothic", 9F, FontStyle.Bold);
            button8.ForeColor = Color.Transparent;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.ImeMode = ImeMode.NoControl;
            button8.Location = new Point(-4, -8);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Padding = new Padding(20, 0, 0, 0);
            button8.Size = new Size(339, 52);
            button8.TabIndex = 2;
            button8.Text = "       Logout";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // formLoader
            // 
            formLoader.Location = new Point(79, 0);
            formLoader.Name = "formLoader";
            formLoader.Size = new Size(744, 474);
            formLoader.TabIndex = 3;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // ReaderPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(822, 474);
            Controls.Add(sidebar);
            Controls.Add(formLoader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReaderPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReaderPanel";
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
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button8;
        private Panel formLoader;
    }
}