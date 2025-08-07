using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_of_Assignment_03C__advaned
{
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }
        public static string GetAuthor(Book book)
        {
            return book.Author;
        }
       public static Func<Book, string> GetISBN = delegate (Book book)
        {
            return book.ISBN;
        };
       
        public static Func<Book, DateTime> GetPublicationDate = book => book.PublicationDate;
    }

}
