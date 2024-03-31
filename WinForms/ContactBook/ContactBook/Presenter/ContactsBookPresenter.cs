using ContactBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Presenter
{
    public class ContactsBookPresenter
    {
        public ContactsBookView CBView { get; set; }


        public List<Contact> Contacts { get; set; } = new List<Contact>();


        public void AddContact(Contact contact)
        {
            if(String.IsNullOrEmpty(contact.Name)
               || String.IsNullOrEmpty(contact.Surname)
               || String.IsNullOrEmpty(contact.Phone))
            {
                throw new Exception("Данные не полные");
            }
            else
            {
                Contacts.Add(contact);
                CBView.UpdateContactsList(Contacts);
                CBView.Clear();
            }
        }

        public void RemoveContact(Contact contact)
        {
            Contacts.Remove(contact);
            CBView.UpdateContactsList(Contacts);
        }
    }
}
