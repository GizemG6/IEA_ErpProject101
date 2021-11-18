﻿using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using IEA_ErpProject101_Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main.Urun_Islemleri
{
    public partial class frmUrunGiris : Ortaklar
    {
        //ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
       
        //Numaralar n = new Numaralar();

        private int secimId = -1;
        public frmUrunGiris()
        {
            InitializeComponent();
        }

        private void frmUrunGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst=(from s in db.tblUrunler where s.isActive==true select s).ToList();

            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = sira;
                liste.Rows[i].Cells[2].Value = k.UrunGenelNo;
                liste.Rows[i].Cells[3].Value = k.UrunKodu;
                liste.Rows[i].Cells[4].Value = k.UrunAdi;
                i++;
                sira++;
            }
            liste.AllowUserToAddRows = false;
            liste.ReadOnly = true;
            liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblUrunKodu.Text = n.UrunGenelKodu();
            txtUrunGNo.Text = n.UrunGenelKodu();
        }
        private void ComboDoldur()
        {
            txtUTedarikciId.DataSource = (from s in db.tblCariler where s.CariGroupId==3 where s.CariUnvan == "Distributor" select s).ToList();
            txtUTedarikciId.ValueMember = "Id";
            txtUTedarikciId.DisplayMember = "CariAdi";
            txtUTedarikciId.SelectedIndex = -1;
        }
        private void YeniKayit()
        {
            if (secimId != -1 || txtUrunKodu.Text=="" || txtKullanimAy.Text=="")
            {
                MessageBox.Show("Urun kodu veya kullanim suresi bos birakilamaz ya da kaydi yapilmis urunler tekrar kaydedilemez");
                return;
            }
            try
            {
                tblUrunler urn = new tblUrunler();
                urn.UrunAdi = txtUrunAdi.Text;
                urn.UrunGenelNo = n.UrunGenelKodu();
                urn.UrunKodu = txtUrunKodu.Text;
                urn.TedarikciFirmaId = (int)txtUTedarikciId.SelectedValue;
                urn.AlisFiyat = decimal.Parse(txtAlisF.Text);
                urn.SatisFiyat = decimal.Parse(txtAlisF.Text);
                urn.KutuIcerik = txtKutuIcerik.Text;
                urn.UrunAciklama = txtUrunAcik.Text;
                urn.KullanimSuresiAy = (int)txtKullanimAy.Value;
                urn.SaveDate = DateTime.Now;
                urn.SaveUserId = 1;
                urn.isActive = true;

                db.tblUrunler.Add(urn);
                db.SaveChanges();

                MessageBox.Show("Kayit Basarili");

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
        }
        private tblUrunler urunler;
        public void Ac(int id)
        {
            secimId = id;
            urunler = db.tblUrunler.Find(secimId);
            
            try
            {
                tblUrunler urn = urunler;
                txtUTedarikciId.Text = urn.tblCariler.CariAdi;
                txtUrunGNo.Text = urn.UrunGenelNo;
                txtUrunKodu.Text = urn.UrunKodu;
                txtUrunAcik.Text = urn.UrunAciklama;
                txtUrunAdi.Text = urn.UrunAdi;
                txtAlisF.Text = urn.AlisFiyat.ToString();
                txtSatisF.Text = urn.SatisFiyat.ToString();
                txtKutuIcerik.Text = urn.KutuIcerik;
                txtKullanimAy.Text = urn.KullanimSuresiAy.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        private void Guncelle()
        {
            
            if (secimId == -1)
            {
                return;
            }
            try
            {
                tblUrunler urn = urunler;
                urn.UrunAdi = txtUrunAdi.Text;
                urn.UrunGenelNo = txtUrunGNo.Text;
                urn.UrunKodu = txtUrunKodu.Text;
                urn.TedarikciFirmaId = (int)txtUTedarikciId.SelectedValue;
                urn.AlisFiyat = decimal.Parse(txtAlisF.Text);
                urn.SatisFiyat = decimal.Parse(txtAlisF.Text);
                urn.KutuIcerik = txtKutuIcerik.Text;
                urn.UrunAciklama = txtUrunAcik.Text;
                urn.KullanimSuresiAy = (int)txtKullanimAy.Value;
                urn.UpdateDate = DateTime.Now;
                urn.UpdateUserId = 1;
                
                db.SaveChanges();

                MessageBox.Show("Guncelleme Basarili");

                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId=(int?)liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblUrunler urn = db.tblUrunler.Find(secimId);
                urn.isActive = false;
                db.SaveChanges();
                MessageBox.Show("Silme Basarili");
                Temizle();
                Listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnLoad(EventArgs e)
        {

            var btn = new Button();
            btn.Size = new Size(25, txtUrunGNo.ClientSize.Height + 2);
            btn.Location = new Point(txtUrunGNo.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            txtUrunGNo.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += btn_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWknd, int msg, IntPtr wp, IntPtr lp);
        private void btn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmUrunlerListesi"] == null)
            {
                frmUrunlerListesi frm = new frmUrunlerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack();
        }
    }
}
