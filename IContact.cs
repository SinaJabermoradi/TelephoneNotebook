using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneNotebook
{
    public interface IContact
    {
        public string FullName { get; set; } 
        public long PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }

    }
}
