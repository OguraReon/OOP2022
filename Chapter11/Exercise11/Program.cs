using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Exercise11 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

            var test = File.ReadAllText(newfile);
            Console.WriteLine(test);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var samples = xdoc.Root.Elements().Select(x => new {
                Name = x.Element("name").Value,
                TeamMember = x.Element("teammembers").Value
            });
            foreach (var sample in samples) {
                Console.WriteLine("{0}部 {1}人", sample.Name, sample.TeamMember);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var samples = xdoc.Root.Elements()
                            .Select(x => new {
                 Name = x.Element("name").Attribute("kanji").Value,
                 PlayDate = x.Element("firstplayed").Value
             });
            foreach (var sample in samples.OrderBy(x => x.PlayDate)) {
                Console.WriteLine("{0}部 {1}年", sample.Name, sample.PlayDate);
            }

        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var samples = xdoc.Root.Elements().Select(x => new {
                Name = x.Element("name").Value,
                TeamMember = x.Element("teammembers").Value
            }).OrderByDescending(x => x.TeamMember).FirstOrDefault();
            Console.WriteLine("{0}部 {1}人", samples.Name, samples.TeamMember);
        }

        private static void Exercise1_4(string file, string newfile) {
            var xdoc = XDocument.Load(file);
            var element = new XElement("ballsport",
                new XElement("name","サッカー",new  XAttribute("kanji","蹴球")),
                new XElement("teammembers","11"),
                new XElement("firstplayed", "1863")
                );
            xdoc.Root.Add(element);
            xdoc.Save(newfile);
           
        }
    }
}
