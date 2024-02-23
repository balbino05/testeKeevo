using Microsoft.AspNetCore.Mvc;
using testeKeevo.Data;
using testeKeevo.Models;

namespace testeKeevo.Controllers
{
    /// <summary>
    /// Descrição do Seu Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class Task : ControllerBase
    {
        public Task()
        {
            // Construtor
        }
        public IEnumerable<Evento> _evento = new Evento []{
            new Evento(){
                Id = 1,
                Nome = "Nome do Evento",
                Description = "Descrição do Evento",
                Status = "Status do Evento"
            },
            new Evento(){
                Id = 2,
                Nome = "Nome do Evento 2",
                Description = "Descrição do Evento 2",
                Status = "Status do Evento 2"
            }
        };
         /// <summary>
        /// Obtém todos os itens.
        /// </summary>
        /// <returns>Lista de itens</returns>
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            // Lógica para obter dados

            return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            // Lógica para obter dados

            return _evento.Where(evento=> evento.Id == id);
        }

        /// <summary>
        /// Cria um novo item.
        /// </summary>
        /// <param name="modelo">Dados do novo item</param>
        /// <returns>Item criado</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Task task)
        {
            // Lógica para processar dados do modelo
            return Ok("Dados recebidos com sucesso!");
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Task task)
        {
            // Lógica para processar dados do modelo
            return Ok("Dados recebidos com sucesso!");
        }
    }
}
