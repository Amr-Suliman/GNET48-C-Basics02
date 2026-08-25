using System.Text;

namespace AssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Question 01
            //string title = "Clean Code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(upperTitle);
            //Console.WriteLine(title);
            #endregion

            #region Question 02
            //string title = "Clean Code";
            //string title02 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(title, title02));
            #endregion

            #region Question 03
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - updated");
            //Console.WriteLine(sb);
            #endregion

            #region Question 04
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);
            #endregion

            #region Question 05
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book : " + title + ", Pages: " + pages);
            #endregion

            #region Question 06
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine($"Book : {title}, Pages: {pages}");
            #endregion

            #region Question 07
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine(string.Format("Book : {0}, Pages: {1}", title, pages));
            #endregion

            #region Question 08
            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //} 
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion

            #region Question 09
            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region Question 10
            //string title = "Refactoring";

            //switch(title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Question 11
            //string[] books = {"Clean Code ", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}
            #endregion

            #region Question 12
            //string[] books = {"Clean Code ", "The Pragmatic Programmer", "Refactoring" };

            //int i = 0;

            //while(i < books.Length)
            //{
            //    Console.WriteLine("{0} ", books[i]);
            //    i++;
            //}
            #endregion
        }
    }
}
