namespace TanamAja.App.View
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            panel1 = new Panel();
            btnlogout = new Button();
            btnTukangKebun = new Button();
            btnRiwayat = new Button();
            btnProfil = new Button();
            btnKatalog = new Button();
            colorDialog1 = new ColorDialog();
            tempatDashboardCustomer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnTukangKebun);
            panel1.Controls.Add(btnRiwayat);
            panel1.Controls.Add(btnProfil);
            panel1.Controls.Add(btnKatalog);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 1033);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(187, 138, 82);
            btnlogout.BackgroundImage = (Image)resources.GetObject("btnlogout.BackgroundImage");
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(51, 827);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(326, 110);
            btnlogout.TabIndex = 5;
            btnlogout.Text = "          Logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += button1_Click;
            // 
            // btnTukangKebun
            // 
            btnTukangKebun.BackColor = Color.FromArgb(187, 138, 82);
            btnTukangKebun.FlatAppearance.BorderSize = 0;
            btnTukangKebun.FlatStyle = FlatStyle.Flat;
            btnTukangKebun.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTukangKebun.Image = Properties.Resources.IkonProfil__1_;
            btnTukangKebun.Location = new Point(51, 494);
            btnTukangKebun.Name = "btnTukangKebun";
            btnTukangKebun.Size = new Size(326, 110);
            btnTukangKebun.TabIndex = 4;
            btnTukangKebun.Text = "    Tukang Kebun";
            btnTukangKebun.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTukangKebun.UseVisualStyleBackColor = false;
            btnTukangKebun.Click += btnTukangKebun_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.FromArgb(187, 138, 82);
            btnRiwayat.FlatAppearance.BorderSize = 0;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayat.Image = Properties.Resources.Ikon_Riwayat__1_;
            btnRiwayat.Location = new Point(51, 660);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(326, 110);
            btnRiwayat.TabIndex = 3;
            btnRiwayat.Text = "    Riwayat Pesanan";
            btnRiwayat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.FromArgb(187, 138, 82);
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfil.Image = Properties.Resources.IkonProfilUser__1_;
            btnProfil.Location = new Point(51, 170);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(326, 110);
            btnProfil.TabIndex = 2;
            btnProfil.Text = "        Profil";
            btnProfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnKatalog
            // 
            btnKatalog.BackColor = Color.FromArgb(187, 138, 82);
            btnKatalog.BackgroundImageLayout = ImageLayout.None;
            btnKatalog.Cursor = Cursors.Hand;
            btnKatalog.FlatAppearance.BorderSize = 0;
            btnKatalog.FlatStyle = FlatStyle.Flat;
            btnKatalog.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKatalog.Image = Properties.Resources.IkonKatalog__1_;
            btnKatalog.Location = new Point(51, 327);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(326, 110);
            btnKatalog.TabIndex = 0;
            btnKatalog.Text = "          Katalog";
            btnKatalog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKatalog.UseVisualStyleBackColor = false;
            btnKatalog.Click += btnKatalog_Click;
            // 
            // tempatDashboardCustomer
            // 
            tempatDashboardCustomer.Location = new Point(410, 0);
            tempatDashboardCustomer.Name = "tempatDashboardCustomer";
            tempatDashboardCustomer.Size = new Size(1491, 1033);
            tempatDashboardCustomer.TabIndex = 1;
            tempatDashboardCustomer.Paint += tempatDashboardCustomer_Paint;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tempatDashboardCustomer);
            Controls.Add(panel1);
            Name = "DashboardAdmin";
            Text = "Dashboard";
            Load += DashboardCustomer_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnKatalog;
        private Button btnProfil;
        private ColorDialog colorDialog1;
        private Button btnTukangKebun;
        private Button btnRiwayat;
        private Panel tempatDashboardCustomer;
        private Button btnlogout;
    }
}