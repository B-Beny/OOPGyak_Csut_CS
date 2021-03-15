using System;
using System.Collections.Generic;
using System.Text;

namespace gyak_004_2
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public Book(string Title, string Author, int Year, int Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
            this.Price = Price;
        }

        public Book(string Title, string Author) : this(Title, Author, DateTime.Now.Year, 2500) { }

        public override string ToString()
        {
            return $"Cim: {Title}, Szerzo: {Author}, Kiadas Eve: {Year}, Ara: {Price}";
        }

        public void PercentPriceInc(long percent)
        {
            Price = (int)(Price + Price * percent);
        }

        /// <summary>
        /// Links the properties of the book together in a string, then writes it on console.
        /// </summary>
        /// <returns>string</returns>

        /*public string LinkStringOut()
        {
            return $"Cim: {Title}, Szerzo: {Author}, Kiadas Eve: {Year}, Ara: {Price}";
        }*/

    }
}
