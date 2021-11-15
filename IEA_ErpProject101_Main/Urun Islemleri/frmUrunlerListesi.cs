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

namespace IEA_ErpProject101_Main.Urun_Islemleri
{
    public partial class frmUrunlerListesi : Form
    {
        private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        private int secimId = -1;
        Numaralar n = new Numaralar();
        public frmUrunlerListesi()
        {
            InitializeComponent();
        }

        private void frmUrunlerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblUrunler where s.isActive == true select s).ToList();

            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = sira;
                liste.Rows[i].Cells[2].Value = k.UrunGenelNo;
                liste.Rows[i].Cells[3].Value = k.UrunKodu;
                liste.Rows[i].Cells[3].Value = k.UrunAdi;
                i++;
                sira++;
            }
            liste.AllowUserToAddRows = false;
            liste.ReadOnly = true;
            liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            lblUrunKodu.Text = n.UrunGenelKodu();
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Application.OpenForms["frmUrunGiris"] == null)
            {
                frmUrunGiris frm = new frmUrunGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
                Close();
            }
            else if (Application.OpenForms["frmUrunGiris"] != null)
            {
                frmUrunGiris frm1 = Application.OpenForms["frmUrunGiris"] as frmUrunGiris;
                frm1.Ac(secimId);
                Close();
            }
        }
    }
}
