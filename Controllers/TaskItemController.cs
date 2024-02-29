using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class TaskItem : ControllerBase
    {
        private readonly ApplicationDbContext _ApplicationDbContext;

        public TaskItem()
        {
        }

        public TaskItem( ApplicationDbContext ApplicationDbContext)
        {
            _ApplicationDbContext = ApplicationDbContext;
        }
         /// <summary>
        /// Obtém todos os itens.
        /// </summary>
        /// <returns>Lista de itens</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Lógica para obter dados
            var tasks =  await _ApplicationDbContext.Tasks.ToListAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            // Lógica para obter dados

            var tasks = await _ApplicationDbContext.Tasks.Where(x => x.Id == id).ToListAsync();
            return tasks.Count > 0 ? Ok(tasks) : NotFound();
        }

        /// <summary>
        /// Cria um novo item.
        /// </summary>
        /// <param name="modelo">Dados do novo item</param>
        /// <returns>Item criado</returns>
        [HttpPost]
        public IActionResult Post([FromBody] TaskItem task)
        {
            // Lógica para processar dados do modelo
            return Ok("Dados recebidos com sucesso!");
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] TaskItem task)
        {
            // Lógica para processar dados do modelo
            return Ok("Dados recebidos com sucesso!");
        }
    }

}
