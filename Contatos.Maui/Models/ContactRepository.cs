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
            new Contato { Name = "John Doe", Email = "johndoe@gmail.com" },
            new Contato { Name = "Joao Silva", Email = "joaosilva@gmail.com"},
            new Contato { Name = "Juan pablo", Email = "Juanpablo@gmail.com"},
            new Contato { Name = "eduardo ferrira", Email = "eduardoferreira@gmail.com"},
        };

        public static List<Contato> GetContatos() => _contatos;

        public static Contato GetContactById(int Id)
        {
            return _contatos.FirstOrDefault(x => x.Id == Id);
        }
    }
}
