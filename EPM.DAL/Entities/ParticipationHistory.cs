using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM.DAL.Entities
{
    public class ParticipationHistory
    {
        [Key, ForeignKey("Employee")]
        [Column("EmployeeId", Order = 0)]
        public int EmployeeId { get; set; }

        [Required]
        public Employee Employee { get; set; }

        [Key, ForeignKey("Project")]
        [Column("ProjectId",Order = 1)]
        public int ProjectId { get; set; }

        [Required]
        public Project Project { get; set; }
    }
}
