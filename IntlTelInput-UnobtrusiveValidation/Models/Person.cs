using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Connect.Registration.Website.Attributes.Validation.SignUp;

namespace IntlTelInput_UnobtrusiveValidation.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [IntlTelNumber]
        public string MobileNumber { get; set; }
        public string FormattedMobileNumber { get; set; }
    }
}