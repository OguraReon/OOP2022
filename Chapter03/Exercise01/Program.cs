using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            Exercise1_1(numbers);
            Console.WriteLine("------------------");

            Exercise01_2(numbers);
            Console.WriteLine("------------------");

            Exercise01_3(numbers);
            Console.WriteLine("------------------");

            Exercise01_4(numbers);

        }

        private static void Exercise1_1(List<int> numbers) {
            var exists = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            Console.WriteLine(exists);
        }
        private static void Exercise01_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }
        private static void Exercise01_3(List<int> numbers) {
            var nums = numbers.Where(n => n >= 50);
            foreach (var w in nums.Where(n => n >= 50)) {
                Console.WriteLine(w);
            }
        }
        private static void Exercise01_4(List<int> numbers) {
            var list = numbers.Select(n => n * 2).ToList();

            numbers[5] = 5000;

            foreach (var n in list) { //遅延実行(即時実行)
                Console.WriteLine(n);
            }

        }
    }
}
