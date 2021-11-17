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
    public partial class frmFirmalarListesi : Ortaklar
    {
        //private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        private int secimId = -1;
        internal bool Secim = false;
        public frmFirmalarListesi()
        {
            InitializeComponent();
        }

        private void frmFirmalarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblCariler where s.isActive == true && s.CariGroupId == 3 select s).ToList();
            foreach (tblCariler k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = sira;
                liste.Rows[i].Cells[2].Value = k.CariNo;
                liste.Rows[i].Cells[3].Value = k.CariAdi;
                liste.Rows[i].Cells[4].Value = k.CariTel;
                liste.Rows[i].Cells[5].Value = k.CariMail;
                liste.Rows[i].Cells[6].Value = k.YetkiliAdi1;
                i++;
                sira++;
            }
            liste.AllowUserToAddRows = false;
            liste.ReadOnly = true;
            liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Secim && Application.OpenForms["frmFirmaGiris"] == null)
            {
                //frmFirmaGiris frm = new frmFirmaGiris();
                //frm.MdiParent = Home.ActiveForm;
                //frm.Show();
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmFirmaGiris"] != null)
            {
                frmFirmaGiris frm1 = Application.OpenForms["frmFirmaGiris"] as frmFirmaGiris;
                frm1.Ac(secimId);
                Close();
            }
        }
    }
}
