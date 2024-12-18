namespace TanamAja.App.View
{
    partial class RiwayatCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatCustomer));
            btn_beranda = new Button();
            dataGridView1 = new DataGridView();
            btnprofil = new Button();
            btnlogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_beranda
            // 
            btn_beranda.BackColor = Color.FromArgb(187, 138, 82);
            btn_beranda.BackgroundImage = (Image)resources.GetObject("btn_beranda.BackgroundImage");
            btn_beranda.FlatStyle = FlatStyle.Flat;
            btn_beranda.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_beranda.Location = new Point(65, 421);
            btn_beranda.Name = "btn_beranda";
            btn_beranda.Size = new Size(326, 110);
            btn_beranda.TabIndex = 6;
            btn_beranda.Text = "          Beranda";
            btn_beranda.UseVisualStyleBackColor = false;
            btn_beranda.Click += btn_kembali_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(591, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1093, 618);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnprofil
            // 
            btnprofil.BackColor = Color.FromArgb(187, 138, 82);
            btnprofil.BackgroundImage = (Image)resources.GetObject("btnprofil.BackgroundImage");
            btnprofil.FlatStyle = FlatStyle.Flat;
            btnprofil.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprofil.Location = new Point(65, 191);
            btnprofil.Name = "btnprofil";
            btnprofil.Size = new Size(326, 110);
            btnprofil.TabIndex = 7;
            btnprofil.Text = "          Profil";
            btnprofil.UseVisualStyleBackColor = false;
            btnprofil.Click += btnprofil_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(187, 138, 82);
            btnlogout.BackgroundImage = (Image)resources.GetObject("btnlogout.BackgroundImage");
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(65, 882);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(326, 110);
            btnlogout.TabIndex = 8;
            btnlogout.Text = "          Logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // RiwayatCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 236, 215);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnlogout);
            Controls.Add(btnprofil);
            Controls.Add(btn_beranda);
            Controls.Add(dataGridView1);
            Name = "RiwayatCustomer";
            Text = "RiwayatCustomer";
            Load += RiwayatCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_beranda;
        private DataGridView dataGridView1;
        private Button btnprofil;
        private Button btnlogout;
    }
}