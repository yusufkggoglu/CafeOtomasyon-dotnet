namespace Forms
{
    partial class PaymentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentScreen));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNakit = new DevExpress.XtraEditors.SimpleButton();
            this.btnKart = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.dqwOrders = new System.Windows.Forms.DataGridView();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnNakit);
            this.groupBox2.Controls.Add(this.btnKart);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.tbxPrice);
            this.groupBox2.Controls.Add(this.dqwOrders);
            this.groupBox2.Location = new System.Drawing.Point(846, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 756);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnNakit
            // 
            this.btnNakit.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNakit.Appearance.Options.UseFont = true;
            this.btnNakit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNakit.ImageOptions.SvgImage")));
            this.btnNakit.Location = new System.Drawing.Point(119, 352);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(186, 74);
            this.btnNakit.TabIndex = 5;
            this.btnNakit.Text = "Nakit";
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // btnKart
            // 
            this.btnKart.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKart.Appearance.Options.UseFont = true;
            this.btnKart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKart.ImageOptions.SvgImage")));
            this.btnKart.Location = new System.Drawing.Point(311, 352);
            this.btnKart.Name = "btnKart";
            this.btnKart.Size = new System.Drawing.Size(186, 74);
            this.btnKart.TabIndex = 4;
            this.btnKart.Text = "Kredi Kartı";
            this.btnKart.Click += new System.EventHandler(this.btnKart_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 256);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(221, 54);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Ürün Sil";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Enabled = false;
            this.tbxPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPrice.Location = new System.Drawing.Point(406, 256);
            this.tbxPrice.Multiline = true;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(196, 54);
            this.tbxPrice.TabIndex = 2;
            // 
            // dqwOrders
            // 
            this.dqwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwOrders.Location = new System.Drawing.Point(6, 22);
            this.dqwOrders.Name = "dqwOrders";
            this.dqwOrders.RowTemplate.Height = 24;
            this.dqwOrders.Size = new System.Drawing.Size(596, 219);
            this.dqwOrders.TabIndex = 1;
            // 
            // flp
            // 
            this.flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp.AutoScroll = true;
            this.flp.Location = new System.Drawing.Point(10, 80);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(825, 699);
            this.flp.TabIndex = 9;
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenile.ImageOptions.SvgImage")));
            this.btnYenile.Location = new System.Drawing.Point(12, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(151, 47);
            this.btnYenile.TabIndex = 6;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 802);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flp);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "PaymentScreen";
            this.Text = "Ödeme Ekranı";
            this.Load += new System.EventHandler(this.PaymentScreen_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnNakit;
        private DevExpress.XtraEditors.SimpleButton btnKart;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.DataGridView dqwOrders;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
    }
}