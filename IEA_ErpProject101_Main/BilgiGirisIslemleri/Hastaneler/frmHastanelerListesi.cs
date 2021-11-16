using IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler;
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

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri
{
    public partial class frmHastanelerListesi : Form
    {
        private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        private int secimId = -1;
        internal bool Secim=false;

        public frmHastanelerListesi()
        {
            InitializeComponent();
        }

        private void frmHastanelerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler where s.isActive == true where s.CariGroupId == 1 && s.CariGroupId==1 select s).ToList();
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

        private void frmHastanelerListesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Home.kontrol = false;
            //this.Dispose();
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Secim && Application.OpenForms["frmHastaneGiris"]==null)
            {
                Home.Aktarma = secimId;
                //frmHastaneGiris frm = new frmHastaneGiris();
                //frm.MdiParent = Home.ActiveForm;
                //frm.Show();
                Close();
            }
            else if (Application.OpenForms["frmHastaneGiris"] != null)
            {
                frmHastaneGiris frm1 =Application.OpenForms["frmHastaneGiris"] as frmHastaneGiris;
                frm1.Ac(secimId);
                Close();
            }

        }
    }
}
