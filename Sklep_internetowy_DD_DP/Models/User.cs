using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sklep_internetowy_DD_DP.Models
{
    public class User
    {
        [Display(Name = "Imię")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
