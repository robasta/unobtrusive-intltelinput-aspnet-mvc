using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using IntlTelInput_UnobtrusiveValidation.Models;

namespace Connect.Registration.Website.Attributes.Validation.SignUp
{
    public class IntlTelNumberAttribute : ValidationAttribute, IClientValidatable
    {
        public string FormattedField { get; set; }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule();
            rule.ErrorMessage = FormatErrorMessage(metadata.GetDisplayName());
            rule.ValidationType = "intltelinput";
            yield return rule;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Person viewModel = (Person)validationContext.ObjectInstance; 

            return Regex.IsMatch(viewModel.FormattedMobileNumber, @"^[\+][0-9]{9,15}$") ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }

    }
}