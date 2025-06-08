using System.ComponentModel.DataAnnotations;

namespace ProjectBoardApp.Models
{
    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Done
    }

    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public TaskStatus Status { get; set; }

        public int ProjectId { get; set; } // Foreign key to Project
        public Project Project { get; set; } // Navigation property
    }
}