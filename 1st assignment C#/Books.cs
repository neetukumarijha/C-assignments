﻿using System;

namespace Books
{


    enum BookType : byte
    {
        Magazine = 11,
        Novel = 2,
        ReferenceBook = 101,
        Miscellaneous = 10
    }

    struct BOOK
    {
        public int BookID;
        public string title;
        public short Price;
        public BookType heading;


        public BOOK(int i, string n, short p, BookType et)
        {
            BookID = i;
            title = n;
            Price = p;
            heading = et;

        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            BOOK trend;
            trend.BookID = 90;
            trend.title = "Java";
            trend.Price = 500;
            trend.heading = BookType.Novel;

            BOOK Nike = new BOOK(100, "Nike", 2000, BookType.Magazine);

            Console.WriteLine("BookID is {0} ", Nike.BookID);
            Console.WriteLine("Title is {0}", Nike.title);
            Console.WriteLine("Price is {0}", Nike.Price);
            Console.WriteLine("Type of the book is {0}", Nike.heading);

            Console.WriteLine("\n");

            Console.WriteLine("BookID is {0}", trend.BookID);
            Console.WriteLine("Title is {0}", trend.title);
            Console.WriteLine("Price is {0}", trend.Price);
            Console.WriteLine("Type of the book is {0}", trend.heading);


        }
    }
}
