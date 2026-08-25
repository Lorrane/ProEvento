using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoID == id);
        }

        [HttpPost]
        public string Post()
        {
            string message = "Hello World - Post";
            return message;
        }

        [HttpPut]
        public string Put()
        {
            string message = "Hello World - Put";
            return message;
        }

        [HttpDelete]
        public string Delete()
        {
            string message = "Hello World - Delete";
            return message;
        }
    }
}
