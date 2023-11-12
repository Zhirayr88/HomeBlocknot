namespace HomeBlocknot
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Book book = new Book("Rich dad poor dad", "Robert Kiyosaki", "123", false);

            Console.Write("Book : ");
            book.Title = Console.ReadLine();



            if (book.Title == "Rich dad poor dad")
            {
                book.BorrowItem();
                Console.WriteLine($"Book '{book.Title}' has been borrowed. ");
            }
            if (book.Title == "Rich dad poor dad")
            {
                Console.WriteLine($"book: {book.Title}, Author: {book.Author}, IBSM: {book.ISBM}, Avaliabe: {book.IsAvailabe}");
            }
            else
            {
                book.ReturnItem();
                Console.WriteLine($"Book {book.Title} is not available.");
            }

            Magazine magazine = new Magazine("Forbes", "Adam Witty", "1234", false, 2020);
            Console.Write("Magazin : ");
            magazine.Title = Console.ReadLine();

         
            if (magazine.Title == "Forbes")
            {

                magazine.BorrowItem();
                Console.WriteLine($"Magazine '{magazine.Title}' has been borrowed. ");

            }
            if (magazine.Title == "Forbes")
            {
                magazine.ReturnItem();
                Console.WriteLine($"Magazine: {magazine.Title}, Author: {magazine.Author}, IBSM: {magazine.ISBM}, " +
                    $"Avaliabe: {magazine.IsAvailabe},IssueNumber: {2020}");
            }
            else
            {
                magazine.ReturnItem();
                Console.WriteLine($"Book {magazine.Title} is not available.");
            }
  
            
            
        }
    }
}