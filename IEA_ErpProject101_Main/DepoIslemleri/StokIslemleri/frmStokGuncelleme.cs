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

namespace IEA_ErpProject101_Main.DepoIslemleri.StokIslemleri
{
    public partial class frmStokGuncelleme : Form
    {
        public string[] MyArray { get; set; }
        public static DateTime Value { get; private set; }

        private ErpProjectWMPEntities db = new ErpProjectWMPEntities();
        //private formlar f = new formlar();
        internal bool Secim = false;
        private int secimId = -1;
        public frmStokGuncelleme()
        {
            InitializeComponent();
        }

        private void frmStokGuncelleme_Load(object sender, EventArgs e)
        {
            txtUrunKodu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();

            var drinst = db.tblUrunler.Where(x => x.isActive == true).Select(item => item.UrunKodu).Distinct();
            foreach (string urun in drinst)
            {
                veri.Add(urun);
                txtUrunKodu.Items.Add(urun);
            }
            var lst = db.tblStokGirisAlt.Find(Home.Aktarma);
            lblGenelNo.Text = lst.GenelNo.ToString();
            txtAdet.Text = lst.Adet.ToString();
            txtAlisFiyat.Text = lst.AlisFiyat.ToString();
            txtBarkod.Text = lst.Barkod;
            txtLot.Text = lst.LotSeriNo;
            txtUrunKodu.Text = lst.UrunKodu;
            txtUT.Value = lst.UT.Value;
            txtSKT.Value = lst.SKT.Value;
            lblAdet.Text = lst.Adet.ToString();
            lblAlisFiyat.Text = lst.AlisFiyat.ToString();
            lblBarkod.Text = lst.Barkod;
            lblLot.Text = lst.LotSeriNo;
            lblUrunKodu.Text = lst.UrunKodu;
            lblUT.Text = lst.UT.ToString();
            lblSKT.Text = lst.SKT.ToString();
        }

        private void Guncelle()
        {
            if (lblBarkod.Text==txtBarkod.Text)
            {
                var srg = db.tblStokDurum.First(s => s.Barkod == lblBarkod.Text);
                if (srg != null)
                {
                    srg.StokAdet -= int.Parse(lblAdet.Text);
                    srg.RafAdet -= int.Parse(lblAdet.Text);
                    srg.StokAdet += int.Parse(txtAdet.Text);
                    srg.RafAdet += int.Parse(txtAdet.Text);
                }
                var lst = db.tblStokGirisAlt.First(s => s.Id == secimId);

                lst.UrunKodu = txtUrunKodu.Text;
                lst.AlisFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
                lst.Barkod = txtBarkod.Text;
                lst.LotSeriNo = txtLot.Text;
                lst.SKT = txtSKT.Value;
                lst.UT = txtUT.Value;
                lst.Adet = Convert.ToInt32(txtAdet.Text);

                db.SaveChanges();
                MessageBox.Show("Guncelleme yapildi");
                Close(); 
            }else if (txtBarkod.Text != lblBarkod.Text)
            {
                var varmi = db.tblStokDurum.Where(s => s.Barkod == txtBarkod.Text).ToList();
                
                if (varmi.Count>0)
                {
                    var srg = db.tblStokDurum.First(s => s.Barkod == lblBarkod.Text);
                    if (srg != null)
                    {
                        srg.StokAdet -= int.Parse(lblAdet.Text);
                        srg.RafAdet -= int.Parse(lblAdet.Text);
                    }
                    var lst = db.tblStokGirisAlt.First(s => s.Id == secimId);

                    lst.UrunKodu = txtUrunKodu.Text;
                    lst.AlisFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
                    lst.Barkod = txtBarkod.Text;
                    lst.LotSeriNo = txtLot.Text;
                    lst.SKT = txtSKT.Value;
                    lst.UT = txtUT.Value;
                    lst.Adet = Convert.ToInt32(txtAdet.Text);

                    var srg1 = db.tblStokDurum.First(s => s.Barkod == txtBarkod.Text);
                    if (srg1 != null)
                    {
                        srg1.StokAdet += int.Parse(txtAdet.Text);
                        srg1.RafAdet += int.Parse(txtAdet.Text);
                    }
                    db.SaveChanges();
                }
                else
                {
                    var srg = db.tblStokDurum.First(s => s.Barkod == lblBarkod.Text);
                    if (srg != null)
                    {
                        srg.StokAdet -= int.Parse(lblAdet.Text);
                        srg.RafAdet -= int.Parse(lblAdet.Text);
                    }
                    tblStokDurum stk = new tblStokDurum();
                    stk.Barkod = txtBarkod.Text;
                    stk.RafAdet = int.Parse(txtAdet.Text);
                    stk.StokAdet = int.Parse(txtAdet.Text);
                    stk.KonsinyeAdet = 0;
                    stk.Lot = txtLot.Text;
                    stk.SKT = txtSKT.Value;
                    stk.StokKodu = "1";
                    stk.SubeAdet = 0;
                    stk.UT = txtUT.Value;
                    stk.Urun = txtUrunKodu.Text;

                    db.tblStokDurum.Add(stk);

                    var lst = db.tblStokGirisAlt.First(s => s.Id == secimId);

                    lst.UrunKodu = txtUrunKodu.Text;
                    lst.AlisFiyat = Convert.ToDecimal(txtAlisFiyat.Text);
                    lst.Barkod = txtBarkod.Text;
                    lst.LotSeriNo = txtLot.Text;
                    lst.SKT = txtSKT.Value;
                    lst.UT = txtUT.Value;
                    lst.Adet = Convert.ToInt32(txtAdet.Text);

                    db.SaveChanges();
                }
                MessageBox.Show("Guncelleme yapildi");
                Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secimId = Home.Aktarma;
            Guncelle();
        }

        private void txtUrunKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBarkod.Text = txtUrunKodu.Text + "/" + txtLot.Text;
            txtAdet.ReadOnly = true;
            txtBarkod.ReadOnly = true;
            TarihHesapla();
        }
        private void txtLot_TextChanged(object sender, EventArgs e)
        {
            txtBarkod.Text = txtUrunKodu.Text + "/" + txtLot.Text;
            txtAdet.ReadOnly = true;
            txtBarkod.ReadOnly = true;
        }

        private void txtUT_ValueChanged(object sender, EventArgs e)
        {
            TarihHesapla();
        }
        private void TarihHesapla()
        {
            var lst = (from s in db.tblUrunler
                       where s.UrunKodu == txtUrunKodu.Text
                       select s).FirstOrDefault();
            int ayy = lst.KullanimSuresiAy.Value;
            txtSKT.Value = txtUT.Value.AddMonths(ayy);
            txtSKT.Enabled = false;
        }
    }
}
