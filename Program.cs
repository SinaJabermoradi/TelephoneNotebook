using System;

namespace TelephoneNotebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wellcome To Telphone Notebook");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Update");
            Console.WriteLine("3.Delete"); 
            Console.WriteLine("4.Search By Name"); 
            Console.WriteLine("5.Search By Number"); 
            Console.WriteLine("6.Exit");
            Console.WriteLine();
            Console.WriteLine("Please Select an options (1 to 6): ");




            Console.ReadKey();
        }
    }
}
