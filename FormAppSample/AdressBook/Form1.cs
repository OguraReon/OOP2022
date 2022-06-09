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
            };
            listPerson.Add(newPeason);
            
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog()== DialogResult.OK) {
                pbPicture.Image = Image.FromFile( openFileDialog1.FileName);
            }
            
        }

        private void btPictureClear_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
    }
}
