using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPM.WebAPI.Models
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleViewModel Role { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTimeOffset CreateDate { get; set; }
    }
}