// Task.cs

using System.ComponentModel.DataAnnotations;

namespace testeKeevo.Data{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Status { get; set; }

        public Task()
        {
            Name = "";
            Description = "";
            Status = "";
        }
    }
}

