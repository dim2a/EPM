using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPM.DAL.Entities
{
    public class User
    {        
        [Required(ErrorMessage = "Обязательное поле")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public Role Role { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression(@"^\+[1-9]\d{3}-\d{3}-\d{4}$", ErrorMessage = "Номер телефона должен иметь формат +xxxx-xxx-xxxx")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        public DateTimeOffset CreateDate { get; set; }                
    }
}
