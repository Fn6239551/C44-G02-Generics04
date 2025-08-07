using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solv_of_Assignment_03C__advaned
{
    #region Define a delegate type for user-defined delegate
    public delegate string BookDelegate(Book book);
    #endregion
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
