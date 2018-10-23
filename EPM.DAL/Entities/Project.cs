using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM.DAL.Entities
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Недопустимая длина названия")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(1024, MinimumLength = 2, ErrorMessage = "Недопустимая длина")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public DateTimeOffset StartDate { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public DateTimeOffset EndDate { get; set; }
        public DateTimeOffset CloseDate { get; set; }
        public State State { get; set; }
        public EmploymentType EmploymentType { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }        
    }
}
