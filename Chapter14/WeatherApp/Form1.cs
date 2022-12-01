
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;




namespace WeatherApp {
    public partial class Form1 : Form {
        IDictionary<string, string> areas = areaCsvRead();
        List<string> dates = setListDates();
        //private Form2 f2;


        public Form1() {
            InitializeComponent();


        }

        

        private void weatherGet_Click(object sender, EventArgs e) {
            WebClient wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            //try {
            var code = areas[cb_areaList.Text];
            //一日の天気
            var dateUrl = $"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{code}.json";

            //一週間の天気
            var weekUrl = $"https://www.jma.go.jp/bosai/forecast/data/overview_week/{code}.json";

            //一週間の天気（天気マーク取得）
            var weekDateUrl = $"https://www.jma.go.jp/bosai/forecast/data/forecast/{code}.json";

            //天気図のデータ取得
            var wetherMapUrl = $"https://www.jma.go.jp/bosai/himawari/data/satimg/targetTimes_fd.json";


            //Todayの天気のデータ取得
            var dString = wc.DownloadString(dateUrl);
            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            //Tomorrowの天気のデータ取得
            var dStringWeek = wc.DownloadString(weekDateUrl);
            var jsonWeek = JsonConvert.DeserializeObject<Class1[]>(dStringWeek);

            //Weekの天気のお天気マークのデータ取得              
            var icon0 = jsonWeek[1].timeSeries[0].areas[0].weatherCodes[0];
            var icon1 = jsonWeek[1].timeSeries[0].areas[0].weatherCodes[1];
            var icon2 = jsonWeek[1].timeSeries[0].areas[0].weatherCodes[2];
            var icon3 = jsonWeek[1].timeSeries[0].areas[0].weatherCodes[3];
            var icon4 = jsonWeek[1].timeSeries[0].areas[0].weatherCodes[4];
            var icon5 = jsonWeek[1].timeSeries[0].areas[0].weatherCodes[5];
            var icon6 = jsonWeek[1].timeSeries[0].areas[0].weatherCodes[6];


            
            switch (date_select.SelectedIndex) {

                case 0:
                    //Today                      
                    wetherInfo.Text = json.text;
                    wetherPicture1.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon0}.png";
                    MinTemp1.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMin[0];
                    if (MinTemp1.Text == "") {
                        MinTemp1.Text = "なし";
                    } else {
                        MinTemp1.Text += "℃";
                    }

                    MaxTemp1.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMax[0];
                    if (MaxTemp1.Text == "") {
                        MaxTemp1.Text = "なし";
                    } else {
                        MaxTemp1.Text += "℃";
                    }

                    windInfo.Text = jsonWeek[0].timeSeries[0].areas[0].winds[0];
                    if (windInfo.Text == "") {
                        windInfo.Text = "なし";
                    }
                    break;

                case 1:
                    //Tomorrow                      
                    icon0 = jsonWeek[1].timeSeries[0].areas[0].weatherCodes[1];
                    MinTemp2.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMin[1] += "℃";
                    MaxTemp2.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMax[1] += "℃";
                    windInfo.Text = jsonWeek[0].timeSeries[0].areas[1].winds[1];
                    pops2.Text = jsonWeek[1].timeSeries[0].areas[0].pops[1] += "％";
                    wetherPicture2.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon0}.png";
                    if (MinTemp1.Text == "" + "℃") {
                        MinTemp1.Text = "なし";
                    }


                    if (MaxTemp1.Text == "" + "℃") {
                        MaxTemp1.Text = "なし";
                    }


                    if (pops2.Text == "" + "％") {
                        pops2.Text = "なし";
                    }

                    if (windInfo.Text == "") {
                        windInfo.Text = "なし";
                    }

                    break;

