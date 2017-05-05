using System.Collections.Generic;
using RazorDeepDive.Models;

namespace RazorDeepDive.Services
{
    public interface IContactsService
    {
        IList<ContactInfo> GetContacts();
    }

    public class ContactService : IContactsService
    {
        public IList<ContactInfo> GetContacts()
        {
            return new List<ContactInfo>
            {
                new ContactInfo {Image = "dinesh.png", Name = "Dinesh Chugtai"},
                new ContactInfo {Image = "", Name = ""},
                new ContactInfo {Image = "", Name = ""},
                new ContactInfo {Image = "", Name = ""},
                new ContactInfo {Image = "", Name = ""},
                new ContactInfo {Image = "", Name = ""},
                new ContactInfo {Image = "", Name = ""},
            };
        }
    }
}