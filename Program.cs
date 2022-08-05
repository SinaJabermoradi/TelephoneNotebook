﻿using System;

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
                Console.WriteLine($"                              Wellcome To Telphone Notebook (( TotalContacts = {PhoneBook.TotalContacts} ))");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                --------------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("                              A   => Add");
                Console.WriteLine("                              U   => Update");
                Console.WriteLine("                              D   => Delete");
                Console.WriteLine("                              SNA => Search By Name");
                Console.WriteLine("                              SNU => Search By Number");
                Console.WriteLine("                              E   => Exit");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\n                              Please Select an options (1 to 6): ");

                string option = Console.ReadLine();


                switch (option.ToLower())
                {
                    case "a":
                        {
                            try
                            {
                                IContact contact = new Contact();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;

                                Console.WriteLine("                --------------------------------------------------------------\n");
                                Console.Write("                              FullName : ");
                                contact.FullName = Console.ReadLine();

                                Console.Write("                              PhoneNumber : ");
                                contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

                                Console.Write("                              EmailAddress : ");
                                contact.EmailAddress = Console.ReadLine();

                                Console.Write("                              HomeAddress : ");
                                contact.HomeAddress = Console.ReadLine();

                                PhoneBook.Add(contact);

                                Console.ForegroundColor = ConsoleColor.DarkCyan;

                                Console.WriteLine("\n                              The User Sucssesfuly Added ");
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
                                Console.ForegroundColor = ConsoleColor.DarkGreen;

                                Console.WriteLine("                --------------------------------------------------------------\n");
                                Console.Write("                              UserPhoneNumber : ");
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
                }

                Console.ReadKey();

            }
        }
    }
}
