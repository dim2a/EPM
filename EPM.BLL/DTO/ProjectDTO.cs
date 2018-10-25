using EPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM.BLL.DTO
{
    public class ProjectDTO
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public DateTimeOffset CloseDate { get; set; }
        public State State { get; set; }
        public EmploymentType EmploymentType { get; set; }
    }
}
