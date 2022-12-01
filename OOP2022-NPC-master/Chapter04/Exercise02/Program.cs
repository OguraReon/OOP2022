using Exercise01;
using System;
using System.Linq;

namespace Exercise02 {
    class Program {
        public static void Main(string[] args) {

            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(2001,12),
                new YearMonth(2004,2),
                new YearMonth(2002,4),
                new YearMonth(2000,5),
                new YearMonth(1900,5),
            };

            //4.2.2
            Exercise02_2(ymCollection);
            Console.WriteLine("-----------");

            //4.2.4
            Exercise02_4(ymCollection);
            Console.WriteLine("-----------");

            //4.2.5
            Exercise02_5(ymCollection);
            Console.WriteLine("-----------");

            Exercise02_6(ymCollection);
            Console.WriteLine("-----------");

            /* var ym = new YearMonth(2022, 12);

             var check = ym.Is21Century;
             var test = ym.AddOneMonth();

             Console.WriteLine(ym);
            */
        }

        private static void Exercise02_2(YearMonth[] ymCollection) {

            foreach (var y in ymCollection) {
                Console.WriteLine(y);
            }

        }

        //4.2.3
        //最初に見つかった21世紀のオブジェクトを返す
        //見つからない場合はnullを返す

        static YearMonth FindFirst21C(YearMonth[] yms) {

            foreach (var y in yms) {
                if (y.Is21Century == true) {
                    return y;
                }
            }
            return null;
        }
        private static void Exercise02_4(YearMonth[] ymCollection) {

            var num = FindFirst21C(ymCollection);
            if (num == null) {
                Console.WriteLine("21世紀のデータはありません");
            } else {
                Console.WriteLine(num);
            }
        }
        private static void Exercise02_5(YearMonth[] ymCollection) {
            /*var yearMonth = new List<YearMonth>();
            foreach (var y in ymCollection) {
                y.AddOneMonth();
                yearMonth.Add(y);
                Console.WriteLine(y);
            }
            */
            Console.WriteLine("------------");

            var array = ymCollection.Select(y => y.AddOneMonth()).ToArray();
            foreach (var a in array) {
                Console.WriteLine(a);
            }
        }
        private static void Exercise02_6(YearMonth[] ymCollection) {
            //(1)月で昇順
            foreach (var y in ymCollection.OrderBy(y => y.Month)) {
                Console.WriteLine(y);
            }
            Console.WriteLine("---------------------");

            //(2)偶数年のみ昇順
            foreach (var y in ymCollection.Where(y => y.Year % 2 == 0).OrderBy(y => y.Year)) {
                Console.WriteLine(y);
            }
            Console.WriteLine("---------------------");

            //(3)うるう年のみ出力

            foreach (var y in ymCollection.Where(y => DateTime.IsLeapYear(y.Year))) {
                Console.WriteLine(y);
            }
            Console.WriteLine("--------------------");

            //(4)すべての年から12月に一番近い月を出力

            var date = ymCollection.Max(y => y.Month);
            Console.WriteLine(date);
        }
    }
}
