using System;
using System.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {

            var group1 = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(b => b.Key);
            foreach (var g in group1) {
                Console.WriteLine($"{g.Key}年　{g.Count()}冊");
            }


        }

        private static void Exercise1_4() {
            var book = Library.Books.OrderByDescending(o => o.PublishedYear)
                                    .ThenByDescending(o => o.Price);
            foreach (var b in book) {
                Console.WriteLine(b);
            }
        }

        private static void Exercise1_5() {
            var books = Library.Books.Where(b => b.PublishedYear == 2016)
                                     .Join(Library.Categories,
                                            book => book.CategoryId,
                                            category => category.Id,
                                            (book, category) => category.Name

                                            ).Distinct();
            foreach (var book in books) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6() {

            var groups = Library.Categories.GroupJoin(Library.Books,
                                                            c => c.Id,
                                                            b => b.CategoryId,
                                                            (c, books) => new {
                                                                Category = c.Name,
                                                                Books = books
                                                            });
            foreach (var group in groups) {
                Console.WriteLine(group.Category);
                foreach (var book in group.Books) {
                    Console.WriteLine($"    {book.Title}");
                }
            }


        }

        private static void Exercise1_7() {
            var categoryId = Library.Categories.Single(c => c.Name == "Development").Id ;
            var groups = Library.Books
                                .Where(b => b.CategoryId == categoryId)
                                .GroupBy(g => g.PublishedYear)
                                .OrderBy(b => b.Key);

            foreach (var group in groups) {
                Console.WriteLine("#{0}年",group.Key);
                foreach (var book in group) {
                    Console.WriteLine("{0}" ,book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var groups = Library.Categories.GroupJoin(Library.Books,
                                                      c => c.Id,
                                                      book => book.CategoryId,
                                                      (c, book) => new { Category = c.Name, Books = book.Count() });
            var categoryName = groups.Where(c => c.Books >= 4);

            foreach (var cateName in categoryName) {
                Console.WriteLine("{0}",cateName.Category);
            }
        }
    }
}
