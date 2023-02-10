namespace Forms
{
    partial class TableSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSettings));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabEkle = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblTableName = new DevExpress.XtraEditors.LabelControl();
            this.TabGuncelle = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.dqwMasalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.TabGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwMasalar)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(1133, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.TabEkle;
            this.xtraTabControl1.Size = new System.Drawing.Size(322, 779);
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
            this.TabEkle.Size = new System.Drawing.Size(320, 733);
            this.TabEkle.Text = "Ekle";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.tbxName);
            this.groupControl1.Controls.Add(this.lblTableName);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(315, 727);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(103, 185);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(143, 44);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(103, 102);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(143, 48);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(103, 47);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(143, 23);
            this.tbxName.TabIndex = 3;
            // 
            // lblTableName
            // 
            this.lblTableName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTableName.Appearance.Options.UseFont = true;
            this.lblTableName.Location = new System.Drawing.Point(16, 48);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(80, 22);
            this.lblTableName.TabIndex = 1;
            this.lblTableName.Text = "Masa İsmi";
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
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.btnGuncelle);
            this.groupControl2.Controls.Add(this.tbxUpdateName);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(345, 677);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 22);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Masa İsmi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(105, 118);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(143, 48);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(105, 50);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdateName.TabIndex = 10;
            // 
            // dqwMasalar
            // 
            this.dqwMasalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwMasalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwMasalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwMasalar.Location = new System.Drawing.Point(9, 12);
            this.dqwMasalar.Name = "dqwMasalar";
            this.dqwMasalar.RowTemplate.Height = 24;
            this.dqwMasalar.Size = new System.Drawing.Size(1118, 779);
            this.dqwMasalar.TabIndex = 5;
            this.dqwMasalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwMasalar_CellClick_1);
            // 
            // TableSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 803);
            this.Controls.Add(this.dqwMasalar);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "TableSettings";
            this.Text = "Masa Ayarları";
            this.Load += new System.EventHandler(this.TableSettings_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dqwMasalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabEkle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.TextBox tbxName;
        private DevExpress.XtraEditors.LabelControl lblTableName;
        private DevExpress.XtraTab.XtraTabPage TabGuncelle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dqwMasalar;
    }
}