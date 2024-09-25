using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1Project
{
    public class ListMemoryRepo : IRepo
    {
        private List<Contact> contacts = new List<Contact>();

        public void Create(Contact contact)
        {
            contacts.Add(contact);
        }
    }
}
