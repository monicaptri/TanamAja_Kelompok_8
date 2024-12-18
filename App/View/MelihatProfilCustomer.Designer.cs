namespace TanamAja.App.View
{
    partial class MelihatProfilCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MelihatProfilCustomer));
            btnberandacus = new Button();
            btnriwayatcus = new Button();
            btnlogoutcus = new Button();
            tbusernamecus = new TextBox();
            tbalamatcus = new TextBox();
            tbemailcus = new TextBox();
            tbnotelcus = new TextBox();
            btnubah = new Button();
            SuspendLayout();
            // 
            // btnberandacus
            // 
            btnberandacus.BackgroundImage = (Image)resources.GetObject("btnberandacus.BackgroundImage");
            btnberandacus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnberandacus.Location = new Point(61, 421);
            btnberandacus.Name = "btnberandacus";
            btnberandacus.Size = new Size(326, 110);
            btnberandacus.TabIndex = 0;
            btnberandacus.Text = "          Beranda";
            btnberandacus.UseVisualStyleBackColor = true;
            btnberandacus.Click += btnberandacus_Click;
            // 
            // btnriwayatcus
            // 
            btnriwayatcus.BackgroundImage = (Image)resources.GetObject("btnriwayatcus.BackgroundImage");
            btnriwayatcus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnriwayatcus.Location = new Point(61, 651);
            btnriwayatcus.Name = "btnriwayatcus";
            btnriwayatcus.Size = new Size(326, 110);
            btnriwayatcus.TabIndex = 1;
            btnriwayatcus.Text = "          Riwayat";
            btnriwayatcus.UseVisualStyleBackColor = true;
            btnriwayatcus.Click += btnriwayatcus_Click;
            // 
            // btnlogoutcus
            // 
            btnlogoutcus.BackgroundImage = (Image)resources.GetObject("btnlogoutcus.BackgroundImage");
            btnlogoutcus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogoutcus.Location = new Point(61, 882);
            btnlogoutcus.Name = "btnlogoutcus";
            btnlogoutcus.Size = new Size(326, 110);
            btnlogoutcus.TabIndex = 2;
            btnlogoutcus.Text = "          Logout";
            btnlogoutcus.UseVisualStyleBackColor = true;
            btnlogoutcus.Click += btnlogoutcus_Click;
            // 
            // tbusernamecus
            // 
            tbusernamecus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusernamecus.Location = new Point(969, 365);
            tbusernamecus.Multiline = true;
            tbusernamecus.Name = "tbusernamecus";
            tbusernamecus.Size = new Size(665, 56);
            tbusernamecus.TabIndex = 3;
            // 
            // tbalamatcus
            // 
            tbalamatcus.Font = new Font("Microsoft Sans Serif", 13.8F);
            tbalamatcus.Location = new Point(969, 467);
            tbalamatcus.Multiline = true;
            tbalamatcus.Name = "tbalamatcus";
            tbalamatcus.Size = new Size(665, 56);
            tbalamatcus.TabIndex = 4;
            // 
            // tbemailcus
            // 
            tbemailcus.Font = new Font("Microsoft Sans Serif", 13.8F);
            tbemailcus.Location = new Point(969, 571);
            tbemailcus.Multiline = true;
            tbemailcus.Name = "tbemailcus";
            tbemailcus.Size = new Size(665, 56);
            tbemailcus.TabIndex = 5;
            // 
            // tbnotelcus
            // 
            tbnotelcus.Font = new Font("Microsoft Sans Serif", 13.8F);
            tbnotelcus.Location = new Point(969, 679);
            tbnotelcus.Multiline = true;
            tbnotelcus.Name = "tbnotelcus";
            tbnotelcus.Size = new Size(665, 56);
            tbnotelcus.TabIndex = 6;
            // 
            // btnubah
            // 
            btnubah.BackColor = Color.FromArgb(109, 151, 115);
            btnubah.FlatStyle = FlatStyle.Flat;
            btnubah.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnubah.Location = new Point(1423, 840);
            btnubah.Name = "btnubah";
            btnubah.Size = new Size(211, 57);
            btnubah.TabIndex = 7;
            btnubah.Text = "UBAH";
            btnubah.UseVisualStyleBackColor = false;
            btnubah.Click += btnubah_Click;
            // 
            // MelihatProfilCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnubah);
            Controls.Add(tbnotelcus);
            Controls.Add(tbemailcus);
            Controls.Add(tbalamatcus);
            Controls.Add(tbusernamecus);
            Controls.Add(btnlogoutcus);
            Controls.Add(btnriwayatcus);
            Controls.Add(btnberandacus);
            Name = "MelihatProfilCustomer";
            Text = "MelihatProfilCustomer";
            Load += MelihatProfilCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnberandacus;
        private Button btnriwayatcus;
        private Button btnlogoutcus;
        private TextBox tbusernamecus;
        private TextBox tbalamatcus;
        private TextBox tbemailcus;
        private TextBox tbnotelcus;
        private Button btnubah;
    }
}