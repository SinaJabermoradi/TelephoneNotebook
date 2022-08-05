using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneNotebook
{
    public class Contact : IContact
    {
        #region Attributes

        private string _fullName;
        private long _phoneNumber = 0;
        private string _emailAddress;
        private string _homeAddress;

        #endregion


        #region Set & Get

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public long PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        } 

        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        public string HomeAddress
        {
            get { return _homeAddress; }
            set { _homeAddress = value; }
        }

        #endregion

    }
}
