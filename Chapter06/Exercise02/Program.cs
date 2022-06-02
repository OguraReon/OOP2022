using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
       new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
       new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
       new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
       new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
       new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
       new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
       new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);

            Console.WriteLine("-----");

            Exercise2_8(books);
        }

        

        private static void Exercise2_1(List<Book> books) {
            var bookPricePages = books.Where(name => name.Title == "ワンダフル・C#ライフ").
                Select(n => new { n.Price,n.Pages });
                 
            foreach (var item in bookPricePages) {
                Console.WriteLine(item);
            }
         
            
}
        private static void Exercise2_2(List<Book> books) {
           var countBook = books.Where(name => name.Title.Contains("C#")).Count();
            Console.WriteLine(countBook);
        }

        private static void Exercise2_3(List<Book> books) {
            var averageBook = books.Where(name => name.Title.Contains("C#")).Average(a => a.Pages);
            Console.WriteLine(averageBook);
        }

        private static void Exercise2_4(List<Book> books) {
            var findBook = books.Where(find => find.Price >= 4000).
                                 Select(find => find.Title);
             Console.WriteLine(findBook.First());

            /*
             * 先生の解答
             *  var book = book.FirstOrDefault(b => b.Price >= 4000);
             *  if(book != null)
             *      Console.WriteLine(book.Title);
             * 
             */
  
        }

        private static void Exercise2_5(List<Book> books) {
            var maxPage = books.Where(price => price.Price < 4000).Max(page => page.Pages);
            Console.WriteLine(maxPage);
        }

        private static void Exercise2_6(List<Book> books) {
            var highPrice = books.Where(pages => pages.Pages >= 400);
                                  
            foreach (var item in highPrice.OrderByDescending(price => price.Price)) {
                Console.WriteLine(item.Title+"  "+item.Price+"円");
            }             

        }

        private static void Exercise2_7(List<Book> books) {
            var titleBook = books.Where(title => title.Title.Contains("C#") && title.Pages <= 500);
                                 
            foreach (var item in titleBook) {
                Console.WriteLine(item.Title);
            }
        }

        private static void Exercise2_8(List<Book> books) {
            var count = books;
        }

        class Book {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
    }
}

