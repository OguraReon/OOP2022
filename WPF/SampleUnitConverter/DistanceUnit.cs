using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class DistanceUnit {
        public string Name { get; set;}//単位の名称
        public double Coenfficient { get; set; } //係数
        public override string ToString() {
            return this.Name; 
        }
    }

    //メートル単位を表すクラス
    public class MetricUnit : DistanceUnit {
        private static List<MetricUnit> units = new List<MetricUnit> {
            new MetricUnit{Name = "mm",Coenfficient =1},
            new MetricUnit{Name = "cm",Coenfficient =10},
            new MetricUnit{Name = "m",Coenfficient =10 * 100},
            new MetricUnit{Name = "km",Coenfficient =10 * 100 * 100},
        };
    }


    //ヤード単位を表すクラス
    public class ImperialUnit : DistanceUnit {

    }
}
