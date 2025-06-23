
namespace GymFitnessManagement.Utilities {
    /// <summary>
    /// Provides static methods for validating input values.
    /// </summary>
    public static class InputValidator {
        /// <summary>
        /// Checks if the provided number is positive.
        /// </summary>
        /// <param name="num">The number to check.</param>
        /// <exception cref="ArgumentException">Thrown if the number 
        /// is negative.</exception>
        public static void CheckIfPositiveNumber(double num)
        {
            if (Double.IsNegative(num))
            {
                throw new ArgumentException("The number is not positive.");
            }
        }

        /// <summary>
        /// Checks if the provided integer is within the specified range 
        /// (inclusive).
        /// </summary>
        /// <param name="num">The integer to check.</param>
        /// <param name="min">The minimum allowed value.</param>
        /// <param name="max">The maximum allowed value.</param>
        /// <exception cref="ArgumentException">Thrown if the number is 
        /// outside the specified range.</exception>
        public static void CheckIfIntInRange(int num, int min, int max)
        {
            if ((num < min) || (num > max))
            {
                throw new ArgumentException($"The number should be between " +
                    $"{min} and {max}.");

            }
        }
    }
}