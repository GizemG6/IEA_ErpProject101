
namespace IEA_ErpProject101_Main.Urun_Islemleri
{
    partial class frmUrunlerListesi
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
            this.liste = new System.Windows.Forms.DataGridView();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.BackgroundColor = System.Drawing.Color.LightCoral;
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SiraNo,
            this.GenelNo,
            this.UrunKodu,
            this.UrunAdi});
            this.liste.Dock = System.Windows.Forms.DockStyle.Top;
            this.liste.Location = new System.Drawing.Point(0, 45);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(693, 366);
            this.liste.TabIndex = 61;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblUrunKodu);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(693, 45);
            this.pnlUst.TabIndex = 60;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUrunKodu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.Location = new System.Drawing.Point(345, 8);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(187, 23);
            this.lblUrunKodu.TabIndex = 5;
            this.lblUrunKodu.Text = "***";
            this.lblUrunKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSil
            // 
            this.btnSil.Image = global::IEA_ErpProject101_Main.Properties.Resources.Sil24x24;
            this.btnSil.Location = new System.Drawing.Point(141, 8);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(39, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = global::IEA_ErpProject101_Main.Properties.Resources.Sil32x32;
            this.btnTemizle.Location = new System.Drawing.Point(186, 8);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(39, 30);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.UseVisualStyleBackColor = true;
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
            // 
            // btnFormCikis
            // 
            this.btnFormCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormCikis.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.exit_48;
            this.btnFormCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormCikis.Location = new System.Drawing.Point(642, 3);
            this.btnFormCikis.Name = "btnFormCikis";
            this.btnFormCikis.Size = new System.Drawing.Size(39, 40);
            this.btnFormCikis.TabIndex = 0;
            this.btnFormCikis.UseVisualStyleBackColor = true;
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
            this.SiraNo.Width = 67;
            // 
            // GenelNo
            // 
            this.GenelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GenelNo.HeaderText = "Genel No";
            this.GenelNo.Name = "GenelNo";
            this.GenelNo.Width = 77;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Urun Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAdi.HeaderText = "Urun Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // frmUrunlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmUrunlerListesi";
            this.Text = "frmUrunlerListesi";
            this.Load += new System.EventHandler(this.frmUrunlerListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
    }
}