using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBook {
    public partial class Form1 : Form {
        BindingList<Peason> listPerson = new BindingList<Peason>();
        
        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
           // btDelete.Enabled = false;
            //btUpDate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
           

            Peason newPeason = new Peason {
                Name = tbName.Text,
                MailAddress = tbMailAddress.Text, 
                Adress = tbAddress.Text,
                Company = tbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };
            listPerson.Add(newPeason);
            if (listPerson.Count() >= 1) btDelete.Enabled = true;
            if (listPerson.Count() >= 1) btUpDate.Enabled = true;


        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog()== DialogResult.OK) {
                pbPicture.Image = Image.FromFile( openFileDialog1.FileName);
            }
            
        }

        //チェックボックスにセットされている値をリストとして取り出す
        private List<Peason.Grouptype> GetCheckBoxGroup() {
            var listGroup = new List<Peason.Grouptype>();

            if (cbFamily.Checked ) {
                listGroup.Add(Peason.Grouptype.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Peason.Grouptype.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Peason.Grouptype.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Peason.Grouptype.その他);
            }


            return listGroup;
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private  void dgvPersons_Click(object sender, EventArgs e) {

            //データグリッドビューをクリックした時のイベントハンドラ
            int iRow = dgvPersons.CurrentRow.Index;
            if (tbName.Text == null) return;
            if (dgvPersons.CurrentRow == null) return;

            tbName.Text = listPerson[iRow].Name;
            tbAddress.Text = listPerson[iRow].Adress;
            tbMailAddress.Text = listPerson[iRow].MailAddress;
            tbCompany.Text = listPerson[iRow].Company;
            pbPicture.Image = listPerson[iRow].Picture;

            CheckBoxAllClear();

            foreach (var grop in listPerson[iRow].listGroup) {
                switch (grop) {
                    case Peason.Grouptype.家族:
                        cbFamily.Checked = true;
                        break;
                    case Peason.Grouptype.友人:
                        cbFriend.Checked = true;
                        break;
                    case Peason.Grouptype.仕事:
                        cbWork.Checked = true;
                        break;
                    case Peason.Grouptype.その他:
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
            listPerson[iRow].Company = tbCompany.Text;
            listPerson[iRow].listGroup = GetCheckBoxGroup();
            listPerson[iRow].Picture = pbPicture.Image;
            dgvPersons.Refresh();
            if (listPerson.Count() == 0) btUpDate.Enabled = false;

        }
        private void btDelete_Click(object sender, EventArgs e) {
            
            int iRow = dgvPersons.CurrentRow.Index;
            listPerson.RemoveAt(iRow);
            if (listPerson.Count() == 0) btDelete.Enabled = false;
        }
    }
}
