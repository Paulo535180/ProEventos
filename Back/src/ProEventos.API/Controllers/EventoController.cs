﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){                
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "São Paulo",
                Lote = "1ª Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(13).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto.png"
                },

                new Evento(){
                EventoId = 2,
                Tema = "SQL SERVER",
                Local = "São Paulo",
                Lote = "1ª Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(13).ToString("dd/MM/yyyy"),
                ImagemUrl = "fotoSQL.png"
                }
            };
    

        public EventoController()
        {            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {   
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){
            return _evento.Where(evento => evento.EventoId == id);
        }
        
        [HttpPost]
        public string Post()
        {
            return "Retornando Post";      
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de um Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de um Delete passando o id = {id}";
        }
    }
}