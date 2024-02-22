using Microsoft.AspNetCore.Mvc;
using testeKeevo.Data;

namespace testeKeevo.Controllers
{
    /// <summary>
    /// Descrição do Seu Controller
    /// </summary>
    [Route("api/[task]")]
    [ApiController]
    public class Task : ControllerBase
    {
         /// <summary>
        /// Obtém todos os itens.
        /// </summary>
        /// <returns>Lista de itens</returns>
        [HttpGet]
        public IActionResult Get()
        {
            // Lógica para obter dados
            return Ok("API está funcionando!");
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
    }
}
