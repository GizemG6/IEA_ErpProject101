using IEA_ErpProject101_Main.Fonksiyonlar;
using IEA_ErpProject101_Main.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar
{
    public partial class frmDoktorGiris : Form
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();

        private Numaralar n = new Numaralar();

        public int secimId = -1;
        public frmDoktorGiris()
        {
            InitializeComponent();
        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
                liste.Rows.Clear();
                int i = 0, sira = 1;
                var lst = (from s in erp.tblCariler
                           where s.isActive == true
                           where s.CariGroupId == 2
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
                lblDoktorKodu.Text = n.CariKoduDoktor(); 
            }

        private void ComboDoldur()
        {
            txtDUnvan.DataSource=Enum.GetValues(typeof (DoktorUnvan));
            var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 2).ToList();
            txtDepartman1.DataSource = lst;
            txtDepartman1.ValueMember = "Id";
            txtDepartman1.DisplayMember = "DepartmanAdi";

            var lst1 = erp.tblSehirler.ToList();
            txtSehir.DataSource = lst1;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
        }
        private void frmDoktorGiris_FormClosing(object sender, FormClosingEventArgs e)
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
            string dkodu = n.CariKoduDoktor();
            try
            {
                if (secimId == -1)
                {
                    tblCariler dr = new tblCariler();
                    dr.isActive = true;
                    dr.CariAdi = txtDoktorAdi.Text;
                    dr.CariMail = txtDoktorMail.Text;
                    dr.CariTel = txtDoktorTel.Text;
                    dr.YetkiliDepartmani1 = txtDepartman1.Text;
                    dr.YetkiliCep1 = txtDcep1.Text;
                    dr.Adres1 = txtAdres1.Text;
                    dr.Adres2 = txtAdres2.Text;
                    dr.CariGroupId = 2;
                    dr.CariTipId = 1;
                    dr.CariUnvan = txtDUnvan.Text;
                    dr.Vdairesi = txtVergiDairesi.Text;
                    dr.Tc_Vn = txtVerTcNo.Text;
                    if (txtSehir.Text != "")
                    {
                        dr.SehirId = (int?)txtSehir.SelectedValue ?? -1;
                    }
                    //dr.SehirId = (int?)txtSehir.SelectedValue ?? -1;//txtSehir.SelectedValue!=null ? (int)txtSehir.SelectedValue:-1 ;//erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                    dr.SaveUserId = 1;
                    dr.SaveDate = DateTime.Now;
                    dr.CariNo = dkodu;

                    erp.tblCariler.Add(dr);
                    erp.SaveChanges();

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

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }
        public void Ac(int id)
        {
            secimId = id;//dis formdan veri gelirse secimid hatası almamak icin
            try
            {
                tblCariler hst = erp.tblCariler.Find(id);
                txtDoktorAdi.Text = hst.CariAdi;
                txtDoktorMail.Text = hst.CariMail;
                txtDoktorTel.Text = hst.CariTel;
           
                txtDepartman1.Text = hst.YetkiliDepartmani1;
              
                
                txtAdres1.Text = hst.Adres1;
                txtAdres2.Text = hst.Adres2;
                
                txtVergiDairesi.Text = hst.Vdairesi;
                txtVerTcNo.Text = hst.Tc_Vn;
                txtSehir.Text = hst.tblSehirler == null ? "" : hst.tblSehirler.sehir;
                
                lblDoktorKodu.Text = hst.CariNo;
                txtKayitBul.Text = hst.CariNo;
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
            try
            {
                tblCariler dr = erp.tblCariler.Find(secimId);
                dr.CariAdi = txtDoktorAdi.Text;
                dr.CariMail = txtDoktorMail.Text;
                dr.CariTel = txtDoktorTel.Text;
                dr.YetkiliDepartmani1 = txtDepartman1.Text;
                dr.Adres1 = txtAdres1.Text;
                dr.Adres2 = txtAdres2.Text;
                dr.CariTipId = 2;
                dr.CariUnvan = txtDUnvan.Text;
                dr.Vdairesi = txtVergiDairesi.Text;
                dr.Tc_Vn = txtVerTcNo.Text;
                dr.SehirId = (int?)txtSehir.SelectedValue ?? -1;//txtSehir.SelectedValue!=null ? (int)txtSehir.SelectedValue:-1 ;//erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                dr.UpdateUserId = 1;
                dr.UpdateDate = DateTime.Now;

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
    }
}
