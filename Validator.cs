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
    }
}
