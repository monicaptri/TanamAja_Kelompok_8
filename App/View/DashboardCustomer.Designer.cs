namespace TanamAja.App.View
{
    partial class DashboardCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardCustomer));
            btnRiwayat = new Button();
            button1 = new Button();
            btnBeranda = new Button();
            panel1 = new Panel();
            tempatDashboardCustomer = new Panel();
            button2 = new Button();
            tempatDashboardCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.FromArgb(187, 138, 82);
            btnRiwayat.FlatAppearance.BorderSize = 0;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnRiwayat.Image = Properties.Resources.Ikon_Riwayat__1_;
            btnRiwayat.Location = new Point(88, 621);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(320, 110);
            btnRiwayat.TabIndex = 3;
            btnRiwayat.Text = "     Riwayat Pesanan";
            btnRiwayat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(187, 138, 82);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.IkonProfilUser__1_;
            button1.Location = new Point(88, 178);
            button1.Name = "button1";
            button1.Size = new Size(320, 110);
            button1.TabIndex = 2;
            button1.Text = "          Profil";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.FromArgb(187, 138, 82);
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBeranda.Image = Properties.Resources.IkonKatalog__1_;
            btnBeranda.Location = new Point(88, 403);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(320, 110);
            btnBeranda.TabIndex = 1;
            btnBeranda.Text = "          Beranda";
            btnBeranda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(221, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 601);
            panel1.TabIndex = 4;
            // 
            // tempatDashboardCustomer
            // 
            tempatDashboardCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            tempatDashboardCustomer.Controls.Add(panel1);
            tempatDashboardCustomer.Location = new Point(503, 128);
            tempatDashboardCustomer.Name = "tempatDashboardCustomer";
            tempatDashboardCustomer.Size = new Size(1526, 864);
            tempatDashboardCustomer.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(88, 841);
            button2.Name = "button2";
            button2.Size = new Size(320, 110);
            button2.TabIndex = 4;
            button2.Text = "          Logout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DashboardCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 236, 215);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(tempatDashboardCustomer);
            Controls.Add(btnRiwayat);
            Controls.Add(btnBeranda);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "DashboardCustomer";
            Text = "Dashboard";
            Load += DashboardCustomer_Load;
            tempatDashboardCustomer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnBeranda;
        private Button btnRiwayat;
        private Button button1;
        private Panel panel1;
        private Panel tempatDashboardCustomer;
        private Button button2;
    }
}