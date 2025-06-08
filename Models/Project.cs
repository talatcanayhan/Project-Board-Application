using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectBoardApp.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public ICollection<TaskItem> Tasks { get; set; } // Navigation property
    }
}