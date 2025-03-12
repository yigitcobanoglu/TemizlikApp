namespace TemizlikApp
{
    partial class FrmYeniSınıf
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
            txtsinifAd = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Azure;
            btnKaydet.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKaydet.Location = new Point(153, 156);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(142, 42);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 1;
            label1.Text = "Sınıf Adı :";
            // 
            // txtsinifAd
            // 
            txtsinifAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtsinifAd.Location = new Point(12, 102);
            txtsinifAd.Name = "txtsinifAd";
            txtsinifAd.Size = new Size(283, 29);
            txtsinifAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.Azure;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(307, 38);
            label2.TabIndex = 3;
            label2.Text = "Bir Sınıf  Ekleyiniz";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmYeniSınıf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(307, 210);
            Controls.Add(label2);
            Controls.Add(txtsinifAd);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Name = "FrmYeniSınıf";
            Text = "FrmYeniSınıf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label1;
        private TextBox txtsinifAd;
        private Label label2;
    }
}