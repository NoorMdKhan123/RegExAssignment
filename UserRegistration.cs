using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExAssignment
{
    class UserRegistration

    {
        public string regExPattern = "^[A-Z]{1}[a-z]{2}$";
        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, regExPattern);
        }
    }
}
