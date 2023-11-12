using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBlocknot
{
    class Book : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBM { get; set; }
        public bool IsAvailabe { get; set; }

        public Book (string title, string author, string isbn, bool isAvailabe)
        {
            Title = title;
            Author = author;
            ISBM = isbn;
            IsAvailabe = isAvailabe;

            
        }
        public void BorrowItem()
        {
            if (IsAvailabe  )
            {
                IsAvailabe = true;
                //Console.WriteLine($"Book '{Title}' has been borrowed. ");
            }
            else
            {
                IsAvailabe = false;
                
                //Console.WriteLine($"Book {Title} is not available.");
            }
        }
        public void ReturnItem()
        {
            if (IsAvailabe == false)
            {
                
                //Console.WriteLine($"Book {Title} has been returned ");
            }
        }
    }
}
