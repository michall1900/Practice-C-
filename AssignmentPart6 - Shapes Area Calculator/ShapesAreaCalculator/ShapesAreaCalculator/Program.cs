namespace ShapesAreaCalculator {
    /// <summary>
    /// Entry point and logic for the Shapes Area Calculator application.
    /// </summary>
    internal class Program {
        /// <summary>
        /// Calculates the area of a rectangle.
        /// </summary>
        /// <param name="length">The length of the rectangle.</param>
        /// <param name="breadth">The breadth of the rectangle.</param>
        /// <returns>The area of the rectangle.</returns>
        public static double calculateArea(double length, double breadth)
        {
            return length * breadth;
        }

        /// <summary>
        /// Calculates the area of a circle.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>The area of the circle.</returns>
        public static double calculateArea(double radius)
        {
            return System.Math.PI * radius * radius;
        }

        /// <summary>
        /// Calculates the area of a triangle.
        /// </summary>
        /// <param name="baseLength">The base length of the triangle.</param>
        /// <param name="height">The height of the triangle.</param>
        /// <param name="isTriangle">Indicates the calculation is for a triangle (not used in calculation).</param>
        /// <returns>The area of the triangle.</returns>
        public static double calculateArea(double baseLength, double height, bool isTriangle)
        {
            return baseLength * height * 0.5;
        }

        /// <summary>
        /// Prompts the user for a positive double value and validates the input.
        /// </summary>
        /// <param name="message">The message to display to the user.</param>
        /// <returns>A positive double value entered by the user.</returns>
        public static double getPositiveDoubleFromUser(string message)
        {
            double result;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out result) ||
                result < 0)
            {
                Console.WriteLine("Error: Invalid input. Please enter a positive number.");
            }

            return result;
        }

        /// <summary>
        /// Asks the user if they want to continue using the calculator.
        /// </summary>
        /// <returns>True if the user wants to continue; otherwise, false.</returns>
        public static bool toContinue()
        {
            Console.Write("Do you want to calculate the area of another shape? (Yes/No): ");
            string response = Console.ReadLine()?.Trim().ToLower();

            while (!response.Equals("yes") && !response.Equals("no"))
            {
                Console.WriteLine("Error: Invalid input. Please enter 'Yes' or 'No'.");
                response = Console.ReadLine()?.Trim().ToLower();
            }
            return response.Equals("yes");
        }

        /// <summary>
        /// Displays the menu of shape options to the user.
        /// </summary>
        public static void printMenu()
        {
            Console.WriteLine("Choose a shape to calculate the area: \n" +
                    "1. Rectangle\n" +
                    "2. Circle\n" +
                    "3. Triangle");
        }

        /// <summary>
        /// Main entry point of the application. Handles user interaction and area calculations.
        /// </summary>
        static void Main()
        {
            bool needsToContinue = true;
            string shapeName;
            double area;
            while (needsToContinue)
            {
                try
                {
                    printMenu();
                    switch (Console.ReadLine()?.Trim())
                    {
                        case "1":
                            shapeName = "Rectangle";
                            area = calculateArea(getPositiveDoubleFromUser("Enter the length of the rectangle: "),
                                           getPositiveDoubleFromUser("Enter the breadth of the rectangle: "));
                            break;
                        case "2":
                            shapeName = "Circle";
                            area = calculateArea(getPositiveDoubleFromUser("Enter the radius of the circle: "));
                            break;

                        case "3":
                            shapeName = "Triangle";
                            area = calculateArea(getPositiveDoubleFromUser("Enter the base of the triangle: "),
                                           getPositiveDoubleFromUser("Enter the height of the triangle: "), true);
                            break;
                        default:
                            throw new ArgumentException("Invalid shape selection. Please choose 1, 2, or 3.");
                    }
                    Console.WriteLine($"Area of the {shapeName}: {area}");
                    needsToContinue = toContinue();

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}