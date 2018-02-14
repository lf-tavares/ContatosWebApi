using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContatosWebAPI.Interfaces;
using ContatosWebAPI.Models;

namespace ContatosWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Contato")]
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _ContatoRepository;

        public ContatoController(IContatoRepository ContatoRepository)
        {
            _ContatoRepository = ContatoRepository;
        }

        [HttpGet]
        public IEnumerable<Contato> Get()
        {
            return _ContatoRepository.Get();
        }

        // GET: api/Contato/5
        [HttpGet("{id}")]
        public Contato Get(string id)
        {
            return _ContatoRepository.Get(id) ?? new Contato();
        }
  
        [HttpPost]
        public bool Add([FromBody]Contato value)
        {
            return _ContatoRepository.Add(value);
        }

        [HttpPut]
        public bool Update([FromBody]Contato value)
        {
            return _ContatoRepository.Update(value);
        }

        [HttpDelete]
        public bool Delete(string id)
        {
            return _ContatoRepository.Remove(id);
        }

    }
}