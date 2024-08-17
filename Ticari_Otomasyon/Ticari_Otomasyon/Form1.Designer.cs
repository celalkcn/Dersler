namespace Ticari_Otomasyon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusterıler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFırmalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGıderler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Location = new System.Drawing.Point(482, 78);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(8, 8);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ticari Otomasyon";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMusterıler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFırmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnGıderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.Caption = "ANA SAYFA";
            this.BtnAnasayfa.Id = 3;
            this.BtnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.ImageOptions.Image")));
            this.BtnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.ImageOptions.LargeImage")));
            this.BtnAnasayfa.LargeWidth = 80;
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Caption = "ÜRÜNLER";
            this.BtnUrunler.Id = 1;
            this.BtnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.Image")));
            this.BtnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.LargeImage")));
            this.BtnUrunler.LargeWidth = 80;
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUrunler_ItemClick);
            // 
            // BtnMusterıler
            // 
            this.BtnMusterıler.Caption = "MÜŞTERİLER";
            this.BtnMusterıler.Id = 5;
            this.BtnMusterıler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusterıler.ImageOptions.Image")));
            this.BtnMusterıler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMusterıler.ImageOptions.LargeImage")));
            this.BtnMusterıler.LargeWidth = 80;
            this.BtnMusterıler.Name = "BtnMusterıler";
            this.BtnMusterıler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMusterıler_ItemClick);
            // 
            // BtnFırmalar
            // 
            this.BtnFırmalar.Caption = "FİRMALAR";
            this.BtnFırmalar.Id = 6;
            this.BtnFırmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFırmalar.ImageOptions.Image")));
            this.BtnFırmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFırmalar.ImageOptions.LargeImage")));
            this.BtnFırmalar.LargeWidth = 80;
            this.BtnFırmalar.Name = "BtnFırmalar";
            this.BtnFırmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFırmalar_ItemClick);
            // 
            // BtnPersoneller
            // 
            this.BtnPersoneller.Caption = "PERSONELLER";
            this.BtnPersoneller.Id = 7;
            this.BtnPersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersoneller.ImageOptions.Image")));
            this.BtnPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersoneller.ImageOptions.LargeImage")));
            this.BtnPersoneller.LargeWidth = 80;
            this.BtnPersoneller.Name = "BtnPersoneller";
            this.BtnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersoneller_ItemClick);
            // 
            // BtnGıderler
            // 
            this.BtnGıderler.Caption = "GİDERLER";
            this.BtnGıderler.Id = 8;
            this.BtnGıderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGıderler.ImageOptions.Image")));
            this.BtnGıderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGıderler.ImageOptions.LargeImage")));
            this.BtnGıderler.LargeWidth = 80;
            this.BtnGıderler.Name = "BtnGıderler";
            this.BtnGıderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGıderler_ItemClick);
            // 
            // BtnKasa
            // 
            this.BtnKasa.Caption = "KASA";
            this.BtnKasa.Id = 9;
            this.BtnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKasa.ImageOptions.Image")));
            this.BtnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKasa.ImageOptions.LargeImage")));
            this.BtnKasa.LargeWidth = 80;
            this.BtnKasa.Name = "BtnKasa";
            // 
            // BtnNotlar
            // 
            this.BtnNotlar.Caption = "NOTLAR";
            this.BtnNotlar.Id = 10;
            this.BtnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.Image")));
            this.BtnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.LargeImage")));
            this.BtnNotlar.LargeWidth = 80;
            this.BtnNotlar.Name = "BtnNotlar";
            // 
            // BtnStoklar
            // 
            this.BtnStoklar.Caption = "STOKLAR";
            this.BtnStoklar.Id = 4;
            this.BtnStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnStoklar.ImageOptions.Image")));
            this.BtnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnStoklar.ImageOptions.LargeImage")));
            this.BtnStoklar.LargeWidth = 80;
            this.BtnStoklar.Name = "BtnStoklar";
            // 
            // BtnBankalar
            // 
            this.BtnBankalar.Caption = "BANKALAR";
            this.BtnBankalar.Id = 11;
            this.BtnBankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBankalar.ImageOptions.Image")));
            this.BtnBankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBankalar.ImageOptions.LargeImage")));
            this.BtnBankalar.LargeWidth = 80;
            this.BtnBankalar.Name = "BtnBankalar";
            this.BtnBankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // BtnRehber
            // 
            this.BtnRehber.Caption = "REHBER";
            this.BtnRehber.Id = 12;
            this.BtnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRehber.ImageOptions.Image")));
            this.BtnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnRehber.ImageOptions.LargeImage")));
            this.BtnRehber.LargeWidth = 80;
            this.BtnRehber.Name = "BtnRehber";
            this.BtnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRehber_ItemClick);
            // 
            // BtnFaturalar
            // 
            this.BtnFaturalar.Caption = "FATURALAR";
            this.BtnFaturalar.Id = 13;
            this.BtnFaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFaturalar.ImageOptions.Image")));
            this.BtnFaturalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFaturalar.ImageOptions.LargeImage")));
            this.BtnFaturalar.LargeWidth = 80;
            this.BtnFaturalar.Name = "BtnFaturalar";
            this.BtnFaturalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFaturalar_ItemClick);
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Caption = "AYARLAR";
            this.BtnAyarlar.Id = 14;
            this.BtnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.ImageOptions.Image")));
            this.BtnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.ImageOptions.LargeImage")));
            this.BtnAyarlar.LargeWidth = 80;
            this.BtnAyarlar.Name = "BtnAyarlar";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "ÜRÜNLER";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnUrunler,
            this.barButtonItem2,
            this.BtnAnasayfa,
            this.BtnStoklar,
            this.BtnMusterıler,
            this.BtnFırmalar,
            this.BtnPersoneller,
            this.BtnGıderler,
            this.BtnKasa,
            this.BtnNotlar,
            this.BtnBankalar,
            this.BtnRehber,
            this.BtnFaturalar,
            this.BtnAyarlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1348, 183);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 905);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.xtraScrollableControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem BtnUrunler;
        private DevExpress.XtraBars.BarButtonItem BtnStoklar;
        private DevExpress.XtraBars.BarButtonItem BtnMusterıler;
        private DevExpress.XtraBars.BarButtonItem BtnFırmalar;
        private DevExpress.XtraBars.BarButtonItem BtnPersoneller;
        private DevExpress.XtraBars.BarButtonItem BtnGıderler;
        private DevExpress.XtraBars.BarButtonItem BtnKasa;
        private DevExpress.XtraBars.BarButtonItem BtnNotlar;
        private DevExpress.XtraBars.BarButtonItem BtnBankalar;
        private DevExpress.XtraBars.BarButtonItem BtnRehber;
        private DevExpress.XtraBars.BarButtonItem BtnFaturalar;
        private DevExpress.XtraBars.BarButtonItem BtnAyarlar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

