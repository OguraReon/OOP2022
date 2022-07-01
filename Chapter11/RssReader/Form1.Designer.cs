
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.btRssGet = new System.Windows.Forms.Button();
            this.lbRssTitle1 = new System.Windows.Forms.ListBox();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(23, 34);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(563, 20);
            this.cbRssUrl.TabIndex = 0;
            // 
            // btRssGet
            // 
            this.btRssGet.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRssGet.Location = new System.Drawing.Point(613, 12);
            this.btRssGet.Name = "btRssGet";
            this.btRssGet.Size = new System.Drawing.Size(75, 53);
            this.btRssGet.TabIndex = 1;
            this.btRssGet.Text = "取得";
            this.btRssGet.UseVisualStyleBackColor = true;
            this.btRssGet.Click += new System.EventHandler(this.btRssGet_Click);
            // 
            // lbRssTitle1
            // 
            this.lbRssTitle1.FormattingEnabled = true;
            this.lbRssTitle1.ItemHeight = 12;
            this.lbRssTitle1.Location = new System.Drawing.Point(23, 75);
            this.lbRssTitle1.Name = "lbRssTitle1";
            this.lbRssTitle1.Size = new System.Drawing.Size(831, 112);
            this.lbRssTitle1.TabIndex = 2;
            this.lbRssTitle1.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle1_SelectedIndexChanged);
            // 
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(23, 193);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.ScriptErrorsSuppressed = true;
            this.wb.Size = new System.Drawing.Size(831, 332);
            this.wb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 537);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.lbRssTitle1);
            this.Controls.Add(this.btRssGet);
            this.Controls.Add(this.cbRssUrl);
            this.Name = "Form1";
            this.Text = "RSSReader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.Button btRssGet;
        private System.Windows.Forms.ListBox lbRssTitle1;
        private System.Windows.Forms.WebBrowser wb;
    }
}

