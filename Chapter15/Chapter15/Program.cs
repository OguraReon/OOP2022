using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {
            var asc = 1;
            var desc = 2;
            int num;
            var Years = new List<int>();

            //西暦入力
            Console.WriteLine("西暦入力  :");
            var inputYear = int.Parse(Console.ReadLine());           

            while (inputYear != -1) {
                Years.Add(inputYear);
                inputYear = int.Parse(Console.ReadLine());                                                                           

            }
            //入力した西暦とあっているものを抽出
            var Yearslist = Library.Books.Where(b => Years.Contains(b.PublishedYear));

            //昇順、降順
            Console.WriteLine("昇順 1    降順 2   ");
            num = int.Parse(Console.ReadLine());

            switch (num) {
                case 1:
                    var query1 = Yearslist.OrderBy(b =>b.PublishedYear);
                    foreach (var q in query1) {
                        Console.WriteLine(q);
                    }
                    break;
                case 2:
                    var query2 = Yearslist.OrderByDescending(b => b.PublishedYear);
                    foreach (var q in query2) {
                        Console.WriteLine(q);
                    }
                    break;
                default:return;

            }


            //入力された発行年を表示して、そのあとカテゴリ別

            var group = Library.Books.Where(b => Years.Contains(b.PublishedYear))
                                                       .GroupBy(b => b.PublishedYear)
                                                       .OrderBy(o => o.Key);
            foreach (var g in group) {
                Console.WriteLine($"{g.Key}年");
                foreach (var book in g) {
                    var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                    Console.WriteLine($"タイトル:{book.Title},価格:{book.Price},カテゴリ:{category.Name}");

                }
            }
          
        }
    }
}
