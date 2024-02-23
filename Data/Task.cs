// Task.cs

using System.ComponentModel.DataAnnotations;

namespace testeKeevo.Data{
    public class Task
    {
        /// <summary>
        /// Identificador único da tarefa.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Título da tarefa.
        /// </summary>
        public string Name { get; set; }

         /// <summary>
        /// Status da tarefa.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Descrição da tarefa.
        /// </summary>
        public string Description { get; set; }

        // Outras propriedades...

        /// <summary>
        /// Data de criação da tarefa.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Data da última atualização da tarefa.
        /// </summary>
        public DateTime UpdatedAt { get; set; }
        
    }
}

