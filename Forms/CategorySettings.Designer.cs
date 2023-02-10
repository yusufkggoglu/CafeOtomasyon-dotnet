namespace Forms
{
    partial class CategorySettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorySettings));
            this.dqwKategoriler = new System.Windows.Forms.DataGridView();
            this.xtraTab = new DevExpress.XtraTab.XtraTabControl();
            this.TabEkle = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new DevExpress.XtraEditors.LabelControl();
            this.TabGuncelle = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dqwKategoriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).BeginInit();
            this.xtraTab.SuspendLayout();
            this.TabEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.TabGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dqwKategoriler
            // 
            this.dqwKategoriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dqwKategoriler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dqwKategoriler.Location = new System.Drawing.Point(10, 12);
            this.dqwKategoriler.Name = "dqwKategoriler";
            this.dqwKategoriler.RowTemplate.Height = 24;
            this.dqwKategoriler.Size = new System.Drawing.Size(1148, 820);
            this.dqwKategoriler.TabIndex = 3;
            this.dqwKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwKategoriler_CellClick);
            // 
            // xtraTab
            // 
            this.xtraTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTab.Location = new System.Drawing.Point(1163, 12);
            this.xtraTab.Name = "xtraTab";
            this.xtraTab.SelectedTabPage = this.TabEkle;
            this.xtraTab.Size = new System.Drawing.Size(322, 820);
            this.xtraTab.TabIndex = 4;
            this.xtraTab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabEkle,
            this.TabGuncelle});
            // 
            // TabEkle
            // 
            this.TabEkle.Controls.Add(this.groupControl1);
            this.TabEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabEkle.ImageOptions.Image")));
            this.TabEkle.Name = "TabEkle";
            this.TabEkle.Size = new System.Drawing.Size(318, 776);
            this.TabEkle.Text = "Ekle";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.tbxName);
            this.groupControl1.Controls.Add(this.lblCategoryName);
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
            this.btnSil.Location = new System.Drawing.Point(127, 188);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(143, 44);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(127, 107);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(143, 48);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(127, 47);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(143, 23);
            this.tbxName.TabIndex = 3;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.Appearance.Options.UseFont = true;
            this.lblCategoryName.Location = new System.Drawing.Point(16, 48);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(105, 22);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Kategori İsmi";
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
            this.groupControl2.Controls.Add(this.tbxUpdateName);
            this.groupControl2.Controls.Add(this.labelControl2);
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
            this.btnGuncelle.Location = new System.Drawing.Point(115, 111);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(143, 48);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(115, 50);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(143, 23);
            this.tbxUpdateName.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 22);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Kategori İsmi";
            // 
            // CategorySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 844);
            this.Controls.Add(this.xtraTab);
            this.Controls.Add(this.dqwKategoriler);
            this.Name = "CategorySettings";
            this.Text = "Kategori Ayarları";
            this.Load += new System.EventHandler(this.CategorySettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqwKategoriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTab)).EndInit();
            this.xtraTab.ResumeLayout(false);
            this.TabEkle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.TabGuncelle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dqwKategoriler;
        private DevExpress.XtraTab.XtraTabControl xtraTab;
        private DevExpress.XtraTab.XtraTabPage TabEkle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.TextBox tbxName;
        private DevExpress.XtraEditors.LabelControl lblCategoryName;
        private DevExpress.XtraTab.XtraTabPage TabGuncelle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}