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

        public void Delete(string userPhoneNumber)
        {
            for (int temp = 0; temp < _contactList.Count; temp++)
            {
                if (_contactList[temp] != null && _contactList[temp].PhoneNumber == Convert.ToInt64(userPhoneNumber))
                {
                    _contactList[temp] = null;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This Number does Not Exist");
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

        public void Update(string userPhoneNumber, Contact newPerson)
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

        #endregion


    }
}
