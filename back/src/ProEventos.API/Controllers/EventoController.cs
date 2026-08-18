using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _eventos = new Evento[]
            {
                new Evento()
                {
                    EventoID = 1,
                    Tema = "Festa Agostina dos Amigos",
                    Local = "Casa do Bolinho",
                    Lote = "3° Lote",
                    QtdPessoas = 20,
                    DataEvento = "22/8/2026",
                    ImagemUrl = "Amigos.jpg"
                },
                new Evento() {
                    EventoID = 2,
                    Tema = "Casamento do Leozinho",
                    Local = "Madureira",
                    Lote = "1° Lote",
                    QtdPessoas = 200,
                    DataEvento = "03/10/2026",
                    ImagemUrl = "Casamento.jpg"
                }
            };

        public EventoController()
        { }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _eventos.FirstOrDefault(evento => evento.EventoID == id);
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
