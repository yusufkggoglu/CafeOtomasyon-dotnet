namespace Forms
{
    partial class PaymentHistoryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentHistoryScreen));
            this.dqwPayments = new System.Windows.Forms.DataGridView();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbxToplam = new System.Windows.Forms.TextBox();
            this.tbxKart = new System.Windows.Forms.TextBox();
            this.tbxNakit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dqwPayments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dqwPayments
            // 
            this.dqwPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwPayments.Location = new System.Drawing.Point(12, 65);
            this.dqwPayments.Name = "dqwPayments";
            this.dqwPayments.RowTemplate.Height = 24;
            this.dqwPayments.Size = new System.Drawing.Size(1024, 726);
            this.dqwPayments.TabIndex = 4;
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenile.ImageOptions.SvgImage")));
            this.btnYenile.Location = new System.Drawing.Point(12, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(151, 47);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 33);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Toplam";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 33);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Kart";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 207);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 33);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Nakit";
            // 
            // tbxToplam
            // 
            this.tbxToplam.Enabled = false;
            this.tbxToplam.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxToplam.Location = new System.Drawing.Point(15, 48);
            this.tbxToplam.Multiline = true;
            this.tbxToplam.Name = "tbxToplam";
            this.tbxToplam.Size = new System.Drawing.Size(285, 54);
            this.tbxToplam.TabIndex = 11;
            // 
            // tbxKart
            // 
            this.tbxKart.Enabled = false;
            this.tbxKart.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKart.Location = new System.Drawing.Point(15, 147);
            this.tbxKart.Multiline = true;
            this.tbxKart.Name = "tbxKart";
            this.tbxKart.Size = new System.Drawing.Size(285, 54);
            this.tbxKart.TabIndex = 12;
            // 
            // tbxNakit
            // 
            this.tbxNakit.Enabled = false;
            this.tbxNakit.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNakit.Location = new System.Drawing.Point(15, 246);
            this.tbxNakit.Multiline = true;
            this.tbxNakit.Name = "tbxNakit";
            this.tbxNakit.Size = new System.Drawing.Size(285, 54);
            this.tbxNakit.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tbxNakit);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.tbxKart);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.tbxToplam);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(1042, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 708);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTemizle.ImageOptions.SvgImage")));
            this.btnTemizle.Location = new System.Drawing.Point(15, 371);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(285, 47);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(15, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(285, 47);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Excell\'e Aktar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PaymentHistoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 803);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dqwPayments);
            this.Name = "PaymentHistoryScreen";
            this.Text = "Ödeme Geçmişi Ekranı";
            this.Load += new System.EventHandler(this.PaymentHistoryScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqwPayments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dqwPayments;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox tbxToplam;
        private System.Windows.Forms.TextBox tbxKart;
        private System.Windows.Forms.TextBox tbxNakit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}