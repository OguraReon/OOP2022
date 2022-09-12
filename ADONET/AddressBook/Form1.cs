using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addressTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202211DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202211DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            //this.addressTableTableAdapter.Fill(this.infosys202211DataSet.AddressTable);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

        }    

        private void button_Add_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202211DataSet.AddressTable.NewRow();
            newRow[1] = text_Name.Text;
            newRow[2] = text_Address.Text;
            newRow[3] = text_Tell.Text;
            newRow[4] = text_Mail.Text;
            newRow[5] = text_Memo.Text;
            newRow[6] = pbImage.Image;

            // データベースへ新しいレコードを追加
            infosys202211DataSet.AddressTable.Rows.Add(newRow);
            //データベース更新
            this.addressTableTableAdapter.Update(this.infosys202211DataSet.AddressTable);
        }

        private void button_Save_Click(object sender, EventArgs e) {
            //データグリッドビューの選択レコードを各テキストボックスへ
            addressTableDataGridView.CurrentRow.Cells[1].Value = text_Name.Text;
            addressTableDataGridView.CurrentRow.Cells[2].Value = text_Address.Text;
            addressTableDataGridView.CurrentRow.Cells[3].Value = text_Tell.Text;
            addressTableDataGridView.CurrentRow.Cells[4].Value = text_Mail.Text;
            addressTableDataGridView.CurrentRow.Cells[5].Value = text_Memo;
            addressTableDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);

            //データセットの中をデータベースへ反映
            this.Validate();
            this.addressTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202211DataSet);

        }

        private void addressTableDataGridView_Click(object sender, EventArgs e) {
            textEmpty();
            if (addressTableDataGridView.CurrentRow == null) {
                return;
            }
            text_Name.Text = addressTableDataGridView.CurrentRow.Cells[1].Value.ToString();
            text_Address.Text = addressTableDataGridView.CurrentRow.Cells[2].Value.ToString();
            text_Tell.Text = addressTableDataGridView.CurrentRow.Cells[3].Value.ToString();
            text_Mail.Text = addressTableDataGridView.CurrentRow.Cells[4].Value.ToString();
            text_Memo.Text = addressTableDataGridView.CurrentRow.Cells[5].Value.ToString();
            if (!(addressTableDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                pbImage.Image = ByteArrayToImage((byte[])addressTableDataGridView.CurrentRow.Cells[6].Value);

            } else {
                pbImage.Image = null;
            }
           


        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImage.Filter = "画像ファイル(*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            if (ofdImage.ShowDialog() == DialogResult.OK) {
                pbImage.Image = System.Drawing.Image.FromFile(ofdImage.FileName);
            }
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbImage.Image = null;
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

        private void addressTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void button_SerchName_Click(object sender, EventArgs e) {
           addressTableTableAdapter.FillBySerchName(infosys202211DataSet.AddressTable,text_SerchName.Text);
        }

        private void textEmpty() {
            text_Name.Text = text_Address.Text = text_Mail.Text =
            text_Memo.Text = text_Tell.Text = "";
        }

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void データベース接続ToolStripMenuItem1_Click(object sender, EventArgs e) {
            this.addressTableTableAdapter.Fill(this.infosys202211DataSet.AddressTable);
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            new Version().ShowDialog();
        }
    }
}
