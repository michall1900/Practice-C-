using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformation.Utilities {
    public static class InputValidator {

        public static string CheckIfNoneEmptyOrWhiteSpaceString(string input,
            string errorMessage = "You should enter a none empty string.")
        {

            if (input.Length == 0 || String.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException(errorMessage);
            }
            return input.Trim();
        }
        public static int GetPositiveInteger()
        {
            return GetIntInRange(0, int.MaxValue, "The number you enter is not a positive integer.");
        }
        public static int GetIntInRange(int min, int max, string errorMessage)
        {
            string? inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);
            CheckIfIntInRange(input, min, max, errorMessage);
            return input;
        }

        public static void CheckIfIntInRange(int input, int min, int max, string errorMessage)
        {
            if (input < min || input > max)
                throw new ArgumentOutOfRangeException(errorMessage);
        }
    }
}
