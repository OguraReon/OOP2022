using System;
using System.Collections.Generic;
using System.Linq;

namespace Section04 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            // IEnumerable<string> query = names.FindAll(s => s.Length <= 5);
            var query = names.Select(s => s.Length);
            foreach (var s in query) {
                Console.WriteLine(s);
            }
        }
    }
}
