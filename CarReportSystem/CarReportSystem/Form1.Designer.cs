
namespace CarReportSystem {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textReport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonPicOpen = new System.Windows.Forms.Button();
            this.buttonPicDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbGaikokusya = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色の設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データベース接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogSelect = new System.Windows.Forms.ColorDialog();
            this.carReportDBDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202211DataSet = new CarReportSystem.infosys202211DataSet();
            this.carReportDBTableAdapter = new CarReportSystem.infosys202211DataSetTableAdapters.CarReportDBTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202211DataSetTableAdapters.TableAdapterManager();
            this.button_Update = new System.Windows.Forms.Button();
            this.bottun_SerchName = new System.Windows.Forms.Button();
            this.text_SerchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202211DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "記事者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(41, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "車名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(20, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "記事一覧：";
            // 
            // textReport
            // 
            this.textReport.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textReport.Location = new System.Drawing.Point(102, 244);
            this.textReport.Multiline = true;
            this.textReport.Name = "textReport";
            this.textReport.Size = new System.Drawing.Size(440, 184);
            this.textReport.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "メーカー：";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(102, 87);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(346, 20);
            this.cbAuthor.TabIndex = 3;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(102, 185);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(351, 20);
            this.cbCarName.TabIndex = 4;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonExit.Location = new System.Drawing.Point(853, 609);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 33);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "レポート：";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(106, 32);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker.TabIndex = 7;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(565, 87);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(313, 258);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // buttonPicOpen
            // 
            this.buttonPicOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPicOpen.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPicOpen.Location = new System.Drawing.Point(625, 48);
            this.buttonPicOpen.Name = "buttonPicOpen";
            this.buttonPicOpen.Size = new System.Drawing.Size(75, 33);
            this.buttonPicOpen.TabIndex = 5;
            this.buttonPicOpen.Text = "開く";
            this.buttonPicOpen.UseVisualStyleBackColor = true;
            this.buttonPicOpen.Click += new System.EventHandler(this.buttonPicOpen_Click);
            // 
            // buttonPicDelete
            // 
            this.buttonPicDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPicDelete.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonPicDelete.Location = new System.Drawing.Point(720, 48);
            this.buttonPicDelete.Name = "buttonPicDelete";
            this.buttonPicDelete.Size = new System.Drawing.Size(75, 33);
            this.buttonPicDelete.TabIndex = 5;
            this.buttonPicDelete.Text = "削除";
            this.buttonPicDelete.UseVisualStyleBackColor = true;
            this.buttonPicDelete.Click += new System.EventHandler(this.buttonPicDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdd.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Location = new System.Drawing.Point(565, 351);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 33);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelete.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDelete.Location = new System.Drawing.Point(565, 395);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 33);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(561, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像：";
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(102, 139);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 9;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(155, 139);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 9;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(208, 139);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 9;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(259, 139);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 9;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbGaikokusya
            // 
            this.rbGaikokusya.AutoSize = true;
            this.rbGaikokusya.Location = new System.Drawing.Point(312, 139);
            this.rbGaikokusya.Name = "rbGaikokusya";
            this.rbGaikokusya.Size = new System.Drawing.Size(59, 16);
            this.rbGaikokusya.TabIndex = 9;
            this.rbGaikokusya.Text = "外国車";
            this.rbGaikokusya.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Checked = true;
            this.rbOther.Location = new System.Drawing.Point(377, 139);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 9;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.色の設定ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.終了ToolStripMenuItem,
            this.データベース接続ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル（&F）";
            // 
            // 色の設定ToolStripMenuItem
            // 
            this.色の設定ToolStripMenuItem.Name = "色の設定ToolStripMenuItem";
            this.色の設定ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.色の設定ToolStripMenuItem.Text = "色の設定";
            this.色の設定ToolStripMenuItem.Click += new System.EventHandler(this.色の設定ToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.buttunSave_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // データベース接続ToolStripMenuItem
            // 
            this.データベース接続ToolStripMenuItem.Name = "データベース接続ToolStripMenuItem";
            this.データベース接続ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.データベース接続ToolStripMenuItem.Text = "データベース接続";
            this.データベース接続ToolStripMenuItem.Click += new System.EventHandler(this.データベース接続ToolStripMenuItem_Click);
            // 
            // carReportDBDataGridView
            // 
            this.carReportDBDataGridView.AllowUserToAddRows = false;
            this.carReportDBDataGridView.AllowUserToDeleteRows = false;
            this.carReportDBDataGridView.AutoGenerateColumns = false;
            this.carReportDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.carReportDBDataGridView.DataSource = this.carReportDBBindingSource;
            this.carReportDBDataGridView.Location = new System.Drawing.Point(106, 434);
            this.carReportDBDataGridView.Name = "carReportDBDataGridView";
            this.carReportDBDataGridView.ReadOnly = true;
            this.carReportDBDataGridView.RowTemplate.Height = 21;
            this.carReportDBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carReportDBDataGridView.Size = new System.Drawing.Size(741, 220);
            this.carReportDBDataGridView.TabIndex = 28;
            this.carReportDBDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.carReportDBDataGridView_DataError);
            this.carReportDBDataGridView.Click += new System.EventHandler(this.carReportDBDataGridView_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            this.makerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            this.carNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            this.reportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // carReportDBBindingSource
            // 
            this.carReportDBBindingSource.DataMember = "CarReportDB";
            this.carReportDBBindingSource.DataSource = this.infosys202211DataSet;
            // 
            // infosys202211DataSet
            // 
            this.infosys202211DataSet.DataSetName = "infosys202211DataSet";
            this.infosys202211DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportDBTableAdapter
            // 
            this.carReportDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportDBTableAdapter = this.carReportDBTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202211DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button_Update
            // 
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Update.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Update.Location = new System.Drawing.Point(12, 498);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(88, 58);
            this.button_Update.TabIndex = 29;
            this.button_Update.Text = "更新";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // bottun_SerchName
            // 
            this.bottun_SerchName.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bottun_SerchName.Location = new System.Drawing.Point(679, 351);
            this.bottun_SerchName.Name = "bottun_SerchName";
            this.bottun_SerchName.Size = new System.Drawing.Size(125, 33);
            this.bottun_SerchName.TabIndex = 30;
            this.bottun_SerchName.Text = "名前検索";
            this.bottun_SerchName.UseVisualStyleBackColor = true;
            this.bottun_SerchName.Click += new System.EventHandler(this.bottun_SerchName_Click);
            // 
            // text_SerchName
            // 
            this.text_SerchName.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.text_SerchName.Location = new System.Drawing.Point(679, 390);
            this.text_SerchName.Name = "text_SerchName";
            this.text_SerchName.Size = new System.Drawing.Size(223, 36);
            this.text_SerchName.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 662);
            this.Controls.Add(this.text_SerchName);
            this.Controls.Add(this.bottun_SerchName);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.carReportDBDataGridView);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbGaikokusya);
            this.Controls.Add(this.rbSubaru);
            this.Controls.Add(this.rbHonda);
            this.Controls.Add(this.rbNissan);
            this.Controls.Add(this.rbToyota);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPicDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonPicOpen);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.textReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202211DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonPicOpen;
        private System.Windows.Forms.Button buttonPicDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbGaikokusya;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色の設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialogSelect;
        private System.Windows.Forms.ToolStripMenuItem データベース接続ToolStripMenuItem;
        private infosys202211DataSet infosys202211DataSet;
        private System.Windows.Forms.BindingSource carReportDBBindingSource;
        private infosys202211DataSetTableAdapters.CarReportDBTableAdapter carReportDBTableAdapter;
        private infosys202211DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carReportDBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button bottun_SerchName;
        private System.Windows.Forms.TextBox text_SerchName;
    }
}

