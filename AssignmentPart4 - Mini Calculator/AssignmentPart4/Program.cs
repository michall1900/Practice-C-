
namespace AssignmentPart4 {
    // Program class contains the entry point and main logic for the calculator
    internal class Program {

        /// <summary>
        /// The main entry point for the calculator application.
        /// Handles user input, validation, and performs basic arithmetic operations.
        /// </summary>
        /// <param name="args">Command-line arguments (not used).</param>
        public static void Main(string[] args) {

            // Declare variables for user input and calculation
            string firstNumberAsString, secondNumberAsString, operationAsString, toContinue;
            double firstNumber, secondNumber, result = 0;
            bool isFirstTime = true, isValidOperation;

            // Main loop to allow multiple calculations
            while (true) {
                isValidOperation = true;
                // Ask user if they want to continue after the first calculation
                if (!isFirstTime) {
                    Console.Write("Do you want to perform another calculation? (Yes/No): ");
                    toContinue = Console.ReadLine();
                    if (!String.IsNullOrEmpty(toContinue)) {
                        toContinue = toContinue.Trim().ToLower();
                    }
                    if (String.Equals(toContinue, "no")) {
                        Console.WriteLine("Goodbye!");
                        break; // Exit the loop if user says no
                    }
                    else if (!String.Equals(toContinue, "yes")) {
                        Console.WriteLine("Error: Invalid choise!");
                        continue; // Ask again if input is invalid
                    }
                }
                else {
                    isFirstTime = false; // Set flag after first run
                }

                // Prompt for the first number
                Console.Write("Enter the first number:");
                firstNumberAsString = Console.ReadLine();

                // Validate the first number
                if (!double.TryParse(firstNumberAsString, out firstNumber)) {
                    Console.WriteLine($"Error: {firstNumberAsString} is not a number.");
                    continue; // Restart loop if invalid
                }

                // Prompt for the second number
                Console.Write("Enter the second number:");
                secondNumberAsString = Console.ReadLine();

                // Validate the second number
                if (!double.TryParse(secondNumberAsString, out secondNumber)) {
                    Console.WriteLine($"Error: {secondNumberAsString} is not a number.");
                    continue; // Restart loop if invalid
                }

                // Ask user to select an operation
                Console.Write("Select operation: (1) Addition (2) Subtraction (3) Multiplication (4) Division\nYour choice: ");
                operationAsString = Console.ReadLine();

                // Perform the selected operation
                switch (operationAsString) {
                    case "1": {
                            result = firstNumber + secondNumber; // Addition
                            break;
                        }
                    case "2": {
                            result = firstNumber - secondNumber; // Subtraction
                            break;
                        }
                    case "3": {
                            result = firstNumber * secondNumber; // Multiplication
                            break;
                        }
                    case "4": {
                            // Check for division by zero
                            if (secondNumber == 0) {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                                isValidOperation = false;
                            }
                            else {
                                result = firstNumber / secondNumber; // Division
                            }
                            break;
                        }
                    default: {
                            Console.WriteLine("Error: Invalid operation choice!");
                            isValidOperation = false; // Invalid operation
                            break;
                        }
                }
                // Display result if operation was valid
                if (isValidOperation) {
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
    }
}
