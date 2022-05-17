using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Exercise1_1(names);
            Console.WriteLine("------------------");

            Exercise01_2(names);
            Console.WriteLine("------------------");

            Exercise01_3(names);
            Console.WriteLine("------------------");

            Exercise01_4(names);

        }
        private static void Exercise1_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");
            do {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) 
                break;
                int index = names.FindIndex(n => n == line);
                Console.WriteLine(index);
            
            } while (true); //無限ループ
        }

        private static void Exercise01_2(List<string> names) {
            var count = names.Count(n => n.Contains("o"));
            Console.WriteLine(count);
            
        }
        private static void Exercise01_3(List<string> names) {
            var name = names.Where(n => n.Contains("o")).ToArray();
            foreach (var n in name) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise01_4(List<string> names) {
            var name = names.Where(n => n.StartsWith("B")).Select(n => n.Length);
            foreach (var n in name) {
                Console.WriteLine(n);
            }
           
        }

       

       

       
    }
}
