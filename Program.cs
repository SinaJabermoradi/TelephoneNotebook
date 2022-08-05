using System;

namespace TelephoneNotebook
{
    public class Program
    {

        static void Main(string[] args)
        {
            INoteBook PhoneBook = new NoteBook();

            while (true)
            {
                Console.Clear();
                Console.Title = "دفترچه تلفن لوکس";
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
                                IContact contact = new Contact();

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("                --------------------------------------------------------------\n");
                                Console.WriteLine("                              Please Fill The Following Items : ");
                                
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.Write("\n                              FullName : ");
                                contact.FullName = Console.ReadLine();

                                Console.Write("                              PhoneNumber : ");
                                contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

                                Console.Write("                              EmailAddress : ");
                                contact.EmailAddress = Console.ReadLine();

                                Console.Write("                              HomeAddress : ");
                                contact.HomeAddress = Console.ReadLine();

                                PhoneBook.Add(contact);

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\n                              The User Sucssesfuly Added ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine($"\n                              Press Enter To Use Software Again ");
                            }
                            catch (Exception)
                            {
                                PhoneBook.ErrorMenu();
                            }
                            break;
                        }
                    case "u":
                        {

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
                    case "4":
                        {

                            break;
                        }
                    case "5":
                        {

                            break;
                        }
                    case "6":
                        {

                            break;
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
