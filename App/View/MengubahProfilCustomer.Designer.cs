namespace TanamAja.App.View
{
    partial class MengubahProfilCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MengubahProfilCustomer));
            tbusernamecus = new TextBox();
            tbalamatcus = new TextBox();
            tbemailcus = new TextBox();
            tbnotelcus = new TextBox();
            btnbatal = new Button();
            btnupdate = new Button();
            SuspendLayout();
            // 
            // tbusernamecus
            // 
            tbusernamecus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusernamecus.Location = new Point(798, 304);
            tbusernamecus.Multiline = true;
            tbusernamecus.Name = "tbusernamecus";
            tbusernamecus.Size = new Size(668, 57);
            tbusernamecus.TabIndex = 0;
            // 
            // tbalamatcus
            // 
            tbalamatcus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbalamatcus.Location = new Point(798, 406);
            tbalamatcus.Multiline = true;
            tbalamatcus.Name = "tbalamatcus";
            tbalamatcus.Size = new Size(668, 57);
            tbalamatcus.TabIndex = 1;
            // 
            // tbemailcus
            // 
            tbemailcus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemailcus.Location = new Point(798, 514);
            tbemailcus.Multiline = true;
            tbemailcus.Name = "tbemailcus";
            tbemailcus.Size = new Size(668, 57);
            tbemailcus.TabIndex = 2;
            // 
            // tbnotelcus
            // 
            tbnotelcus.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnotelcus.Location = new Point(798, 620);
            tbnotelcus.Multiline = true;
            tbnotelcus.Name = "tbnotelcus";
            tbnotelcus.Size = new Size(668, 57);
            tbnotelcus.TabIndex = 3;
            // 
            // btnbatal
            // 
            btnbatal.BackColor = Color.FromArgb(109, 151, 115);
            btnbatal.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbatal.Location = new Point(959, 818);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(214, 61);
            btnbatal.TabIndex = 4;
            btnbatal.Text = "BATAL";
            btnbatal.UseVisualStyleBackColor = false;
            btnbatal.Click += btnbatal_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(109, 151, 115);
            btnupdate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(1252, 818);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(214, 61);
            btnupdate.TabIndex = 5;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // MengubahProfilCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnupdate);
            Controls.Add(btnbatal);
            Controls.Add(tbnotelcus);
            Controls.Add(tbemailcus);
            Controls.Add(tbalamatcus);
            Controls.Add(tbusernamecus);
            Name = "MengubahProfilCustomer";
            Text = "MengubahProfilCustomer";
            Load += MengubahProfilCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbusernamecus;
        private TextBox tbalamatcus;
        private TextBox tbemailcus;
        private TextBox tbnotelcus;
        private Button btnbatal;
        private Button btnupdate;
    }
}