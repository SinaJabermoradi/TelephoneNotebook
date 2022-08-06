using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneNotebook
{
    public class NoteBook : INoteBook
    {
        #region Atributes 
        
        private readonly List<IContact> _contactList = null;
        private int _personCount = 0;
        private bool _deleteFlag = true;

        #endregion


        #region Behavior

        #region Constractors

        public NoteBook()
        {
            _contactList = new List<IContact>();
        }

        #endregion

        #region Setter & Getter
        
        /// <summary>
        /// Return Total Cantacts
        /// </summary>
        public int TotalContacts
        {
            get
            {
                _personCount = 0;

                foreach (IContact contact in _contactList)
                {
                    if (contact != null)
                    {
                        _personCount++;
                    }
                }
                return _personCount;
            }
        }

        #endregion

        #region Oprations

        /// <summary>
        /// Deleted a Specifics Contact 
        /// </summary>
        /// <param name="newPerson">
        /// Your New Contact
        /// </param>
        public void Add(IContact newPerson)
        {
            const string SUCCESSFULYMASSAGE = " Added";

            _contactList.Add(newPerson);

            this.SuccessfulyMassage(SUCCESSFULYMASSAGE);
        }

        /// <summary>
        /// Deleted a Specifics Contact 
        /// </summary>
        /// <param name="userPhoneNumber">
        /// Find The Specefics Contact With The Help Of Contact Number
        /// </param>
        public void Delete(long userPhoneNumber)
        {
            const string SUCCESSFULYMASSAGE = " Deleted";
            _deleteFlag = true;

            foreach (IContact people in _contactList)
            {
                if (people.PhoneNumber == userPhoneNumber)
                {
                    _contactList.Remove(people);

                    this.ShowContactToEndUser(people);
                    this.SuccessfulyMassage(SUCCESSFULYMASSAGE);

                    _deleteFlag = false;
                    break;
                }
            }

            if (_deleteFlag)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                --------------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n                              This Number does Not Exist In NoteBook ");
            }
        }

        /// <summary>
        /// Search a Specifics Contact 
        /// </summary>
        /// <param name="userName">
        /// Find The Specefics Contact With The Help Of Contact Name
        /// </param>
        public void SearchByName(string userName)
        {
            const string ERRORMESSAGE = " You Cant Search This Contact";

            if (!this.IsContactListEmpty(ERRORMESSAGE))
            {
                foreach (IContact people in _contactList)
                {
                    if (people.FullName == userName)
                    {
                        this.ShowContactToEndUser(people);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"\n                              Press Enter To Use Software Again ");
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Search a Specifics Contact 
        /// </summary>
        /// <param name="userPhoneNumber">
        /// Find The Specefics Contact With The Help Of Contact Number
        /// </param>
        public void SearchByNumber(long userPhoneNumber)
        {
            const string ERRORMESSAGE = " You Cant Search This Contact";

            if (!this.IsContactListEmpty(ERRORMESSAGE))
            {
                foreach (IContact people in _contactList)
                {
                    if (people.PhoneNumber == userPhoneNumber)
                    {
                        this.ShowContactToEndUser(people);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"\n                              Press Enter To Use Software Again ");
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Updates a Specifics Contact 
        /// </summary>
        /// <param name="userPhoneNumber">
        /// Find The Specefics Contact With The Help Of Contact Number
        /// </param>
        /// <param name="newPerson">
        /// Your New Contact
        /// </param>
        public void Update(long userPhoneNumber, IContact newPerson)
        {
            const string ERRORMESSAGE = " You Cant Update This Contact";
            const string SUCCESSFULYMASSAGE = " Updated";

            if (!this.IsContactListEmpty(ERRORMESSAGE))
            {
                foreach (IContact people in _contactList)
                {
                    if (people.PhoneNumber == userPhoneNumber)
                    {
                        people.FullName = newPerson.FullName;
                        people.PhoneNumber = newPerson.PhoneNumber;
                        people.EmailAddress = newPerson.EmailAddress;
                        people.HomeAddress = newPerson.HomeAddress;

                        this.ShowContactToEndUser(people);
                        this.SuccessfulyMassage(SUCCESSFULYMASSAGE);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Show Error To End User
        /// </summary>
        public void ErrorMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("                --------------------------------------------------------------\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("\n                 Error----Error----Error----Error----Error----Error----Error");

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("\n                              Press Enter To Refresh Software ");
        }

        /// <summary>
        /// </summary>
        /// <param name="massage">
        /// Your Error Message
        /// </param>
        /// <returns>
        /// true : When ContactList was Empty (( ContactList.Count == 0 )).
        /// 
        /// false : When ContactList was NotEmpty (( ContactList.Count != 0 )) .
        /// </returns>
        public bool IsContactListEmpty(string message)
        {
            if (_contactList.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                --------------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\n                    {message} , BeCause The NoteBook Is Empty ");
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Show Success Message To The EndUser
        /// </summary>
        /// <param name="massage">
        /// Key Word For Your Operation
        /// </param>
        public void SuccessfulyMassage(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n                              The User Successfuly {message}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n                              Press Enter To Use Software Again ");
        }

        /// <summary>
        /// Show The Contact To The End User  
        /// </summary>
        /// <param name="person">
        /// Your Contact
        /// </param>
        public void ShowContactToEndUser(IContact person)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                --------------------------------------------------------------\n");
            Console.WriteLine("                              This Is Your Contact : \n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"                              UserFullName = {person.FullName} \n" +
                              $"                              UserPhoneNumber = {person.PhoneNumber} \n" +
                              $"                              UserEmailAddress = {person.EmailAddress} \n" +
                              $"                              UserHomeAddress = {person.HomeAddress} \n" );
        }

        #endregion

        #endregion
    }
}
