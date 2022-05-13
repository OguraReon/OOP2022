using System;
using System.Collections.Generic;

namespace Section01 {
    class Program {
       

        static void Main(string[] args) {
            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            /*var exists = list.Exists(s => s[0] == 'A');
            Console.WriteLine(exists);*/

            var names = list.FindAll(s => s.Length <= 5);
            names.ForEach(s => Console.WriteLine(s));
            
            
            //foreach (var s in names) {
            //    Console.WriteLine(s);
           // }
            
        }

    }
}
