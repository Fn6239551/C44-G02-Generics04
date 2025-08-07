namespace Solv_of_Assignment_03C__advaned
{
    internal class Program
    {
        #region The Task in Session
        
        //public delegate int MathOperation(int a, int b);
       
        //public static int Add(int a, int b) => a + b;
        //public static int Subtract(int a, int b) => a - b;
        //public static int Multiply(int a, int b) => a * b;
        //public static int Divide(int a, int b)
        //{
        //    if (b == 0)
        //    {
        //        throw new DivideByZeroException("Cannot divide by zero.");
        //    }
        //    return a / b;
        //}
        
        #endregion
        static void Main(string[] args)
        {
            #region THE Solv of Assignment 03
            /*
             *  ⦁Considering the Code Below , Write Down the Body of all Listed Methods and Properties , you need to Define fPtr as the following cases:
                a. User Defined Delegate Datatype
                b. BCL Delegates
                c. Anonymous Method (GetISBN)
                d. Lambda Expression (GetPublicationDate) */
            //List<Book> books = new List<Book>
            //{
            //    new Book { Title = "C# Programming", Author = "John Doe", ISBN = "1234567890", PublicationDate = new DateTime(2020, 1, 1) },
            //    new Book { Title = "Advanced C#", Author = "Jane Smith", ISBN = "0987654321", PublicationDate = new DateTime(2021, 5, 15) },
            //    new Book { Title = "Data Structures", Author = "Alice Johnson", ISBN = "1122334455", PublicationDate = new DateTime(2019, 3, 10) }
            //};
            //Console.WriteLine("Using User Defined Delegate (GetTitle)");
            //LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunctions.GetTitle));

            //Console.WriteLine("Using BCL Delegates (GetAuthor)");
            //LibraryEngine.ProcessBooks(books, new Func<Book, string>(BookFunctions.GetAuthor));

            //Console.WriteLine("Using Anonymous Method (GetISBN)");
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetISBN);

            //Console.WriteLine("Using Lambda Expression (GetPublicationDate)");
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetPublicationDate);
            #endregion

            #region THE Task in Session
            /*
             * عاوزين نعمل برنامج Console بسيط كأنه آلة حاسبة.
            المطلوب:
            تعريف delegate يمثل دالة رياضية تأخذ 2 أرقام (int) وترجع int.
            نعمل 4 دوال:
            جمع
            طرح
            ضرب
            قسمة
            نستخدم delegate لاختيار العملية المناسبة حسب إدخال المستخدم. */

            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Choose an operation: Add, Subtract, Multiply, Divide");
            //string operation = Console.ReadLine().ToLower();
            //MathOperation mathOperation;
            //switch (operation)
            //{
            //    case "add":
            //        mathOperation = Add;
            //        break;
            //    case "subtract":
            //        mathOperation = Subtract;
            //        break;
            //    case "multiply":
            //        mathOperation = Multiply;
            //        break;
            //    case "divide":
            //        mathOperation = Divide;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation.");
            //        return;
            //}
            //try
            //{
            //    int result = mathOperation(firstNumber, secondNumber);
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

        }
    }
}
