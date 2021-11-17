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

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma
{
    public partial class frmFirmaGiris : Ortaklar
    {
        //private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        //private Numaralar n = new Numaralar();

        public int secimId = -1;

        //private tblCariler idyeGoreBul;
        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void frmFirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblCariler
                       where s.isActive == true
                       where s.CariGroupId == 3
                       select new
                       {
                           id = s.Id,
                           hcode = s.CariNo,
                           hadi = s.CariAdi,
                           htel = s.CariTel,
                           hmail = s.CariMail,
                           hyet = s.YetkiliAdi1,

                       }).ToList();

            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.id;
                liste.Rows[i].Cells[1].Value = sira;
                liste.Rows[i].Cells[2].Value = k.hcode;
                liste.Rows[i].Cells[3].Value = k.hadi;
                liste.Rows[i].Cells[4].Value = k.htel;
                liste.Rows[i].Cells[5].Value = k.hmail;
                liste.Rows[i].Cells[6].Value = k.hyet;
                i++;
                sira++;
            }
            liste.AllowUserToAddRows = false;
            lblFirmaKodu.Text = n.CariKoduFirma();
        }

        private void ComboDoldur()
        {
            txtFTipi.DataSource = Enum.GetValues(typeof(enumFirmaTipi));
            var lst = db.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            txtFDepartman1.DataSource = lst;
            txtFDepartman1.ValueMember = "Id";
            txtFDepartman1.DisplayMember = "DepartmanAdi";

            txtFDepartman1.SelectedIndex = -1;

            var lst1 = db.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            txtFDepartman2.DataSource = lst1;
            txtFDepartman2.ValueMember = "Id";
            txtFDepartman2.DisplayMember = "DepartmanAdi";

            txtFDepartman2.SelectedIndex = -1;

            var lst2 = db.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            txtFDepartman3.DataSource = lst2;
            txtFDepartman3.ValueMember = "Id";
            txtFDepartman3.DisplayMember = "DepartmanAdi";

            txtFDepartman3.SelectedIndex = -1;

            var lst3 = db.tblSehirler.ToList();
            txtSehir.DataSource = lst3;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";

            txtFDepartman3.SelectedIndex = -1;
        }

        private void frmFirmaGiris_FormClosing(object sender, FormClosingEventArgs e)
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
            string fkodu = n.CariKoduFirma();
            try
            {
                
                if (secimId ==-1)
                {
                    tblCariler f = new tblCariler();
                    f.isActive = true;
                    f.CariAdi = txtFAdi.Text;
                    f.CariMail = txtFMail.Text;
                    f.CariTel = txtFTel.Text;
                    f.YetkiliAdi1 = txtFYet1.Text;
                    f.YetkiliAdi2 = txtFYet2.Text;
                    f.YetkiliAdi2 = txtFYet3.Text;
                    f.YetkiliDepartmani1 = txtFDepartman1.Text;
                    f.YetkiliDepartmani2 = txtFDepartman2.Text;
                    f.YetkiliDepartmani3 = txtFDepartman3.Text;
                    f.YetkiliTel1 = txtFYTel1.Text;
                    f.YetkiliTel2 = txtFYTel2.Text;
                    f.YetkiliTel3 = txtFYTel3.Text;
                    f.YetkiliCep1 = txtFYcep1.Text;
                    f.YetkiliCep2 = txtFYcep2.Text;
                    f.YetkiliCep3 = txtFYcep3.Text;
                    f.YetkiliMail1 = txtFEmail1.Text;
                    f.YetkiliMail2 = txtFEmail2.Text;
                    f.YetkiliMail3 = txtFEmail3.Text;
                    f.Adres1 = txtAdres1.Text;
                    f.Adres2 = txtAdres2.Text;
                    f.CariGroupId = 3;
                    f.CariTipId = txtFTipi.SelectedIndex+1;
                    f.CariUnvan = txtFTipi.Text;
                    f.Vdairesi = txtVergiDairesi.Text;
                    f.Tc_Vn = txtVerTcNo.Text;
                    if (txtSehir.Text != "")
                    {
                        f.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    }
                    //f.SehirId = (int?)txtSehir.SelectedValue ?? -1;//txtSehir.SelectedValue!=null ? (int)txtSehir.SelectedValue:-1 ;//db.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    f.SaveUserId = 1;
                    f.SaveDate = DateTime.Now;
                    f.CariNo = fkodu;

                    db.tblCariler.Add(f);
                    db.SaveChanges();

                    MessageBox.Show("Kayit Basarili");
                    Temizle();
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
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            try
            {
                tblCariler f = Home.tblCarilerId;
                f.CariAdi = txtFAdi.Text;
                f.CariMail = txtFMail.Text;
                f.CariTel = txtFTel.Text;
                f.YetkiliAdi1 = txtFYet1.Text;
                f.YetkiliAdi2 = txtFYet2.Text;
                f.YetkiliAdi2 = txtFYet3.Text;
                f.YetkiliDepartmani1 = txtFDepartman1.Text;
                f.YetkiliDepartmani2 = txtFDepartman2.Text;
                f.YetkiliDepartmani3 = txtFDepartman3.Text;
                f.YetkiliTel1 = txtFYTel2.Text;
                f.YetkiliTel3 = txtFYTel3.Text;
                f.YetkiliCep1 = txtFYcep1.Text;
                f.YetkiliCep2 = txtFYcep2.Text;
                f.YetkiliCep3 = txtFYcep3.Text;
                f.YetkiliMail1 = txtFEmail1.Text;
                f.YetkiliMail2 = txtFEmail2.Text;
                f.YetkiliMail3 = txtFEmail3.Text;
                f.Adres1 = txtAdres1.Text;
                f.Adres2 = txtAdres2.Text;
                f.CariGroupId = 3;
                if (txtFTipi.Text != "")
                {
                    f.CariTipId = (int)txtFTipi.SelectedValue;
                }
                f.CariUnvan = txtFTipi.Text;
                f.Vdairesi = txtVergiDairesi.Text;
                f.Tc_Vn = txtVerTcNo.Text;
                f.SehirId = (int?)txtSehir.SelectedValue ?? -1;//txtSehir.SelectedValue!=null ? (int)txtSehir.SelectedValue:-1 ;//db.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                f.UpdateUserId = 1;
                f.UpdateDate = DateTime.Now;

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler f = Home.tblCarilerId;
                f.isActive = false;
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

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
        public void Ac(int id)
        {
            secimId = id;//dis formdan veri gelirse secimid hatası almamak icin
            Home.tblCarilerId = db.tblCariler.Find(id);
            try
            {
                tblCariler f = Home.tblCarilerId;
                txtFAdi.Text = f.CariAdi;
                txtFMail.Text = f.CariMail;
                txtFTel.Text = f.CariTel;
                txtFYet1.Text = f.YetkiliAdi1;
                txtFYet2.Text = f.YetkiliAdi2;
                txtFYet3.Text = f.YetkiliAdi2;
                txtFDepartman1.Text = f.YetkiliDepartmani1;
                txtFDepartman2.Text = f.YetkiliDepartmani2;
                txtFDepartman3.Text = f.YetkiliDepartmani3;
                txtFYTel1.Text = f.YetkiliTel1;
                txtFYTel2.Text = f.YetkiliTel2;
                txtFYTel3.Text = f.YetkiliTel3;
                txtFYcep1.Text = f.YetkiliCep1;
                txtFYcep2.Text = f.YetkiliCep2;
                txtFYcep3.Text = f.YetkiliCep3;
                txtFEmail1.Text = f.YetkiliMail1;
                txtFEmail2.Text = f.YetkiliMail2;
                txtFEmail3.Text = f.YetkiliMail3;
                txtAdres1.Text = f.Adres1;
                txtAdres2.Text = f.Adres2;
                txtVergiDairesi.Text = f.Vdairesi;
                txtVerTcNo.Text = f.Tc_Vn;
                if (f.tblSehirler != null)
                {
                    txtSehir.Text = f.tblSehirler.sehir;
                }
                else
                {
                    txtSehir.Text = "";
                }
                lblFirmaKodu.Text = f.CariNo;
                txtKayitBul.Text = f.CariNo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
