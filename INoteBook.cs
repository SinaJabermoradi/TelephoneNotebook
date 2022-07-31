using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneNotebook
{
    public interface INoteBook
    {
        public void Add(Contact person);
        public void Delete(string userPhoneNumber);
        public int TotalContacts { get; }
        public Contact SearchByName(string userName);
        public Contact SearchByNumber(string userPhoneNumber);
        public void Update(string userPhoneNumber,Contact person);

    }
}
