﻿using System;
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
            new Contato { ContactId = 1, Name = "John Doe", Email = "johndoe@gmail.com" },
            new Contato { ContactId = 2, Name = "Joao Silva", Email = "joaosilva@gmail.com"},
            new Contato { ContactId = 3, Name = "Juan pablo", Email = "Juanpablo@gmail.com"},
            new Contato { ContactId = 4, Name = "eduardo ferrira", Email = "eduardoferreira@gmail.com"},
        };

        public static List<Contato> GetContatos() => _contatos;

        public static Contato GetContactById(int contactId)
        {
            return _contatos.FirstOrDefault(x => x.ContactId == contactId);
        }
    }
}
