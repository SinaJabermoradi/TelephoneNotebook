using System;

namespace TelephoneNotebook
{
    public class Program
    {
        public static IContact InsertContact(string message)
        {
            IContact contact = new Contact();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"\n                              {message}FullName : ");
            contact.FullName = Console.ReadLine();

            Console.Write($"                              {message}PhoneNumber : ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write($"                              {message}EmailAddress : ");
            contact.EmailAddress = Console.ReadLine();

            Console.Write($"                              {message}HomeAddress : ");
            contact.HomeAddress = Console.ReadLine();

            return contact;
        }

        static void Main(string[] args)
        {
            INoteBook PhoneBook = new NoteBook();

            while (true)
            {
                Console.Clear();
                Console.Title = " WellCome To Sina Jabermoradi TelePhoneNotebook ";
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"                              Telphone Notebook (( TotalContacts = {PhoneBook.TotalContacts} ))");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                --------------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("                              A   => Add");
                Console.WriteLine("                              U   => Update");
                Console.WriteLine("                              D   => Delete");
                Console.WriteLine("                              SNA => Search By Name");
                Console.WriteLine("                              SNU => Search By Number");
                Console.WriteLine("                              E   => Exit");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\n                              Please Select an options (A to E): ");

                string option = Console.ReadLine();

                switch (option.ToLower())
                {
                    case "a":
                        {
                            try
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("                --------------------------------------------------------------\n");
                                Console.WriteLine("                              Please Fill The Following Items : ");

                                PhoneBook.Add(InsertContact(""));
                            }
                            catch (Exception)
                            {
                                PhoneBook.ErrorMenu();
                            }
                            break;
                        }
                    case "u":
                        {
                            try
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("                --------------------------------------------------------------\n");
                                Console.WriteLine("                              Please Fill The Following Items : ");

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("\n                              LastPhoneNumber : ");
                                long LastUserPhoneNumber = Convert.ToInt64(Console.ReadLine());


                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\n                --------------------------------------------------------------\n");

                                PhoneBook.Update(LastUserPhoneNumber, InsertContact("New"));
                            }
                            catch (Exception)
                            {
                                PhoneBook.ErrorMenu();
                            }
                            break;
                        }
                    case "d":
                        {
                            try
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("                --------------------------------------------------------------\n");
                                Console.WriteLine("                              Please Fill The Following Item : ");

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("\n                              UserPhoneNumber : ");
                                long UserPhoneNumber = Convert.ToInt64(Console.ReadLine());

                                PhoneBook.Delete(UserPhoneNumber);
                            }
                            catch (Exception)
                            {
                                PhoneBook.ErrorMenu();
                            }
                           
                            break;
                        }
                    case "sna":
                        {

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                --------------------------------------------------------------\n");
                            Console.WriteLine("                              Please Fill The Following Items : ");

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("\n                              YourContactFullName : ");
                            string ContactName = Console.ReadLine();

                            PhoneBook.SearchByName(ContactName);

                            break;
                        }
                    case "snu":
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                --------------------------------------------------------------\n");
                            Console.WriteLine("                              Please Fill The Following Items : ");

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("\n                              YourContactNumber : ");
                            long ContactNumber = Convert.ToInt64(Console.ReadLine());

                            PhoneBook.SearchByNumber(ContactNumber);

                            break;
                        }
                    case "e":
                        {
                            return;
                        }

                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("                --------------------------------------------------------------\n");

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            
                            Console.Write("\n                              Please Chose One of List Option ");
                            
                            Console.ForegroundColor = ConsoleColor.DarkCyan;

                            Console.WriteLine("\n\n                              Press Enter To Refresh Software ");
                           
                            break;
                        }
                }

                Console.ReadKey();
            }
        }
    }
}
