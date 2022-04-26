﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
   public static class FeetConverter {
        //メートルからフィートを求める(静的メソッド)
        public static double FromMeter(int meter) {
         
        return meter / 0.3048;
    }
        //メートルからフィートを求める(静的メソッド)
        public static double ToMeter(int feet) {
            return feet / 0.3048;
        }

    }
}
