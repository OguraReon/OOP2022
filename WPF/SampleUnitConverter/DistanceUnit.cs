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

        public static ICollection<MetricUnit>Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>

        public double FromImperialUnit(ImperialUnit unit, double value) {
            return (value * unit.Coenfficient) * 25.4 / this.Coenfficient;
        
        }

    }


    //ヤード単位を表すクラス
    public class ImperialUnit : DistanceUnit {
        private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit { Name = "in",Coenfficient = 1,},
            new ImperialUnit { Name = "ft",Coenfficient = 12,},
            new ImperialUnit { Name = "yd",Coenfficient = 12 * 3,},
            new ImperialUnit { Name = "ml",Coenfficient = 12 * 3 * 1760,},

        };

        public static ICollection<ImperialUnit> Units { get { return units; } }


        /// <summary>
        /// メートル単位からヤード単位へ変換 
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FromMetricUnit(MetricUnit unit, double value) {
            return (value * unit.Coenfficient) / 25.4 / this.Coenfficient;

        }
    }
}
