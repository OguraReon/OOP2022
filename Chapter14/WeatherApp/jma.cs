using System;

namespace WeatherApp {

    //今日
    public class Rootobject {
        public string publishingOffice { get; set; }
        public DateTime reportDatetime { get; set; }
        public string targetArea { get; set; }
        public string headlineText { get; set; }
        public string text { get; set; }
    }

    //一週間
    public class RootobjectWeek {
        public string publishingOffice { get; set; }
        public DateTime reportDatetime { get; set; }
        public string headTitle { get; set; }
        public string text { get; set; }
    }



    //お天気マーク、一週間の情報
    public class RootobjectAreaIcon {
        public Class1[] Property1 { get; set; }
    }

    //お天気マーク、一週間の情報
    public class Class1 {
        public string publishingOffice { get; set; }
        public DateTime reportDatetime { get; set; }
        public Timesery[] timeSeries { get; set; }
        public Tempaverage tempAverage { get; set; }
        public Precipaverage precipAverage { get; set; }
    }

    //お天気マーク、一週間の情報
    public class Tempaverage {
        public Area[] areas { get; set; }
    }

    public class Area {
        public Area1 area { get; set; }
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Area1 {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Precipaverage {
        public Area2[] areas { get; set; }
    }

    public class Area2 {
        public Area3 area { get; set; }
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Area3 {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Timesery {
        public DateTime[] timeDefines { get; set; }
        public Area4[] areas { get; set; }
    }

    public class Area4 {
        public Area5 area { get; set; }
        public string[] weatherCodes { get; set; }
        public string[] weathers { get; set; }
        public string[] winds { get; set; }
        public string[] pops { get; set; }
        public string[] temps { get; set; }
        public string[] reliabilities { get; set; }
        public string[] tempsMin { get; set; }
        public string[] tempsMinUpper { get; set; }
        public string[] tempsMinLower { get; set; }
        public string[] tempsMax { get; set; }
        public string[] tempsMaxUpper { get; set; }
        public string[] tempsMaxLower { get; set; }
    }

    public class Area5 {
        public string name { get; set; }
        public string code { get; set; }
    }

    //ひまわり　日本海付近
    public class RootobjectWetherMap {
        public Class1[] Property1 { get; set; }
    }

    //ひまわり　日本海付近
    public class WetherMapClass1 {
        public string basetime { get; set; }
        public string validtime { get; set; }
    }



    //雨雲レーダー
    public class RootobjectRainCloudMap {
        public Class1[] Property1 { get; set; }
    }

    //雨雲レーダー
    public class RainCloudMapClass1 {
        public string basetime { get; set; }
        public string validtime { get; set; }
        public string[] elements { get; set; }
    }


}