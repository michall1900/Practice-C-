namespace PrimeNumbersDisplayer {
    internal class Program {
        /// <summary>
        /// Entry point of the application. Prompts the user for a range and displays prime numbers within that range.
        /// </summary>
        public static void Main(string[] args)
        {
            // Get the start of the range from the user
            int start = readPositiveInteger("Enter the start of the range: ");
            // Get the end of the range from the user, ensuring it is greater than or equal to start
            int end = readPositiveInteger("Enter the end of the range: ", start, $" that is greater from {start}");
            // Print prime numbers in the specified range; notify if none are found
            if (!printPrimes(start, end))
            {
                Console.WriteLine("No prime numbers found in the given range ");
            }
        }

        /// <summary>
        /// Prints all prime numbers between start and end (inclusive).
        /// </summary>
        /// <param name="start">Start of the range.</param>
        /// <param name="end">End of the range.</param>
        /// <returns>True if at least one prime number is found; otherwise, false.</returns>
        private static bool printPrimes(int start, int end)
        {
            int i = start;
            bool isFound = false;
            while (i <= end)
            {
                if (isPrime(i))
                {
                    if (!isFound)
                    {
                        // Print header before the first prime number
                        Console.Write($"Prime numbers between {start} and {end} are: ");
                    }
                    else
                    {
                        // Print comma separator for subsequent numbers
                        Console.Write(", ");
                    }
                    Console.Write(i);
                    isFound = true;
                }
                i++;
            }

            return isFound;
        }

        /// <summary>
        /// Determines whether a given number is prime.
        /// </summary>
        /// <param name="num">The number to check.</param>
        /// <returns>True if the number is prime; otherwise, false.</returns>
        private static bool isPrime(int num)
        {
            if (num <= 2)
            {
                // 2 is the only even prime number
                return num == 2;
            }
            else if (num % 2 == 0)
            {
                // Exclude even numbers greater than 2
                return false;
            }
            int squreRoot = (int)Math.Sqrt(num);
            // Check divisibility by odd numbers up to the square root
            for (int i = 3; i <= squreRoot; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Prompts the user to enter a positive integer, optionally enforcing a minimum value.
        /// </summary>
        /// <param name="message">Prompt message to display.</param>
        /// <param name="start">Minimum allowed value (inclusive). Default is -1 (no minimum).</param>
        /// <param name="errorMessage">Additional error message to display on invalid input.</param>
        /// <returns>The validated integer entered by the user.</returns>
        public static int readPositiveInteger(string message, int start = -1, string errorMessage = "")
        {
            bool isValidNumber = false;
            int result;
            do
            {
                Console.Write(message);
                // Try to parse user input and check if it meets the criteria
                if (int.TryParse(Console.ReadLine(), out result) &&
                    result >= 0 && start < result)
                {
                    isValidNumber = true;
                }
                else
                {
                    // Display error message for invalid input
                    Console.WriteLine($"Error: Invalid input. Please enter a positive integer{errorMessage}.");
                }

            } while (!isValidNumber);

            return result;
        }
    }
}