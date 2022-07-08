using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {

    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Hiredate { get; set; }
        public override string ToString() {
            return string.Format("[Id={0}, Name={1}, Hiredate={2}]",
                                  Id, Name, Hiredate);
        }
    }
    public class EmployeeCollection {
        [XmlElement(Type = typeof(Employee), ElementName = "employee")]
        public Employee[] Employees { get; set; }
    }
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var emp = new Employee {
                Id = 1,
                Name = "小倉伶音",
                Hiredate = new DateTime(2002, 4, 16)
            };

            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using (var writer = XmlWriter.Create("employee.xml")) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
           

        }

        private static void Exercise1_2(string v) {
            var emps = new Employee[] {
                new Employee {
                Id = 1,
                Name = "小倉伶音",
                Hiredate = new DateTime(2002, 4, 16)
                },
                new Employee {
                Id = 2,
                Name = "OguraReon",
                Hiredate = new DateTime(2000,1,1)
                }
            };
            var empCollection = new EmployeeCollection {
                Employees = emps
            };

            using (var writer = XmlWriter.Create("employees.xml")) {
                var serializer = new XmlSerializer(empCollection.GetType());
                serializer.Serialize(writer, empCollection);
            }

            Display("employees.xml");
        }

        private static void Exercise1_3(string v) {
            
              using (var reader = XmlReader.Create("employees.xml")) {
                    var serializer = new XmlSerializer(typeof(EmployeeCollection));
                    var emp = serializer.Deserialize(reader) as EmployeeCollection;
                    // 以下、内容を確認するコード
                    foreach (var item in emp.Employees) {
                        Console.WriteLine(item);
                    }
              }
            
        }

        private static void Exercise1_4(string v) {
            
        }
        //XMLファイルの中身表示用
        private static void Display(string filename) {
            var lines = File.ReadLines(filename);
            foreach (var line in lines)
                Console.WriteLine(line);

        }
    }
}
