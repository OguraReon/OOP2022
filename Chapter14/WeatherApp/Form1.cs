using Aspose.Words;
using GroupDocs.Conversion;
using GroupDocs.Conversion.Options.Convert;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WeatherApp {
    public partial class Form1 : Form {
        IDictionary<string,string> areas = areaCsvRead();
        List<DateTime> dates = setListDates();
     

        public Form1() {
            InitializeComponent();
            
          
        }

        private void weatherGet_Click(object sender, EventArgs e) {
           

            WebClient wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var code = areas[cb_areaList.Text];
            //一日の天気
            var dateUrl = $"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{code}.json";

            //一週間の天気
            var weekUrl = $"https://www.jma.go.jp/bosai/forecast/data/overview_week/{code}.json";

            //一週間の天気（天気マーク取得）
            var weekDateUrl = $"https://www.jma.go.jp/bosai/forecast/data/forecast/{code}.json";

            try {
                switch (date_select.SelectedIndex) {

                    case 0:
                        var dString = wc.DownloadString(dateUrl);
                        var dStringWeek = wc.DownloadString(weekDateUrl);
                        var json = JsonConvert.DeserializeObject<Rootobject>(dString);
                        var jsonPic = JsonConvert.DeserializeObject<Class1[]>(dStringWeek);
                        office.Text = json.publishingOffice;
                        date_select.Text = json.reportDatetime.ToShortDateString();
                        wetherInfo.Text = json.text;
                        var icon = jsonPic[0].timeSeries[0].areas[1].weatherCodes[0];
                        wetherPicture.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon}.png";

                        break;

                    case 1:

                        dStringWeek = wc.DownloadString(weekDateUrl);
                        jsonPic = JsonConvert.DeserializeObject<Class1[]>(dStringWeek);
                        
                        var jsonWeek = JsonConvert.DeserializeObject<RootobjectWeek[]>(dStringWeek);
                        office.Text = jsonPic[0].publishingOffice;
                        wetherInfo.Text = jsonWeek[0].text;
                        icon = jsonPic[0].timeSeries[0].areas[1].weatherCodes[0];
                        wetherPicture.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon}.png";

                        break;
                }
            } catch (Exception io) {
                MessageBox.Show("やり直してください");
            }
            

        }
        //コンボボックスに地域を格納
        private  void setPre(string name){
            if (cb_areaList.FindStringExact(name) == -1) {
                cb_areaList.Items.Add(name);
            }
        }

        //コンボボックスに今日、三日間、七日間
        private void setDate(string date) {
            if (date_select.FindStringExact(date) == -1) {
                date_select.Items.Add(date);
            }
        }
   

        //起動時
        private void Form1_Load(object sender, EventArgs e) {
            
            labelMask();
            BackgroundImageLayout = ImageLayout.Zoom;
            BackgroundImage = Image.FromFile(@"RED2020906021_TP_V.jpg");
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            todayLabel.BackColor = Color.Transparent;
            weekLabel.BackColor = Color.Transparent;
            wetherInfo.BackColor = Color.Transparent;
            
            label5.BackColor = Color.Transparent;           
            

            mask();
            foreach (var name in areas) {
                setPre(name.Key);
            }
            foreach (var date in dates) {
                setDate(date.ToShortDateString());
            }
            

        }

        //ラベルマスク化
        private void labelMask() {
            if (date_select.SelectedIndex == 0) {
                todayLabel.Visible = true;
                weekLabel.Visible = false;
            } else if (date_select.SelectedIndex == 1){
                todayLabel.Visible = false;
                weekLabel.Visible = true;

            } else {
                todayLabel.Visible = weekLabel.Visible = false;
            }
        
        }

        //マスク処理
        private void mask() {
            if (cb_areaList.Text == "") {
                weatherGet.Enabled = false;
            } else {
                weatherGet.Enabled = true;
            }
        }

        //CSVファイルをDictionaryのオブジェクトに変換して、返す
        private static Dictionary<string,string> areaCsvRead() {
            
            var file = @"areacode.csv";
            var pre = new Dictionary<string,string>();
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                AreaCode areaCode = new AreaCode {
                    Name = items[0],
                    Code = items[1]
                };
                
                 pre.Add(areaCode.Name,areaCode.Code);
                
            }
            return pre;

        }

        //今日、三日間、七日間をリストに格納
        private static  List<DateTime> setListDates() {
            var date = new List<DateTime>();
            date.Add(DateTime.Now.Date);
            date.Add(DateTime.Now.Date.AddDays(6));
            return date;

        }

        //コンボボックスの選択処理
        private void cb_areaList_SelectedIndexChanged(object sender, EventArgs e) {
            mask();  
            
            
        }

        private void date_select_SelectedIndexChanged(object sender, EventArgs e) {
            labelMask();
            wetherInfo.Text = "";
        }
    }
}
