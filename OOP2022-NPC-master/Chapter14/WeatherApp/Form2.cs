using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            WebClient wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            //ひまわり　フルディスク画像
            var himaUrl = $"https://www.jma.go.jp/bosai/himawari/data/satimg/targetTimes_fd.json";
            var dString = wc.DownloadString(himaUrl);
            var json = JsonConvert.DeserializeObject<WetherMapClass1[]>(dString);

            //ひまわり日本付近
            var himaJpUrl = $" https://www.jma.go.jp/bosai/himawari/data/satimg/targetTimes_jp.json ";
            
            picWetherMap.ImageLocation = json[0].basetime[0].ToString();
        }
        
        
    }
}
