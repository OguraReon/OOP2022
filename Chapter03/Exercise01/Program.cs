﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };           

            Exercise1_1(numbers);
            Console.WriteLine("------------------");

            Exercise01_2(numbers);
            Console.WriteLine("------------------");
        }

        private static void Exercise01_2(List<int> numbers) {
           
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }

        private static void Exercise1_1(List<int> numbers) {
            var exists = numbers.Exists(n => n % 21 == 0 || n % 92 == 0);
            Console.WriteLine(exists);           
        }
    }
}
