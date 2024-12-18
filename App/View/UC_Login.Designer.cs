namespace TanamAja.App.View
{
    partial class UC_Login
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
            PanelLogin = new Panel();
            btnTogglePassword = new Button();
            klikDaftar = new Label();
            btnLogin = new Button();
            textPassword = new TextBox();
            textUsername = new TextBox();
            PanelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLogin
            // 
            PanelLogin.BackgroundImage = Properties.Resources.Login_Form__1_;
            PanelLogin.BackgroundImageLayout = ImageLayout.Zoom;
            PanelLogin.Controls.Add(btnTogglePassword);
            PanelLogin.Controls.Add(klikDaftar);
            PanelLogin.Controls.Add(btnLogin);
            PanelLogin.Controls.Add(textPassword);
            PanelLogin.Controls.Add(textUsername);
            PanelLogin.Location = new Point(221, 146);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(615, 604);
            PanelLogin.TabIndex = 0;
            PanelLogin.Paint += PanelLogin_Paint;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.Location = new Point(495, 384);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(94, 29);
            btnTogglePassword.TabIndex = 8;
            btnTogglePassword.Text = "Show/Hide";
            btnTogglePassword.UseVisualStyleBackColor = true;
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // klikDaftar
            // 
            klikDaftar.AutoSize = true;
            klikDaftar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            klikDaftar.ForeColor = SystemColors.ActiveCaption;
            klikDaftar.Location = new Point(367, 573);
            klikDaftar.Name = "klikDaftar";
            klikDaftar.Size = new Size(101, 31);
            klikDaftar.TabIndex = 7;
            klikDaftar.Text = "Register";
            klikDaftar.Click += klikDaftar_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(109, 151, 115);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(178, 465);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(264, 54);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(217, 217, 217);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Location = new Point(29, 384);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(560, 20);
            textPassword.TabIndex = 1;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(217, 217, 217);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Location = new Point(29, 243);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(560, 20);
            textUsername.TabIndex = 0;
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            Controls.Add(PanelLogin);
            Name = "UC_Login";
            Size = new Size(1453, 1009);
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLogin;
        private TextBox textPassword;
        private TextBox textUsername;
        private Button btnLogin;
        private Label klikDaftar;
        private Button btnTogglePassword;
    }
}
