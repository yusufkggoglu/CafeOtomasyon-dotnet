namespace Forms
{
    partial class OrderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderScreen));
            this.dqwOrders = new System.Windows.Forms.DataGridView();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.BtnTableList = new DevExpress.XtraEditors.SimpleButton();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tabEkran = new DevExpress.XtraTab.XtraTabPage();
            this.tabNotes = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.rtbxNotes = new System.Windows.Forms.RichTextBox();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dqwOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tabEkran.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dqwOrders
            // 
            this.dqwOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwOrders.Location = new System.Drawing.Point(779, 120);
            this.dqwOrders.Name = "dqwOrders";
            this.dqwOrders.RowTemplate.Height = 24;
            this.dqwOrders.Size = new System.Drawing.Size(675, 352);
            this.dqwOrders.TabIndex = 1;
            this.dqwOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwOrders_CellClick);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Enabled = false;
            this.tbxPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPrice.Location = new System.Drawing.Point(399, 46);
            this.tbxPrice.Multiline = true;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(196, 54);
            this.tbxPrice.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 248);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(6, 46);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(221, 54);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Ürün Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // flp
            // 
            this.flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp.Location = new System.Drawing.Point(3, 120);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(770, 668);
            this.flp.TabIndex = 0;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1466, 0);
            this.fluentDesignFormControl1.TabIndex = 9;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // BtnTableList
            // 
            this.BtnTableList.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTableList.Appearance.Options.UseFont = true;
            this.BtnTableList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnTableList.ImageOptions.SvgImage")));
            this.BtnTableList.Location = new System.Drawing.Point(12, 44);
            this.BtnTableList.Name = "BtnTableList";
            this.BtnTableList.Size = new System.Drawing.Size(170, 48);
            this.BtnTableList.TabIndex = 4;
            this.BtnTableList.Text = "Geri ";
            this.BtnTableList.Click += new System.EventHandler(this.BtnTableList_Click);
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.xtraTabControl1);
            this.fluentDesignFormContainer1.Controls.Add(this.BtnTableList);
            this.fluentDesignFormContainer1.Controls.Add(this.dqwOrders);
            this.fluentDesignFormContainer1.Controls.Add(this.btnYenile);
            this.fluentDesignFormContainer1.Controls.Add(this.flp);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1466, 802);
            this.fluentDesignFormContainer1.TabIndex = 7;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(779, 478);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tabEkran;
            this.xtraTabControl1.Size = new System.Drawing.Size(682, 310);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabEkran,
            this.tabNotes});
            // 
            // tabEkran
            // 
            this.tabEkran.Controls.Add(this.groupBox1);
            this.tabEkran.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabEkran.ImageOptions.SvgImage")));
            this.tabEkran.Name = "tabEkran";
            this.tabEkran.Size = new System.Drawing.Size(678, 258);
            this.tabEkran.Text = "Ekran";
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.groupBox3);
            this.tabNotes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNotes.ImageOptions.SvgImage")));
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Size = new System.Drawing.Size(678, 258);
            this.tabNotes.Text = "Notes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.rtbxNotes);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 255);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(451, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 47);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbxNotes
            // 
            this.rtbxNotes.Location = new System.Drawing.Point(6, 22);
            this.rtbxNotes.Name = "rtbxNotes";
            this.rtbxNotes.Size = new System.Drawing.Size(596, 155);
            this.rtbxNotes.TabIndex = 0;
            this.rtbxNotes.Text = "";
            // 
            // btnYenile
            // 
            this.btnYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenile.ImageOptions.SvgImage")));
            this.btnYenile.Location = new System.Drawing.Point(1303, 45);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(151, 47);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-7, -213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 362);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // OrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 802);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.Name = "OrderScreen";
            this.Text = "Sipariş Ekranı";
            this.Load += new System.EventHandler(this.OrderScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqwOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tabEkran.ResumeLayout(false);
            this.tabNotes.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dqwOrders;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        public System.Windows.Forms.FlowLayoutPanel flp;
        private DevExpress.XtraEditors.SimpleButton BtnTableList;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tabEkran;
        private DevExpress.XtraTab.XtraTabPage tabNotes;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.RichTextBox rtbxNotes;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}