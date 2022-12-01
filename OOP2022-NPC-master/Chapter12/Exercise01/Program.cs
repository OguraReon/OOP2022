using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {

    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public override string ToString() {
            return string.Format("[Id={0}, Name={1}, Hiredate={2}]",
                                  Id, Name, HireDate);
        }
    }
    [DataContract(Name = "employee2")]
    public class Employee2 {
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "hireDate")]
        public DateTime HireDate { get; set; }
    }
    public class EmployeeCollection {
            [XmlElement(Type = typeof(Employee), ElementName = "employee")]
            public Employee[] Employees { get; set; }
        }

        public class EmployeeCollection2 {
            [XmlElement(Type = typeof(Employee), ElementName = "employee")]
            public Employee2[] Employees { get; set; }
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
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var emp = new Employee {
                Id = 1,
                Name = "小倉伶音",
                HireDate = new DateTime(2002, 4, 16)
            };

            //シリアル化
            using (var writer = XmlWriter.Create(outfile)) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }

            //逆シリアル化
            using (var reader = XmlReader.Create(outfile)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employee);
            }


        }

        private static void Exercise1_2(string outfile) {
            var emps = new Employee[] {
                new Employee {
                Id = 1,
                Name = "小倉伶音",
                HireDate = new DateTime(2002, 4, 16)
                },
                new Employee {
                Id = 2,
                Name = "OguraReon",
                HireDate = new DateTime(2000,1,1)
                }
            };
            var empCollection = new EmployeeCollection {
                Employees = emps
            };

            using (var writer = XmlWriter.Create(outfile)) {
                var serializer = new XmlSerializer(empCollection.GetType());
                serializer.Serialize(writer, empCollection);
            }

            Display(outfile);
        }

        private static void Exercise1_3(string outfile) {

            using (var reader = XmlReader.Create(outfile)) {
                var serializer = new XmlSerializer(typeof(EmployeeCollection));
                var emp = serializer.Deserialize(reader) as EmployeeCollection;
                // 以下、内容を確認するコード
                foreach (var item in emp.Employees) {
                    Console.WriteLine(item);
                }
            }

        }

        private static void Exercise1_4(string outfile) {

            var emps = new Employee2[] {
                new Employee2 {
                    Id = 123,
                    Name = "出井 秀行",
                    HireDate = new DateTime(2001, 5, 10)
                },
                new Employee2 {
                    Id = 139,
                    Name = "大橋 孝仁",
                    HireDate = new DateTime(2004, 12, 1)
                },
            };

            var empCollection2 = new EmployeeCollection2 {
                Employees = emps
            };
            using (var stream = new FileStream(outfile, FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(empCollection2.GetType(),
                                 new DataContractJsonSerializerSettings {
                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd")
                                 });
                serializer.WriteObject(stream, empCollection2);
            }

        }
            //XMLファイルの中身表示用
            private static void Display(string filename) {
                var lines = File.ReadLines(filename);
                foreach (var line in lines)
                    Console.WriteLine(line);

            }
        }
    }


