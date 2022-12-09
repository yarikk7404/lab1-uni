using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab1.Classes
{
    internal class Validator
    {
        static readonly Regex validator = new Regex(@"[1234567890ABCDEFGHminmax]+");
        static readonly Regex numValidator = new Regex(@"^[0-9]+$");
        public static bool AllConditionsCheck(string? value)
        {
            if (value == null || value + "" == "")
            {
                return true;
            }
            else
            {
                return validator.IsMatch(value + "");
            }
        }
        public static bool NumbersCheck(string? value)
        {
            if (value == null || value + "" == "")
            {
                return false;
            }
            else
            {
                return numValidator.IsMatch(value);
            }
        }
    }
}
