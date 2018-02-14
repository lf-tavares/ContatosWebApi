using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContatosWebAPI.Models;

namespace ContatosWebAPI.Interfaces
{
    public interface IContatoRepository
    {
        Contato Get(string id);
        IEnumerable<Contato> Get();

        bool Add(Contato item);
        bool Update(Contato item);
        bool Remove(string id);

    }
}
