using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contato> _contatos = new List<Contato>()
        {
            new Contato { ContactId = 1, Name = "John Doe", Email = "johndoe@gmail.com", Phone = "(11)99999-9999", Address = "Monte mioboco" },
            new Contato { ContactId = 2, Name = "Joao Silva", Email = "joaosilva@gmail.com", Phone = "(11)99999-9999", Address = "Konoha"},
            new Contato { ContactId = 3, Name = "Juan pablo", Email = "Juanpablo@gmail.com", Address = "Vila da areia"},
            new Contato { ContactId = 4, Name = "eduardo ferrira", Email = "eduardoferreira@gmail.com", Phone = "(11)99999-9999", Address = "Vila da chuva"},
        };
        public static List<Contato> GetContatos() => _contatos;

        public static Contato GetContactById(int contactId)
        {
            var contact = _contatos.FirstOrDefault(x => x.ContactId == contactId);
            if (contact != null)
            {
                return new Contato
                {
                    ContactId = contactId,
                    Name = contact.Name,
                    Email = contact.Email,
                    Phone = contact.Phone,
                    Address = contact.Address,
                };
            }
            return null;
        }

        public static void UpdateContact(int contactId, Contato contato)
        {
            if (contactId != contato.ContactId) return;
            var contactToUpdate = _contatos.FirstOrDefault(x => x.ContactId == contactId);
            if (contactToUpdate != null)
            {
                contactToUpdate.Address = contato.Address;
                contactToUpdate.Name = contato.Name;
                contactToUpdate.Email = contato.Email;
                contactToUpdate.Phone = contato.Phone;
            }
        }

        public static void AddContact(Contato contato)
        {
            if (contato != null)
            {
                _contatos.Add(contato);
            }
        }
    }
}
