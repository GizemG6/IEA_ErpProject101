﻿
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller
{
    partial class frmPersonelGiris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.txtPUnvan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.txtCariTipi = new System.Windows.Forms.ComboBox();
            this.txtPersonelMail = new System.Windows.Forms.TextBox();
            this.txtPersonelTel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtDepartman1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblPersonelKodu = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.CheckBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 298);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(858, 10);
            this.pnlAlt.TabIndex = 89;
            // 
            // txtPUnvan
            // 
            this.txtPUnvan.FormattingEnabled = true;
            this.txtPUnvan.Location = new System.Drawing.Point(125, 30);
            this.txtPUnvan.Name = "txtPUnvan";
            this.txtPUnvan.Size = new System.Drawing.Size(100, 21);
            this.txtPUnvan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 87;
            this.label2.Text = "Personel:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(17, 3);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(177, 20);
            this.txtKayitBul.TabIndex = 85;
            // 
            // txtCariTipi
            // 
            this.txtCariTipi.FormattingEnabled = true;
            this.txtCariTipi.Location = new System.Drawing.Point(385, 129);
            this.txtCariTipi.Name = "txtCariTipi";
            this.txtCariTipi.Size = new System.Drawing.Size(100, 21);
            this.txtCariTipi.TabIndex = 10;
            // 
            // txtPersonelMail
            // 
            this.txtPersonelMail.Location = new System.Drawing.Point(385, 30);
            this.txtPersonelMail.Name = "txtPersonelMail";
            this.txtPersonelMail.Size = new System.Drawing.Size(167, 20);
            this.txtPersonelMail.TabIndex = 4;
            // 
            // txtPersonelTel
            // 
            this.txtPersonelTel.Location = new System.Drawing.Point(660, 29);
            this.txtPersonelTel.Mask = "(999) 000-0000";
            this.txtPersonelTel.Name = "txtPersonelTel";
            this.txtPersonelTel.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelTel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Personel Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPTcNo
            // 
            this.txtPTcNo.Location = new System.Drawing.Point(385, 95);
            this.txtPTcNo.Mask = "00000000000";
            this.txtPTcNo.Name = "txtPTcNo";
            this.txtPTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtPTcNo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 71;
            this.label4.Text = "Personel Adres1:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(19, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 73;
            this.label5.Text = "Personel Adres2:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(279, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "Personel Tipi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(279, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 77;
            this.label8.Text = "Departman:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.IndianRed;
            this.splitter2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 308);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(858, 10);
            this.splitter2.TabIndex = 91;
            this.splitter2.TabStop = false;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(660, 93);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 21);
            this.txtSehir.TabIndex = 9;
            // 
            // txtDepartman1
            // 
            this.txtDepartman1.FormattingEnabled = true;
            this.txtDepartman1.Location = new System.Drawing.Point(385, 61);
            this.txtDepartman1.Name = "txtDepartman1";
            this.txtDepartman1.Size = new System.Drawing.Size(121, 21);
            this.txtDepartman1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(279, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 80;
            this.label12.Text = "Tc No:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(554, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 19);
            this.label16.TabIndex = 84;
            this.label16.Text = "Sehir:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(279, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 19);
            this.label15.TabIndex = 83;
            this.label15.Text = "Personel Mail:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(554, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 19);
            this.label14.TabIndex = 82;
            this.label14.Text = "Personel Tel:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(125, 177);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(144, 70);
            this.txtAdres2.TabIndex = 3;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(125, 105);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(144, 66);
            this.txtAdres1.TabIndex = 2;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.Location = new System.Drawing.Point(125, 62);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(144, 20);
            this.txtPersonelAdi.TabIndex = 1;
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
            this.Cep,
            this.CariMail,
            this.Baslangic,
            this.Bitis});
            this.liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.liste.Location = new System.Drawing.Point(0, 318);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(858, 96);
            this.liste.TabIndex = 90;
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
            this.CariKodu.HeaderText = "Personel Kodu";
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 93;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Personel Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTelefon
            // 
            this.CariTelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTelefon.HeaderText = "Personel Telefon";
            this.CariTelefon.Name = "CariTelefon";
            this.CariTelefon.Width = 103;
            // 
            // Cep
            // 
            this.Cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cep.HeaderText = "Personel GSM";
            this.Cep.Name = "Cep";
            this.Cep.Width = 92;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Personel Mail";
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 87;
            // 
            // Baslangic
            // 
            this.Baslangic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Format = "d";
            this.Baslangic.DefaultCellStyle = dataGridViewCellStyle1;
            this.Baslangic.HeaderText = "Bas.Tarih";
            this.Baslangic.Name = "Baslangic";
            this.Baslangic.Width = 77;
            // 
            // Bitis
            // 
            this.Bitis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Format = "d";
            this.Bitis.DefaultCellStyle = dataGridViewCellStyle2;
            this.Bitis.HeaderText = "Bit.Tarih";
            this.Bitis.Name = "Bitis";
            this.Bitis.Width = 71;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblPersonelKodu);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(858, 45);
            this.pnlUst.TabIndex = 88;
            // 
            // lblPersonelKodu
            // 
            this.lblPersonelKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPersonelKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelKodu.Location = new System.Drawing.Point(428, 8);
            this.lblPersonelKodu.Name = "lblPersonelKodu";
            this.lblPersonelKodu.Size = new System.Drawing.Size(187, 23);
            this.lblPersonelKodu.TabIndex = 5;
            this.lblPersonelKodu.Text = "***";
            this.lblPersonelKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtBaslangic
            // 
            this.txtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBaslangic.Location = new System.Drawing.Point(454, 176);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(200, 20);
            this.txtBaslangic.TabIndex = 11;
            // 
            // txtBitis
            // 
            this.txtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBitis.Location = new System.Drawing.Point(454, 206);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(200, 20);
            this.txtBitis.TabIndex = 12;
            this.txtBitis.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(348, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "Is Baslangic T:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(348, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 95;
            this.label7.Text = "Is Bitis T:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Visible = false;
            // 
            // txtDurum
            // 
            this.txtDurum.AutoSize = true;
            this.txtDurum.Location = new System.Drawing.Point(660, 189);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(118, 17);
            this.txtDurum.TabIndex = 96;
            this.txtDurum.Text = "Is Bitis Tarihi Girilsin";
            this.txtDurum.UseVisualStyleBackColor = true;
            this.txtDurum.Visible = false;
            this.txtDurum.CheckedChanged += new System.EventHandler(this.txtDurum_CheckedChanged);
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoSize = true;
            this.pnlOrta.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Controls.Add(this.maskedTextBox1);
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.txtDurum);
            this.pnlOrta.Controls.Add(this.txtPersonelAdi);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Controls.Add(this.txtBitis);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.txtBaslangic);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.txtPUnvan);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.txtDepartman1);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.txtCariTipi);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtPersonelMail);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtPersonelTel);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtPTcNo);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 45);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(858, 253);
            this.pnlOrta.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(554, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 98;
            this.label9.Text = "Personel Tel:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(660, 58);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // frmPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 414);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmPersonelGiris";
            this.Text = "frmPersonelGiris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonelGiris_FormClosing);
            this.Load += new System.EventHandler(this.frmPersonelGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.ComboBox txtPUnvan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKayitBul;
        private System.Windows.Forms.ComboBox txtCariTipi;
        private System.Windows.Forms.TextBox txtPersonelMail;
        private System.Windows.Forms.MaskedTextBox txtPersonelTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPTcNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.ComboBox txtDepartman1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblPersonelKodu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DateTimePicker txtBaslangic;
        private System.Windows.Forms.DateTimePicker txtBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox txtDurum;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}