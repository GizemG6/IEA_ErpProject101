
namespace IEA_ErpProject101_Main.DepoIslemleri.StokIslemleri
{
    partial class frmStokGuncelleme
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
            this.txtLot = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUT = new System.Windows.Forms.DateTimePicker();
            this.txtSKT = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGenelNo = new System.Windows.Forms.Label();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblAlisFiyat = new System.Windows.Forms.Label();
            this.lblUT = new System.Windows.Forms.Label();
            this.lblSKT = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtUrunKodu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(140, 93);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(100, 20);
            this.txtLot.TabIndex = 1;
            this.txtLot.TextChanged += new System.EventHandler(this.txtLot_TextChanged);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(256, 93);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 20);
            this.txtBarkod.TabIndex = 2;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(373, 93);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 20);
            this.txtAdet.TabIndex = 3;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(489, 93);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtAlisFiyat.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(21, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Urun Kodu";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(137, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lot Seri";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(253, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Barkod";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(370, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adet";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(486, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alis Fiyat";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(350, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "SKT";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(137, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "UT";
            // 
            // txtUT
            // 
            this.txtUT.Location = new System.Drawing.Point(112, 152);
            this.txtUT.Name = "txtUT";
            this.txtUT.Size = new System.Drawing.Size(183, 20);
            this.txtUT.TabIndex = 17;
            this.txtUT.ValueChanged += new System.EventHandler(this.txtUT_ValueChanged);
            // 
            // txtSKT
            // 
            this.txtSKT.Location = new System.Drawing.Point(311, 152);
            this.txtSKT.Name = "txtSKT";
            this.txtSKT.Size = new System.Drawing.Size(200, 20);
            this.txtSKT.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(21, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Genel No";
            // 
            // lblGenelNo
            // 
            this.lblGenelNo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblGenelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenelNo.Location = new System.Drawing.Point(109, 9);
            this.lblGenelNo.Name = "lblGenelNo";
            this.lblGenelNo.Size = new System.Drawing.Size(103, 23);
            this.lblGenelNo.TabIndex = 20;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblUrunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUrunKodu.Location = new System.Drawing.Point(21, 44);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(103, 23);
            this.lblUrunKodu.TabIndex = 21;
            // 
            // lblLot
            // 
            this.lblLot.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLot.Location = new System.Drawing.Point(137, 44);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(103, 23);
            this.lblLot.TabIndex = 22;
            // 
            // lblBarkod
            // 
            this.lblBarkod.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBarkod.Location = new System.Drawing.Point(253, 44);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(103, 23);
            this.lblBarkod.TabIndex = 23;
            // 
            // lblAdet
            // 
            this.lblAdet.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdet.Location = new System.Drawing.Point(370, 44);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(103, 23);
            this.lblAdet.TabIndex = 24;
            // 
            // lblAlisFiyat
            // 
            this.lblAlisFiyat.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblAlisFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlisFiyat.Location = new System.Drawing.Point(486, 44);
            this.lblAlisFiyat.Name = "lblAlisFiyat";
            this.lblAlisFiyat.Size = new System.Drawing.Size(103, 23);
            this.lblAlisFiyat.TabIndex = 25;
            // 
            // lblUT
            // 
            this.lblUT.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUT.Location = new System.Drawing.Point(182, 126);
            this.lblUT.Name = "lblUT";
            this.lblUT.Size = new System.Drawing.Size(103, 23);
            this.lblUT.TabIndex = 26;
            // 
            // lblSKT
            // 
            this.lblSKT.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSKT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSKT.Location = new System.Drawing.Point(393, 126);
            this.lblSKT.Name = "lblSKT";
            this.lblSKT.Size = new System.Drawing.Size(103, 23);
            this.lblSKT.TabIndex = 27;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(548, 126);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(82, 31);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.FormattingEnabled = true;
            this.txtUrunKodu.Location = new System.Drawing.Point(12, 93);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(112, 21);
            this.txtUrunKodu.TabIndex = 29;
            this.txtUrunKodu.SelectedIndexChanged += new System.EventHandler(this.txtUrunKodu_SelectedIndexChanged);
            // 
            // frmStokGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(663, 207);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblSKT);
            this.Controls.Add(this.lblUT);
            this.Controls.Add(this.lblAlisFiyat);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblLot);
            this.Controls.Add(this.lblUrunKodu);
            this.Controls.Add(this.lblGenelNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSKT);
            this.Controls.Add(this.txtUT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtLot);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmStokGuncelleme";
            this.Text = "frmStokGuncelleme";
            this.Load += new System.EventHandler(this.frmStokGuncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtAlisFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtUT;
        private System.Windows.Forms.DateTimePicker txtSKT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGenelNo;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblAlisFiyat;
        private System.Windows.Forms.Label lblUT;
        private System.Windows.Forms.Label lblSKT;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox txtUrunKodu;
    }
}