﻿using EPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM.BLL.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }        
        public User User { get; set; }
    }
}
