using System;
using System.Collections.Generic;

namespace Section01 {
    class Program {

        static void Main(string[] args) {
            var greetings = new List<IGreeting>() {
                new GreetingMorning(),
                new GreetingAfternoon(),
                new GreetingEvening(),
            };

            foreach (var obj in greetings) {
                string msj = obj.GetMessage();
                Console.WriteLine(msj);
            }
        }
    }
}
