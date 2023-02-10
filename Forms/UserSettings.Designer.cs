namespace Forms
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.dqwRoller = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKullaniciSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKullaniciEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.lblRol = new DevExpress.XtraEditors.LabelControl();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.btnRolSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnRolEkle = new DevExpress.XtraEditors.SimpleButton();
            this.tbxRoleName = new System.Windows.Forms.TextBox();
            this.lbRolName = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnKullaniciGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.cbxUpdateRole = new System.Windows.Forms.ComboBox();
            this.tbxUpdateSifre = new System.Windows.Forms.TextBox();
            this.lblUpdateSifre = new DevExpress.XtraEditors.LabelControl();
            this.lblUpdateRole = new DevExpress.XtraEditors.LabelControl();
            this.tbxUpdateSoyad = new System.Windows.Forms.TextBox();
            this.lblUpdateSoyad = new DevExpress.XtraEditors.LabelControl();
            this.tbxUpdateAd = new System.Windows.Forms.TextBox();
            this.lblUpdateAd = new DevExpress.XtraEditors.LabelControl();
            this.tbxUpdateRoleName = new System.Windows.Forms.TextBox();
            this.lblUpdateRol = new DevExpress.XtraEditors.LabelControl();
            this.btnRolGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.dqwKullanicilar = new System.Windows.Forms.DataGridView();
            this.TabGuncelle = new DevExpress.XtraTab.XtraTabPage();
            this.TabEkle = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTab = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dqwRoller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwKullanicilar)).BeginInit();
            this.TabGuncelle.SuspendLayout();
            this.TabEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).BeginInit();
            this.xtraTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // dqwRoller
            // 
            this.dqwRoller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwRoller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwRoller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwRoller.Location = new System.Drawing.Point(10, 12);
            this.dqwRoller.Name = "dqwRoller";
            this.dqwRoller.RowTemplate.Height = 24;
            this.dqwRoller.Size = new System.Drawing.Size(1118, 237);
            this.dqwRoller.TabIndex = 4;
            this.dqwRoller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwRoller_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKullaniciSil);
            this.groupControl1.Controls.Add(this.btnKullaniciEkle);
            this.groupControl1.Controls.Add(this.cbxRole);
            this.groupControl1.Controls.Add(this.tbxSifre);
            this.groupControl1.Controls.Add(this.lblSifre);
            this.groupControl1.Controls.Add(this.lblRol);
            this.groupControl1.Controls.Add(this.tbxSoyad);
            this.groupControl1.Controls.Add(this.lblSoyad);
            this.groupControl1.Controls.Add(this.tbxAd);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Controls.Add(this.btnRolSil);
            this.groupControl1.Controls.Add(this.btnRolEkle);
            this.groupControl1.Controls.Add(this.tbxRoleName);
            this.groupControl1.Controls.Add(this.lbRolName);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(315, 731);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKullaniciSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciSil.ImageOptions.Image")));
            this.btnKullaniciSil.Location = new System.Drawing.Point(113, 452);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(143, 44);
            this.btnKullaniciSil.TabIndex = 26;
            this.btnKullaniciSil.Text = "Sil";
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKullaniciEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkle.ImageOptions.Image")));
            this.btnKullaniciEkle.Location = new System.Drawing.Point(113, 378);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(143, 48);
            this.btnKullaniciEkle.TabIndex = 25;
            this.btnKullaniciEkle.Text = "Ekle";
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // cbxRole
            // 
            this.cbxRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(113, 293);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(143, 24);
            this.cbxRole.TabIndex = 24;
            // 
            // tbxSifre
            // 
            this.tbxSifre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxSifre.Location = new System.Drawing.Point(113, 338);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(143, 23);
            this.tbxSifre.TabIndex = 23;
            // 
            // lblSifre
            // 
            this.lblSifre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSifre.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.Location = new System.Drawing.Point(16, 336);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(35, 22);
            this.lblSifre.TabIndex = 22;
            this.lblSifre.Text = "Şifre";
            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRol.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRol.Appearance.Options.UseFont = true;
            this.lblRol.Location = new System.Drawing.Point(16, 291);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(25, 22);
            this.lblRol.TabIndex = 20;
            this.lblRol.Text = "Rol";
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxSoyad.Location = new System.Drawing.Point(113, 246);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(143, 23);
            this.tbxSoyad.TabIndex = 19;
            // 
            // lblSoyad
            // 
            this.lblSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Appearance.Options.UseFont = true;
            this.lblSoyad.Location = new System.Drawing.Point(16, 247);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(48, 22);
            this.lblSoyad.TabIndex = 18;
            this.lblSoyad.Text = "Soyad";
            // 
            // tbxAd
            // 
            this.tbxAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxAd.Location = new System.Drawing.Point(113, 195);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(143, 23);
            this.tbxAd.TabIndex = 17;
            // 
            // lblAd
            // 
            this.lblAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Appearance.Options.UseFont = true;
            this.lblAd.Location = new System.Drawing.Point(16, 196);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(21, 22);
            this.lblAd.TabIndex = 16;
            this.lblAd.Text = "Ad";
            // 
            // btnRolSil
            // 
            this.btnRolSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRolSil.ImageOptions.Image")));
            this.btnRolSil.Location = new System.Drawing.Point(113, 128);
            this.btnRolSil.Name = "btnRolSil";
            this.btnRolSil.Size = new System.Drawing.Size(143, 44);
            this.btnRolSil.TabIndex = 15;
            this.btnRolSil.Text = "Sil";
            this.btnRolSil.Click += new System.EventHandler(this.btnRolSil_Click);
            // 
            // btnRolEkle
            // 
            this.btnRolEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRolEkle.ImageOptions.Image")));
            this.btnRolEkle.Location = new System.Drawing.Point(113, 59);
            this.btnRolEkle.Name = "btnRolEkle";
            this.btnRolEkle.Size = new System.Drawing.Size(143, 48);
            this.btnRolEkle.TabIndex = 14;
            this.btnRolEkle.Text = "Ekle";
            this.btnRolEkle.Click += new System.EventHandler(this.btnRolEkle_Click);
            // 
            // tbxRoleName
            // 
            this.tbxRoleName.Location = new System.Drawing.Point(113, 16);
            this.tbxRoleName.Name = "tbxRoleName";
            this.tbxRoleName.Size = new System.Drawing.Size(143, 23);
            this.tbxRoleName.TabIndex = 3;
            // 
            // lbRolName
            // 
            this.lbRolName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbRolName.Appearance.Options.UseFont = true;
            this.lbRolName.Location = new System.Drawing.Point(16, 17);
            this.lbRolName.Name = "lbRolName";
            this.lbRolName.Size = new System.Drawing.Size(65, 22);
            this.lbRolName.TabIndex = 1;
            this.lbRolName.Text = "Rol İsmi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnKullaniciGuncelle);
            this.groupControl2.Controls.Add(this.cbxUpdateRole);
            this.groupControl2.Controls.Add(this.tbxUpdateSifre);
            this.groupControl2.Controls.Add(this.lblUpdateSifre);
            this.groupControl2.Controls.Add(this.lblUpdateRole);
            this.groupControl2.Controls.Add(this.tbxUpdateSoyad);
            this.groupControl2.Controls.Add(this.lblUpdateSoyad);
            this.groupControl2.Controls.Add(this.tbxUpdateAd);
            this.groupControl2.Controls.Add(this.lblUpdateAd);
            this.groupControl2.Controls.Add(this.tbxUpdateRoleName);
            this.groupControl2.Controls.Add(this.lblUpdateRol);
            this.groupControl2.Controls.Add(this.btnRolGuncelle);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(345, 677);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnKullaniciGuncelle
            // 
            this.btnKullaniciGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciGuncelle.ImageOptions.Image")));
            this.btnKullaniciGuncelle.Location = new System.Drawing.Point(115, 414);
            this.btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            this.btnKullaniciGuncelle.Size = new System.Drawing.Size(143, 48);
            this.btnKullaniciGuncelle.TabIndex = 35;
            this.btnKullaniciGuncelle.Text = "Güncelle";
            this.btnKullaniciGuncelle.Click += new System.EventHandler(this.btnKullaniciGuncelle_Click);
            // 
            // cbxUpdateRole
            // 
            this.cbxUpdateRole.FormattingEnabled = true;
            this.cbxUpdateRole.Location = new System.Drawing.Point(115, 311);
            this.cbxUpdateRole.Name = "cbxUpdateRole";
            this.cbxUpdateRole.Size = new System.Drawing.Size(143, 24);
            this.cbxUpdateRole.TabIndex = 34;
            // 
            // tbxUpdateSifre
            // 
            this.tbxUpdateSifre.Location = new System.Drawing.Point(115, 356);
            this.tbxUpdateSifre.Name = "tbxUpdateSifre";
            this.tbxUpdateSifre.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdateSifre.TabIndex = 33;
            // 
            // lblUpdateSifre
            // 
            this.lblUpdateSifre.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateSifre.Appearance.Options.UseFont = true;
            this.lblUpdateSifre.Location = new System.Drawing.Point(18, 354);
            this.lblUpdateSifre.Name = "lblUpdateSifre";
            this.lblUpdateSifre.Size = new System.Drawing.Size(35, 22);
            this.lblUpdateSifre.TabIndex = 32;
            this.lblUpdateSifre.Text = "Şifre";
            // 
            // lblUpdateRole
            // 
            this.lblUpdateRole.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateRole.Appearance.Options.UseFont = true;
            this.lblUpdateRole.Location = new System.Drawing.Point(18, 309);
            this.lblUpdateRole.Name = "lblUpdateRole";
            this.lblUpdateRole.Size = new System.Drawing.Size(25, 22);
            this.lblUpdateRole.TabIndex = 31;
            this.lblUpdateRole.Text = "Rol";
            // 
            // tbxUpdateSoyad
            // 
            this.tbxUpdateSoyad.Location = new System.Drawing.Point(115, 264);
            this.tbxUpdateSoyad.Name = "tbxUpdateSoyad";
            this.tbxUpdateSoyad.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdateSoyad.TabIndex = 30;
            // 
            // lblUpdateSoyad
            // 
            this.lblUpdateSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateSoyad.Appearance.Options.UseFont = true;
            this.lblUpdateSoyad.Location = new System.Drawing.Point(18, 265);
            this.lblUpdateSoyad.Name = "lblUpdateSoyad";
            this.lblUpdateSoyad.Size = new System.Drawing.Size(48, 22);
            this.lblUpdateSoyad.TabIndex = 29;
            this.lblUpdateSoyad.Text = "Soyad";
            // 
            // tbxUpdateAd
            // 
            this.tbxUpdateAd.Location = new System.Drawing.Point(115, 213);
            this.tbxUpdateAd.Name = "tbxUpdateAd";
            this.tbxUpdateAd.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdateAd.TabIndex = 28;
            // 
            // lblUpdateAd
            // 
            this.lblUpdateAd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateAd.Appearance.Options.UseFont = true;
            this.lblUpdateAd.Location = new System.Drawing.Point(18, 214);
            this.lblUpdateAd.Name = "lblUpdateAd";
            this.lblUpdateAd.Size = new System.Drawing.Size(21, 22);
            this.lblUpdateAd.TabIndex = 27;
            this.lblUpdateAd.Text = "Ad";
            // 
            // tbxUpdateRoleName
            // 
            this.tbxUpdateRoleName.Location = new System.Drawing.Point(115, 52);
            this.tbxUpdateRoleName.Name = "tbxUpdateRoleName";
            this.tbxUpdateRoleName.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdateRoleName.TabIndex = 26;
            // 
            // lblUpdateRol
            // 
            this.lblUpdateRol.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateRol.Appearance.Options.UseFont = true;
            this.lblUpdateRol.Location = new System.Drawing.Point(18, 53);
            this.lblUpdateRol.Name = "lblUpdateRol";
            this.lblUpdateRol.Size = new System.Drawing.Size(65, 22);
            this.lblUpdateRol.TabIndex = 25;
            this.lblUpdateRol.Text = "Rol İsmi";
            // 
            // btnRolGuncelle
            // 
            this.btnRolGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRolGuncelle.ImageOptions.Image")));
            this.btnRolGuncelle.Location = new System.Drawing.Point(114, 106);
            this.btnRolGuncelle.Name = "btnRolGuncelle";
            this.btnRolGuncelle.Size = new System.Drawing.Size(143, 48);
            this.btnRolGuncelle.TabIndex = 13;
            this.btnRolGuncelle.Text = "Güncelle";
            this.btnRolGuncelle.Click += new System.EventHandler(this.btnRolGuncelle_Click);
            // 
            // dqwKullanicilar
            // 
            this.dqwKullanicilar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwKullanicilar.Location = new System.Drawing.Point(10, 255);
            this.dqwKullanicilar.Name = "dqwKullanicilar";
            this.dqwKullanicilar.RowTemplate.Height = 24;
            this.dqwKullanicilar.Size = new System.Drawing.Size(1118, 535);
            this.dqwKullanicilar.TabIndex = 6;
            this.dqwKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwKullanicilar_CellClick);
            // 
            // TabGuncelle
            // 
            this.TabGuncelle.Controls.Add(this.groupControl2);
            this.TabGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabGuncelle.ImageOptions.Image")));
            this.TabGuncelle.Name = "TabGuncelle";
            this.TabGuncelle.Size = new System.Drawing.Size(320, 732);
            this.TabGuncelle.Text = "Güncelle";
            // 
            // TabEkle
            // 
            this.TabEkle.Controls.Add(this.groupControl1);
            this.TabEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabEkle.ImageOptions.Image")));
            this.TabEkle.Name = "TabEkle";
            this.TabEkle.Size = new System.Drawing.Size(320, 732);
            this.TabEkle.Text = "Ekle";
            // 
            // xtraTab
            // 
            this.xtraTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTab.Location = new System.Drawing.Point(1133, 12);
            this.xtraTab.Name = "xtraTab";
            this.xtraTab.SelectedTabPage = this.TabEkle;
            this.xtraTab.Size = new System.Drawing.Size(322, 778);
            this.xtraTab.TabIndex = 5;
            this.xtraTab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabEkle,
            this.TabGuncelle});
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 802);
            this.Controls.Add(this.dqwKullanicilar);
            this.Controls.Add(this.xtraTab);
            this.Controls.Add(this.dqwRoller);
            this.Name = "UserSettings";
            this.Text = "Kullanıcı Ayarları";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqwRoller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwKullanicilar)).EndInit();
            this.TabGuncelle.ResumeLayout(false);
            this.TabEkle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).EndInit();
            this.xtraTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dqwRoller;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnRolSil;
        private DevExpress.XtraEditors.SimpleButton btnRolEkle;
        private System.Windows.Forms.TextBox tbxRoleName;
        private DevExpress.XtraEditors.LabelControl lbRolName;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnRolGuncelle;
        private System.Windows.Forms.DataGridView dqwKullanicilar;
        private DevExpress.XtraEditors.LabelControl lblRol;
        private System.Windows.Forms.TextBox tbxSoyad;
        private DevExpress.XtraEditors.LabelControl lblSoyad;
        private System.Windows.Forms.TextBox tbxAd;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private System.Windows.Forms.TextBox tbxSifre;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciSil;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciEkle;
        private System.Windows.Forms.ComboBox cbxRole;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciGuncelle;
        private System.Windows.Forms.ComboBox cbxUpdateRole;
        private System.Windows.Forms.TextBox tbxUpdateSifre;
        private DevExpress.XtraEditors.LabelControl lblUpdateSifre;
        private DevExpress.XtraEditors.LabelControl lblUpdateRole;
        private System.Windows.Forms.TextBox tbxUpdateSoyad;
        private DevExpress.XtraEditors.LabelControl lblUpdateSoyad;
        private System.Windows.Forms.TextBox tbxUpdateAd;
        private DevExpress.XtraEditors.LabelControl lblUpdateAd;
        private System.Windows.Forms.TextBox tbxUpdateRoleName;
        private DevExpress.XtraEditors.LabelControl lblUpdateRol;
        private DevExpress.XtraTab.XtraTabPage TabGuncelle;
        private DevExpress.XtraTab.XtraTabPage TabEkle;
        private DevExpress.XtraTab.XtraTabControl xtraTab;
    }
}