using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPM.WebAPI.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public User User { get; set; }
    }
}