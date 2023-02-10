namespace Forms
{
    partial class KitchenScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenScreen));
            this.dqwKitchen = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.rtbxNotes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dqwKitchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dqwKitchen
            // 
            this.dqwKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dqwKitchen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwKitchen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwKitchen.Location = new System.Drawing.Point(12, 12);
            this.dqwKitchen.Name = "dqwKitchen";
            this.dqwKitchen.RowTemplate.Height = 24;
            this.dqwKitchen.Size = new System.Drawing.Size(1148, 820);
            this.dqwKitchen.TabIndex = 4;
            this.dqwKitchen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwKitchen_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnAll);
            this.groupControl1.Controls.Add(this.rtbxNotes);
            this.groupControl1.Location = new System.Drawing.Point(1169, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(315, 820);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnAll
            // 
            this.btnAll.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAll.ImageOptions.SvgImage")));
            this.btnAll.Location = new System.Drawing.Point(73, 18);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(143, 48);
            this.btnAll.TabIndex = 16;
            this.btnAll.Text = "Yenile";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // rtbxNotes
            // 
            this.rtbxNotes.Enabled = false;
            this.rtbxNotes.Location = new System.Drawing.Point(16, 81);
            this.rtbxNotes.Name = "rtbxNotes";
            this.rtbxNotes.Size = new System.Drawing.Size(281, 393);
            this.rtbxNotes.TabIndex = 0;
            this.rtbxNotes.Text = "";
            // 
            // KitchenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 844);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dqwKitchen);
            this.Name = "KitchenScreen";
            this.Text = "Sipariş Listeleme Ekranı";
            this.Load += new System.EventHandler(this.KitchenScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqwKitchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dqwKitchen;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox rtbxNotes;
        private DevExpress.XtraEditors.SimpleButton btnAll;
    }
}