
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
            return ReadIntegerWithinRange(0, int.MaxValue, 
                "The number you enter is not a positive integer.");
        }
        public static int ReadIntegerWithinRange(int min, int max, string errorMessage)
        {
            string? inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);
            CheckIfIntInRange(input, min, max, errorMessage);
            return input;
        }

        public static void CheckIfIntInRange(int input, int min, int max, string errorMessage)
        {
            if (input < min || input > max)
                throw new ArgumentException(errorMessage);
        }

        public static void ValidateAge(int age)
        {
            CheckIfIntInRange(age, 0, 120,
                "Person's age must be a positive integer and less than or equal to 120");
        }

        public static int GetAge()
        {
            Console.Write("Enter Person Age: ");
            return ReadIntegerWithinRange(0, 120,
                "Person's age must be a positive integer and less than or equal to 120");
        }
    }
}
