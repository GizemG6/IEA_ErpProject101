﻿
namespace IEA_ErpProject101_Main
{
    partial class Home
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
            this.tabUstMenu = new System.Windows.Forms.TabControl();
            this.tapPGenel = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPYonetim = new System.Windows.Forms.TabPage();
            this.pnlAltBilgi = new System.Windows.Forms.Panel();
            this.pnlSolMenu = new System.Windows.Forms.Panel();
            this.spcSolMenuOrta = new System.Windows.Forms.SplitContainer();
            this.tvDepoIslemleri = new System.Windows.Forms.TreeView();
            this.tvBilgiGirisIslemleri = new System.Windows.Forms.TreeView();
            this.tv12 = new System.Windows.Forms.TreeView();
            this.tv11 = new System.Windows.Forms.TreeView();
            this.tv10 = new System.Windows.Forms.TreeView();
            this.tv9 = new System.Windows.Forms.TreeView();
            this.tv8 = new System.Windows.Forms.TreeView();
            this.tv7 = new System.Windows.Forms.TreeView();
            this.tv6 = new System.Windows.Forms.TreeView();
            this.tv5 = new System.Windows.Forms.TreeView();
            this.tv4 = new System.Windows.Forms.TreeView();
            this.tvUrunIslemleri = new System.Windows.Forms.TreeView();
            this.btnUrunIslemleri = new System.Windows.Forms.Button();
            this.btnDepoIslemleri = new System.Windows.Forms.Button();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.pnlSolIcUst = new System.Windows.Forms.Panel();
            this.btnCollaps = new System.Windows.Forms.Button();
            this.lblBilgiEkrani = new System.Windows.Forms.Label();
            this.btnSolMenuArama = new System.Windows.Forms.Button();
            this.txtSolMenuArama = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabUstMenu.SuspendLayout();
            this.tapPGenel.SuspendLayout();
            this.pnlSolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcSolMenuOrta)).BeginInit();
            this.spcSolMenuOrta.Panel1.SuspendLayout();
            this.spcSolMenuOrta.Panel2.SuspendLayout();
            this.spcSolMenuOrta.SuspendLayout();
            this.pnlSolIcUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUstMenu
            // 
            this.tabUstMenu.Controls.Add(this.tapPGenel);
            this.tabUstMenu.Controls.Add(this.tabPYonetim);
            this.tabUstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabUstMenu.Location = new System.Drawing.Point(0, 0);
            this.tabUstMenu.Name = "tabUstMenu";
            this.tabUstMenu.SelectedIndex = 0;
            this.tabUstMenu.Size = new System.Drawing.Size(805, 100);
            this.tabUstMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabUstMenu.TabIndex = 1;
            // 
            // tapPGenel
            // 
            this.tapPGenel.BackColor = System.Drawing.Color.LightSlateGray;
            this.tapPGenel.Controls.Add(this.button1);
            this.tapPGenel.Location = new System.Drawing.Point(4, 22);
            this.tapPGenel.Name = "tapPGenel";
            this.tapPGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tapPGenel.Size = new System.Drawing.Size(797, 74);
            this.tapPGenel.TabIndex = 0;
            this.tapPGenel.Text = "Genel";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 52);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPYonetim
            // 
            this.tabPYonetim.Location = new System.Drawing.Point(4, 22);
            this.tabPYonetim.Name = "tabPYonetim";
            this.tabPYonetim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPYonetim.Size = new System.Drawing.Size(797, 74);
            this.tabPYonetim.TabIndex = 1;
            this.tabPYonetim.Text = "Yönetim";
            this.tabPYonetim.UseVisualStyleBackColor = true;
            // 
            // pnlAltBilgi
            // 
            this.pnlAltBilgi.BackColor = System.Drawing.Color.DeepPink;
            this.pnlAltBilgi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAltBilgi.Location = new System.Drawing.Point(0, 386);
            this.pnlAltBilgi.Name = "pnlAltBilgi";
            this.pnlAltBilgi.Size = new System.Drawing.Size(805, 24);
            this.pnlAltBilgi.TabIndex = 1;
            // 
            // pnlSolMenu
            // 
            this.pnlSolMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSolMenu.Controls.Add(this.spcSolMenuOrta);
            this.pnlSolMenu.Controls.Add(this.pnlSolIcUst);
            this.pnlSolMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSolMenu.Location = new System.Drawing.Point(0, 100);
            this.pnlSolMenu.Name = "pnlSolMenu";
            this.pnlSolMenu.Size = new System.Drawing.Size(200, 286);
            this.pnlSolMenu.TabIndex = 2;
            // 
            // spcSolMenuOrta
            // 
            this.spcSolMenuOrta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcSolMenuOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcSolMenuOrta.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcSolMenuOrta.Location = new System.Drawing.Point(0, 51);
            this.spcSolMenuOrta.Name = "spcSolMenuOrta";
            this.spcSolMenuOrta.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcSolMenuOrta.Panel1
            // 
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tvBilgiGirisIslemleri);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tv12);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tv11);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tv10);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tv9);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tv8);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tv7);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tv6);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tv5);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tv4);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tvUrunIslemleri);
            this.spcSolMenuOrta.Panel1.Controls.Add(this.tvDepoIslemleri);
            // 
            // spcSolMenuOrta.Panel2
            // 
            this.spcSolMenuOrta.Panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.spcSolMenuOrta.Panel2.Controls.Add(this.btnUrunIslemleri);
            this.spcSolMenuOrta.Panel2.Controls.Add(this.btnDepoIslemleri);
            this.spcSolMenuOrta.Panel2.Controls.Add(this.btnBilgiGiris);
            this.spcSolMenuOrta.Size = new System.Drawing.Size(200, 235);
            this.spcSolMenuOrta.SplitterDistance = 127;
            this.spcSolMenuOrta.TabIndex = 1;
            // 
            // tvDepoIslemleri
            // 
            this.tvDepoIslemleri.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tvDepoIslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDepoIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tvDepoIslemleri.Location = new System.Drawing.Point(0, 0);
            this.tvDepoIslemleri.Name = "tvDepoIslemleri";
            this.tvDepoIslemleri.Size = new System.Drawing.Size(196, 123);
            this.tvDepoIslemleri.TabIndex = 1;
            this.tvDepoIslemleri.Visible = false;
            this.tvDepoIslemleri.DoubleClick += new System.EventHandler(this.tvDepoIslemleri_DoubleClick);
            // 
            // tvBilgiGirisIslemleri
            // 
            this.tvBilgiGirisIslemleri.BackColor = System.Drawing.Color.LightGreen;
            this.tvBilgiGirisIslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBilgiGirisIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tvBilgiGirisIslemleri.Location = new System.Drawing.Point(0, 0);
            this.tvBilgiGirisIslemleri.Name = "tvBilgiGirisIslemleri";
            this.tvBilgiGirisIslemleri.Size = new System.Drawing.Size(196, 123);
            this.tvBilgiGirisIslemleri.TabIndex = 0;
            this.tvBilgiGirisIslemleri.Visible = false;
            this.tvBilgiGirisIslemleri.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBilgiGirisIslemleri_AfterSelect);
            this.tvBilgiGirisIslemleri.DoubleClick += new System.EventHandler(this.tvBilgiGirisIslemleri_DoubleClick);
            // 
            // tv12
            // 
            this.tv12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv12.Location = new System.Drawing.Point(0, 0);
            this.tv12.Name = "tv12";
            this.tv12.Size = new System.Drawing.Size(196, 123);
            this.tv12.TabIndex = 11;
            this.tv12.Visible = false;
            // 
            // tv11
            // 
            this.tv11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv11.Location = new System.Drawing.Point(0, 0);
            this.tv11.Name = "tv11";
            this.tv11.Size = new System.Drawing.Size(196, 123);
            this.tv11.TabIndex = 10;
            this.tv11.Visible = false;
            // 
            // tv10
            // 
            this.tv10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv10.Location = new System.Drawing.Point(0, 0);
            this.tv10.Name = "tv10";
            this.tv10.Size = new System.Drawing.Size(196, 123);
            this.tv10.TabIndex = 9;
            this.tv10.Visible = false;
            // 
            // tv9
            // 
            this.tv9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv9.Location = new System.Drawing.Point(0, 0);
            this.tv9.Name = "tv9";
            this.tv9.Size = new System.Drawing.Size(196, 123);
            this.tv9.TabIndex = 8;
            this.tv9.Visible = false;
            // 
            // tv8
            // 
            this.tv8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv8.Location = new System.Drawing.Point(0, 0);
            this.tv8.Name = "tv8";
            this.tv8.Size = new System.Drawing.Size(196, 123);
            this.tv8.TabIndex = 7;
            this.tv8.Visible = false;
            // 
            // tv7
            // 
            this.tv7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv7.Location = new System.Drawing.Point(0, 0);
            this.tv7.Name = "tv7";
            this.tv7.Size = new System.Drawing.Size(196, 123);
            this.tv7.TabIndex = 6;
            this.tv7.Visible = false;
            // 
            // tv6
            // 
            this.tv6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv6.Location = new System.Drawing.Point(0, 0);
            this.tv6.Name = "tv6";
            this.tv6.Size = new System.Drawing.Size(196, 123);
            this.tv6.TabIndex = 5;
            this.tv6.Visible = false;
            // 
            // tv5
            // 
            this.tv5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv5.Location = new System.Drawing.Point(0, 0);
            this.tv5.Name = "tv5";
            this.tv5.Size = new System.Drawing.Size(196, 123);
            this.tv5.TabIndex = 4;
            this.tv5.Visible = false;
            // 
            // tv4
            // 
            this.tv4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv4.Location = new System.Drawing.Point(0, 0);
            this.tv4.Name = "tv4";
            this.tv4.Size = new System.Drawing.Size(196, 123);
            this.tv4.TabIndex = 3;
            this.tv4.Visible = false;
            // 
            // tvUrunIslemleri
            // 
            this.tvUrunIslemleri.BackColor = System.Drawing.Color.LightPink;
            this.tvUrunIslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUrunIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tvUrunIslemleri.Location = new System.Drawing.Point(0, 0);
            this.tvUrunIslemleri.Name = "tvUrunIslemleri";
            this.tvUrunIslemleri.Size = new System.Drawing.Size(196, 123);
            this.tvUrunIslemleri.TabIndex = 2;
            this.tvUrunIslemleri.Visible = false;
            this.tvUrunIslemleri.DoubleClick += new System.EventHandler(this.tvUrunIslemleri_DoubleClick);
            // 
            // btnUrunIslemleri
            // 
            this.btnUrunIslemleri.BackColor = System.Drawing.Color.Orchid;
            this.btnUrunIslemleri.Location = new System.Drawing.Point(132, 3);
            this.btnUrunIslemleri.Name = "btnUrunIslemleri";
            this.btnUrunIslemleri.Size = new System.Drawing.Size(66, 46);
            this.btnUrunIslemleri.TabIndex = 1;
            this.btnUrunIslemleri.Text = "Urun İşlemleri";
            this.btnUrunIslemleri.UseVisualStyleBackColor = false;
            this.btnUrunIslemleri.Click += new System.EventHandler(this.btnUrunIslemleri_Click);
            // 
            // btnDepoIslemleri
            // 
            this.btnDepoIslemleri.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDepoIslemleri.Location = new System.Drawing.Point(66, 51);
            this.btnDepoIslemleri.Name = "btnDepoIslemleri";
            this.btnDepoIslemleri.Size = new System.Drawing.Size(66, 46);
            this.btnDepoIslemleri.TabIndex = 2;
            this.btnDepoIslemleri.Text = "Depo İşlemleri";
            this.btnDepoIslemleri.UseVisualStyleBackColor = false;
            this.btnDepoIslemleri.Click += new System.EventHandler(this.btnDepoIslemleri_Click);
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.BackColor = System.Drawing.Color.LightGreen;
            this.btnBilgiGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBilgiGiris.Location = new System.Drawing.Point(1, 3);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(63, 46);
            this.btnBilgiGiris.TabIndex = 0;
            this.btnBilgiGiris.Text = "Bilgi Giriş İşlemleri";
            this.btnBilgiGiris.UseVisualStyleBackColor = false;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // pnlSolIcUst
            // 
            this.pnlSolIcUst.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlSolIcUst.Controls.Add(this.btnCollaps);
            this.pnlSolIcUst.Controls.Add(this.lblBilgiEkrani);
            this.pnlSolIcUst.Controls.Add(this.btnSolMenuArama);
            this.pnlSolIcUst.Controls.Add(this.txtSolMenuArama);
            this.pnlSolIcUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolIcUst.Location = new System.Drawing.Point(0, 0);
            this.pnlSolIcUst.Name = "pnlSolIcUst";
            this.pnlSolIcUst.Size = new System.Drawing.Size(200, 51);
            this.pnlSolIcUst.TabIndex = 0;
            // 
            // btnCollaps
            // 
            this.btnCollaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollaps.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.RightLeft2Red;
            this.btnCollaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCollaps.Location = new System.Drawing.Point(177, 26);
            this.btnCollaps.Name = "btnCollaps";
            this.btnCollaps.Size = new System.Drawing.Size(23, 21);
            this.btnCollaps.TabIndex = 3;
            this.btnCollaps.UseVisualStyleBackColor = true;
            // 
            // lblBilgiEkrani
            // 
            this.lblBilgiEkrani.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBilgiEkrani.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblBilgiEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgiEkrani.Location = new System.Drawing.Point(3, 26);
            this.lblBilgiEkrani.Name = "lblBilgiEkrani";
            this.lblBilgiEkrani.Size = new System.Drawing.Size(173, 23);
            this.lblBilgiEkrani.TabIndex = 2;
            this.lblBilgiEkrani.Text = "***";
            this.lblBilgiEkrani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSolMenuArama
            // 
            this.btnSolMenuArama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolMenuArama.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Ara32x32;
            this.btnSolMenuArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolMenuArama.Location = new System.Drawing.Point(177, 2);
            this.btnSolMenuArama.Name = "btnSolMenuArama";
            this.btnSolMenuArama.Size = new System.Drawing.Size(23, 21);
            this.btnSolMenuArama.TabIndex = 1;
            this.btnSolMenuArama.UseVisualStyleBackColor = true;
            // 
            // txtSolMenuArama
            // 
            this.txtSolMenuArama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolMenuArama.Location = new System.Drawing.Point(4, 4);
            this.txtSolMenuArama.Name = "txtSolMenuArama";
            this.txtSolMenuArama.Size = new System.Drawing.Size(173, 20);
            this.txtSolMenuArama.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 286);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(805, 410);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlSolMenu);
            this.Controls.Add(this.pnlAltBilgi);
            this.Controls.Add(this.tabUstMenu);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "ErpProject - Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabUstMenu.ResumeLayout(false);
            this.tapPGenel.ResumeLayout(false);
            this.pnlSolMenu.ResumeLayout(false);
            this.spcSolMenuOrta.Panel1.ResumeLayout(false);
            this.spcSolMenuOrta.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcSolMenuOrta)).EndInit();
            this.spcSolMenuOrta.ResumeLayout(false);
            this.pnlSolIcUst.ResumeLayout(false);
            this.pnlSolIcUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUstMenu;
        private System.Windows.Forms.TabPage tapPGenel;
        private System.Windows.Forms.TabPage tabPYonetim;
        private System.Windows.Forms.Panel pnlAltBilgi;
        private System.Windows.Forms.Panel pnlSolMenu;
        private System.Windows.Forms.Panel pnlSolIcUst;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnSolMenuArama;
        private System.Windows.Forms.TextBox txtSolMenuArama;
        private System.Windows.Forms.Button btnCollaps;
        private System.Windows.Forms.Label lblBilgiEkrani;
        private System.Windows.Forms.SplitContainer spcSolMenuOrta;
        private System.Windows.Forms.TreeView tv12;
        private System.Windows.Forms.TreeView tv11;
        private System.Windows.Forms.TreeView tv10;
        private System.Windows.Forms.TreeView tv9;
        private System.Windows.Forms.TreeView tv8;
        private System.Windows.Forms.TreeView tv7;
        private System.Windows.Forms.TreeView tv6;
        private System.Windows.Forms.TreeView tv5;
        private System.Windows.Forms.TreeView tv4;
        private System.Windows.Forms.TreeView tvUrunIslemleri;
        private System.Windows.Forms.TreeView tvDepoIslemleri;
        private System.Windows.Forms.TreeView tvBilgiGirisIslemleri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBilgiGiris;
        private System.Windows.Forms.Button btnDepoIslemleri;
        private System.Windows.Forms.Button btnUrunIslemleri;
    }
}

