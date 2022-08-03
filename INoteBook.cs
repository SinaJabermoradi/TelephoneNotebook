using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneNotebook
{
    public interface INoteBook
    {
        public void Add(IContact newPerson);
        public void Delete(long userPhoneNumber);
        public int TotalContacts { get; }
        public IContact SearchByName(string userName);
        public IContact SearchByNumber(string userPhoneNumber);
        public void Update(string userPhoneNumber,IContact newPerson);
        public void ErrorMenu();

    }
}
