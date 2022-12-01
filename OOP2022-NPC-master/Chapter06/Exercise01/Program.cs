using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {

            //最大値を求める
            var maxNum = numbers.Max();
            Console.WriteLine(maxNum.ToString());
        }

        private static void Exercise1_2(int[] numbers) {
            //最後から二つ目を取り出す
           
            foreach (var item in numbers.Skip(numbers.Length-2)) {
                Console.WriteLine(item);
            }
            
        }

        private static void Exercise1_3(int[] numbers) {
            var numTostr = numbers.Select(num => num.ToString());
            foreach (var item in numTostr) {
                Console.WriteLine(item);
            }
            
        }

        private static void Exercise1_4(int[] numbers) {
            //小さい順　先頭から三個抽出
            foreach (var item in numbers.OrderBy(num => num).Take(3)) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            //重複排除の後、１０より大きい数カウント
            var disNum = numbers.Distinct().Count(n => n > 10);
            foreach (var item in disNum.ToString()) {
                Console.WriteLine(item);
            }
        }
    }
}
