using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class InchConverter {
         //１インチの値
        public const double ratio = 0.0254;

        //メートルからInchを求める(静的メソッド)
        public static double FromMeter(int meter) {
            return meter / ratio;
        }
        //インチからメートルを求める(静的メソッド)
        public static double ToMeter(int Inch) {
            return Inch * ratio;
        }
    }


}
