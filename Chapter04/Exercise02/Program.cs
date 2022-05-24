using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        public static void Main(string[] args) {

            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(2001,12),
                new YearMonth(2010,2),
               new YearMonth(2002,4),
               new YearMonth(2000,5),
                new YearMonth(1933,5),


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
            var yearMonth = new List<YearMonth>();
            foreach (var y in ymCollection) {
                y.AddOneMonth();
                yearMonth.Add(y);
                Console.WriteLine(y);
            }
            Console.WriteLine("------------");

            var array = ymCollection.Select(y => y.AddOneMonth()).ToArray();
            foreach (var a in array) {
                Console.WriteLine(a);
            }
        }

        private static void Exercise02_6(YearMonth[] ymCollection) {
            ymCollection.OrderByDescending(y => y.Year);
            foreach (var y in ymCollection) {
                Console.WriteLine(y);
            }

        }
    }
}
