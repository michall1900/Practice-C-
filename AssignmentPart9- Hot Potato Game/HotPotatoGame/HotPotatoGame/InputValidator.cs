namespace HotPotatoGame {
    /// <summary>
    /// Provides static methods for validating user input.
    /// </summary>
    public static class InputValidator {

        /// <summary>
        /// Checks if the provided string is null, empty, or consists only of white-space characters.
        /// Throws an <see cref="ArgumentNullException"/> if the check fails.
        /// </summary>
        /// <param name="input">The string to validate.</param>
        /// <param name="realName">The name of the parameter being validated.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="input"/> is null, empty, or white-space.</exception>
        public static void CheckIfNullOrEmptyString(string? input, string realName)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException(realName);
            }
        }

        /// <summary>
        /// Checks if the provided string represents a positive integer.
        /// Throws an <see cref="ArgumentException"/> if the check fails.
        /// </summary>
        /// <param name="input">The string to validate as a positive integer.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="input"/> is not a valid integer or is less than or equal to zero.
        /// </exception>
        public static void CheckIfPositiveInt(string? input)
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