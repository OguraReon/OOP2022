using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
   public static class FeetConverter {
        private const double ratio = 0.3048; //定数を定義
        //public const readonly double ratio = 0.03048;外部からもアクセスさせたい場合

        //メートルからフィートを求める(静的メソッド)
        public static double FromMeter(int meter) {
        return meter / ratio;
    }
        //メートルからフィートを求める(静的メソッド)
        public static double ToMeter(int feet) {
            return feet / ratio;
        }
    }
}
