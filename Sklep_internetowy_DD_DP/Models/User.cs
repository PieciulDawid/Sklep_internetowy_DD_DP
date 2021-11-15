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
        [Required(ErrorMessage = "Imię jest wymagane")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string Surname { get; set; }
        [Display(Name = "Adres e-mail")]
        [Required(ErrorMessage = "E-mail jest wymagany")]
        public string Email { get; set; }
        [Display(Name = "Hasło")]
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Akceptuję regulamin sklepu")]
        //  walidacja poprzez jQuery
        [Compare("TermsOfUse",ErrorMessage = "Akceptacja regulaminu jest obowiązkowa")]
        //  walidacja na serwerze
        [IsTrue(ErrorMessage = "Akceptacja regulaminu jest obowiązkowa")]
        public bool TermsOfUse { get; set; }

        private class IsTrueAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                return value != null && value is bool && (bool) value;
            }
        }
    }
}
