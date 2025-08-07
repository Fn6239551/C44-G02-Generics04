using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_of_Assignment_03C__advaned
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, BookDelegate fPtr)
        {
            foreach (var book in books)
            {

                Console.WriteLine("Title: " + fPtr(book));
            }
        }
        public static void ProcessBooks(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (var book in books)
            {
                Console.WriteLine("Author: " + fPtr(book));
            }
        }
        public static void ProcessBooks(List<Book> books, Func<Book, DateTime> datePtr)
        {
            foreach (var book in books)
            {
                Console.WriteLine("Publication Date: " + datePtr(book).ToShortDateString());
            }

        }
    }
}
