using System;

namespace gyak_004_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Book = new Book();

            Book.Author = "Karcsi";
            Book.Title = "Az utolso ut";
            Book.Year = 2021;
            Book.Price = 5099;

            Console.WriteLine(Book.LinkStringOut());
        }
    }
}
