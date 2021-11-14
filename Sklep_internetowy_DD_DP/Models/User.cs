using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Sklep_internetowy_DD_DP.Models
{
    public class User
    {
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Surname { get; set; }
        [Display(Name = "Adres e-mail")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Email { get; set; }
        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Password { get; set; }

    }
}
