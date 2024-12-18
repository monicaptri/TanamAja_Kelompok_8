namespace TanamAja.App.View
{
    partial class FormTukangKebun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTukangKebun));
            btnProfilAdmin = new Button();
            btnLogoutAdmin = new Button();
            btnKatalogAdmin = new Button();
            btnRiwayatAdmin = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnProfilAdmin
            // 
            btnProfilAdmin.BackColor = Color.FromArgb(187, 138, 82);
            btnProfilAdmin.BackgroundImage = (Image)resources.GetObject("btnProfilAdmin.BackgroundImage");
            btnProfilAdmin.FlatAppearance.BorderSize = 0;
            btnProfilAdmin.FlatStyle = FlatStyle.Flat;
            btnProfilAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfilAdmin.ForeColor = Color.Black;
            btnProfilAdmin.Location = new Point(55, 168);
            btnProfilAdmin.Margin = new Padding(1);
            btnProfilAdmin.Name = "btnProfilAdmin";
            btnProfilAdmin.Size = new Size(326, 110);
            btnProfilAdmin.TabIndex = 0;
            btnProfilAdmin.Text = "        Profil";
            btnProfilAdmin.TextImageRelation = TextImageRelation.TextAboveImage;
            btnProfilAdmin.UseVisualStyleBackColor = false;
            btnProfilAdmin.Click += btnProfilAdmin_Click;
            // 
            // btnLogoutAdmin
            // 
            btnLogoutAdmin.BackColor = Color.FromArgb(187, 138, 82);
            btnLogoutAdmin.BackgroundImage = (Image)resources.GetObject("btnLogoutAdmin.BackgroundImage");
            btnLogoutAdmin.FlatAppearance.BorderSize = 0;
            btnLogoutAdmin.FlatStyle = FlatStyle.Flat;
            btnLogoutAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogoutAdmin.ForeColor = Color.Black;
            btnLogoutAdmin.Location = new Point(55, 828);
            btnLogoutAdmin.Margin = new Padding(1);
            btnLogoutAdmin.Name = "btnLogoutAdmin";
            btnLogoutAdmin.Size = new Size(326, 110);
            btnLogoutAdmin.TabIndex = 1;
            btnLogoutAdmin.Text = "         Logout";
            btnLogoutAdmin.UseVisualStyleBackColor = false;
            btnLogoutAdmin.Click += btnLogoutAdmin_Click;
            // 
            // btnKatalogAdmin
            // 
            btnKatalogAdmin.BackColor = Color.FromArgb(187, 138, 82);
            btnKatalogAdmin.BackgroundImage = (Image)resources.GetObject("btnKatalogAdmin.BackgroundImage");
            btnKatalogAdmin.FlatAppearance.BorderSize = 0;
            btnKatalogAdmin.FlatStyle = FlatStyle.Flat;
            btnKatalogAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKatalogAdmin.ForeColor = Color.Black;
            btnKatalogAdmin.Location = new Point(55, 330);
            btnKatalogAdmin.Margin = new Padding(1);
            btnKatalogAdmin.Name = "btnKatalogAdmin";
            btnKatalogAdmin.Size = new Size(326, 110);
            btnKatalogAdmin.TabIndex = 2;
            btnKatalogAdmin.Text = "        Katalog";
            btnKatalogAdmin.UseVisualStyleBackColor = false;
            btnKatalogAdmin.Click += btnKatalogAdmin_Click;
            // 
            // btnRiwayatAdmin
            // 
            btnRiwayatAdmin.BackColor = Color.FromArgb(187, 138, 82);
            btnRiwayatAdmin.BackgroundImage = (Image)resources.GetObject("btnRiwayatAdmin.BackgroundImage");
            btnRiwayatAdmin.FlatAppearance.BorderSize = 0;
            btnRiwayatAdmin.FlatStyle = FlatStyle.Flat;
            btnRiwayatAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatAdmin.ForeColor = Color.Black;
            btnRiwayatAdmin.Location = new Point(55, 661);
            btnRiwayatAdmin.Margin = new Padding(1);
            btnRiwayatAdmin.Name = "btnRiwayatAdmin";
            btnRiwayatAdmin.Size = new Size(326, 110);
            btnRiwayatAdmin.TabIndex = 4;
            btnRiwayatAdmin.Text = "        Riwayat";
            btnRiwayatAdmin.UseVisualStyleBackColor = false;
            btnRiwayatAdmin.Click += btnRiwayatAdmin_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(669, 294);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(959, 511);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(109, 151, 115);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1491, 891);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(213, 79);
            button1.TabIndex = 6;
            button1.Text = "TAMBAH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormTukangKebun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1054);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnRiwayatAdmin);
            Controls.Add(btnKatalogAdmin);
            Controls.Add(btnLogoutAdmin);
            Controls.Add(btnProfilAdmin);
            Margin = new Padding(1);
            Name = "FormTukangKebun";
            Text = "FormTukangKebun";
            Load += FormTukangKebun_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProfilAdmin;
        private Button btnLogoutAdmin;
        private Button btnKatalogAdmin;
        private Button btnRiwayatAdmin;
        private DataGridView dataGridView1;
        private Button button1;
    }
}