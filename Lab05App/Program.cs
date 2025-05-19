using System;
using Lab05Lib;
namespace Lab05App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть книг: ");
            int count = int.Parse(Console.ReadLine());

            ClassesLib[] books = new ClassesLib[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n--- Книга {i + 1} ---");

                Console.Write("Назва: ");
                string title = Console.ReadLine();

                Console.Write("Автор: ");
                string author = Console.ReadLine();

                Console.Write("Видавництво: ");
                string publisher = Console.ReadLine();

                Console.Write("Рiк видання: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Кiлькiсть сторiнок: ");
                int pages = int.Parse(Console.ReadLine());

                Console.Write("Цiна: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Чи тверда обкладинка? (y/n): ");
                ConsoleKeyInfo isHardcoverKey = Console.ReadKey();
                bool isHardcover = isHardcoverKey.Key == ConsoleKey.Y;
                Console.WriteLine();

                books[i] = new ClassesLib()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    Year = year,
                    Pages = pages,
                    Price = price,
                    IsHardcover = isHardcover
                };
            }

            Console.WriteLine("\n\n===== Інформація про книги =====\n");

            foreach (ClassesLib book in books)
            {
                Console.WriteLine($"Назва: {book.Title}");
                Console.WriteLine($"Автор: {book.Author}");
                Console.WriteLine($"Видавництво: {book.Publisher}");
                Console.WriteLine($"Рiк: {book.Year}");
                Console.WriteLine($"Сторiнки: {book.Pages}");
                Console.WriteLine($"Цiна: {book.Price:0.00}");
                Console.WriteLine(book.IsHardcover ? "Тверда обкладинка" : "М'яка обкладинка");
                Console.WriteLine($"Цiна за сторiнку: {book.PricePerPage:0.00}\n");
            }

            Console.ReadKey();
        }
    }
}