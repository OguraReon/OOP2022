using System;
using System.Windows.Forms;

namespace Sample0610 {
    public partial class Form1 : Form {
        private Random rand = new Random();
        private int randomNumber;
        public Form1() {
            InitializeComponent();
        }

        private void buttom_judge_Click(object sender, EventArgs e) {
           
            int inputNum = int.Parse(Number.Value.ToString());
            
            if (inputNum == randomNumber) {
                text_reslut.Text = "正解";
            } else {
                if (inputNum > randomNumber) {
                    text_reslut.Text = "今より小さい値です";                                      
                } else {
                    text_reslut.Text = "今より大きい値です";                
                }
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            //乱数取得
            randomNumber = rand.Next(minValue: 1, maxValue: 51);
            Number2.Value = randomNumber;
        }
    }
}
