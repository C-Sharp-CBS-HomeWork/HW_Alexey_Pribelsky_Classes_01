using System;

namespace task3
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Введите название книги: ");
            string bookName = Console.ReadLine();

            Console.Write("Введите имя автора: ");
            string authorName = Console.ReadLine();

            Console.Write("Введите содержимое текста: ");
            string content = Console.ReadLine();

            Book myBook = new Book(bookName, authorName, content);

            Console.WriteLine();

            myBook.Show();

            Console.ReadKey();
        }
    }
}
