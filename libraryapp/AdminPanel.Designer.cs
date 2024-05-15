namespace libraryapp
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            LoanContainer = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            formLoader = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            LoanTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            LoanContainer.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(34, 40, 49);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(LoanContainer);
            sidebar.Controls.Add(panel4);
            resources.ApplyResources(sidebar, "sidebar");
            sidebar.Name = "sidebar";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.list__1_;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(button1);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 40, 49);
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.Transparent;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(button2);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 40, 49);
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = Color.Transparent;
            button2.Image = Properties.Resources.open_book;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LoanContainer
            // 
            LoanContainer.BackColor = Color.FromArgb(35, 40, 45);
            LoanContainer.Controls.Add(button7);
            LoanContainer.Controls.Add(button6);
            LoanContainer.Controls.Add(button5);
            LoanContainer.Controls.Add(button4);
            resources.ApplyResources(LoanContainer, "LoanContainer");
            LoanContainer.Name = "LoanContainer";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(50, 60, 65);
            button7.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button7, "button7");
            button7.ForeColor = Color.Transparent;
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(50, 60, 65);
            button6.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button6, "button6");
            button6.ForeColor = Color.Transparent;
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(50, 60, 65);
            button5.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button5, "button5");
            button5.ForeColor = Color.Transparent;
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(34, 40, 49);
            button4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button4, "button4");
            button4.ForeColor = Color.Transparent;
            button4.Image = Properties.Resources.book;
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Controls.Add(button3);
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 40, 49);
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = Color.Transparent;
            button3.Image = Properties.Resources.profile__1_;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // formLoader
            // 
            formLoader.BackColor = Color.FromArgb(57, 62, 70);
            resources.ApplyResources(formLoader, "formLoader");
            formLoader.Name = "formLoader";
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // LoanTimer
            // 
            LoanTimer.Interval = 10;
            LoanTimer.Tick += LoanTimer_Tick;
            // 
            // AdminPanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sidebar);
            Controls.Add(formLoader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            LoanContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel LoanContainer;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Panel panel4;
        private Button button3;
        private Panel formLoader;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer LoanTimer;
    }
}