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

        #region Constractors

        public NoteBook()
        {
            _contactList = new List<IContact>();
        }

        #endregion

        #region Setter & Getter

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

        public void Add(IContact newPerson)
        {
            _contactList.Add(newPerson);
        }

        public void Delete(long userPhoneNumber)
        {
            foreach (IContact people in _contactList)
            {
                if (people.PhoneNumber == userPhoneNumber)
                {
                    people.FullName = null;
                    people.PhoneNumber = 0;
                    people.EmailAddress = null;
                    people.HomeAddress = null;

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n                              The User Sucssesfuly Deleted ");

                    _deleteFlag = false;
                }

                if (_deleteFlag)
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
            return null;
        }

        public IContact SearchByNumber(string userPhoneNumber)
        {
            return null;
        }

        public void Update(string userPhoneNumber, IContact newPerson)
        {
            //for (int temp = 0; temp < _contactList.Length; temp++)
            //{
            //    if (_contactList[temp].PhoneNumber == Convert.ToInt64(userPhoneNumber))
            //    {
            //        _contactList[temp].FullName = newPerson.FullName;
            //        _contactList[temp].PhoneNumber = newPerson.PhoneNumber;
            //        _contactList[temp].EmailAddress = newPerson.EmailAddress;
            //        _contactList[temp].HomeAddress = newPerson.HomeAddress;
            //    }
            //}
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
