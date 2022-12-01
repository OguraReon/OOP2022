
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
            this.label3 = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.wetherPicture1 = new System.Windows.Forms.PictureBox();
            this.date_select = new System.Windows.Forms.ComboBox();
            this.wetherInfo = new System.Windows.Forms.Label();
            this.weekLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tomorrowLabel = new System.Windows.Forms.Label();
            this.minTempLabel = new System.Windows.Forms.Label();
            this.MinTemp1 = new System.Windows.Forms.Label();
            this.maxTempLabel = new System.Windows.Forms.Label();
            this.MaxTemp1 = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.windInfo = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.date5 = new System.Windows.Forms.Label();
            this.date6 = new System.Windows.Forms.Label();
            this.date7 = new System.Windows.Forms.Label();
            this.wetherPicture2 = new System.Windows.Forms.PictureBox();
            this.wetherPicture3 = new System.Windows.Forms.PictureBox();
            this.wetherPicture4 = new System.Windows.Forms.PictureBox();
            this.wetherPicture5 = new System.Windows.Forms.PictureBox();
            this.wetherPicture6 = new System.Windows.Forms.PictureBox();
            this.wetherPicture7 = new System.Windows.Forms.PictureBox();
            this.MinTemp2 = new System.Windows.Forms.Label();
            this.MinTemp3 = new System.Windows.Forms.Label();
            this.MinTemp4 = new System.Windows.Forms.Label();
            this.MinTemp5 = new System.Windows.Forms.Label();
            this.MinTemp6 = new System.Windows.Forms.Label();
            this.MinTemp7 = new System.Windows.Forms.Label();
            this.MaxTemp2 = new System.Windows.Forms.Label();
            this.MaxTemp3 = new System.Windows.Forms.Label();
            this.MaxTemp4 = new System.Windows.Forms.Label();
            this.MaxTemp5 = new System.Windows.Forms.Label();
            this.MaxTemp6 = new System.Windows.Forms.Label();
            this.MaxTemp7 = new System.Windows.Forms.Label();
            this.popsLabel = new System.Windows.Forms.Label();
            this.pops1 = new System.Windows.Forms.Label();
            this.pops2 = new System.Windows.Forms.Label();
            this.pops3 = new System.Windows.Forms.Label();
            this.pops4 = new System.Windows.Forms.Label();
            this.pops5 = new System.Windows.Forms.Label();
            this.pops6 = new System.Windows.Forms.Label();
            this.pops7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.天気図選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ひまわりToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ひまわり日本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.雨雲レーダーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture7)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherGet
            // 
            this.weatherGet.BackColor = System.Drawing.Color.Snow;
            this.weatherGet.Font = new System.Drawing.Font("ＭＳ ゴシック", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weatherGet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.weatherGet.Location = new System.Drawing.Point(317, 63);
            this.weatherGet.Name = "weatherGet";
            this.weatherGet.Size = new System.Drawing.Size(87, 66);
            this.weatherGet.TabIndex = 1;
            this.weatherGet.Text = "取得";
            this.weatherGet.UseVisualStyleBackColor = false;
            this.weatherGet.Click += new System.EventHandler(this.weatherGet_Click);
            // 
            // cb_areaList
            // 
            this.cb_areaList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cb_areaList.FormattingEnabled = true;
            this.cb_areaList.Location = new System.Drawing.Point(70, 102);
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
            this.label1.Location = new System.Drawing.Point(10, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "地域";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "日時";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.todayLabel.ForeColor = System.Drawing.Color.Snow;
            this.todayLabel.Location = new System.Drawing.Point(120, 133);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(105, 35);
            this.todayLabel.TabIndex = 9;
            this.todayLabel.Text = "Today";
            // 
            // wetherPicture1
            // 
            this.wetherPicture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wetherPicture1.Location = new System.Drawing.Point(126, 225);
            this.wetherPicture1.Name = "wetherPicture1";
            this.wetherPicture1.Size = new System.Drawing.Size(94, 61);
            this.wetherPicture1.TabIndex = 10;
            this.wetherPicture1.TabStop = false;
            // 
            // date_select
            // 
            this.date_select.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date_select.FormattingEnabled = true;
            this.date_select.Location = new System.Drawing.Point(70, 69);
            this.date_select.Name = "date_select";
            this.date_select.Size = new System.Drawing.Size(157, 26);
            this.date_select.TabIndex = 11;
            this.date_select.SelectedIndexChanged += new System.EventHandler(this.date_select_SelectedIndexChanged);
            // 
            // wetherInfo
            // 
            this.wetherInfo.AutoSize = true;
            this.wetherInfo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.wetherInfo.ForeColor = System.Drawing.Color.Snow;
            this.wetherInfo.Location = new System.Drawing.Point(10, 444);
            this.wetherInfo.Name = "wetherInfo";
            this.wetherInfo.Size = new System.Drawing.Size(0, 16);
            this.wetherInfo.TabIndex = 14;
            // 
            // weekLabel
            // 
            this.weekLabel.AutoSize = true;
            this.weekLabel.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weekLabel.ForeColor = System.Drawing.Color.Snow;
            this.weekLabel.Location = new System.Drawing.Point(404, 133);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(97, 35);
            this.weekLabel.TabIndex = 15;
            this.weekLabel.Text = "Week";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "表示したい日時と地域を選択";
            // 
            // tomorrowLabel
            // 
            this.tomorrowLabel.AutoSize = true;
            this.tomorrowLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tomorrowLabel.ForeColor = System.Drawing.Color.Snow;
            this.tomorrowLabel.Location = new System.Drawing.Point(225, 133);
            this.tomorrowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tomorrowLabel.Name = "tomorrowLabel";
            this.tomorrowLabel.Size = new System.Drawing.Size(167, 35);
            this.tomorrowLabel.TabIndex = 17;
            this.tomorrowLabel.Text = "Tomorrow";
            // 
            // minTempLabel
            // 
            this.minTempLabel.AutoSize = true;
            this.minTempLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minTempLabel.ForeColor = System.Drawing.Color.Snow;
            this.minTempLabel.Location = new System.Drawing.Point(9, 288);
            this.minTempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minTempLabel.Name = "minTempLabel";
            this.minTempLabel.Size = new System.Drawing.Size(110, 24);
            this.minTempLabel.TabIndex = 18;
            this.minTempLabel.Text = "最低気温";
            // 
            // MinTemp1
            // 
            this.MinTemp1.AutoSize = true;
            this.MinTemp1.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinTemp1.ForeColor = System.Drawing.Color.Snow;
            this.MinTemp1.Location = new System.Drawing.Point(121, 288);
            this.MinTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinTemp1.Name = "MinTemp1";
            this.MinTemp1.Size = new System.Drawing.Size(0, 30);
            this.MinTemp1.TabIndex = 19;
            // 
            // maxTempLabel
            // 
            this.maxTempLabel.AutoSize = true;
            this.maxTempLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxTempLabel.ForeColor = System.Drawing.Color.Snow;
            this.maxTempLabel.Location = new System.Drawing.Point(8, 330);
            this.maxTempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxTempLabel.Name = "maxTempLabel";
            this.maxTempLabel.Size = new System.Drawing.Size(110, 24);
            this.maxTempLabel.TabIndex = 20;
            this.maxTempLabel.Text = "最高気温";
            // 
            // MaxTemp1
            // 
            this.MaxTemp1.AutoSize = true;
            this.MaxTemp1.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxTemp1.ForeColor = System.Drawing.Color.Snow;
            this.MaxTemp1.Location = new System.Drawing.Point(121, 330);
            this.MaxTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxTemp1.Name = "MaxTemp1";
            this.MaxTemp1.Size = new System.Drawing.Size(0, 30);
            this.MaxTemp1.TabIndex = 21;
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.windLabel.ForeColor = System.Drawing.Color.Snow;
            this.windLabel.Location = new System.Drawing.Point(9, 369);
            this.windLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(85, 24);
            this.windLabel.TabIndex = 22;
            this.windLabel.Text = "風向き";
            // 
            // windInfo
            // 
            this.windInfo.AutoSize = true;
            this.windInfo.Font = new System.Drawing.Font("ＭＳ ゴシック", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.windInfo.ForeColor = System.Drawing.Color.Snow;
            this.windInfo.Location = new System.Drawing.Point(110, 371);
            this.windInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.windInfo.Name = "windInfo";
            this.windInfo.Size = new System.Drawing.Size(0, 22);
            this.windInfo.TabIndex = 23;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date1.ForeColor = System.Drawing.Color.Snow;
            this.date1.Location = new System.Drawing.Point(127, 186);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(0, 35);
            this.date1.TabIndex = 24;
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date2.ForeColor = System.Drawing.Color.Snow;
            this.date2.Location = new System.Drawing.Point(232, 186);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(0, 35);
            this.date2.TabIndex = 25;
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date3.ForeColor = System.Drawing.Color.Snow;
            this.date3.Location = new System.Drawing.Point(350, 186);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(0, 35);
            this.date3.TabIndex = 26;
            // 
            // date4
            // 
            this.date4.AutoSize = true;
            this.date4.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date4.ForeColor = System.Drawing.Color.Snow;
            this.date4.Location = new System.Drawing.Point(476, 186);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(0, 35);
            this.date4.TabIndex = 27;
            // 
            // date5
            // 
            this.date5.AutoSize = true;
            this.date5.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date5.ForeColor = System.Drawing.Color.Snow;
            this.date5.Location = new System.Drawing.Point(608, 186);
            this.date5.Name = "date5";
            this.date5.Size = new System.Drawing.Size(0, 35);
            this.date5.TabIndex = 28;
            // 
            // date6
            // 
            this.date6.AutoSize = true;
            this.date6.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date6.ForeColor = System.Drawing.Color.Snow;
            this.date6.Location = new System.Drawing.Point(717, 186);
            this.date6.Name = "date6";
            this.date6.Size = new System.Drawing.Size(0, 35);
            this.date6.TabIndex = 29;
            // 
            // date7
            // 
            this.date7.AutoSize = true;
            this.date7.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.date7.ForeColor = System.Drawing.Color.Snow;
            this.date7.Location = new System.Drawing.Point(840, 186);
            this.date7.Name = "date7";
            this.date7.Size = new System.Drawing.Size(0, 35);
            this.date7.TabIndex = 30;
            // 
            // wetherPicture2
            // 
            this.wetherPicture2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wetherPicture2.Location = new System.Drawing.Point(238, 225);
            this.wetherPicture2.Name = "wetherPicture2";
            this.wetherPicture2.Size = new System.Drawing.Size(94, 61);
            this.wetherPicture2.TabIndex = 31;
            this.wetherPicture2.TabStop = false;
            // 
            // wetherPicture3
            // 
            this.wetherPicture3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wetherPicture3.Location = new System.Drawing.Point(356, 225);
            this.wetherPicture3.Name = "wetherPicture3";
            this.wetherPicture3.Size = new System.Drawing.Size(94, 61);
            this.wetherPicture3.TabIndex = 32;
            this.wetherPicture3.TabStop = false;
            // 
            // wetherPicture4
            // 
            this.wetherPicture4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wetherPicture4.Location = new System.Drawing.Point(482, 225);
            this.wetherPicture4.Name = "wetherPicture4";
            this.wetherPicture4.Size = new System.Drawing.Size(94, 61);
            this.wetherPicture4.TabIndex = 33;
            this.wetherPicture4.TabStop = false;
            // 
            // wetherPicture5
            // 
            this.wetherPicture5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wetherPicture5.Location = new System.Drawing.Point(608, 225);
            this.wetherPicture5.Name = "wetherPicture5";
            this.wetherPicture5.Size = new System.Drawing.Size(94, 61);
            this.wetherPicture5.TabIndex = 34;
            this.wetherPicture5.TabStop = false;
            // 
            // wetherPicture6
            // 
            this.wetherPicture6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wetherPicture6.Location = new System.Drawing.Point(723, 225);
            this.wetherPicture6.Name = "wetherPicture6";
            this.wetherPicture6.Size = new System.Drawing.Size(94, 61);
            this.wetherPicture6.TabIndex = 35;
            this.wetherPicture6.TabStop = false;
            // 
            // wetherPicture7
            // 
            this.wetherPicture7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wetherPicture7.Location = new System.Drawing.Point(846, 225);
            this.wetherPicture7.Name = "wetherPicture7";
            this.wetherPicture7.Size = new System.Drawing.Size(94, 61);
            this.wetherPicture7.TabIndex = 36;
            this.wetherPicture7.TabStop = false;
            // 
            // MinTemp2
            // 
            this.MinTemp2.AutoSize = true;
            this.MinTemp2.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinTemp2.ForeColor = System.Drawing.Color.Snow;
            this.MinTemp2.Location = new System.Drawing.Point(233, 288);
            this.MinTemp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinTemp2.Name = "MinTemp2";
            this.MinTemp2.Size = new System.Drawing.Size(0, 30);
            this.MinTemp2.TabIndex = 37;
            // 
            // MinTemp3
            // 
            this.MinTemp3.AutoSize = true;
            this.MinTemp3.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinTemp3.ForeColor = System.Drawing.Color.Snow;
            this.MinTemp3.Location = new System.Drawing.Point(356, 288);
            this.MinTemp3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinTemp3.Name = "MinTemp3";
            this.MinTemp3.Size = new System.Drawing.Size(0, 30);
            this.MinTemp3.TabIndex = 38;
            // 
            // MinTemp4
            // 
            this.MinTemp4.AutoSize = true;
            this.MinTemp4.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinTemp4.ForeColor = System.Drawing.Color.Snow;
            this.MinTemp4.Location = new System.Drawing.Point(478, 288);
            this.MinTemp4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinTemp4.Name = "MinTemp4";
            this.MinTemp4.Size = new System.Drawing.Size(0, 30);
            this.MinTemp4.TabIndex = 39;
            // 
            // MinTemp5
            // 
            this.MinTemp5.AutoSize = true;
            this.MinTemp5.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinTemp5.ForeColor = System.Drawing.Color.Snow;
            this.MinTemp5.Location = new System.Drawing.Point(603, 288);
            this.MinTemp5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinTemp5.Name = "MinTemp5";
            this.MinTemp5.Size = new System.Drawing.Size(0, 30);
            this.MinTemp5.TabIndex = 40;
            // 
            // MinTemp6
            // 
            this.MinTemp6.AutoSize = true;
            this.MinTemp6.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinTemp6.ForeColor = System.Drawing.Color.Snow;
            this.MinTemp6.Location = new System.Drawing.Point(718, 288);
            this.MinTemp6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinTemp6.Name = "MinTemp6";
            this.MinTemp6.Size = new System.Drawing.Size(0, 30);
            this.MinTemp6.TabIndex = 41;
            // 
            // MinTemp7
            // 
            this.MinTemp7.AutoSize = true;
            this.MinTemp7.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinTemp7.ForeColor = System.Drawing.Color.Snow;
            this.MinTemp7.Location = new System.Drawing.Point(840, 288);
            this.MinTemp7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinTemp7.Name = "MinTemp7";
            this.MinTemp7.Size = new System.Drawing.Size(0, 30);
            this.MinTemp7.TabIndex = 42;
            // 
            // MaxTemp2
            // 
            this.MaxTemp2.AutoSize = true;
            this.MaxTemp2.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxTemp2.ForeColor = System.Drawing.Color.Snow;
            this.MaxTemp2.Location = new System.Drawing.Point(233, 330);
            this.MaxTemp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxTemp2.Name = "MaxTemp2";
            this.MaxTemp2.Size = new System.Drawing.Size(0, 30);
            this.MaxTemp2.TabIndex = 43;
            // 
            // MaxTemp3
            // 
            this.MaxTemp3.AutoSize = true;
            this.MaxTemp3.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxTemp3.ForeColor = System.Drawing.Color.Snow;
            this.MaxTemp3.Location = new System.Drawing.Point(356, 330);
            this.MaxTemp3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxTemp3.Name = "MaxTemp3";
            this.MaxTemp3.Size = new System.Drawing.Size(0, 30);
            this.MaxTemp3.TabIndex = 44;
            // 
            // MaxTemp4
            // 
            this.MaxTemp4.AutoSize = true;
            this.MaxTemp4.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxTemp4.ForeColor = System.Drawing.Color.Snow;
            this.MaxTemp4.Location = new System.Drawing.Point(477, 330);
            this.MaxTemp4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxTemp4.Name = "MaxTemp4";
            this.MaxTemp4.Size = new System.Drawing.Size(0, 30);
            this.MaxTemp4.TabIndex = 45;
            // 
            // MaxTemp5
            // 
            this.MaxTemp5.AutoSize = true;
            this.MaxTemp5.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxTemp5.ForeColor = System.Drawing.Color.Snow;
            this.MaxTemp5.Location = new System.Drawing.Point(603, 330);
            this.MaxTemp5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxTemp5.Name = "MaxTemp5";
            this.MaxTemp5.Size = new System.Drawing.Size(0, 30);
            this.MaxTemp5.TabIndex = 46;
            // 
            // MaxTemp6
            // 
            this.MaxTemp6.AutoSize = true;
            this.MaxTemp6.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxTemp6.ForeColor = System.Drawing.Color.Snow;
            this.MaxTemp6.Location = new System.Drawing.Point(718, 330);
            this.MaxTemp6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxTemp6.Name = "MaxTemp6";
            this.MaxTemp6.Size = new System.Drawing.Size(0, 30);
            this.MaxTemp6.TabIndex = 47;
            // 
            // MaxTemp7
            // 
            this.MaxTemp7.AutoSize = true;
            this.MaxTemp7.Font = new System.Drawing.Font("ＭＳ ゴシック", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxTemp7.ForeColor = System.Drawing.Color.Snow;
            this.MaxTemp7.Location = new System.Drawing.Point(841, 330);
            this.MaxTemp7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxTemp7.Name = "MaxTemp7";
            this.MaxTemp7.Size = new System.Drawing.Size(0, 30);
            this.MaxTemp7.TabIndex = 48;
            // 
            // popsLabel
            // 
            this.popsLabel.AutoSize = true;
            this.popsLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.popsLabel.ForeColor = System.Drawing.Color.Snow;
            this.popsLabel.Location = new System.Drawing.Point(8, 410);
            this.popsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popsLabel.Name = "popsLabel";
            this.popsLabel.Size = new System.Drawing.Size(110, 24);
            this.popsLabel.TabIndex = 49;
            this.popsLabel.Text = "降水確率";
            // 
            // pops1
            // 
            this.pops1.AutoSize = true;
            this.pops1.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pops1.ForeColor = System.Drawing.Color.Snow;
            this.pops1.Location = new System.Drawing.Point(129, 410);
            this.pops1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pops1.Name = "pops1";
            this.pops1.Size = new System.Drawing.Size(0, 24);
            this.pops1.TabIndex = 50;
            // 
            // pops2
            // 
            this.pops2.AutoSize = true;
            this.pops2.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pops2.ForeColor = System.Drawing.Color.Snow;
            this.pops2.Location = new System.Drawing.Point(235, 410);
            this.pops2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pops2.Name = "pops2";
            this.pops2.Size = new System.Drawing.Size(0, 24);
            this.pops2.TabIndex = 51;
            // 
            // pops3
            // 
            this.pops3.AutoSize = true;
            this.pops3.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pops3.ForeColor = System.Drawing.Color.Snow;
            this.pops3.Location = new System.Drawing.Point(357, 410);
            this.pops3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pops3.Name = "pops3";
            this.pops3.Size = new System.Drawing.Size(0, 24);
            this.pops3.TabIndex = 52;
            // 
            // pops4
            // 
            this.pops4.AutoSize = true;
            this.pops4.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pops4.ForeColor = System.Drawing.Color.Snow;
            this.pops4.Location = new System.Drawing.Point(478, 410);
            this.pops4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pops4.Name = "pops4";
            this.pops4.Size = new System.Drawing.Size(0, 24);
            this.pops4.TabIndex = 53;
            // 
            // pops5
            // 
            this.pops5.AutoSize = true;
            this.pops5.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pops5.ForeColor = System.Drawing.Color.Snow;
            this.pops5.Location = new System.Drawing.Point(604, 410);
            this.pops5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pops5.Name = "pops5";
            this.pops5.Size = new System.Drawing.Size(0, 24);
            this.pops5.TabIndex = 54;
            // 
            // pops6
            // 
            this.pops6.AutoSize = true;
            this.pops6.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pops6.ForeColor = System.Drawing.Color.Snow;
            this.pops6.Location = new System.Drawing.Point(719, 410);
            this.pops6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pops6.Name = "pops6";
            this.pops6.Size = new System.Drawing.Size(0, 24);
            this.pops6.TabIndex = 55;
            // 
            // pops7
            // 
            this.pops7.AutoSize = true;
            this.pops7.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pops7.ForeColor = System.Drawing.Color.Snow;
            this.pops7.Location = new System.Drawing.Point(842, 410);
            this.pops7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pops7.Name = "pops7";
            this.pops7.Size = new System.Drawing.Size(0, 24);
            this.pops7.TabIndex = 56;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.天気図選択ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 24);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 天気図選択ToolStripMenuItem
            // 
            this.天気図選択ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ひまわりToolStripMenuItem,
            this.ひまわり日本ToolStripMenuItem,
            this.雨雲レーダーToolStripMenuItem});
            this.天気図選択ToolStripMenuItem.Name = "天気図選択ToolStripMenuItem";
            this.天気図選択ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.天気図選択ToolStripMenuItem.Text = "天気図選択";
            // 
            // ひまわりToolStripMenuItem
            // 
            this.ひまわりToolStripMenuItem.Name = "ひまわりToolStripMenuItem";
            this.ひまわりToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ひまわりToolStripMenuItem.Text = "ひまわり（フルディスク）";
            this.ひまわりToolStripMenuItem.Click += new System.EventHandler(this.ひまわりToolStripMenuItem_Click);
            // 
            // ひまわり日本ToolStripMenuItem
            // 
            this.ひまわり日本ToolStripMenuItem.Name = "ひまわり日本ToolStripMenuItem";
            this.ひまわり日本ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ひまわり日本ToolStripMenuItem.Text = "ひまわり（日本付近）";
            // 
            // 雨雲レーダーToolStripMenuItem
            // 
            this.雨雲レーダーToolStripMenuItem.Name = "雨雲レーダーToolStripMenuItem";
            this.雨雲レーダーToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.雨雲レーダーToolStripMenuItem.Text = "雨雲レーダー";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1073, 702);
            this.Controls.Add(this.pops7);
            this.Controls.Add(this.pops6);
            this.Controls.Add(this.pops5);
            this.Controls.Add(this.pops4);
            this.Controls.Add(this.pops3);
            this.Controls.Add(this.pops2);
            this.Controls.Add(this.pops1);
            this.Controls.Add(this.popsLabel);
            this.Controls.Add(this.MaxTemp7);
            this.Controls.Add(this.MaxTemp6);
            this.Controls.Add(this.MaxTemp5);
            this.Controls.Add(this.MaxTemp4);
            this.Controls.Add(this.MaxTemp3);
            this.Controls.Add(this.MaxTemp2);
            this.Controls.Add(this.MinTemp7);
            this.Controls.Add(this.MinTemp6);
            this.Controls.Add(this.MinTemp5);
            this.Controls.Add(this.MinTemp4);
            this.Controls.Add(this.MinTemp3);
            this.Controls.Add(this.MinTemp2);
            this.Controls.Add(this.wetherPicture7);
            this.Controls.Add(this.wetherPicture6);
            this.Controls.Add(this.wetherPicture5);
            this.Controls.Add(this.wetherPicture4);
            this.Controls.Add(this.wetherPicture3);
            this.Controls.Add(this.wetherPicture2);
            this.Controls.Add(this.date7);
            this.Controls.Add(this.date6);
            this.Controls.Add(this.date5);
            this.Controls.Add(this.date4);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.windInfo);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.MaxTemp1);
            this.Controls.Add(this.maxTempLabel);
            this.Controls.Add(this.MinTemp1);
            this.Controls.Add(this.minTempLabel);
            this.Controls.Add(this.tomorrowLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.wetherInfo);
            this.Controls.Add(this.date_select);
            this.Controls.Add(this.wetherPicture1);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_areaList);
            this.Controls.Add(this.weatherGet);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "天気アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wetherPicture7)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button weatherGet;
        private System.Windows.Forms.ComboBox cb_areaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.PictureBox wetherPicture1;
        private System.Windows.Forms.ComboBox date_select;
        private System.Windows.Forms.Label wetherInfo;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tomorrowLabel;
        private System.Windows.Forms.Label minTempLabel;
        private System.Windows.Forms.Label MinTemp1;
        private System.Windows.Forms.Label maxTempLabel;
        private System.Windows.Forms.Label MaxTemp1;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label windInfo;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label date5;
        private System.Windows.Forms.Label date6;
        private System.Windows.Forms.Label date7;
        private System.Windows.Forms.PictureBox wetherPicture2;
        private System.Windows.Forms.PictureBox wetherPicture3;
        private System.Windows.Forms.PictureBox wetherPicture4;
        private System.Windows.Forms.PictureBox wetherPicture5;
        private System.Windows.Forms.PictureBox wetherPicture6;
        private System.Windows.Forms.PictureBox wetherPicture7;
        private System.Windows.Forms.Label MinTemp2;
        private System.Windows.Forms.Label MinTemp3;
        private System.Windows.Forms.Label MinTemp4;
        private System.Windows.Forms.Label MinTemp5;
        private System.Windows.Forms.Label MinTemp6;
        private System.Windows.Forms.Label MinTemp7;
        private System.Windows.Forms.Label MaxTemp2;
        private System.Windows.Forms.Label MaxTemp3;
        private System.Windows.Forms.Label MaxTemp4;
        private System.Windows.Forms.Label MaxTemp5;
        private System.Windows.Forms.Label MaxTemp6;
        private System.Windows.Forms.Label MaxTemp7;
        private System.Windows.Forms.Label popsLabel;
        private System.Windows.Forms.Label pops1;
        private System.Windows.Forms.Label pops2;
        private System.Windows.Forms.Label pops3;
        private System.Windows.Forms.Label pops4;
        private System.Windows.Forms.Label pops5;
        private System.Windows.Forms.Label pops6;
        private System.Windows.Forms.Label pops7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 天気図選択ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ひまわりToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ひまわり日本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 雨雲レーダーToolStripMenuItem;
    }
}

