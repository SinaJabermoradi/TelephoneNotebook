using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneNotebook
{
    public interface INoteBook
    {
        public int TotalContacts { get; }
        public void Add(IContact newPerson);
        public void Delete(long userPhoneNumber);
        public void SearchByName(string userName);
        public void SearchByNumber(long userPhoneNumber);
        public void Update(long userPhoneNumber,IContact newPerson);
        public void ErrorMenu();
        public bool IsContactListEmpty(string message);
        public void SuccessfulyMassage(string message);
        public void ShowContactToEndUser(IContact person);

    }
}
