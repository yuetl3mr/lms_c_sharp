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
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("0xProto Nerd Font Mono", 24F, FontStyle.Bold, GraphicsUnit.Point, 255);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(40, 34);
            label2.Name = "label2";
            label2.Size = new Size(306, 48);
            label2.TabIndex = 20;
            label2.Text = "Book Manage";
            // 
            // frmBookManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 62, 70);
            ClientSize = new Size(744, 474);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBookManage";
            Text = "frmBookManage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
    }
}