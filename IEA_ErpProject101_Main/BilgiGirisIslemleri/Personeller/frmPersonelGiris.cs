using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller
{
    public partial class frmPersonelGiris : Form
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        private Numaralar n = new Numaralar();

        public int secimId = -1;
        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void frmPersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblPersonelDetay
                       where s.tblCariler.isActive == true
                       where s.tblCariler.CariGroupId == 6
                      select s).ToList();

            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = sira;
                liste.Rows[i].Cells[2].Value = k.tblCariler.CariNo;
                liste.Rows[i].Cells[3].Value = k.tblCariler.CariAdi;
                liste.Rows[i].Cells[4].Value = k.tblCariler.CariTel;
                liste.Rows[i].Cells[5].Value = k.tblCariler.YetkiliCep1;
                liste.Rows[i].Cells[6].Value = k.tblCariler.CariMail;
                liste.Rows[i].Cells[7].Value = k.IsBasiTarih;
                liste.Rows[i].Cells[8].Value = k.IsSonuTarih;
                i++;
                sira++;
            }
            liste.AllowUserToAddRows = false;
            lblPersonelKodu.Text = n.CariKoduPersonel();
        }

        private void ComboDoldur()
        {
            txtPUnvan.DataSource = Enum.GetValues(typeof(enumPersonelUnvan));
            txtPUnvan.SelectedIndex = -1;
            var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 6).ToList();
            txtDepartman1.DataSource = lst;
            txtDepartman1.ValueMember = "Id";
            txtDepartman1.DisplayMember = "DepartmanAdi";
            txtDepartman1.SelectedIndex = -1;

            var lst1 = erp.tblSehirler.ToList();
            txtSehir.DataSource = lst1;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
        }

        private void frmPersonelGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.kontrol = false;
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            string pkodu = n.CariKoduPersonel();
            try
            {
                if (secimId == -1)
                {
                    tblCariler p = new tblCariler();
                    p.isActive = true;
                    p.CariAdi = txtPersonelAdi.Text;
                    p.CariMail = txtPersonelMail.Text;
                    p.CariTel = txtPersonelTel.Text;
                    p.YetkiliDepartmani1 = txtDepartman1.Text;
                    p.Adres1 = txtAdres1.Text;
                    p.Adres2 = txtAdres2.Text;
                    p.CariGroupId = 6;
                    p.CariTipId = 1;
                    p.CariUnvan = txtPUnvan.Text;
                    p.Tc_Vn = txtPTcNo.Text;
                    if (txtSehir.Text != "")
                    {
                        p.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    }
                    //p.SehirId = (int?)txtSehir.SelectedValue ?? -1;//txtSehir.SelectedValue!=null ? (int)txtSehir.SelectedValue:-1 ;//erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    p.SaveUserId = 1;
                    p.SaveDate = DateTime.Now;
                    p.CariNo = pkodu;

                    erp.tblCariler.Add(p);
                    erp.SaveChanges();

                    tblPersonelDetay pdet = new tblPersonelDetay();
                    pdet.CariId = erp.tblCariler.First(x => x.CariAdi == txtPersonelAdi.Text).Id;
                    pdet.IsBasiTarih = txtBaslangic.Value;
                    //pdet.IsSonuTarih = txtBitis.Value;

                    erp.tblPersonelDetay.Add(pdet);
                    erp.SaveChanges();

                    MessageBox.Show("Kayit Basarili");
                    //Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Bu kayit daha once yapilmis.Kendine baska kayit bul");
                }

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
            txtDurum.Visible = false;
            label7.Visible = false;
            txtBitis.Visible = false;
            txtBitis.Text = "";
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        public void Ac(int id)
        {
            secimId = id;//dis formdan veri gelirse secimid hatası almamak icin
            Home.tblPersonelDetayId = erp.tblPersonelDetay.Find(id);
            try
            {
                txtDurum.Visible = true;
                tblPersonelDetay p =Home.tblPersonelDetayId ;
                txtPersonelAdi.Text = p.tblCariler.CariAdi;
                txtPersonelMail.Text = p.tblCariler.CariMail;
                txtPersonelTel.Text = p.tblCariler.CariTel;
                txtDepartman1.Text = p.tblCariler.YetkiliDepartmani1;
                txtAdres1.Text = p.tblCariler.Adres1;
                txtAdres2.Text = p.tblCariler.Adres2;
                txtPTcNo.Text = p.tblCariler.Tc_Vn;
                txtSehir.Text = p.tblCariler.tblSehirler == null ? "": p.tblCariler.tblSehirler.sehir;
                lblPersonelKodu.Text = p.tblCariler.CariNo;
                txtKayitBul.Text = p.tblCariler.CariNo;
                txtBaslangic.Text = p.IsBasiTarih.ToString();
                txtBitis.Text = p.IsSonuTarih.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            if (secimId < 0)
            {
                return;
            }
            try
            {
                tblPersonelDetay p = Home.tblPersonelDetayId;
                p.tblCariler.CariAdi = txtPersonelAdi.Text;
                p.tblCariler.CariMail = txtPersonelMail.Text;
                p.tblCariler.CariTel = txtPersonelTel.Text;
                p.tblCariler.YetkiliDepartmani1 = txtDepartman1.Text;
                p.tblCariler.Adres1 = txtAdres1.Text;
                p.tblCariler.Adres2 = txtAdres2.Text;
                p.tblCariler.CariTipId = 6;
                p.tblCariler.CariUnvan = txtPUnvan.Text;
                p.tblCariler.Tc_Vn = txtPTcNo.Text;
                p.tblCariler.SehirId = (int?)txtSehir.SelectedValue ?? -1;//txtSehir.SelectedValue!=null ? (int)txtSehir.SelectedValue:-1 ;//erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                p.tblCariler.UpdateUserId = 1;
                p.tblCariler.UpdateDate = DateTime.Now;
                p.IsBasiTarih = txtBaslangic.Value;
                if (txtDurum.Checked)
                {
                    p.IsSonuTarih = txtBitis.Value;
                }

                erp.SaveChanges();

                MessageBox.Show("Guncelleme Basarili");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme Basarili");
                Temizle();
                Listele();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurum.Checked)
            {
                label7.Visible = true;
                txtBitis.Visible = true;
            }
            else
            {
                label7.Visible = false;
                txtBitis.Visible = false;
            }
        }
    }
}
