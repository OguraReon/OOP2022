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
            var url = getUrl();
            var dString = wc.DownloadString(url);
            if (date_select.SelectedIndex == 2) {
                var jsonPic = JsonConvert.DeserializeObject<Class1[]>(dString);
                var icon = jsonPic[0].timeSeries[1].areas[1].weatherCodes;
                var iconUrl = $"https://www.jma.go.jp/bosai/forecast/img/{icon}.svg";
               // wetherPicture.Location = 

            } else {
                var json = JsonConvert.DeserializeObject<Rootobject>(dString);
                office.Text = json.publishingOffice;
                date_select.Text = json.reportDatetime.ToShortDateString();
                weatherInfo.Text = json.text;
                //wetherPicture.Image = 
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

        //エリアコードをURLに代入してURLを返す
        private string getUrl() {
            var code = areas[cb_areaList.Text];
            var dateUrl = $"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{code}.json";           
            switch (date_select.SelectedIndex) {
                case 0:
                    dateUrl = $"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{code}.json";
                    break;
                case 1:
                    dateUrl = $"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{code}.json";
                    break;
                case 2:
                    dateUrl = $"https://www.jma.go.jp/bosai/forecast/data/forecast/{code}.json";
                    break;
            }

            return dateUrl;
        }

        //起動時
        private void Form1_Load(object sender, EventArgs e) {
            BackgroundImageLayout = ImageLayout.Zoom;
            BackgroundImage = Image.FromFile(@"RED2020906021_TP_V.jpg");
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            
            mask();
            foreach (var name in areas) {
                setPre(name.Key);
            }
            foreach (var date in dates) {
                setDate(date.ToShortDateString());
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
            date.Add(DateTime.Now.Date.AddDays(2));
            date.Add(DateTime.Now.Date.AddDays(6));
            return date;

        }

        //コンボボックスの選択処理
        private void cb_areaList_SelectedIndexChanged(object sender, EventArgs e) {
            mask();  
            
            
        }

    }
}
