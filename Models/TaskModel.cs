using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{[Table("Tasks")]
    public class TaskModel
    {
        

        [DisplayName("Id zadania")]
        [Key]
        public int TaskId { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage ="Pole Nazwa jest wymagane.")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Szczegóły")]
        [MaxLength(2000)]
        public string Description { get; set; }
        [DisplayName("Status")]
        public bool Done { get; set; }
    }
}
