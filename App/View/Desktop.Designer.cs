namespace TanamAja
{
    partial class Desktop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnMulai = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Desktop___1__1_;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnMulai);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1908, 1080);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnMulai
            // 
            btnMulai.BackColor = Color.FromArgb(71, 102, 59);
            btnMulai.FlatAppearance.BorderSize = 0;
            btnMulai.FlatStyle = FlatStyle.Flat;
            btnMulai.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMulai.Location = new Point(726, 862);
            btnMulai.Margin = new Padding(4);
            btnMulai.Name = "btnMulai";
            btnMulai.Size = new Size(421, 99);
            btnMulai.TabIndex = 0;
            btnMulai.Text = "MULAI";
            btnMulai.UseVisualStyleBackColor = false;
            btnMulai.Click += btnMulai_Click;
            // 
            // Desktop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 236, 215);
            ClientSize = new Size(1924, 1050);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Desktop";
            Text = "Form1";
            Load += Desktop_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMulai;
    }
}
