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

        List<MyColor> colors = new List<MyColor>();
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
            rSlider.Value = mycolor.Color.R;
            gSlider.Value = mycolor.Color.G;
            bSlider.Value = mycolor.Color.B;
            setColor();

        }

        private void Stock_Click(object sender, RoutedEventArgs e) {
            
            
            //var mycolor = (MyColor)colorComboBox.SelectedItem;
            //var mycolorR = rSlider.Value;
            //var mycolorG = gSlider.Value;
            //var mycolorB = bSlider.Value;
            //var mycolorRGB = "R:" + mycolorR + " G:" + mycolorG + " B:" + mycolorB;
            //List<string> colors = new List<string>();   

            //colors.Add(mycolorRGB);                      
            //foreach (var c in colors) {

            //    listColorBox.Items.Add(c);
            //}

            //listColorBox.Items.Add("R:" + rValue.Text + " G:" + gValue.Text + " B:" + bValue.Text);
            MyColor myColor = new MyColor();
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            myColor.Color = Color.FromRgb(r, g, b);


            var colorName = ((IEnumerable<MyColor>)DataContext).Where(c => c.Color.R == myColor.Color.R &&
                                                                          c.Color.G == myColor.Color.G &&
                                                                          c.Color.B == myColor.Color.B).FirstOrDefault();
            listColorBox.Items.Insert(0, colorName?.Name ?? "R:" + r + " G:" + g + " B:" + b);
            colors.Insert(0, myColor);
            maskJudge();
        }

        private void maskJudge() {
            if (listColorBox.Items.Count != 0) {
                deleteButton.IsEnabled = true;
            } else {
                deleteButton.IsEnabled = false;
            }
        }

        private void DELETE_Click(object sender, RoutedEventArgs e) {

            listColorBox.Items.RemoveAt(0);
            maskJudge();

        }

        private void listColorBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            rSlider.Value = colors[listColorBox.SelectedIndex].Color.R;
            gSlider.Value = colors[listColorBox.SelectedIndex].Color.G;
            bSlider.Value = colors[listColorBox.SelectedIndex].Color.B;
            setColor();
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
