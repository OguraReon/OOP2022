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
        private static string text = "Jackdaws love my big sphinx of quartz";
        private static string line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

        static void Main(string[] args) {            

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            foreach (var lines in line.Split(';')) 
                {
                var array = lines.Split('=');
                Console.WriteLine("{0}:{1}", ToJapanese(array[0]), array[1]);
            }
            Console.WriteLine("-----");           
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
            var eng1 = text.Count(e => e == ' ');
            Console.WriteLine(eng1);

            Console.WriteLine("----------------");

            //5.1.3.2
            var eng2 = text.Replace("big", "small");
            Console.WriteLine(eng2);

            Console.WriteLine("----------------");

            //5.1.3.3
            var eng3 = text.Split(' ').Length;
            Console.WriteLine(eng3);

            Console.WriteLine("----------------");

            //5.1.3.4
            var eng4 = text.Split(' ').Where(e => e.Length <= 4);
            foreach (var e in eng4) {
                Console.WriteLine(e);
            }

            Console.WriteLine("----------------");

            //5.1.3.5
            var eng5 = text.Split(' ').ToArray();
            if (eng5.Length > 0) {
                var sb = new StringBuilder();           
                foreach (var e in eng5.Skip(1)) {                   
                    sb.Append(' ');
                    sb.Append(e);
                }
                var textBuilder = sb.ToString();
                Console.WriteLine(textBuilder);
            }
        }
        private static string ToJapanese(string key) {                                  
            switch (key) {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数keyは、正しい値ではありません");
            
        }        
    }
}
