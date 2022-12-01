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




        }

        private void btRandom_Click(object sender, EventArgs e) {
            Random rand = new Random();
            //①１から６の数字
            //Number.Value = rand.Next(minValue:1,maxValue:7);

            //②
           Number.Value = rand.Next(
                    minValue: (int)Min.Value, maxValue:(int)Max.Value) ;

        }
    }
}
