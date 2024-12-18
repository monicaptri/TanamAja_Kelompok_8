namespace TanamAja.App.View
{
    partial class UC_DashboardCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Iki;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(337, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 517);
            panel1.TabIndex = 0;
            // 
            // UC_DashboardCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_DashboardCustomer";
            Size = new Size(1444, 1009);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}
