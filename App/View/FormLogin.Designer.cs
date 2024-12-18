namespace TanamAja.App.View
{
    partial class formLogin
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
            panel1 = new Panel();
            tempatLogin = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.BackgroundImage = Properties.Resources.Logo_TanamAja;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 838);
            panel1.TabIndex = 0;
            // 
            // tempatLogin
            // 
            tempatLogin.Dock = DockStyle.Right;
            tempatLogin.Location = new Point(425, 0);
            tempatLogin.Name = "tempatLogin";
            tempatLogin.Size = new Size(1112, 838);
            tempatLogin.TabIndex = 1;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1537, 838);
            Controls.Add(tempatLogin);
            Controls.Add(panel1);
            Name = "formLogin";
            Text = "Login";
            Load += formLogin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel tempatLogin;
    }
}