using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneNotebook
{
    public class Contact
    {
        #region Attributes

        private int _fullName;
        private int _phoneNumber;
        private int _emailAddress;
        private int _homeAddress;

        #endregion


        #region Set & Get

        public int FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public int EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        public int HomeAddress
        {
            get { return _homeAddress; }
            set { _homeAddress = value; }
        }

        #endregion




    }
}
