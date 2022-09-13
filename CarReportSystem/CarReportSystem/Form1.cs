﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //設定情報オブジェクト
        Settings settings = Settings.getSettings();
       
       private BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            //carReportDBDataGridView.DataSource = listCarReport;


        }

        private void Form1_Load(object sender, EventArgs e) {
            
            maskJudge();
            //設定ファイルを逆シリアル化して拝啓の色を設定
            try {
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    var setting = serializer.Deserialize(reader) as Settings;

                    BackColor = Color.FromArgb(setting.MainFormColor);
                }
                
            } catch (Exception) {
             
            }
           
        }

        //追加ボタン
        private void buttonAdd_Click(object sender, EventArgs e) {
            CarReport newCarReport = new CarReport {
                Date = dateTimePicker.Value,
                Auther = cbAuthor.Text,
                Maker = GetCheckBoxGroup(),
                CarName = cbCarName.Text,
                Report = textReport.Text,
                Picture = pictureBox.Image,

            };
            if (cbAuthor.Text == "" || cbCarName.Text == "" || textReport.Text == "") {
                MessageBox.Show("記事者、車名、レポートを入力してください");
                return;
            }
            listCarReport.Add(newCarReport);
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
            textEmpty();
            maskJudge();
        }

        //記事者の登録
        private void setCbAuthor(string name) {
            if (cbAuthor.FindStringExact(name) == -1) {
                cbAuthor.Items.Add(name);
            }
        }

        //マスク
        private void maskJudge() {
            buttonDelete.Enabled = buttonCorrect.Enabled =
            buttonPicDelete.Enabled = buttunSave.Enabled = listCarReport.Count() > 0 ? true : false;
        }

        //テキストを空白にする
        private void textEmpty() {
            textReport.Text = "";
        }

        //メーカーの選択
        private List<CarReport.MakerGroup> GetCheckBoxGroup() {
            var listGroup = new List<CarReport.MakerGroup>();

            if (rbToyota.Checked) {
                listGroup.Add(CarReport.MakerGroup.トヨタ);
            }
            if (rbSubaru.Checked) {
                listGroup.Add(CarReport.MakerGroup.スバル);
            }
            if (rbNissan.Checked) {
                listGroup.Add(CarReport.MakerGroup.日産);
            }
            if (rbGaikokusya.Checked) {
                listGroup.Add(CarReport.MakerGroup.外国車);
            }
            if (rbOther.Checked) {
                listGroup.Add(CarReport.MakerGroup.その他);
            }
            return listGroup;
        }

        //コンボボックスに車名を登録（重複なし）
        private void setCbCarName(string carName) {
            if (cbCarName.FindStringExact(carName) == -1) {
                cbCarName.Items.Add(carName);
            }
        }

        

        //終了ボタン
        private void buttonExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //削除ボタン
        private void buttonDelete_Click(object sender, EventArgs e) {
            int iRow = carReportDBDataGridView.CurrentRow.Index;

            listCarReport.RemoveAt(iRow);
            maskJudge();
        }

        //保存ボタン
        private void buttunSave_Click(object sender, EventArgs e) {

            //データグリッドビューの選択レコードを各テキストボックスへ

            carReportDBDataGridView.CurrentRow.Cells[2].Value = dateTimePicker.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = cbAuthor.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pictureBox.Image);

            //データセットの中をデータベースへ反映
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202211DataSet);


            if (saveFile.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(saveFile.FileName,
                                                        FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        //開く...ボタン（ファイル）
        private void buttonOpen_Click(object sender, EventArgs e) {
            if (openFile.ShowDialog() == DialogResult.OK) {

                try {
                    //バイナリーで逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(openFile.FileName,
                                                FileMode.Open, FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        carReportDBDataGridView.DataSource = null;
                        carReportDBDataGridView.DataSource = listCarReport;
                    }

                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
                maskJudge();

                //コンボボックスへ登録
                foreach (var item in listCarReport.Select(p => p.CarName)) {
                    setCbCarName(item); //車名を登録
                }
                cbCarName.Items.Clear();
                cbAuthor.Items.Clear();

                //コンボボックスへ登録
                foreach (var item in listCarReport.Select(p => p.Auther)) {
                    setCbAuthor(item); //記事者を登録
                }
                cbAuthor.Items.Clear();
            }
        }

        //写真の削除ボタン
        private void buttonPicDelete_Click(object sender, EventArgs e) {
            pictureBox.Image = null;

        }

        //写真の開くボタン
        private void buttonPicOpen_Click(object sender, EventArgs e) {
            if (openFile.ShowDialog() == DialogResult.OK) {
                pictureBox.Image = Image.FromFile(openFile.FileName);
            }
        }

        //修正ボタン
        private void buttonCorrect_Click(object sender, EventArgs e) {

            int iRow = carReportDBDataGridView.CurrentRow.Index;
            listCarReport[iRow].Date = dateTimePicker.Value;
            listCarReport[iRow].CarName = cbCarName.Text;
            listCarReport[iRow].Auther = cbAuthor.Text;
            listCarReport[iRow].Maker = GetCheckBoxGroup();
            listCarReport[iRow].Report = textReport.Text;
            listCarReport[iRow].Picture = pictureBox.Image;

            carReportDBDataGridView.Refresh();
            maskJudge();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルをシリアル化
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }

        }

        //色設定ダイアログの表示
        private void 色の設定ToolStripMenuItem_Click(object sender, EventArgs e) {

            if (colorDialogSelect.ShowDialog() == DialogResult.OK) {
                settings.MainFormColor = colorDialogSelect.Color.ToArgb();
                BackColor = colorDialogSelect.Color;


            }
        }

        //データベース接続
        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202211DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202211DataSet.CarReportDB);
        }

        private void carReportDBDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            textEmpty();
            if (carReportDBDataGridView.CurrentRow == null) {
                return;
            }

            dateTimePicker.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbAuthor.Text = carReportDBDataGridView.CurrentRow.Cells[3].Value.ToString();
            cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
            textReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                pictureBox.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);

            } else {
                pictureBox.Image = null;
            }




        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

    }
}
