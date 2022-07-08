﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            //Serialize();
            Deserialize();
        }

        //List 12-2
        //シリアル化
        public static void Serialize() {
            //var novel = new Novel {
            //    Author = "ジェイムズ・P・ホーガン",
            //    Title = "星を継ぐもの",
            //    Published = 1977,
            //};

            var novels = new Novel[] {
               new Novel {
                  Author = "ジェイムズ・P・ホーガン",
                  Title = "星を継ぐもの",
                  Published = 1977,
               },
               new Novel {
                  Author = "H・G・ウェルズ",
                  Title = "タイム・マシン",
                  Published = 1895,
               },
            };

            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using (var writer = XmlWriter.Create("novels.xml", settings)) {
                var serializer = new DataContractSerializer(novels.GetType()); //P185
                serializer.WriteObject(writer, novels);
            }

            Display("novels.xml");
        }

        //List 12-3
        //逆シリアル化
        public static void Deserialize() {
            using (var reader = XmlReader.Create("novels.xml")) {
                var serializer = new DataContractSerializer(typeof(Novel[]));
                var novel = serializer.ReadObject(reader) as Novel[];
                foreach (var item in novel) {
                    Console.WriteLine(item);
                }
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
