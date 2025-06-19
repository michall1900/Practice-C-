using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotatoGame {
    public static class InputValidator {

        public static void CheckIfNullOrEmptyString(string input, string realName)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException(realName);
            }


        }

        public static void CheckIfPositiveInt (string input)
        {
            int result;
            if (!int.TryParse(input, out result))
            {
                throw new ArgumentException("You should enter an integer.");
            }

            if (result <= 0)
            {
                throw new ArgumentException("Please enter an integer number greater than 0.");
            }
        }
    }
}
