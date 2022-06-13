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

        private void dgvPersons_Click(object sender, EventArgs e) {
            //データグリッドビューをクリックした時のイベントハンドラ
            int iRow = dgvPersons.CurrentCell.RowIndex;
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

        private void CheckBoxAllClear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }
    }
}
