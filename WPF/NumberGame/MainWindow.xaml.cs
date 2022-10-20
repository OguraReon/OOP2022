using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    
   
    public partial class MainWindow : Window {
        
        //乱数で生成した答えを入力
        int anserNum = GetRandom();

        public MainWindow() {
            
            InitializeComponent();
        }
        private static int GetRandom() {
            Random rand = new Random();
            var r = rand.Next(0,26);
            return r;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Button b1 = (Button)sender;                        
            if (b1.Content.ToString() == anserNum.ToString()) {

                b1.Background = Brushes.Red;
                numText.Text = "あたり";              
               
            } else {

                numText.Text = int.Parse((string)b1.Content) < anserNum
                                            ? "もっと大きいです" : "もっと小さいですです";
                b1.Background = Brushes.Aqua;
                //numText.Text = "はずれ";

            }
        }   
    }
}
