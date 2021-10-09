using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExAssignment
{
    class UserRegistration

    {
        public string regExPattern = "^[A-Z]{1}[a-z]{2,5}$";
        public bool ValidateName(string firstname)
        {
            return Regex.IsMatch(firstname, regExPattern);
        }
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, regExPattern);
        }
        string regExEmail = "^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@"
            + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$";

        public bool UserEmailValidation(string email)
        {
            return Regex.IsMatch(email, regExEmail);
        }
        public string regExPattern2 = "^91?[0-9]{10}$";

        public bool PhoneNumberCheck(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, regExPattern2);

        }
        public string regEx3 = "^(?=.*[A-Z])[0-9A-Za-z]{8}";
        public bool Password(string password)
        {
            return Regex.IsMatch(password, regEx3);
        }
    }
}
