namespace TemizlikApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbSinif = new ComboBox();
            lbOgrenci = new ListBox();
            btnAtamaYap = new Button();
            btnCıkar = new Button();
            label1 = new Label();
            btnYeniSınıf = new Button();
            panel1 = new Panel();
            lbTemizlikSırası = new ListBox();
            label2 = new Label();
            btnOnayla = new Button();
            panel2 = new Panel();
            label3 = new Label();
            btnOgrenciEkle = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cbSinif
            // 
            cbSinif.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(74, 36);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(165, 29);
            cbSinif.TabIndex = 0;
            cbSinif.SelectedIndexChanged += cbSinif_SelectedIndexChanged;
            cbSinif.SelectedValueChanged += cbSınıf_SelectedValueChanged;
            // 
            // lbOgrenci
            // 
            lbOgrenci.FormattingEnabled = true;
            lbOgrenci.Location = new Point(10, 42);
            lbOgrenci.Name = "lbOgrenci";
            lbOgrenci.Size = new Size(215, 424);
            lbOgrenci.TabIndex = 1;
            lbOgrenci.SelectedIndexChanged += lbOgrenci_SelectedIndexChanged;
            // 
            // btnAtamaYap
            // 
            btnAtamaYap.BackColor = Color.Azure;
            btnAtamaYap.Font = new Font("Calisto MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtamaYap.Location = new Point(411, 582);
            btnAtamaYap.Name = "btnAtamaYap";
            btnAtamaYap.Size = new Size(128, 43);
            btnAtamaYap.TabIndex = 2;
            btnAtamaYap.Text = "Atama Yap";
            btnAtamaYap.UseVisualStyleBackColor = false;
            btnAtamaYap.Click += btnAtamaYap_Click;
            // 
            // btnCıkar
            // 
            btnCıkar.BackColor = Color.Azure;
            btnCıkar.Font = new Font("Calisto MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCıkar.Location = new Point(561, 582);
            btnCıkar.Name = "btnCıkar";
            btnCıkar.Size = new Size(128, 43);
            btnCıkar.TabIndex = 2;
            btnCıkar.Text = "Çıkar";
            btnCıkar.UseVisualStyleBackColor = false;
            btnCıkar.Click += btnCıkar_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 29);
            label1.TabIndex = 3;
            label1.Text = "Sınıf:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYeniSınıf
            // 
            btnYeniSınıf.BackColor = Color.SkyBlue;
            btnYeniSınıf.Font = new Font("Calisto MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnYeniSınıf.Location = new Point(12, 582);
            btnYeniSınıf.Name = "btnYeniSınıf";
            btnYeniSınıf.Size = new Size(120, 43);
            btnYeniSınıf.TabIndex = 2;
            btnYeniSınıf.Text = "Yeni Sınıf";
            btnYeniSınıf.UseVisualStyleBackColor = false;
            btnYeniSınıf.Click += btnYeniSınıf_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTemizlikSırası);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnOnayla);
            panel1.Location = new Point(411, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 480);
            panel1.TabIndex = 4;
            // 
            // lbTemizlikSırası
            // 
            lbTemizlikSırası.FormattingEnabled = true;
            lbTemizlikSırası.Location = new Point(19, 51);
            lbTemizlikSırası.Name = "lbTemizlikSırası";
            lbTemizlikSırası.Size = new Size(242, 379);
            lbTemizlikSırası.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.PeachPuff;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(278, 48);
            label2.TabIndex = 0;
            label2.Text = "Bu Hafta Temizlik Sırası";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.Bisque;
            btnOnayla.Font = new Font("Calisto MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOnayla.Location = new Point(135, 438);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(128, 42);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbOgrenci);
            panel2.Location = new Point(14, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 480);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.PeachPuff;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(240, 34);
            label3.TabIndex = 2;
            label3.Text = "Öğreciler";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Font = new Font("Calisto MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOgrenciEkle.Location = new Point(135, 581);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(127, 44);
            btnOgrenciEkle.TabIndex = 6;
            btnOgrenciEkle.Text = "Ogrenci Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(719, 637);
            Controls.Add(btnOgrenciEkle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnYeniSınıf);
            Controls.Add(label1);
            Controls.Add(btnCıkar);
            Controls.Add(btnAtamaYap);
            Controls.Add(cbSinif);
            Name = "Form1";
            Text = "Temizlik Sıralaması";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbSinif;
        private ListBox lbOgrenci;
        private Button btnAtamaYap;
        private Button btnCıkar;
        private Label label1;
        private Button btnYeniSınıf;
        private Panel panel1;
        private ListBox lbTemizlikSırası;
        private Label label2;
        private Button btnOnayla;
        private Panel panel2;
        private Label label3;
        private Button btnOgrenciEkle;
    }
}
