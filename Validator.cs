using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem_OOP
{
    public static class Validator
    {
        // Validates if a string is not null or empty
        public static bool IsValidName(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        // Validates if an integer is positive
        public static bool IsValidId(int id)
        {
            return id > 0;
        }

        // Validates if age is reasonable (e.g., 0–120)
        public static bool IsValidAge(int age)
        {
            return age >= 0 && age <= 120;
        }

        // Validates if phone number is at least 8 digits and only numeric
        public static bool IsValidPhoneNumber(string phone)
        {
            return !string.IsNullOrWhiteSpace(phone) && phone.Length >= 8 && long.TryParse(phone, out _);
        }

        // Validates if a DateTime is in the future
        public static bool IsFutureDate(DateTime date)
        {
            return date > DateTime.Now;
        }
    }
}
