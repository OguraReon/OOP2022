﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBook {
    public partial class Form1 : Form {
        BindingList<Person> listPerson = new BindingList<Person>();
        
        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
           //btDelete.Enabled = false;
           //btUpDate.Enabled = false;
        }

        //追加ボタンを押された時の処理
        private void button1_Click(object sender, EventArgs e) {

            Person newPeason = new Person {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text,
                Adress = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
                Registration = dateTimePicker1.Value,
                TellNumber = tbPhoneNum.Text,
                kindNumber = GetKindNumberTypes(),
            };
            listPerson.Add(newPeason);
            setCbCompany(cbCompany.Text);
            textEmpty();
            maskJudge();        

        }
        //テキストを空白にする処理
        private void textEmpty() {
            tbName.Text = tbAddress.Text = tbMailAddress.Text = cbCompany.Text = "";                      
        }

        //更新・削除ボタンのマスク処理
        private void maskJudge() {       
         btDelete.Enabled = btUpDate.Enabled = listPerson.Count() > 0 ? true : false;           
        }

        //コンボボックスに会社名を登録（重複なし）
        private void setCbCompany(string company) {
            if (cbCompany.FindStringExact(company) == -1) {
                cbCompany.Items.Add(company);
            }

            /*先生の解答
            if (!cbCompany.Items.Contains(cbCompany.Text)) {
                cbCompany.Items.Add(cbCompany.Text);
            }
            */
        }


        //開く...ボタンの処理
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog()== DialogResult.OK) {
                pbPicture.Image = Image.FromFile( openFileDialog1.FileName);
            }           
        }


        //チェックボックスにセットされている値をリストとして取り出す
        private List<Person.Grouptype> GetCheckBoxGroup() {
            var listGroup = new List<Person.Grouptype>();

            if (cbFamily.Checked ) {
                listGroup.Add(Person.Grouptype.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Person.Grouptype.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.Grouptype.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.Grouptype.その他);
            }

            return listGroup;
        }

        //ラジオボックスにセットされている値をリストとして取り出す
        private Person.KindNumberType GetKindNumberTypes() {
            var listGroup = Person.KindNumberType.その他;

            if (rbHome1.Checked) {
                listGroup = Person.KindNumberType.自宅;
            }
            if (rbPhone.Checked) {
                listGroup  =Person.KindNumberType.携帯;
            }
            return listGroup;
            
        }


        //クリアボタンを押された時の処理
        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }


        //データグリッドビューをクリックした時のイベントハンドラ
        private void dgvPersons_Click(object sender, EventArgs e) {
            
            int iRow = dgvPersons.CurrentRow.Index;
            if (tbName.Text == null) return;
            if (dgvPersons.CurrentRow == null) return;

            tbName.Text = listPerson[iRow].Name;
            tbAddress.Text = listPerson[iRow].Adress;
            tbMailAddress.Text = listPerson[iRow].MailAddress;
            cbCompany.Text = listPerson[iRow].Company;
            pbPicture.Image = listPerson[iRow].Picture;
           // dateTimePicker1.Value = listPerson[iRow].Registration >1900 ? 

            CheckBoxAllClear();

            foreach (var grop in listPerson[iRow].listGroup) {
                switch (grop) {
                    case Person.Grouptype.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.Grouptype.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.Grouptype.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.Grouptype.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }

        }


        //グループのチェックボックスをオールクリア
        private  void CheckBoxAllClear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }


        //更新ボタンが押された時の処理
        private void btUpDate_Click(object sender, EventArgs e) {           

            int iRow = dgvPersons.CurrentRow.Index;
            listPerson[iRow].Name = tbName.Text;
            listPerson[iRow].Adress = tbAddress.Text;
            listPerson[iRow].MailAddress = tbMailAddress.Text;
            listPerson[iRow].Company = cbCompany.Text;
            listPerson[iRow].listGroup = GetCheckBoxGroup();
            listPerson[iRow].Picture = pbPicture.Image;
            listPerson[iRow].Registration = dateTimePicker1.Value;

            dgvPersons.Refresh();
            maskJudge();
        }


        //削除ボタンが押された時の処理
        private void btDelete_Click(object sender, EventArgs e) {           
            int iRow = dgvPersons.CurrentRow.Index;

            listPerson.RemoveAt(iRow);
            maskJudge();
        }


        //保存ボタンのイベントハンドラ
        private void btSave_Click(object sender, EventArgs e) {
           
            if (sfdSaveDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdSaveDialog.FileName,
                                                        FileMode.Create)) {
                        bf.Serialize(fs, listPerson);
                    }

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    
                }
            }

        }

        //開くボタンが押された時の処理
        private void btOpen_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                
                try {
                    //バイナリーで逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(openFileDialog1.FileName,
                                                FileMode.Open,FileAccess.Read)) {

                        //逆シリアル化して読み込む
                         listPerson =  (BindingList<Person>) bf.Deserialize(fs);
                        dgvPersons.DataSource = null;
                        dgvPersons.DataSource = listPerson;
                    }

                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
                maskJudge();
                cbCompany.Items.Clear();
                //コンボボックスへ登録
                foreach (var item in listPerson.Select(p=> p.Company)) {
                    setCbCompany(item); //存在する会社を登録
                }
                cbCompany.Items.Clear();

            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            //マスク処理呼び出し
            maskJudge();
        }
    }
}