                case 2:
                    //Week                   
                    wetherPicture1.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon0}.png";
                    wetherPicture2.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon1}.png";
                    wetherPicture3.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon2}.png";
                    wetherPicture4.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon3}.png";
                    wetherPicture5.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon4}.png";
                    wetherPicture6.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon5}.png";
                    wetherPicture7.ImageLocation = $"https://www.jma.go.jp/bosai/forecast/img/{icon6}.png";

                    //最低気温
                    MinTemp1.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMin[0] += "℃";
                    MinTemp2.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMin[1] += "℃";
                    MinTemp3.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMin[2] += "℃";
                    MinTemp4.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMin[3] += "℃";
                    MinTemp5.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMin[4] += "℃";
                    MinTemp6.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMin[5] += "℃";
                    MinTemp7.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMin[6] += "℃";

                    //最高気温
                    MaxTemp1.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMax[0] += "℃";
                    MaxTemp2.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMax[1] += "℃";
                    MaxTemp3.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMax[2] += "℃";
                    MaxTemp4.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMax[3] += "℃";
                    MaxTemp5.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMax[4] += "℃";
                    MaxTemp6.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMax[5] += "℃";
                    MaxTemp7.Text = jsonWeek[1].timeSeries[1].areas[0].tempsMax[6] += "℃";

                    //降水確率
                    pops1.Text = jsonWeek[1].timeSeries[0].areas[0].pops[0] += "％";
                    pops2.Text = jsonWeek[1].timeSeries[0].areas[0].pops[1] += "％";
                    pops3.Text = jsonWeek[1].timeSeries[0].areas[0].pops[2] += "％";
                    pops4.Text = jsonWeek[1].timeSeries[0].areas[0].pops[3] += "％";
                    pops5.Text = jsonWeek[1].timeSeries[0].areas[0].pops[4] += "％";
                    pops6.Text = jsonWeek[1].timeSeries[0].areas[0].pops[5] += "％";
                    pops7.Text = jsonWeek[1].timeSeries[0].areas[0].pops[6] += "％";

                    if (MinTemp1.Text == ""+ "℃") {
                        MinTemp1.Text = "なし";
                    } 


                    if (MaxTemp1.Text == ""+ "℃") {
                        MaxTemp1.Text = "なし";
                    } 


                    if (pops1.Text == ""+ "％") {
                        pops1.Text = "なし";
                    }

                    if (windInfo.Text == "") {
                        windInfo.Text = "なし";
                    }

                    break;
            }

            //} catch (IndexOutOfRangeException ) {
            //        throw;
            //        MessageBox.Show( "大変申し訳ありません。データがありません");


            //    }

        }
        //コンボボックスに地域を格納
        private void setPre(string name) {
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
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            labelVisible();
            BackgroundImageLayout = ImageLayout.Zoom;
            BackgroundImage = Image.FromFile(@"RED2020906021_TP_V.jpg");

            //ラベルの透過
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            todayLabel.BackColor = Color.Transparent;
            weekLabel.BackColor = Color.Transparent;
            wetherInfo.BackColor = Color.Transparent;
            tomorrowLabel.BackColor = Color.Transparent;

            minTempLabel.BackColor = Color.Transparent;
            MinTemp1.BackColor = Color.Transparent;
            MinTemp2.BackColor = Color.Transparent;
            MinTemp3.BackColor = Color.Transparent;
            MinTemp4.BackColor = Color.Transparent;
            MinTemp5.BackColor = Color.Transparent;
            MinTemp6.BackColor = Color.Transparent;
            MinTemp7.BackColor = Color.Transparent;

            maxTempLabel.BackColor = Color.Transparent;
            MaxTemp1.BackColor = Color.Transparent;
            MaxTemp2.BackColor = Color.Transparent;
            MaxTemp3.BackColor = Color.Transparent;
            MaxTemp4.BackColor = Color.Transparent;
            MaxTemp5.BackColor = Color.Transparent;
            MaxTemp6.BackColor = Color.Transparent;
            MaxTemp7.BackColor = Color.Transparent;

            windLabel.BackColor = Color.Transparent;
            windInfo.BackColor = Color.Transparent;

            date1.BackColor = Color.Transparent;
            date2.BackColor = Color.Transparent;
            date3.BackColor = Color.Transparent;
            date4.BackColor = Color.Transparent;
            date5.BackColor = Color.Transparent;
            date6.BackColor = Color.Transparent;
            date7.BackColor = Color.Transparent;

            popsLabel.BackColor = Color.Transparent;
            pops1.BackColor = Color.Transparent;
            pops2.BackColor = Color.Transparent;
            pops3.BackColor = Color.Transparent;
            pops4.BackColor = Color.Transparent;
            pops5.BackColor = Color.Transparent;
            pops6.BackColor = Color.Transparent;
            pops7.BackColor = Color.Transparent;

            //日にち追加
            date1.Text = DateTime.Now.ToString("MM/dd");
            date2.Text = DateTime.Now.AddDays(1).ToString("MM/dd");
            date3.Text = DateTime.Now.AddDays(2).ToString("MM/dd");
            date4.Text = DateTime.Now.AddDays(3).ToString("MM/dd");
            date5.Text = DateTime.Now.AddDays(4).ToString("MM/dd");
            date6.Text = DateTime.Now.AddDays(5).ToString("MM/dd");
            date7.Text = DateTime.Now.AddDays(6).ToString("MM/dd");
            mask();
            foreach (var name in areas) {
                setPre(name.Key);
            }
            foreach (var date in dates) {
                setDate(date);
            }

        }

        //ラベル表示非表示処理
        private void labelVisible() {
            if (date_select.SelectedIndex == 0) {
                todayLabel.Visible = true;
                tomorrowLabel.Visible = false;
                weekLabel.Visible = false;
                date1.Visible = true;
                date2.Visible = false;
                date3.Visible = false;
                date4.Visible = false;
                date5.Visible = false;
                date6.Visible = false;
                date7.Visible = false;
                wetherPicture1.Visible = true;
                wetherPicture2.Visible = false;
                wetherPicture3.Visible = false;
                wetherPicture4.Visible = false;
                wetherPicture5.Visible = false;
                wetherPicture6.Visible = false;
                wetherPicture7.Visible = false;
                MinTemp1.Visible = true;
                MinTemp2.Visible = false;
                MinTemp3.Visible = false;
                MinTemp4.Visible = false;
                MinTemp5.Visible = false;
                MinTemp6.Visible = false;
                MinTemp7.Visible = false;
                MaxTemp1.Visible = true;
                MaxTemp2.Visible = false;
                MaxTemp3.Visible = false;
                MaxTemp4.Visible = false;
                MaxTemp5.Visible = false;
                MaxTemp6.Visible = false;
                MaxTemp7.Visible = false;
                pops1.Visible = true;
                pops2.Visible = false;
                pops3.Visible = false;
                pops4.Visible = false;
                pops5.Visible = false;
                pops6.Visible = false;
                pops7.Visible = false;


            } else if (date_select.SelectedIndex == 1) {
                todayLabel.Visible = false;
                tomorrowLabel.Visible = true;
                weekLabel.Visible = false;
                date1.Visible = false;
                date2.Visible = true;
                date3.Visible = false;
                date4.Visible = false;
                date5.Visible = false;
                date6.Visible = false;
                date7.Visible = false;
                wetherPicture1.Visible = false;
                wetherPicture2.Visible = true;
                wetherPicture3.Visible = false;
                wetherPicture4.Visible = false;
                wetherPicture5.Visible = false;
                wetherPicture6.Visible = false;
                wetherPicture7.Visible = false;
                MinTemp1.Visible = false;
                MinTemp2.Visible = true;
                MinTemp3.Visible = false;
                MinTemp4.Visible = false;
                MinTemp5.Visible = false;
                MinTemp6.Visible = false;
                MinTemp7.Visible = false;
                MaxTemp1.Visible = false;
                MaxTemp2.Visible = true;
                MaxTemp3.Visible = false;
                MaxTemp4.Visible = false;
                MaxTemp5.Visible = false;
                MaxTemp6.Visible = false;
                MaxTemp7.Visible = false;
                pops1.Visible = false;
                pops2.Visible = true;
                pops3.Visible = false;
                pops4.Visible = false;
                pops5.Visible = false;
                pops6.Visible = false;
                pops7.Visible = false;

            } else if (date_select.SelectedIndex == 2) {
                todayLabel.Visible = false;
                tomorrowLabel.Visible = false;
                weekLabel.Visible = true;
                date1.Visible = true;
                date2.Visible = true;
                date3.Visible = true;
                date4.Visible = true;
                date5.Visible = true;
                date6.Visible = true;
                date7.Visible = true;
                wetherPicture1.Visible = true;
                wetherPicture2.Visible = true;
                wetherPicture3.Visible = true;
                wetherPicture4.Visible = true;
                wetherPicture5.Visible = true;
                wetherPicture6.Visible = true;
                wetherPicture7.Visible = true;
                MinTemp1.Visible = true;
                MinTemp2.Visible = true;
                MinTemp3.Visible = true;
                MinTemp4.Visible = true;
                MinTemp5.Visible = true;
                MinTemp6.Visible = true;
                MinTemp7.Visible = true;
                MaxTemp1.Visible = true;
                MaxTemp2.Visible = true;
                MaxTemp3.Visible = true;
                MaxTemp4.Visible = true;
                MaxTemp5.Visible = true;
                MaxTemp6.Visible = true;
                MaxTemp7.Visible = true;
                pops1.Visible = true;
                pops2.Visible = true;
                pops3.Visible = true;
                pops4.Visible = true;
                pops5.Visible = true;
                pops6.Visible = true;
                pops7.Visible = true;

            } else {
                todayLabel.Visible = weekLabel.Visible = tomorrowLabel.Visible = false;

                date1.Visible = date2.Visible = date3.Visible = date4.Visible
                              = date5.Visible = date6.Visible = date7.Visible
                              = false;

                wetherPicture1.Visible = wetherPicture2.Visible = wetherPicture3.Visible
                                       = wetherPicture4.Visible = wetherPicture5.Visible
                                       = wetherPicture6.Visible = wetherPicture7.Visible
                                       = false;
                MinTemp1.Visible = false;
                MinTemp2.Visible = false;
                MinTemp3.Visible = false;
                MinTemp4.Visible = false;
                MinTemp5.Visible = false;
                MinTemp6.Visible = false;
                MinTemp7.Visible = false;
                MaxTemp1.Visible = false;
                MaxTemp2.Visible = false;
                MaxTemp3.Visible = false;
                MaxTemp4.Visible = false;
                MaxTemp5.Visible = false;
                MaxTemp6.Visible = false;
                MaxTemp7.Visible = false;
                pops1.Visible = false;
                pops2.Visible = false;
                pops3.Visible = false;
                pops4.Visible = false;
                pops5.Visible = false;
                pops6.Visible = false;
                pops7.Visible = false;
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

        //テキスト表示非表示処理
        private void textVisible() {
            wetherInfo.Text = windInfo.Text =
            MinTemp1.Text = MinTemp2.Text =
            MinTemp3.Text = MinTemp4.Text =
            MinTemp5.Text = MinTemp6.Text =
            MinTemp7.Text =
            MaxTemp1.Text = MaxTemp2.Text =
            MaxTemp3.Text = MaxTemp4.Text =
            MaxTemp5.Text = MaxTemp6.Text =
            MaxTemp7.Text =
            pops1.Text = pops2.Text =
            pops3.Text = pops4.Text =
            pops5.Text = pops6.Text =
            pops7.Text = "";
            
        }

        //画像表示非表示処理
        private void pictureVisible() {
            wetherPicture1.Image = wetherPicture2.Image = wetherPicture3.Image =
            wetherPicture4.Image = wetherPicture5.Image = wetherPicture6.Image =
            wetherPicture7.Image = null;
        }

        //CSVファイルをDictionaryのオブジェクトに変換して、返す
        private static Dictionary<string, string> areaCsvRead() {

            var file = @"areacode.csv";
            var pre = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                AreaCode areaCode = new AreaCode {
                    Name = items[0],
                    Code = items[1]
                };

                pre.Add(areaCode.Name, areaCode.Code);

            }
            return pre;

        }

        //今日、三日間、七日間をリストに格納
        private static List<string> setListDates() {
            var date = new List<string>();
            date.Add("Today");
            date.Add("Tomorrow");
            date.Add("Week");

            return date;

        }
        

        //地域コンボボックスの選択処理
        private void cb_areaList_SelectedIndexChanged(object sender, EventArgs e) {
            textVisible();
            mask();
            labelVisible();
            pictureVisible();

        }

        //日時コンボボックスの選択処理
        private void date_select_SelectedIndexChanged(object sender, EventArgs e) {
            textVisible();
            mask();
            labelVisible();
            pictureVisible();
            
        }

        private void ひまわりToolStripMenuItem_Click(object sender, EventArgs e) {
            
            //f2 = new Form2();
           
            //f2.Show();
            
            
           
           
        }
        
    }

    
    }
