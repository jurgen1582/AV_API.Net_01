using AvAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AvAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        // GET: api/<JogadorController>
        [HttpGet]
        public IEnumerable<Jogador> Get()
        {
            Jogador jogador = new Jogador();
            var mark = "S";
            return jogador.listaJogadores(mark);
        }

        [HttpGet("Lista agrupada pela Camisa")]
        public IEnumerable<Jogador> GetListadoCamisa()
        {
            Jogador jogador = new Jogador();
            var mark = "C";
            return jogador.listaJogadores(mark);
        }

        [HttpGet("Lista agrupada pela Posição")]
        public IEnumerable<Jogador> GetListadoPosicao()
        {
            Jogador jogador = new Jogador();
            var mark = "P";
            return jogador.listaJogadores(mark);
        }
    }
}
