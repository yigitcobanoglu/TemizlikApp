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
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtSoyAd = new TextBox();
            txtNo = new TextBox();
            txtSınıf = new TextBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.SkyBlue;
            btnKaydet.Font = new Font("Calisto MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKaydet.Location = new Point(97, 342);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(161, 48);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.PeachPuff;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 50);
            label1.TabIndex = 1;
            label1.Text = "Öğrenci ekle";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(21, 103);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 2;
            label2.Text = "Ad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PeachPuff;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 2;
            label3.Text = "SoyAd :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PeachPuff;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(21, 227);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 2;
            label4.Text = "Sınıf:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PeachPuff;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(21, 292);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 2;
            label5.Text = "No :";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 14.25F);
            txtAd.Location = new Point(97, 95);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(178, 33);
            txtAd.TabIndex = 3;
            // 
            // txtSoyAd
            // 
            txtSoyAd.Font = new Font("Segoe UI", 14.25F);
            txtSoyAd.Location = new Point(97, 152);
            txtSoyAd.Name = "txtSoyAd";
            txtSoyAd.Size = new Size(178, 33);
            txtSoyAd.TabIndex = 3;
            // 
            // txtNo
            // 
            txtNo.Font = new Font("Segoe UI", 14.25F);
            txtNo.Location = new Point(97, 284);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(178, 33);
            txtNo.TabIndex = 3;
            // 
            // txtSınıf
            // 
            txtSınıf.Font = new Font("Segoe UI", 14.25F);
            txtSınıf.Location = new Point(97, 219);
            txtSınıf.Name = "txtSınıf";
            txtSınıf.Size = new Size(178, 33);
            txtSınıf.TabIndex = 3;
            // 
            // OgrenciEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(340, 416);
            Controls.Add(txtSınıf);
            Controls.Add(txtNo);
            Controls.Add(txtSoyAd);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Name = "OgrenciEkle";
            Text = "OgrenciEkle";
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
        private TextBox txtNo;
        private TextBox txtSınıf;
    }
}