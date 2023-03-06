namespace Forms
{
    partial class MainLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayout));
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtnSiparis = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMutfak = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRapor = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGider = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKullanıcı = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrun = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKategori = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMasa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBack = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemRatingControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemRatingControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSiparis, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnMutfak, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnKasa, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRapor, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnGider, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // barBtnSiparis
            // 
            this.barBtnSiparis.Caption = "Masalar";
            this.barBtnSiparis.Id = 3;
            this.barBtnSiparis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSiparis.ImageOptions.Image")));
            this.barBtnSiparis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSiparis.ImageOptions.LargeImage")));
            this.barBtnSiparis.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnSiparis.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnSiparis.Name = "barBtnSiparis";
            this.barBtnSiparis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSiparis_ItemClick);
            // 
            // barBtnMutfak
            // 
            this.barBtnMutfak.Caption = "Sipariş";
            this.barBtnMutfak.Id = 5;
            this.barBtnMutfak.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnMutfak.ImageOptions.Image")));
            this.barBtnMutfak.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnMutfak.ImageOptions.LargeImage")));
            this.barBtnMutfak.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnMutfak.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnMutfak.Name = "barBtnMutfak";
            this.barBtnMutfak.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnMutfak_ItemClick);
            // 
            // barBtnKasa
            // 
            this.barBtnKasa.Caption = "Kasa";
            this.barBtnKasa.Enabled = false;
            this.barBtnKasa.Id = 8;
            this.barBtnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnKasa.ImageOptions.Image")));
            this.barBtnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnKasa.ImageOptions.LargeImage")));
            this.barBtnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnKasa.Name = "barBtnKasa";
            this.barBtnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKasa_ItemClick);
            // 
            // barBtnRapor
            // 
            this.barBtnRapor.Caption = "Raporlar";
            this.barBtnRapor.Enabled = false;
            this.barBtnRapor.Id = 9;
            this.barBtnRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRapor.ImageOptions.Image")));
            this.barBtnRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnRapor.ImageOptions.LargeImage")));
            this.barBtnRapor.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnRapor.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnRapor.Name = "barBtnRapor";
            this.barBtnRapor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRapor_ItemClick);
            // 
            // barBtnGider
            // 
            this.barBtnGider.Caption = "Giderler";
            this.barBtnGider.Enabled = false;
            this.barBtnGider.Id = 10;
            this.barBtnGider.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGider.ImageOptions.Image")));
            this.barBtnGider.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGider.ImageOptions.LargeImage")));
            this.barBtnGider.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnGider.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnGider.Name = "barBtnGider";
            this.barBtnGider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGider_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ana Sayfa\r\n";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Kasa";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Ayarlar";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Raporlar";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barBtnSiparis,
            this.barButtonItem4,
            this.barBtnMutfak,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barBtnKasa,
            this.barBtnRapor,
            this.barBtnGider,
            this.barButtonItem9,
            this.barBtnKullanıcı,
            this.barBtnUrun,
            this.barBtnKategori,
            this.barBtnMasa,
            this.barButtonItem3,
            this.barButtonItem5,
            this.barBtnBack,
            this.barBtnRefresh,
            this.barEditItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 289;
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barBtnBack);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRatingControl1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1700, 191);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 11;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barBtnKullanıcı
            // 
            this.barBtnKullanıcı.Caption = "Kullanıcı";
            this.barBtnKullanıcı.Enabled = false;
            this.barBtnKullanıcı.Id = 13;
            this.barBtnKullanıcı.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnKullanıcı.ImageOptions.Image")));
            this.barBtnKullanıcı.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnKullanıcı.ImageOptions.LargeImage")));
            this.barBtnKullanıcı.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnKullanıcı.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnKullanıcı.Name = "barBtnKullanıcı";
            this.barBtnKullanıcı.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKullanıcı_ItemClick);
            // 
            // barBtnUrun
            // 
            this.barBtnUrun.Caption = "Ürün";
            this.barBtnUrun.Enabled = false;
            this.barBtnUrun.Id = 14;
            this.barBtnUrun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnUrun.ImageOptions.Image")));
            this.barBtnUrun.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnUrun.ImageOptions.LargeImage")));
            this.barBtnUrun.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnUrun.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnUrun.Name = "barBtnUrun";
            this.barBtnUrun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrun_ItemClick);
            // 
            // barBtnKategori
            // 
            this.barBtnKategori.Caption = "Kategori";
            this.barBtnKategori.Enabled = false;
            this.barBtnKategori.Id = 15;
            this.barBtnKategori.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnKategori.ImageOptions.Image")));
            this.barBtnKategori.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnKategori.ImageOptions.LargeImage")));
            this.barBtnKategori.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnKategori.ItemAppearance.Disabled.Options.UseFont = true;
            this.barBtnKategori.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnKategori.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnKategori.Name = "barBtnKategori";
            this.barBtnKategori.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnKategori.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnKategori_ItemClick);
            // 
            // barBtnMasa
            // 
            this.barBtnMasa.Caption = "Masa";
            this.barBtnMasa.Enabled = false;
            this.barBtnMasa.Id = 16;
            this.barBtnMasa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnMasa.ImageOptions.SvgImage")));
            this.barBtnMasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtnMasa.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtnMasa.Name = "barBtnMasa";
            this.barBtnMasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnMasa_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 17;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 18;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barBtnBack
            // 
            this.barBtnBack.Caption = "Çıkış";
            this.barBtnBack.Id = 19;
            this.barBtnBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnBack.ImageOptions.SvgImage")));
            this.barBtnBack.Name = "barBtnBack";
            this.barBtnBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBack_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Id = 20;
            this.barBtnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnRefresh.ImageOptions.SvgImage")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemRatingControl1;
            this.barEditItem1.Id = 21;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemRatingControl1
            // 
            this.repositoryItemRatingControl1.AutoHeight = false;
            this.repositoryItemRatingControl1.Name = "repositoryItemRatingControl1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Ayarlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnUrun, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnKategori, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnKullanıcı, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnMasa, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Ayarlar";
            this.barButtonItem10.Id = 12;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem10.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Ayarlar";
            this.barButtonItem11.Id = 12;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.LargeImage")));
            this.barButtonItem11.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem11.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Ayarlar";
            this.barButtonItem13.Id = 12;
            this.barButtonItem13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.Image")));
            this.barButtonItem13.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.LargeImage")));
            this.barButtonItem13.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem13.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Ayarlar";
            this.barButtonItem14.Id = 12;
            this.barButtonItem14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.ImageOptions.Image")));
            this.barButtonItem14.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.ImageOptions.LargeImage")));
            this.barButtonItem14.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barButtonItem14.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // MainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 989);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1712, 1018);
            this.Name = "MainLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Otomasyon Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnSiparis;
        private DevExpress.XtraBars.BarButtonItem barBtnMutfak;
        private DevExpress.XtraBars.BarButtonItem barBtnRapor;
        private DevExpress.XtraBars.BarButtonItem barBtnGider;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barBtnKullanıcı;
        private DevExpress.XtraBars.BarButtonItem barBtnUrun;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barBtnKategori;
        private DevExpress.XtraBars.BarButtonItem barBtnMasa;
        public DevExpress.XtraBars.BarButtonItem barBtnKasa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barBtnBack;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRatingControl repositoryItemRatingControl1;
    }
}