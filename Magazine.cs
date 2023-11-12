using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeBlocknot
{
    class Magazine : Book, IBorrowable
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, string author, string isbn, bool isAvaliable, int issueNumber)
            : base(title, author, isbn, isAvaliable)
        {
            IssueNumber = issueNumber ;
        }

        public void BorrowItem()
        {
            if (IsAvailabe )
            {

                IsAvailabe = true;
            }
            else
            {
                IsAvailabe = false;
            }
        }
        public void ReturnItem()
        {
            if (IsAvailabe )
            {

                IsAvailabe = false;
            }
            
        }
    }
}
