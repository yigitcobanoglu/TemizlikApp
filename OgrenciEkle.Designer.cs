namespace TemizlikApp
{
    partial class OgrenciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciEkle));
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtSoyAd = new TextBox();
            mtxtNumara = new MaskedTextBox();
            cbSinif = new ComboBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.SkyBlue;
            resources.ApplyResources(btnKaydet, "btnKaydet");
            btnKaydet.Name = "btnKaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.PeachPuff;
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.PeachPuff;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.PeachPuff;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.PeachPuff;
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.PeachPuff;
            label5.Name = "label5";
            // 
            // txtAd
            // 
            resources.ApplyResources(txtAd, "txtAd");
            txtAd.Name = "txtAd";
            // 
            // txtSoyAd
            // 
            resources.ApplyResources(txtSoyAd, "txtSoyAd");
            txtSoyAd.Name = "txtSoyAd";
            // 
            // mtxtNumara
            // 
            resources.ApplyResources(mtxtNumara, "mtxtNumara");
            mtxtNumara.Name = "mtxtNumara";
            mtxtNumara.ValidatingType = typeof(int);
            // 
            // cbSinif
            // 
            resources.ApplyResources(cbSinif, "cbSinif");
            cbSinif.FormattingEnabled = true;
            cbSinif.Name = "cbSinif";
            cbSinif.SelectedValueChanged += cbSinif_SelectedValueChanged;
            // 
            // OgrenciEkle
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(cbSinif);
            Controls.Add(mtxtNumara);
            Controls.Add(txtSoyAd);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            MinimizeBox = false;
            Name = "OgrenciEkle";
            ShowIcon = false;
            ShowInTaskbar = false;
            FormClosing += OgrenciEkle_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtSoyAd;
        private TextBox txtSınıf;
        private MaskedTextBox mtxtNumara;
        private ComboBox cbSinif;
    }
}