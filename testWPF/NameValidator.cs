using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Controls;

namespace testWPF
{
    public class NameValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value.ToString().Trim().Length == 0)
                return new ValidationResult(false, "value cannot be empty.");
            return ValidationResult.ValidResult;
        }
    }
}
