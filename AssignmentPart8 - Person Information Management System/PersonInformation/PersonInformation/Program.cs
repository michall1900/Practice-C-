using PersonInformation.Utilities;

namespace PersonInformation {
    /// <summary>
    /// Entry point for the Person Information Management System application.
    /// Handles user interaction and menu navigation.
    /// </summary>
    internal class Program {
        /// <summary>
        /// Main method. Displays the menu and processes user input for 
        /// managing person information.
        /// </summary>
        /// <param name="args">Command-line arguments (not used).</param>
        static void Main(string[] args)
        {
            bool isNeedToExit = false;
            PersonManager personManager = new PersonManager();

            Console.WriteLine("Person Information Management System");
            PrintMenu();
            do
            {
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        personManager.AddPerson();
                        break;
                    case "2":
                        personManager.DisplayAllPeople();
                        break;
                    case "3":
                        HandleError.RunWithValidation(() => 
                            personManager.SearchPerson());
                        break;
                    case "4":
                        HandleError.RunWithValidation(() => 
                            personManager.ChangePersonAddress());
                        break;
                    case "5":
                        isNeedToExit = true;
                        break;
                    default:
                        Console.WriteLine("Error: Invalid choice. Choose a valid option.");
                        break;
                }
                PrintSeparator();

            } while (!isNeedToExit);
            Console.WriteLine("Goodbye!");
        }

        /// <summary>
        /// Prints the main menu options to the console.
        /// </summary>
        static void PrintMenu()
        {
            Console.WriteLine(
                "1. Add a Person\n" +
                "2. Display All Persons\n" +
                "3. Search for a Person\n" +
                "4. Update Address\n" +
                "5. Exit"
            );
        }

        /// <summary>
        /// Prints a separator line to the console for better readability.
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine("\n\n-----------------------------------------\n\n");
        }
    }
}