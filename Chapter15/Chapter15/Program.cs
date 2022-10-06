using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {

            //int sort;
            var Years = new List<int>();

            ////西暦入力
            //Console.WriteLine("西暦入力  :");
            //var inputYear = int.Parse(Console.ReadLine());           

            //while (inputYear != -1) {
            //    Years.Add(inputYear);
            //    inputYear = int.Parse(Console.ReadLine());                                                                           

            //}
            ////入力した西暦とあっているものを抽出
            //var Yearslist = Library.Books.Where(b => Years.Contains(b.PublishedYear));

            ////昇順、降順
            //Console.WriteLine("昇順 1    降順 2   ");
            //sort = int.Parse(Console.ReadLine());

            //switch (sort) {
            //    case 1:

            //        //昇順
            //        var query1 = Yearslist.OrderBy(b =>b.PublishedYear);
            //        foreach (var q in query1) {
            //            Console.WriteLine(q);
            //        }
            //        break;
            //    case 2:

            //        // 降順
            //        var query2 = Yearslist.OrderByDescending(b => b.PublishedYear);
            //        foreach (var q in query2) {
            //            Console.WriteLine(q);
            //        }
            //        break;
            //    default:return;

            //}

            //Console.WriteLine();



            //西暦入力
            Console.WriteLine("西暦入力  :");
            var inputYear = int.Parse(Console.ReadLine());

            while (inputYear != -1) {
                Years.Add(inputYear);
                inputYear = int.Parse(Console.ReadLine());

            }
           
            var names = Library.Books.Where(b => b.PublishedYear == inputYear)
                               .Join(Library.Categories,
                                            book => book.CategoryId,
                                            category => category.Id,                                        
                                            (book, category) => book.Title).Distinct();

            //var books = Library.Books.OrderBy(b => b.CategoryId)
            //                     .ThenBy(b => b.PublishedYear)
            //                     .Join(Library.Categories,  //結合する二番目のシーケンス
            //                            book => book.CategoryId, //対象シーケンスの結合キー
            //                            category => category.Id, //二番目のシーケンスの結合キー
            //                            (book, category) => new {
            //                                Title = book.Title,
            //                                Category = category.Name,
            //                                PublishedYear = book.PublishedYear
            //                            }
            //                            );

            var selected = Library.Books.Where(b => Years.Contains(b.PublishedYear))
                                        .Join(Library.Categories,
                                        book => book.CategoryId,
                                        category => category.Id,
                                        (book, category) => new {
                                            Title = book.Title,
                                            Category = category.Name,
                                            PublishedYear = book.PublishedYear,
                                            Price = book.Price
                                        }).ToList();
            foreach (var book in selected.OrderByDescending(b =>b.PublishedYear)
                                         .ThenBy(x => x.Category)) {
                //Console.WriteLine(name);
                //Console.WriteLine($" {book.PublishedYear}年");
                //var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                //Console.WriteLine($" 出版年:{book.PublishedYear},カテゴリ:{book.Category},タイトル:{book.Title}");
                //foreach (var book in selected) {
                //    var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                    Console.WriteLine($"{book.PublishedYear}年,{book.Title},{book.Category}");

                //}
            }
            Console.WriteLine($"金額の合計{selected.Sum(b => b.Price)}円");
          
        }
    }
}
