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
    public partial class himaJp : Form {
        public himaJp() {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {
            WebClient wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            //ひまわり日本付近
            var himaJpUrl = $" https://www.jma.go.jp/bosai/himawari/data/satimg/targetTimes_jp.json ";
            var himaJpDString = wc.DownloadString(himaJpUrl);
            var himaJpJson = JsonConvert.DeserializeObject<WetherMapClass1[]>(himaJpDString);
            var baseTime = himaJpJson[0].basetime.ToString();
            var validtime = himaJpJson[0].validtime.ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = $"https://www.jma.go.jp/bosai/himawari/data/satimg/{baseTime}/jp/{validtime}/B03/ALBD/5/28/12.jpg";
        }

        private void close_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
