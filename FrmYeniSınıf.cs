﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemizlikApp
{
    public partial class FrmYeniSınıf : Form
    {
        public FrmYeniSınıf()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Sinif yeni = new();

            yeni.Id = Guid.NewGuid().ToString();
            yeni.Ad=txtsinifAd.Text;
            KayitYoneticisi.Siniflar.Add(yeni);
            KayitYoneticisi.Kaydet();
            DialogResult=DialogResult.OK;
            //Diyalog formunu kapatır
            //form kapatılırken geriye DialogResult.OK döner
        }
    }
}