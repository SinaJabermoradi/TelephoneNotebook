using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneNotebook
{
    public class NoteBook : INoteBook
    {
        #region Atributes 

        private List<Contact> _contactList = null;
        private int _personCount = 0;

        #endregion

        #region Constractors

        public NoteBook()
        {
            _contactList = new List<Contact>();
        }

        #endregion

        #region Setter & Getter

        public int TotalContacts
        {
            get
            {
                for (int temp = 0; temp < _contactList.Count; temp++)
                {
                    if (_contactList[temp] != null)
                        _personCount++;
                }
                return _personCount;
            }
        }

        #endregion

        #region Oprations

        public void Add(IContact newPerson)
        {
            foreach (Contact person in _contactList)
            {
                person.FullName = newPerson.FullName;
                person.PhoneNumber = newPerson.PhoneNumber;
                person.EmailAddress = person.EmailAddress;
                person.HomeAddress = newPerson.HomeAddress;
            }
        }

        public void Delete(long userPhoneNumber)
        {
            for (int temp = 0; temp < _contactList.Count; temp++)
            {
                if (_contactList[temp] != null && _contactList[temp].PhoneNumber == userPhoneNumber)
                {
                    _contactList[temp] = null;

                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.WriteLine("\n                              The User Sucssesfuly Deleted ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("                --------------------------------------------------------------\n");

                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.WriteLine("\n                              This Number does Not Exist In Note Book ");
                }
            }
        }

        public IContact SearchByName(string userName)
        {
            for (int temp = 0; temp < _contactList.Count; temp++)
            {
                if (_contactList[temp] != null && _contactList[temp].FullName == userName)
                    return _contactList[temp];
            }
            return null;
        }

        public IContact SearchByNumber(string userPhoneNumber)
        {
            for (int temp = 0; temp < _contactList.Count; temp++)
            {
                if (_contactList[temp] != null && _contactList[temp].PhoneNumber == Convert.ToInt64(userPhoneNumber))
                    return _contactList[temp];
            }
            return null;
        }

        public void Update(string userPhoneNumber, IContact newPerson)
        {
            for (int temp = 0; temp < _contactList.Count; temp++)
            {
                if (_contactList[temp].PhoneNumber == Convert.ToInt64(userPhoneNumber))
                {
                    _contactList[temp].FullName = newPerson.FullName;
                    _contactList[temp].PhoneNumber = newPerson.PhoneNumber;
                    _contactList[temp].EmailAddress = newPerson.EmailAddress;
                    _contactList[temp].HomeAddress = newPerson.HomeAddress;
                }
            }
        }

        public void ErrorMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("                --------------------------------------------------------------\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("\n                 Error----Error----Error----Error----Error----Error----Error");

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\n                              Press Enter To Refresh Software ");
        }

        #endregion


    }
}
