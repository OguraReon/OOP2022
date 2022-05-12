using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        public static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルの対応表を出力
                PrintInchToMeterList(1, 10);
            } else {
                //メートルからフィートの対応表を出力
                PrintMeterToInchList(1, 10);
            }
        }
        //フィートからメートルの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {

            for (int meter = 1; meter <= 10; meter++) {
                double inch = InchConverter.ToMeter(meter);
                Console.WriteLine("{0}m = {1:0.0000} inch", meter, inch);
            }
        }
        //メートルからフィートの対応表を出力
        private static void PrintInchToMeterList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.FromMeter(inch);
                Console.WriteLine("{0}inch = {1:0.0000} m", inch, meter);
            }
        }
    }
}
