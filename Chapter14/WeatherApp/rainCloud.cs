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
    public partial class rainCloud : Form {
        public rainCloud() {
            InitializeComponent();
        }

        private void rainCloud_Load(object sender, EventArgs e) {
            WebClient wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            //雨雲レーダー
            var rainCloudUrl = $" https://www.jma.go.jp/bosai/jmatile/data/nowc/targetTimes_N2.json";
            var rcDString = wc.DownloadString(rainCloudUrl);
            var rcJson = JsonConvert.DeserializeObject<RainCloudMapClass1[]>(rcDString);
            var baseTime = rcJson[0].basetime.ToString();
            var validTime = rcJson[0].validtime.ToString();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = $"https://www.jma.go.jp/bosai/himawari/data/nowc/{baseTime}/none/{validTime}/surf/hrpns/10/7/3.png";
        }

        private void close_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
