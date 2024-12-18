namespace TanamAja.App.View
{
    partial class MengubahProfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MengubahProfilAdmin));
            tbusername = new TextBox();
            tbalamat = new TextBox();
            tbemail = new TextBox();
            tbnotel = new TextBox();
            btnbatal = new Button();
            btnsimpan = new Button();
            SuspendLayout();
            // 
            // tbusername
            // 
            tbusername.Location = new Point(800, 305);
            tbusername.Multiline = true;
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(667, 53);
            tbusername.TabIndex = 0;
            // 
            // tbalamat
            // 
            tbalamat.Location = new Point(800, 409);
            tbalamat.Multiline = true;
            tbalamat.Name = "tbalamat";
            tbalamat.Size = new Size(667, 53);
            tbalamat.TabIndex = 1;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(800, 514);
            tbemail.Multiline = true;
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(667, 53);
            tbemail.TabIndex = 2;
            // 
            // tbnotel
            // 
            tbnotel.Location = new Point(800, 621);
            tbnotel.Multiline = true;
            tbnotel.Name = "tbnotel";
            tbnotel.Size = new Size(667, 53);
            tbnotel.TabIndex = 3;
            // 
            // btnbatal
            // 
            btnbatal.BackColor = Color.FromArgb(109, 151, 115);
            btnbatal.FlatStyle = FlatStyle.Flat;
            btnbatal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbatal.Location = new Point(959, 818);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(215, 61);
            btnbatal.TabIndex = 4;
            btnbatal.Text = "BATAL";
            btnbatal.UseVisualStyleBackColor = false;
            btnbatal.Click += btnbatal_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.BackColor = Color.FromArgb(109, 151, 115);
            btnsimpan.FlatStyle = FlatStyle.Flat;
            btnsimpan.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsimpan.Location = new Point(1252, 818);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(215, 61);
            btnsimpan.TabIndex = 5;
            btnsimpan.Text = "SIMPAN";
            btnsimpan.UseVisualStyleBackColor = false;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // MengubahProfilAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnsimpan);
            Controls.Add(btnbatal);
            Controls.Add(tbnotel);
            Controls.Add(tbemail);
            Controls.Add(tbalamat);
            Controls.Add(tbusername);
            Name = "MengubahProfilAdmin";
            Text = "MengubahProfilAdmin";
            Load += MengubahProfilAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbusername;
        private TextBox tbalamat;
        private TextBox tbemail;
        private TextBox tbnotel;
        private Button btnbatal;
        private Button btnsimpan;
    }
}