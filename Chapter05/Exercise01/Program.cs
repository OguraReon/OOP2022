using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class Program {
        private static string str1 = Console.ReadLine();
        private static string str2 = Console.ReadLine();
        private static string strToNum = Console.ReadLine();
        private static int num1 = 0;
        private static int num2 = 0;
        private static string text = "Jackdaws love my big sphinx of quartz";

        static void Main(string[] args) {


            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");
            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            //5.1.1
            if (string.Compare(str1, str2, true) == 0) {
                Console.WriteLine("正しい");
            } else {
                Console.WriteLine("正しくない");
            }
        }

        private static void Exercise3_2(string text) {
            //5.1.2                       
            if (int.TryParse(strToNum, out num1)) {

                Console.WriteLine(string.Format("{0:N0}",num1));
            }
        }

        private static void Exercise3_3(string text) {
            //5.1.3.1
            var eng1 = text.Where(e => e.ToString().Contains(" ")).Count();
            Console.WriteLine(eng1);

            //5.1.3.2
            var eng2 = text.Replace("big", "small");
            Console.WriteLine(eng2);

            //5.1.3.3
            
        }

        private static void Exercise3_4(string text) {
            
        }

        private static void Exercise3_5(string text) {
            
        }
    }
}
