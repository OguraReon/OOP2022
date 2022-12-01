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
    public partial class hima : Form {
        public hima() {
            InitializeComponent();
            
        }

        private void close_Click(object sender, EventArgs e) {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e) {
            WebClient wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            
           
            //ひまわり　フルディスク画像
            var himaUrl = $"https://www.jma.go.jp/bosai/himawari/data/satimg/targetTimes_fd.json";
            var himaDString = wc.DownloadString(himaUrl);
            var himaJson = JsonConvert.DeserializeObject<WetherMapClass1[]>(himaDString);
            var baseTime = himaJson[0].basetime.ToString();
            var validtime = himaJson[0].validtime.ToString();

            picWetherMap.SizeMode = PictureBoxSizeMode.Zoom;
            picWetherMap.ImageLocation = $"https://www.jma.go.jp/bosai/himawari/data/satimg/{baseTime}/fd/{validtime}/B03/ALBD/5/28/12.jpg";
            
        }
    }
}
