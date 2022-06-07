using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0603 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var intNum1 = int.Parse(tbNum1.Text);
            var intNum2  =int.Parse(tbNum2.Text);
             //var anser = intNum1 + intNum2;
            var anserWaru = intNum1 / intNum2;
            tbAns.Text =  anserWaru.ToString();

            nubAns.Value = nudNum1.Value + nudNum2.Value;



        }
    }
}
