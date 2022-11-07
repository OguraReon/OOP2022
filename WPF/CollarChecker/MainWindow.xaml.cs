using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor myColor;
        //コンストラクタ
        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList(); //←追加

        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor();
        }

        private void setColor() {
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            
           // var colorNum =  Color.FromRgb(byte.Parse(rValue.Text),byte.Parse(gValue.Text),byte.Parse(bValue.Text));
            var color = mycolor.Color;
            var name = mycolor.Name;
            colorArea.Background = new SolidColorBrush(color);
            rValue.Text = color.R.ToString();
            gValue.Text = color.G.ToString();
            bValue.Text = color.B.ToString();
            rSlider.Value = mycolor.Color.R;
            gSlider.Value = mycolor.Color.G;
            bSlider.Value = mycolor.Color.B;

            
        }

        private void Stock_Click(object sender, RoutedEventArgs e) {
            var mycolor = (MyColor)colorComboBox.SelectedItem;
            var mycolorR = rSlider.Value;
            var mycolorG = gSlider.Value;
            var mycolorB = bSlider.Value;
            var mycolorRGB = "R:" + mycolorR + " G:" + mycolorG + " B:" + mycolorB;
            List<string> colors = new List<string>();   
            
            colors.Add(mycolorRGB);                      
            foreach (var c in colors) {

                listColorBox.Items.Add(c);
            }
            
            
        }

        private void DELETE_Click(object sender, RoutedEventArgs e) {
            listColorBox.Items.RemoveAt(0);
        }

        private void listColorBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)colorComboBox.SelectedItem;
            
        }
    }

    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
