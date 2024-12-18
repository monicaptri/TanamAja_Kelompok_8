namespace TanamAja.App.View
{
    partial class UC_Register
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
            btnTogglePassword = new Button();
            btnRegister = new Button();
            klikLogin = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Register_FOrm;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnTogglePassword);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(klikLogin);
            panel1.Controls.Add(textUsername);
            panel1.Controls.Add(textPassword);
            panel1.Location = new Point(187, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 603);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.Location = new Point(522, 375);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(94, 29);
            btnTogglePassword.TabIndex = 9;
            btnTogglePassword.Text = "Show/Hide";
            btnTogglePassword.UseVisualStyleBackColor = true;
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(109, 151, 115);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(193, 456);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(264, 54);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // klikLogin
            // 
            klikLogin.AutoSize = true;
            klikLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            klikLogin.ForeColor = SystemColors.ActiveCaption;
            klikLogin.Location = new Point(394, 566);
            klikLogin.Name = "klikLogin";
            klikLogin.Size = new Size(75, 31);
            klikLogin.TabIndex = 6;
            klikLogin.Text = "Login";
            klikLogin.Click += klikLogin_Click;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(217, 217, 217);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Location = new Point(44, 234);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(560, 20);
            textUsername.TabIndex = 4;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(217, 217, 217);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Location = new Point(44, 375);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(560, 20);
            textPassword.TabIndex = 5;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // UC_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "UC_Register";
            Size = new Size(1453, 1009);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegister;
        private Label klikLogin;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button btnTogglePassword;
    }
}
