
namespace WeatherApp {
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
            this.weatherGet = new System.Windows.Forms.Button();
            this.cb_areaList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.office = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.wetherPicture = new System.Windows.Forms.PictureBox();
            this.date_select = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wetherInfo = new System.Windows.Forms.Label();
            this.weekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // weatherGet
            // 
            this.weatherGet.BackColor = System.Drawing.Color.Snow;
            this.weatherGet.Font = new System.Drawing.Font("ＭＳ ゴシック", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weatherGet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.weatherGet.Location = new System.Drawing.Point(12, 12);
            this.weatherGet.Name = "weatherGet";
            this.weatherGet.Size = new System.Drawing.Size(128, 99);
            this.weatherGet.TabIndex = 1;
            this.weatherGet.Text = "取得";
            this.weatherGet.UseVisualStyleBackColor = false;
            this.weatherGet.Click += new System.EventHandler(this.weatherGet_Click);
            // 
            // cb_areaList
            // 
            this.cb_areaList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cb_areaList.FormattingEnabled = true;
            this.cb_areaList.Location = new System.Drawing.Point(261, 91);
            this.cb_areaList.Name = "cb_areaList";
            this.cb_areaList.Size = new System.Drawing.Size(230, 27);
            this.cb_areaList.TabIndex = 2;
            this.cb_areaList.SelectedIndexChanged += new System.EventHandler(this.cb_areaList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(149, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "地域名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(149, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "発信場所";
            // 
            // office
            // 
            this.office.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.office.Location = new System.Drawing.Point(261, 12);
            this.office.Multiline = true;
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(157, 24);
            this.office.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(149, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "発信日";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.todayLabel.ForeColor = System.Drawing.Color.Snow;
            this.todayLabel.Location = new System.Drawing.Point(6, 134);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(105, 35);
            this.todayLabel.TabIndex = 9;
            this.todayLabel.Text = "Today";
            // 
            // wetherPicture
            // 
            this.wetherPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wetherPicture.Location = new System.Drawing.Point(497, 43);
            this.wetherPicture.Name = "wetherPicture";
            this.wetherPicture.Size = new System.Drawing.Size(121, 75);
            this.wetherPicture.TabIndex = 10;
            this.wetherPicture.TabStop = false;
            // 
            // date_select
            // 
            this.date_select.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date_select.FormattingEnabled = true;
            this.date_select.Location = new System.Drawing.Point(261, 51);
            this.date_select.Name = "date_select";
            this.date_select.Size = new System.Drawing.Size(157, 27);
            this.date_select.TabIndex = 11;
            this.date_select.SelectedIndexChanged += new System.EventHandler(this.date_select_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(492, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "お天気マーク";
            // 
            // wetherInfo
            // 
            this.wetherInfo.AutoSize = true;
            this.wetherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.wetherInfo.ForeColor = System.Drawing.Color.Snow;
            this.wetherInfo.Location = new System.Drawing.Point(12, 180);
            this.wetherInfo.Name = "wetherInfo";
            this.wetherInfo.Size = new System.Drawing.Size(0, 16);
            this.wetherInfo.TabIndex = 14;
            // 
            // weekLabel
            // 
            this.weekLabel.AutoSize = true;
            this.weekLabel.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weekLabel.ForeColor = System.Drawing.Color.Snow;
            this.weekLabel.Location = new System.Drawing.Point(166, 134);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(97, 35);
            this.weekLabel.TabIndex = 15;
            this.weekLabel.Text = "Week";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 469);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.wetherInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_select);
            this.Controls.Add(this.wetherPicture);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.office);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_areaList);
            this.Controls.Add(this.weatherGet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "天気アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button weatherGet;
        private System.Windows.Forms.ComboBox cb_areaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox office;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.PictureBox wetherPicture;
        private System.Windows.Forms.ComboBox date_select;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wetherInfo;
        private System.Windows.Forms.Label weekLabel;
    }
}

