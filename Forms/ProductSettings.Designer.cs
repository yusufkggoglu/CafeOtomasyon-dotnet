namespace Forms
{
    partial class ProductSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSettings));
            this.TabGuncelle = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TabEkle = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.dqwUrunler = new System.Windows.Forms.DataGridView();
            this.TabGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.TabEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGuncelle
            // 
            this.TabGuncelle.Controls.Add(this.groupControl2);
            this.TabGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabGuncelle.ImageOptions.Image")));
            this.TabGuncelle.Name = "TabGuncelle";
            this.TabGuncelle.Size = new System.Drawing.Size(320, 733);
            this.TabGuncelle.Text = "Güncelle";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.cbxUpdateCategory);
            this.groupControl2.Controls.Add(this.tbxUpdatePrice);
            this.groupControl2.Controls.Add(this.tbxUpdateName);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(345, 677);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(105, 211);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(143, 48);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(105, 105);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(143, 24);
            this.cbxUpdateCategory.TabIndex = 12;
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(105, 148);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdatePrice.TabIndex = 11;
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(105, 50);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdateName.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 149);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Fiyat";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 22);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Ürün İsmi";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 22);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Kategori";
            // 
            // TabEkle
            // 
            this.TabEkle.Controls.Add(this.groupControl1);
            this.TabEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabEkle.ImageOptions.Image")));
            this.TabEkle.Name = "TabEkle";
            this.TabEkle.Size = new System.Drawing.Size(320, 733);
            this.TabEkle.Text = "Ekle";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.cbxCategory);
            this.groupControl1.Controls.Add(this.tbxPrice);
            this.groupControl1.Controls.Add(this.tbxName);
            this.groupControl1.Controls.Add(this.lblPrice);
            this.groupControl1.Controls.Add(this.lblProductName);
            this.groupControl1.Controls.Add(this.lblCategory);
            this.groupControl1.Location = new System.Drawing.Point(1, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(315, 727);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(103, 298);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(143, 44);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(103, 229);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(143, 48);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(103, 102);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(143, 24);
            this.cbxCategory.TabIndex = 6;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(103, 145);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(143, 23);
            this.tbxPrice.TabIndex = 5;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(103, 47);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(143, 23);
            this.tbxName.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Appearance.Options.UseFont = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 146);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 22);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Fiyat";
            // 
            // lblProductName
            // 
            this.lblProductName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Appearance.Options.UseFont = true;
            this.lblProductName.Location = new System.Drawing.Point(16, 48);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 22);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün İsmi";
            // 
            // lblCategory
            // 
            this.lblCategory.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Appearance.Options.UseFont = true;
            this.lblCategory.Location = new System.Drawing.Point(16, 104);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 22);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(1133, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabEkle;
            this.xtraTabControl1.Size = new System.Drawing.Size(322, 779);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabEkle,
            this.TabGuncelle});
            // 
            // dqwUrunler
            // 
            this.dqwUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwUrunler.Location = new System.Drawing.Point(10, 12);
            this.dqwUrunler.Name = "dqwUrunler";
            this.dqwUrunler.RowTemplate.Height = 24;
            this.dqwUrunler.Size = new System.Drawing.Size(1118, 779);
            this.dqwUrunler.TabIndex = 2;
            this.dqwUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwUrunler_CellClick_1);
            // 
            // ProductSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 803);
            this.Controls.Add(this.dqwUrunler);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ProductSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ayarları";
            this.Load += new System.EventHandler(this.ProductSettings_Load);
            this.TabGuncelle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.TabEkle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dqwUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage TabGuncelle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTab.XtraTabPage TabEkle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxName;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private System.Windows.Forms.DataGridView dqwUrunler;
    }
}