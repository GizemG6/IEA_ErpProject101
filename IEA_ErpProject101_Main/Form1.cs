using IEA_ErpProject101_Main.BilgiGirisIslemleri;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MenuOlustur();
        }

        private void MenuOlustur()
        {
            #region Bilgi Giris Menusu
            tvBilgiGirisIslemleri.Nodes.Add("Hastaneler");
            tvBilgiGirisIslemleri.Nodes[0].Nodes.Add("Hastane Bilgi Giriş");
            tvBilgiGirisIslemleri.Nodes[0].Nodes.Add("Hastaneler Listesi");

            tvBilgiGirisIslemleri.Nodes.Add("Doktorlar");
            tvBilgiGirisIslemleri.Nodes[1].Nodes.Add("Doktorlar Bilgi Giriş");
            tvBilgiGirisIslemleri.Nodes[1].Nodes.Add("Doktorlar Listesi");

            tvBilgiGirisIslemleri.Nodes.Add("Firmalar");
            tvBilgiGirisIslemleri.Nodes[2].Nodes.Add("Firma Bilgi Giriş");
            tvBilgiGirisIslemleri.Nodes[2].Nodes.Add("Firmalar Listesi");

            tvBilgiGirisIslemleri.Nodes.Add("Personeller");
            tvBilgiGirisIslemleri.Nodes[3].Nodes.Add("Personel Bilgi Giriş");
            tvBilgiGirisIslemleri.Nodes[3].Nodes.Add("Personeller Listesi");
            #endregion

            #region Depo Islemleri Menusu
            tvDepoIslemleri.Nodes.Add("Depo İşlemleri");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Durum");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Sevkiyat Listesi");  
            #endregion


        }

        private void TvGorunum()
        {
            tvBilgiGirisIslemleri.Visible = false;
            tvDepoIslemleri.Visible = false;
            tv3.Visible = false;
            tv4.Visible = false;
            tv5.Visible = false;
            tv6.Visible = false;
            tv7.Visible = false;
            tv8.Visible = false;
            tv9.Visible = false;
            tv10.Visible = false;
            tv11.Visible = false;
            tv12.Visible = false;
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvBilgiGirisIslemleri.Visible = true;
        }

        private void btnDepoIslemleri_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnDepoIslemleri.Text;
            TvGorunum();
            tvDepoIslemleri.Visible = true;
        }

        private void tvBilgiGirisIslemleri_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }
        public static bool kontrol = false;
        private void tvBilgiGirisIslemleri_DoubleClick(object sender, EventArgs e)
        {
            //string isim = "";
            //if (tvBilgiGirisIslemleri.SelectedNode != null)
            //{
            //    isim = tvBilgiGirisIslemleri.SelectedNode.Text;
            //}
            string isim = tvBilgiGirisIslemleri.SelectedNode != null ? tvBilgiGirisIslemleri.SelectedNode.Text : "";

            if (isim=="Hastaneler Listesi" && Application.OpenForms["frmHastanelerListesi"] is null)
            {
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                frm.Activate();
                //kontrol = true;
            }
            else if (isim=="Hastane Bilgi Giriş" && Application.OpenForms["frmHastaneGiris"] is null)
            {
                frmHastaneGiris frm = new frmHastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                //kontrol = false;

            }
            else if(isim=="Doktorlar Bilgi Giriş" && Application.OpenForms["frmDoktorGiris"] is null)
            {
                frmDoktorGiris frm = new frmDoktorGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if(isim=="Doktorlar Listesi" && Application.OpenForms["frmDoktorlarListesi"] is null)
            {
                frmDoktorlarListesi frm = new frmDoktorlarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if(isim == "Personel Bilgi Giriş" && Application.OpenForms["frmPersonelGiris"] is null)
            {
                frmPersonelGiris frm = new frmPersonelGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if(isim == "Personeller Listesi" && Application.OpenForms["frmPersonellerListesi"] is null)
            {
                frmPersonellerListesi frm = new frmPersonellerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if(isim == "Firma Bilgi Giriş" && Application.OpenForms["frmFirmaGiris"] is null)
            {
                frmFirmaGiris frm = new frmFirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            else if(isim == "Firmalar Listesi" && Application.OpenForms["frmFirmalarListesi"] is null)
            {
                frmFirmalarListesi frm = new frmFirmalarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }
    }
}
