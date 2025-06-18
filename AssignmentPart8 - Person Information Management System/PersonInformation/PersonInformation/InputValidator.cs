namespace PersonInformation.Utilities {
    /// <summary>
    /// Provides static methods for validating and reading user input from the console.
    /// </summary>
    public static class InputValidator {

        /// <summary>
        /// Checks if the input string is not null, empty, or whitespace.
        /// </summary>
        /// <param name="input">The input string to validate.</param>
        /// <param name="errorMessage">The error message to use if 
        /// validation fails.</param>
        /// <returns>The trimmed input string if valid.</returns>
        /// <exception cref="ArgumentException">Thrown if the input is null, 
        /// empty, or whitespace.</exception>
        public static string CheckIfNoneEmptyOrWhiteSpaceString(string input,
            string errorMessage = "You should enter a none empty string.")
        {
            if (input.Length == 0 || String.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException(errorMessage);
            }
            return input.Trim();
        }

        /// <summary>
        /// Reads a positive integer from the console.
        /// </summary>
        /// <returns>A positive integer value.</returns>
        /// <exception cref="ArgumentException">Thrown if the input is not 
        /// within the valid range.</exception>
        /// <exception cref="ArgumentNullException">Thrown if the input 
        /// is null.</exception>
        /// <exception cref="FormatException">Thrown if the input is not in a 
        /// valid integer format.</exception>
        /// <exception cref="OverflowException">Thrown if the input represents 
        /// a number less than <see cref="int.MinValue"/> or greater than 
        /// <see cref="int.MaxValue"/>.</exception>
        public static int GetPositiveInteger()
        {
            return ReadIntegerWithinRange(0, int.MaxValue,
                "The number you enter is not a positive integer.");
        }

        /// <summary>
        /// Reads an integer from the console and checks if it is 
        /// within the specified range.
        /// </summary>
        /// <param name="min">The minimum allowed value (inclusive).</param>
        /// <param name="max">The maximum allowed value (inclusive).</param>
        /// <param name="errorMessage">The error message to use 
        /// if validation fails.</param>
        /// <returns>The validated integer value.</returns>
        /// <exception cref="ArgumentException">Thrown if the input 
        /// is not within the valid range.</exception>
        /// <exception cref="ArgumentNullException">Thrown if the 
        /// input is null.</exception>
        /// <exception cref="FormatException">Thrown if the input is not in
        /// a valid integer format.</exception>
        /// <exception cref="OverflowException">Thrown if the input represents 
        /// a number less than 
        /// <see cref="int.MinValue"/> or greater than <see cref="int.MaxValue"/>.
        /// </exception>
        public static int ReadIntegerWithinRange(int min, int max, string errorMessage)
        {
            string? inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);
            CheckIfIntInRange(input, min, max, errorMessage);
            return input;
        }

        /// <summary>
        /// Checks if an integer is within the specified range.
        /// </summary>
        /// <param name="input">The integer to check.</param>
        /// <param name="min">The minimum allowed value (inclusive).</param>
        /// <param name="max">The maximum allowed value (inclusive).</param>
        /// <param name="errorMessage">The error message to use if validation fails.</param>
        /// <exception cref="ArgumentException">Thrown if the input is not 
        /// within the valid range.</exception>
        public static void CheckIfIntInRange(int input, int min, int max, string errorMessage)
        {
            if (input < min || input > max)
                throw new ArgumentException(errorMessage);
        }

        /// <summary>
        /// Validates that the age is within the allowed range (0 to 120).
        /// </summary>
        /// <param name="age">The age to validate.</param>
        /// <exception cref="ArgumentException">Thrown if the age is not 
        /// within the valid range.</exception>
        public static void ValidateAge(int age)
        {
            CheckIfIntInRange(age, 0, 120,
                "Person's age must be a positive integer and less than or equal to 120");
        }

        /// <summary>
        /// Prompts the user to enter an age and validates that it is within 
        /// the allowed range (0 to 120).
        /// </summary>
        /// <returns>The validated age.</returns>
        /// <exception cref="ArgumentException">Thrown if the input is not within 
        /// the valid range.</exception>
        /// <exception cref="ArgumentNullException">Thrown if the 
        /// input is null.</exception>
        /// <exception cref="FormatException">Thrown if the input is not in a 
        /// valid integer format.</exception>
        /// <exception cref="OverflowException">Thrown if the input represents a 
        /// number less than <see cref="int.MinValue"/> or greater than 
        /// <see cref="int.MaxValue"/>.</exception>
        public static int GetAge()
        {
            Console.Write("Enter Person Age: ");
            return ReadIntegerWithinRange(0, 120,
                "Person's age must be a positive integer and less than or equal to 120");
        }
    }
}