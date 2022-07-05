using System;
using System.Xml;
using System.Xml.Serialization;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var novels = new Novel[] {

              new Novel {
                Author = "ジェイムズ・P・ホーガン",
                Title = "星を継ぐもの",
                Published = 1977,
              },
              new Novel {
                Author = "H・G・ウェルズ",
                Title = "タイムマシン",
                Published = 1895,
              },

            };

            var novelCollection = new NovelCollection {
                Novels = novels
            };
           


            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };

            //シリアル化リスト(リスト　１２－６)
            /*using (var writer = XmlWriter.Create("novel.xml")) {
                var serializer = new XmlSerializer(novelCollection.GetType());
                serializer.Serialize(writer, novelCollection);
            }*/

            //逆シリアル化(リスト　12ー５)
            using (var reader = XmlReader.Create("novel.xml")) {
                //var serializer = new DataContractSerializer(typeof(Novel));
                var serializer = new XmlSerializer(typeof(NovelCollection));
                var novels1 = serializer.Deserialize(reader) as NovelCollection;
                Console.WriteLine(novels1);

                foreach (var novel in novels1.Novels) {
                    Console.WriteLine(novel);
                }
            }
        }
    }
}
