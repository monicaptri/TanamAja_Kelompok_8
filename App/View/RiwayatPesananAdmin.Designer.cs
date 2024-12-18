namespace TanamAja.App.View
{
    partial class RiwayatPesananAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatPesananAdmin));
            btnprofil = new Button();
            btnberanda = new Button();
            btnlogout = new Button();
            dataGridViewRiwayat = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).BeginInit();
            SuspendLayout();
            // 
            // btnprofil
            // 
            btnprofil.BackgroundImage = (Image)resources.GetObject("btnprofil.BackgroundImage");
            btnprofil.FlatStyle = FlatStyle.Flat;
            btnprofil.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprofil.Location = new Point(55, 169);
            btnprofil.Name = "btnprofil";
            btnprofil.Size = new Size(326, 110);
            btnprofil.TabIndex = 0;
            btnprofil.Text = "          Profil";
            btnprofil.UseVisualStyleBackColor = true;
            btnprofil.Click += btnprofil_Click;
            // 
            // btnberanda
            // 
            btnberanda.BackgroundImage = (Image)resources.GetObject("btnberanda.BackgroundImage");
            btnberanda.FlatStyle = FlatStyle.Flat;
            btnberanda.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnberanda.Location = new Point(55, 329);
            btnberanda.Name = "btnberanda";
            btnberanda.Size = new Size(326, 110);
            btnberanda.TabIndex = 1;
            btnberanda.Text = "          Katalog";
            btnberanda.UseVisualStyleBackColor = true;
            btnberanda.Click += btnberanda_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackgroundImage = (Image)resources.GetObject("btnlogout.BackgroundImage");
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(55, 827);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(326, 110);
            btnlogout.TabIndex = 2;
            btnlogout.Text = "          Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Click += btnlogout_Click;
            // 
            // dataGridViewRiwayat
            // 
            dataGridViewRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRiwayat.Location = new Point(716, 317);
            dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            dataGridViewRiwayat.RowHeadersWidth = 51;
            dataGridViewRiwayat.Size = new Size(828, 548);
            dataGridViewRiwayat.TabIndex = 3;
            dataGridViewRiwayat.CellContentClick += dataGridViewRiwayat_CellContentClick_1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(55, 495);
            button1.Name = "button1";
            button1.Size = new Size(326, 110);
            button1.TabIndex = 4;
            button1.Text = "     Tukang Kebun";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RiwayatPesananAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(dataGridViewRiwayat);
            Controls.Add(btnlogout);
            Controls.Add(btnberanda);
            Controls.Add(btnprofil);
            Name = "RiwayatPesananAdmin";
            Text = "RiwayatPesananAdmin";
            Load += RiwayatPesananAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnprofil;
        private Button btnberanda;
        private Button btnlogout;
        private DataGridView dataGridViewRiwayat;
        private Button button1;
    }
}