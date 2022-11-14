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
        
      
        public Form1() {
            InitializeComponent();
          
        }

        private void weatherGet_Click(object sender, EventArgs e) { 
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            var areaName = areaCsvRead().Keys;
            var areaCode = areaCsvRead().Values;
            if (cb_areaList.Text == areaName.ToString()) {
                
            }
            //var wetherUrl =  getUrl(cb_areaList.Text);
            //var dString = wc.DownloadString(wetherUrl);
            //var json = JsonConvert.DeserializeObject<Rootobject>(dString);           
            //office.Text = json.publishingOffice;
            //dateTimeText.Text = json.reportDatetime.ToShortDateString();
            //weatherInfo.Text = json.text;
        }
        private  void  setPre(string name){
            if (cb_areaList.FindStringExact(name) == -1) {
                cb_areaList.Items.Add(name);
            }
        }
        
        //private string getUrl() {
        //    switch (name) {

        //        case "青森県":
        //            return "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json";

        //        case "岩手県":
        //            return "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/030000.json";

        //        case "宮城県":
        //            return "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/040000.json";

        //        case "秋田県":
        //            return "https://www.jma.go.jp/bosai/forecast/data/overview_forecast/050000.json";

        //        default:
        //            return "aaaaaaaaaa";
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e) {
            var areas = areaCsvRead();
            foreach (var name in areas) {
                setPre(name.Key);
            }


        }
        //AreaCodeオブジェクトのディクショナリーを返す
        private Dictionary<string,int> areaCsvRead() {
            var file = @"AreaCode.csv";           
            Dictionary<string, int> pre = new Dictionary<string, int>();
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                AreaCode areaCode = new AreaCode {
                    Name = items[0],
                    Code = int.Parse(items[1])

                };
                pre.Add(areaCode.Name, areaCode.Code);
            }
            
            return pre;
        }
    }
}
