namespace Forms
{
    partial class OutGoingsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutGoingsScreen));
            this.dqwGiderler = new System.Windows.Forms.DataGridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabEkle = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.lblAmount = new DevExpress.XtraEditors.LabelControl();
            this.TabGuncelle = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tbxUpdateAmount = new System.Windows.Forms.TextBox();
            this.lblUpdateAmount = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.tbxUpdatePrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbxToplam = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dqwGiderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.TabGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dqwGiderler
            // 
            this.dqwGiderler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwGiderler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwGiderler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwGiderler.Location = new System.Drawing.Point(12, 12);
            this.dqwGiderler.Name = "dqwGiderler";
            this.dqwGiderler.RowTemplate.Height = 24;
            this.dqwGiderler.Size = new System.Drawing.Size(1118, 820);
            this.dqwGiderler.TabIndex = 3;
            this.dqwGiderler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwGiderler_CellClick);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(1136, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabEkle;
            this.xtraTabControl1.Size = new System.Drawing.Size(322, 690);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabEkle,
            this.TabGuncelle});
            // 
            // TabEkle
            // 
            this.TabEkle.Controls.Add(this.groupControl1);
            this.TabEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabEkle.ImageOptions.Image")));
            this.TabEkle.Name = "TabEkle";
            this.TabEkle.Size = new System.Drawing.Size(318, 646);
            this.TabEkle.Text = "Ekle";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl1.Controls.Add(this.tbxAmount);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.tbxPrice);
            this.groupControl1.Controls.Add(this.tbxName);
            this.groupControl1.Controls.Add(this.lblPrice);
            this.groupControl1.Controls.Add(this.lblProductName);
            this.groupControl1.Controls.Add(this.lblAmount);
            this.groupControl1.Location = new System.Drawing.Point(1, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(315, 640);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(103, 98);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(143, 23);
            this.tbxAmount.TabIndex = 16;
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
            this.lblPrice.Size = new System.Drawing.Size(83, 22);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Adet Fiyatı";
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
            // lblAmount
            // 
            this.lblAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.Appearance.Options.UseFont = true;
            this.lblAmount.Location = new System.Drawing.Point(16, 98);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(36, 22);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Adet";
            // 
            // TabGuncelle
            // 
            this.TabGuncelle.Controls.Add(this.groupControl2);
            this.TabGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabGuncelle.ImageOptions.Image")));
            this.TabGuncelle.Name = "TabGuncelle";
            this.TabGuncelle.Size = new System.Drawing.Size(318, 646);
            this.TabGuncelle.Text = "Güncelle";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tbxUpdateAmount);
            this.groupControl2.Controls.Add(this.lblUpdateAmount);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.tbxUpdatePrice);
            this.groupControl2.Controls.Add(this.tbxUpdateName);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(312, 461);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // tbxUpdateAmount
            // 
            this.tbxUpdateAmount.Location = new System.Drawing.Point(107, 99);
            this.tbxUpdateAmount.Name = "tbxUpdateAmount";
            this.tbxUpdateAmount.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdateAmount.TabIndex = 18;
            // 
            // lblUpdateAmount
            // 
            this.lblUpdateAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateAmount.Appearance.Options.UseFont = true;
            this.lblUpdateAmount.Location = new System.Drawing.Point(18, 100);
            this.lblUpdateAmount.Name = "lblUpdateAmount";
            this.lblUpdateAmount.Size = new System.Drawing.Size(36, 22);
            this.lblUpdateAmount.TabIndex = 17;
            this.lblUpdateAmount.Text = "Adet";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(107, 207);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(143, 48);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbxUpdatePrice
            // 
            this.tbxUpdatePrice.Location = new System.Drawing.Point(107, 148);
            this.tbxUpdatePrice.Name = "tbxUpdatePrice";
            this.tbxUpdatePrice.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdatePrice.TabIndex = 11;
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(107, 50);
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
            this.labelControl1.Size = new System.Drawing.Size(83, 22);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Adet Fiyatı";
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
            // tbxToplam
            // 
            this.tbxToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxToplam.Enabled = false;
            this.tbxToplam.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxToplam.Location = new System.Drawing.Point(1193, 786);
            this.tbxToplam.Multiline = true;
            this.tbxToplam.Name = "tbxToplam";
            this.tbxToplam.Size = new System.Drawing.Size(202, 46);
            this.tbxToplam.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1200, 730);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(195, 40);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Toplam Gider";
            // 
            // OutGoingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 844);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tbxToplam);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.dqwGiderler);
            this.Name = "OutGoingsScreen";
            this.Text = "OutGoingsScreen";
            this.Load += new System.EventHandler(this.OutGoingsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqwGiderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabEkle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.TabGuncelle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dqwGiderler;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabEkle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxName;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.LabelControl lblAmount;
        private DevExpress.XtraTab.XtraTabPage TabGuncelle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.TextBox tbxUpdatePrice;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.TextBox tbxUpdateAmount;
        private DevExpress.XtraEditors.LabelControl lblUpdateAmount;
        private System.Windows.Forms.TextBox tbxToplam;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}