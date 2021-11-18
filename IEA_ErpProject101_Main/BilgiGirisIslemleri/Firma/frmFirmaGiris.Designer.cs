
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma
{
    partial class frmFirmaGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiliKisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.txtFTipi = new System.Windows.Forms.ComboBox();
            this.txtFMail = new System.Windows.Forms.TextBox();
            this.txtFTel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtFYTel3 = new System.Windows.Forms.MaskedTextBox();
            this.txtFYTel2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFYTel1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFYcep3 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFYcep2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFYcep1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFDepartman3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFDepartman2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFDepartman1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtFYet1 = new System.Windows.Forms.TextBox();
            this.txtFYet2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFYet3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFEmail1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFEmail2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFEmail3 = new System.Windows.Forms.TextBox();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtFAdi = new System.Windows.Forms.TextBox();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblFirmaKodu = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Purple;
            this.splitter2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 303);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(858, 14);
            this.splitter2.TabIndex = 62;
            this.splitter2.TabStop = false;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SiraNo,
            this.CariKodu,
            this.CariAdi,
            this.CariTelefon,
            this.CariMail,
            this.YetkiliKisi});
            this.liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.liste.Location = new System.Drawing.Point(0, 317);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(858, 71);
            this.liste.TabIndex = 61;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // SiraNo
            // 
            this.SiraNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SiraNo.HeaderText = "Sıra No";
            this.SiraNo.Name = "SiraNo";
            this.SiraNo.Width = 50;
            // 
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Firma Kodu";
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 78;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Firma Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTelefon
            // 
            this.CariTelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTelefon.HeaderText = "Firma Telefon";
            this.CariTelefon.Name = "CariTelefon";
            this.CariTelefon.Width = 88;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Firma Mail";
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 73;
            // 
            // YetkiliKisi
            // 
            this.YetkiliKisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YetkiliKisi.HeaderText = "Firma Yetkili Kisi";
            this.YetkiliKisi.Name = "YetkiliKisi";
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.BackColor = System.Drawing.Color.LightGreen;
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.txtFTipi);
            this.pnlOrta.Controls.Add(this.txtFMail);
            this.pnlOrta.Controls.Add(this.txtFTel);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtVerTcNo);
            this.pnlOrta.Controls.Add(this.txtFYTel3);
            this.pnlOrta.Controls.Add(this.txtFYTel2);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtFYTel1);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtFYcep3);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtFYcep2);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtFYcep1);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Controls.Add(this.txtFDepartman3);
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.txtFDepartman2);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtFDepartman1);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtVergiDairesi);
            this.pnlOrta.Controls.Add(this.txtFYet1);
            this.pnlOrta.Controls.Add(this.txtFYet2);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.txtFYet3);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.txtFEmail1);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.txtFEmail2);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.txtFEmail3);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.txtFAdi);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 45);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(858, 343);
            this.pnlOrta.TabIndex = 60;
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(27, 6);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(177, 20);
            this.txtKayitBul.TabIndex = 38;
            // 
            // txtFTipi
            // 
            this.txtFTipi.FormattingEnabled = true;
            this.txtFTipi.Location = new System.Drawing.Point(118, 36);
            this.txtFTipi.Name = "txtFTipi";
            this.txtFTipi.Size = new System.Drawing.Size(100, 21);
            this.txtFTipi.TabIndex = 0;
            // 
            // txtFMail
            // 
            this.txtFMail.Location = new System.Drawing.Point(118, 124);
            this.txtFMail.Name = "txtFMail";
            this.txtFMail.Size = new System.Drawing.Size(167, 20);
            this.txtFMail.TabIndex = 3;
            // 
            // txtFTel
            // 
            this.txtFTel.Location = new System.Drawing.Point(118, 97);
            this.txtFTel.Mask = "(999) 000-0000";
            this.txtFTel.Name = "txtFTel";
            this.txtFTel.Size = new System.Drawing.Size(100, 20);
            this.txtFTel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firma Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVerTcNo
            // 
            this.txtVerTcNo.Location = new System.Drawing.Point(390, 7);
            this.txtVerTcNo.Mask = "00000000000";
            this.txtVerTcNo.Name = "txtVerTcNo";
            this.txtVerTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtVerTcNo.TabIndex = 7;
            // 
            // txtFYTel3
            // 
            this.txtFYTel3.Location = new System.Drawing.Point(518, 111);
            this.txtFYTel3.Mask = "(999) 000-0000";
            this.txtFYTel3.Name = "txtFYTel3";
            this.txtFYTel3.Size = new System.Drawing.Size(100, 20);
            this.txtFYTel3.TabIndex = 21;
            // 
            // txtFYTel2
            // 
            this.txtFYTel2.Location = new System.Drawing.Point(518, 91);
            this.txtFYTel2.Mask = "(999) 000-0000";
            this.txtFYTel2.Name = "txtFYTel2";
            this.txtFYTel2.Size = new System.Drawing.Size(100, 20);
            this.txtFYTel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(317, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Firma Adres1:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFYTel1
            // 
            this.txtFYTel1.Location = new System.Drawing.Point(518, 73);
            this.txtFYTel1.Mask = "(999) 000-0000";
            this.txtFYTel1.Name = "txtFYTel1";
            this.txtFYTel1.Size = new System.Drawing.Size(100, 20);
            this.txtFYTel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Location = new System.Drawing.Point(581, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Firma Adres2:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFYcep3
            // 
            this.txtFYcep3.Location = new System.Drawing.Point(625, 110);
            this.txtFYcep3.Mask = "(999) 000-0000";
            this.txtFYcep3.Name = "txtFYcep3";
            this.txtFYcep3.Size = new System.Drawing.Size(100, 20);
            this.txtFYcep3.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Firma Tipi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFYcep2
            // 
            this.txtFYcep2.Location = new System.Drawing.Point(625, 91);
            this.txtFYcep2.Mask = "(999) 000-0000";
            this.txtFYcep2.Name = "txtFYcep2";
            this.txtFYcep2.Size = new System.Drawing.Size(100, 20);
            this.txtFYcep2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(291, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yetkili:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFYcep1
            // 
            this.txtFYcep1.Location = new System.Drawing.Point(625, 74);
            this.txtFYcep1.Mask = "(999) 000-0000";
            this.txtFYcep1.Name = "txtFYcep1";
            this.txtFYcep1.Size = new System.Drawing.Size(100, 20);
            this.txtFYcep1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGreen;
            this.label8.Location = new System.Drawing.Point(394, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Departman:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(118, 153);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 21);
            this.txtSehir.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightGreen;
            this.label9.Location = new System.Drawing.Point(731, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "E-Mail:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFDepartman3
            // 
            this.txtFDepartman3.FormattingEnabled = true;
            this.txtFDepartman3.Location = new System.Drawing.Point(394, 110);
            this.txtFDepartman3.Name = "txtFDepartman3";
            this.txtFDepartman3.Size = new System.Drawing.Size(121, 21);
            this.txtFDepartman3.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightGreen;
            this.label10.Location = new System.Drawing.Point(518, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Telefon:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFDepartman2
            // 
            this.txtFDepartman2.FormattingEnabled = true;
            this.txtFDepartman2.Location = new System.Drawing.Point(394, 90);
            this.txtFDepartman2.Name = "txtFDepartman2";
            this.txtFDepartman2.Size = new System.Drawing.Size(121, 21);
            this.txtFDepartman2.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightGreen;
            this.label11.Location = new System.Drawing.Point(625, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cep:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFDepartman1
            // 
            this.txtFDepartman1.FormattingEnabled = true;
            this.txtFDepartman1.Location = new System.Drawing.Point(394, 73);
            this.txtFDepartman1.Name = "txtFDepartman1";
            this.txtFDepartman1.Size = new System.Drawing.Size(121, 21);
            this.txtFDepartman1.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightGreen;
            this.label12.Location = new System.Drawing.Point(287, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Vn-Tc No:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(602, 8);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(100, 20);
            this.txtVergiDairesi.TabIndex = 8;
            // 
            // txtFYet1
            // 
            this.txtFYet1.Location = new System.Drawing.Point(291, 71);
            this.txtFYet1.Name = "txtFYet1";
            this.txtFYet1.Size = new System.Drawing.Size(100, 20);
            this.txtFYet1.TabIndex = 9;
            // 
            // txtFYet2
            // 
            this.txtFYet2.Location = new System.Drawing.Point(291, 90);
            this.txtFYet2.Name = "txtFYet2";
            this.txtFYet2.Size = new System.Drawing.Size(100, 20);
            this.txtFYet2.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.LightGreen;
            this.label16.Location = new System.Drawing.Point(12, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 19);
            this.label16.TabIndex = 37;
            this.label16.Text = "Sehir:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFYet3
            // 
            this.txtFYet3.Location = new System.Drawing.Point(291, 109);
            this.txtFYet3.Name = "txtFYet3";
            this.txtFYet3.Size = new System.Drawing.Size(100, 20);
            this.txtFYet3.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightGreen;
            this.label15.Location = new System.Drawing.Point(12, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 19);
            this.label15.TabIndex = 36;
            this.label15.Text = "Firma Mail:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFEmail1
            // 
            this.txtFEmail1.Location = new System.Drawing.Point(731, 74);
            this.txtFEmail1.Name = "txtFEmail1";
            this.txtFEmail1.Size = new System.Drawing.Size(116, 20);
            this.txtFEmail1.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightGreen;
            this.label14.Location = new System.Drawing.Point(12, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 19);
            this.label14.TabIndex = 35;
            this.label14.Text = "Firma Tel:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFEmail2
            // 
            this.txtFEmail2.Location = new System.Drawing.Point(731, 91);
            this.txtFEmail2.Name = "txtFEmail2";
            this.txtFEmail2.Size = new System.Drawing.Size(116, 20);
            this.txtFEmail2.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightGreen;
            this.label13.Location = new System.Drawing.Point(496, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "Vergi Dairesi:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFEmail3
            // 
            this.txtFEmail3.Location = new System.Drawing.Point(731, 111);
            this.txtFEmail3.Name = "txtFEmail3";
            this.txtFEmail3.Size = new System.Drawing.Size(116, 20);
            this.txtFEmail3.TabIndex = 23;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(687, 154);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(144, 76);
            this.txtAdres2.TabIndex = 6;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(423, 154);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(144, 76);
            this.txtAdres1.TabIndex = 5;
            // 
            // txtFAdi
            // 
            this.txtFAdi.Location = new System.Drawing.Point(118, 63);
            this.txtFAdi.Name = "txtFAdi";
            this.txtFAdi.Size = new System.Drawing.Size(144, 20);
            this.txtFAdi.TabIndex = 1;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 388);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(858, 26);
            this.pnlAlt.TabIndex = 59;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblFirmaKodu);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(858, 45);
            this.pnlUst.TabIndex = 58;
            // 
            // lblFirmaKodu
            // 
            this.lblFirmaKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirmaKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaKodu.Location = new System.Drawing.Point(428, 8);
            this.lblFirmaKodu.Name = "lblFirmaKodu";
            this.lblFirmaKodu.Size = new System.Drawing.Size(187, 23);
            this.lblFirmaKodu.TabIndex = 5;
            this.lblFirmaKodu.Text = "***";
            this.lblFirmaKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSil
            // 
            this.btnSil.Image = global::IEA_ErpProject101_Main.Properties.Resources.Sil24x24;
            this.btnSil.Location = new System.Drawing.Point(141, 8);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(39, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = global::IEA_ErpProject101_Main.Properties.Resources.Sil32x32;
            this.btnTemizle.Location = new System.Drawing.Point(186, 8);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(39, 30);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(84, 8);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(39, 30);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnFormCikis
            // 
            this.btnFormCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormCikis.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.exit_48;
            this.btnFormCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormCikis.Location = new System.Drawing.Point(807, 3);
            this.btnFormCikis.Name = "btnFormCikis";
            this.btnFormCikis.Size = new System.Drawing.Size(39, 40);
            this.btnFormCikis.TabIndex = 0;
            this.btnFormCikis.UseVisualStyleBackColor = true;
            this.btnFormCikis.Click += new System.EventHandler(this.btnFormCikis_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Save_icon32x32;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(27, 8);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(39, 30);
            this.btnKayit.TabIndex = 1;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // frmFirmaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 414);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmFirmaGiris";
            this.Text = "frmFirmaGiris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFirmaGiris_FormClosing);
            this.Load += new System.EventHandler(this.frmFirmaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.TextBox txtKayitBul;
        private System.Windows.Forms.ComboBox txtFTipi;
        private System.Windows.Forms.TextBox txtFMail;
        private System.Windows.Forms.MaskedTextBox txtFTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtVerTcNo;
        private System.Windows.Forms.MaskedTextBox txtFYTel3;
        private System.Windows.Forms.MaskedTextBox txtFYTel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtFYTel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtFYcep3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtFYcep2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtFYcep1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtFDepartman3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtFDepartman2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtFDepartman1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.TextBox txtFYet1;
        private System.Windows.Forms.TextBox txtFYet2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFYet3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFEmail1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFEmail2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFEmail3;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtFAdi;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblFirmaKodu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiliKisi;
    }
}