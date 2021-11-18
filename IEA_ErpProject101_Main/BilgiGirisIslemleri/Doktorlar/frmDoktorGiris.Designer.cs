
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar
{
    partial class frmDoktorGiris
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
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtDUnvan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.txtCariTipi = new System.Windows.Forms.ComboBox();
            this.txtDoktorMail = new System.Windows.Forms.TextBox();
            this.txtDoktorTel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDcep1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDepartman1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblDoktorKodu = new System.Windows.Forms.Label();
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
            this.splitter2.BackColor = System.Drawing.Color.Red;
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
            this.Cep,
            this.CariMail});
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
            this.CariKodu.HeaderText = "Doktor Kodu";
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 85;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Doktor Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTelefon
            // 
            this.CariTelefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTelefon.HeaderText = "Doktor Telefon";
            this.CariTelefon.Name = "CariTelefon";
            this.CariTelefon.Width = 95;
            // 
            // Cep
            // 
            this.Cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cep.HeaderText = "Doktor GSM";
            this.Cep.Name = "Cep";
            this.Cep.Width = 84;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Doktor Mail";
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 79;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlOrta.Controls.Add(this.txtDUnvan);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.txtCariTipi);
            this.pnlOrta.Controls.Add(this.txtDoktorMail);
            this.pnlOrta.Controls.Add(this.txtDoktorTel);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtVerTcNo);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtDcep1);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtDepartman1);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtVergiDairesi);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.txtDoktorAdi);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 45);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(858, 343);
            this.pnlOrta.TabIndex = 60;
            // 
            // txtDUnvan
            // 
            this.txtDUnvan.FormattingEnabled = true;
            this.txtDUnvan.Location = new System.Drawing.Point(118, 33);
            this.txtDUnvan.Name = "txtDUnvan";
            this.txtDUnvan.Size = new System.Drawing.Size(100, 21);
            this.txtDUnvan.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Doktor Unvan:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(27, 6);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(177, 20);
            this.txtKayitBul.TabIndex = 38;
            // 
            // txtCariTipi
            // 
            this.txtCariTipi.FormattingEnabled = true;
            this.txtCariTipi.Location = new System.Drawing.Point(390, 143);
            this.txtCariTipi.Name = "txtCariTipi";
            this.txtCariTipi.Size = new System.Drawing.Size(100, 21);
            this.txtCariTipi.TabIndex = 4;
            // 
            // txtDoktorMail
            // 
            this.txtDoktorMail.Location = new System.Drawing.Point(375, 31);
            this.txtDoktorMail.Name = "txtDoktorMail";
            this.txtDoktorMail.Size = new System.Drawing.Size(167, 20);
            this.txtDoktorMail.TabIndex = 8;
            // 
            // txtDoktorTel
            // 
            this.txtDoktorTel.Location = new System.Drawing.Point(654, 32);
            this.txtDoktorTel.Mask = "(999) 000-0000";
            this.txtDoktorTel.Name = "txtDoktorTel";
            this.txtDoktorTel.Size = new System.Drawing.Size(100, 20);
            this.txtDoktorTel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doktor Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVerTcNo
            // 
            this.txtVerTcNo.Location = new System.Drawing.Point(387, 179);
            this.txtVerTcNo.Mask = "00000000000";
            this.txtVerTcNo.Name = "txtVerTcNo";
            this.txtVerTcNo.Size = new System.Drawing.Size(100, 20);
            this.txtVerTcNo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doktor Hastane Adres:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doktor Muayene Adres:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(284, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cari Tipi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDcep1
            // 
            this.txtDcep1.Location = new System.Drawing.Point(654, 68);
            this.txtDcep1.Mask = "(999) 000-0000";
            this.txtDcep1.Name = "txtDcep1";
            this.txtDcep1.Size = new System.Drawing.Size(100, 20);
            this.txtDcep1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(269, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Departman:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(621, 143);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 21);
            this.txtSehir.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(548, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cep:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDepartman1
            // 
            this.txtDepartman1.FormattingEnabled = true;
            this.txtDepartman1.Location = new System.Drawing.Point(375, 67);
            this.txtDepartman1.Name = "txtDepartman1";
            this.txtDepartman1.Size = new System.Drawing.Size(121, 21);
            this.txtDepartman1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(284, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Vergi No:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(624, 179);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(100, 20);
            this.txtVergiDairesi.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(515, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 19);
            this.label16.TabIndex = 37;
            this.label16.Text = "Sehir:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(269, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 19);
            this.label15.TabIndex = 36;
            this.label15.Text = "Doktor Mail:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(548, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 19);
            this.label14.TabIndex = 35;
            this.label14.Text = "Doktor Tel:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(515, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "Vergi Dairesi:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(118, 180);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(144, 70);
            this.txtAdres2.TabIndex = 3;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(118, 108);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(144, 66);
            this.txtAdres1.TabIndex = 2;
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Location = new System.Drawing.Point(118, 66);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(144, 20);
            this.txtDoktorAdi.TabIndex = 0;
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
            this.pnlUst.Controls.Add(this.lblDoktorKodu);
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
            // lblDoktorKodu
            // 
            this.lblDoktorKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoktorKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorKodu.Location = new System.Drawing.Point(428, 8);
            this.lblDoktorKodu.Name = "lblDoktorKodu";
            this.lblDoktorKodu.Size = new System.Drawing.Size(187, 23);
            this.lblDoktorKodu.TabIndex = 5;
            this.lblDoktorKodu.Text = "***";
            this.lblDoktorKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // frmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 414);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmDoktorGiris";
            this.Text = "frmDoktorGiris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoktorGiris_FormClosing);
            this.Load += new System.EventHandler(this.frmDoktorGiris_Load);
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
        private System.Windows.Forms.ComboBox txtCariTipi;
        private System.Windows.Forms.TextBox txtDoktorMail;
        private System.Windows.Forms.MaskedTextBox txtDoktorTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtVerTcNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDcep1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtDepartman1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblDoktorKodu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.ComboBox txtDUnvan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
    }
}