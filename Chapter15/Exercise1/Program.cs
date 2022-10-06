using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book);                     
        }

        private static void Exercise1_3() {
            //var group = Library.Books.GroupBy(b => b.PublishedYear).Select(g => new {
            //    Year = g.Key,
            //    Count = g.Count()
            //});

            //foreach (var c in group) {
            //    Console.WriteLine($"{c.Year}年 {c.Count}冊");

            //}

            var group1 = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(b =>b.Key);
            foreach (var g in group1) {
                Console.WriteLine($"{g.Key}年,{g.Count()}冊");
            }
            
            
        }

        private static void Exercise1_4() {
            
        }

        private static void Exercise1_5() {
            
        }

        private static void Exercise1_6() {
           
        }

        private static void Exercise1_7() {
            
        }

        private static void Exercise1_8() {
           
        }
    }
}
