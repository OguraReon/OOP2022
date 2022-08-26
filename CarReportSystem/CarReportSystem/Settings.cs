using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarReportSystem {
    

    //設定情報
    [Serializable]
    public class Settings {
       private static Settings setting;

       [System.ComponentModel.DisplayName("色")]        
       public int MainFormColor { get; set; }

        //コンストラクタ
        private Settings() {
            
        }

        public static Settings getSettings() {

            if (setting == null) {
                setting = new Settings();
            }

            return setting;
        }


    }
}
