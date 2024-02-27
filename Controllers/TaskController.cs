using Microsoft.AspNetCore.Mvc;
using testeKeevo.Data;
using testeKeevo.Migrations;
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
        private readonly ApplicationDbContext _context;

        public Task()
        {
            
        }

        public Task( ApplicationDbContext context)
        {
            _context = context;
        }
         /// <summary>
        /// Obtém todos os itens.
        /// </summary>
        /// <returns>Lista de itens</returns>
        [HttpGet]
       
        public IEnumerable<Task> Get()
        {
            // Lógica para obter dados
            return (IEnumerable<Task>)_context.Tasks;
        }

         [HttpGet("{id}")]
        public IEnumerable<Task> GetById(int id)
        {
            // Lógica para obter dados

            return (IEnumerable<Task>)_context.Tasks.Find(id);
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
