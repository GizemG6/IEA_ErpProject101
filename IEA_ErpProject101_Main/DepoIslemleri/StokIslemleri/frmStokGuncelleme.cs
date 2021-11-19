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
            var lst = db.tblStokGirisAlt.Find(Home.Aktarma);
            txtGenelNo.Text = lst.GenelNo.ToString();
            txtAdet.Text = lst.Adet.ToString();
            txtAlisFiyat.Text = lst.AlisFiyat.ToString();
            txtBarkod.Text = lst.Barkod;
            txtLot.Text = lst.LotSeriNo;
            txtUrunKodu.Text = lst.UrunKodu;
            txtUT.Value = lst.UT.Value;
            txtSKT.Value = lst.SKT.Value;
        }
        //private void FormAc(int id)
        //{
        //    int i = 0;
        //    //var kayitBul=db.tblStokGirisUst.Find(id);
        //    var kayitBul1 = db.vwStokGiris.First(x => x.Id == id);
        //    //tblStokGiris Ust ust = kayitBul;
        //    vwStokGiris ust = kayitBul1;
        //    txtGenelNo.Text = ust.GenelNo.ToString();
        //    txtCariGrup.Text = ust.GrupAdi;
        //    txtAciklama.Text = ust.Aciklama;
        //    txtFaturaNo.Text = ust.FaturaNo;
        //    txtCariAdi.Text = ust.CariAdi;
        //    if (ust.FaturaTarih != null) txtGirisTarih.Value = (DateTime)ust.FaturaTarih;
        //    if (ust.GirisTipi != null) txtGirisTipi.SelectedIndex = ust.GirisTipi.Value;

        //    //var alt = db.tblStokGirisAlt.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);
        //    var alt1 = db.vwStokGiris.Where(x => x.GenelNo.ToString() == txtGenelNo.Text);

        //    Liste.Rows.Clear();
        //    foreach (var k in alt1)
        //    {
        //        Liste.Rows.Add();
        //        Liste.Rows[i].Cells[0].Value = k.SiraNo;
        //        Liste.Rows[i].Cells[1].Value = k.Barkod;
        //        Liste.Rows[i].Cells[2].Value = k.UrunKodu;
        //        Liste.Rows[i].Cells[3].Value = k.LotSeriNo;
        //        Liste.Rows[i].Cells[4].Value = k.Adet;
        //        Liste.Rows[i].Cells[5].Value = k.Not;
        //        Liste.Rows[i].Cells[6].Value = k.UT;
        //        Liste.Rows[i].Cells[7].Value = k.SKT;
        //        Liste.Rows[i].Cells[8].Value = k.AlisFiyat;
        //        i++;
        //    }
        //    Liste.AllowUserToAddRows = false;
        //    Liste.ReadOnly = true;
        //    Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //}
        //    private void Listele()
        //    {
        //        Liste.Rows.Clear();
        //        int i = 0, sira = 1;
        //        var lst = (from s in db.tblStokGirisUst where s.isActive == true select s).ToList();

        //        var lst1 = (from s in db.vwStokGiris
        //                    where s.isActive == true
        //                    select s).ToList().Distinct();

        //        foreach (var k in lst1)
        //        {
        //            Liste.Rows.Add();
        //            Liste.Rows[i].Cells[0].Value = k.Id;
        //            Liste.Rows[i].Cells[1].Value = k.GenelNo;
        //            Liste.Rows[i].Cells[2].Value = k.CariAdi;//k.tblCariler.CariAdi;
        //            Liste.Rows[i].Cells[3].Value = k.FaturaNo;
        //            Liste.Rows[i].Cells[4].Value = k.FaturaTarih;
        //            Liste.Rows[i].Cells[5].Value = k.GirisTipi;
        //            i++;
        //            sira++;
        //        }
        //        Liste.AllowUserToAddRows = false;
        //        Liste.ReadOnly = true;
        //        Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    }
        //    private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //    {
        //        try
        //        {
        //            TextBox txt = e.Control as TextBox;
        //            if (Liste.CurrentCell.ColumnIndex == 2 && txt != null)
        //            {
        //                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //                txt.AutoCompleteCustomSource.AddRange(MyArray);
        //            }
        //            else if (Liste.CurrentCell.ColumnIndex != 2 && txt != null)
        //            {
        //                txt.AutoCompleteMode = AutoCompleteMode.None;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}
    }
}
