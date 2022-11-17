
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
            this.weatherInfo = new System.Windows.Forms.TextBox();
            this.weatherGet = new System.Windows.Forms.Button();
            this.cb_areaList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.office = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.areaCode_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weatherInfo
            // 
            this.weatherInfo.Location = new System.Drawing.Point(12, 172);
            this.weatherInfo.Multiline = true;
            this.weatherInfo.Name = "weatherInfo";
            this.weatherInfo.Size = new System.Drawing.Size(572, 266);
            this.weatherInfo.TabIndex = 0;
            // 
            // weatherGet
            // 
            this.weatherGet.Location = new System.Drawing.Point(12, 12);
            this.weatherGet.Name = "weatherGet";
            this.weatherGet.Size = new System.Drawing.Size(128, 99);
            this.weatherGet.TabIndex = 1;
            this.weatherGet.Text = "取得";
            this.weatherGet.UseVisualStyleBackColor = true;
            this.weatherGet.Click += new System.EventHandler(this.weatherGet_Click);
            // 
            // cb_areaList
            // 
            this.cb_areaList.FormattingEnabled = true;
            this.cb_areaList.Location = new System.Drawing.Point(261, 91);
            this.cb_areaList.Name = "cb_areaList";
            this.cb_areaList.Size = new System.Drawing.Size(121, 20);
            this.cb_areaList.TabIndex = 2;
            this.cb_areaList.SelectedIndexChanged += new System.EventHandler(this.cb_areaList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
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
            this.label2.Location = new System.Drawing.Point(149, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "発信場所";
            // 
            // office
            // 
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
            this.label3.Location = new System.Drawing.Point(149, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "発信日";
            // 
            // dateTimeText
            // 
            this.dateTimeText.Location = new System.Drawing.Point(261, 51);
            this.dateTimeText.Multiline = true;
            this.dateTimeText.Name = "dateTimeText";
            this.dateTimeText.Size = new System.Drawing.Size(157, 24);
            this.dateTimeText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "天気概要";
            // 
            // areaCode_Text
            // 
            this.areaCode_Text.Location = new System.Drawing.Point(523, 91);
            this.areaCode_Text.Name = "areaCode_Text";
            this.areaCode_Text.Size = new System.Drawing.Size(157, 19);
            this.areaCode_Text.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(388, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "エリアコード";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.areaCode_Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.office);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_areaList);
            this.Controls.Add(this.weatherGet);
            this.Controls.Add(this.weatherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weatherInfo;
        private System.Windows.Forms.Button weatherGet;
        private System.Windows.Forms.ComboBox cb_areaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox office;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateTimeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox areaCode_Text;
        private System.Windows.Forms.Label label5;
    }
}

