using System;
using System.Collections.Generic;

namespace Index
{
    class Program 
    {
        static void Main()
        {
            //instanciate List object, assign it to names variable and initialize it with same values
            var names = new List<string> {"Gus","Aline","Lisa"};
            var numbers =  new List<int> {1,2,3};

            foreach(string name in names)
            {
                Console.WriteLine($"My name is: {name}");
            }

            Book myBook = new Book("Book Author","Book Title");
        }

    }

    class Book 
    {
        public string author;
        public string title;
        private int bookId;
        private int bookCount = 0;
        public void Book(string author, string title, int bookId = 1)
        {
            this.author = author;
            this.title =  title;
            bookCount++;
        }

        public int Id()
        {
            return this.bookId;
        }
        static string Count()
        {
            return bookCount;
        }

    }
}