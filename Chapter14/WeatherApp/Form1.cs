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
        IDictionary<string,int> areas = areaCsvRead();
        WebClient wc = new WebClient() {
            Encoding = Encoding.UTF8
        };

        public Form1() {
            InitializeComponent();
          
        }

        private void weatherGet_Click(object sender, EventArgs e) {                               
            var wetherUrl =  getUrl(cb_areaList.SelectedItem.ToString());
            var dString = wc.DownloadString(wetherUrl);
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            office.Text = json.offices.ToString();
            dateTimeText.Text = json.class10s.ToString();
            weatherInfo.Text = json.centers.ToString();
        }
        private  void  setPre(string name){
            if (cb_areaList.FindStringExact(name) == -1) {
                cb_areaList.Items.Add(name);
            }
        }

        private string getUrl(string name) {
            var code = areaCode_Text.Text;
           
            var http = $"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{code}.json";
            return http;
        }


        private void Form1_Load(object sender, EventArgs e) {
            
            foreach (var name in areas) {
                setPre(name.Key);
            }

        }

        
        private static Dictionary<string,int> areaCsvRead() {
            
            var file = @"areacode.csv";
            var pre = new Dictionary<string,int>();
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                AreaCode areaCode = new AreaCode {
                    Name = items[0],
                    Code = int.Parse(items[1])
                };
                
                 pre.Add(areaCode.Name,areaCode.Code);
                
            }
            return pre;

        }

        private void cb_areaList_SelectedIndexChanged(object sender, EventArgs e) {
            if (areas.ContainsKey(cb_areaList.Text)){
                foreach (var d in areas) {
                    areaCode_Text.Text = d.Value.ToString();
                }
                
            }           
            
            

        }
    }
}
