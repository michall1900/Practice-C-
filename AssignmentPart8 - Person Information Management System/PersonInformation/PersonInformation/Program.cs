using PersonInformation.Utilities;

namespace PersonInformation {
    internal class Program {
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
                        HandleError.RunWithValidation(()=>personManager.SearchPerson());
                        break;
                    case "4":
                        HandleError.RunWithValidation(() => personManager.ChangePersonAddress());
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

        static void PrintMenu()
        {
            Console.WriteLine(
                "1. Add a Person\n" +
                "2. Display All Persons\n"+
                "3. Search for a Person\n"+
                "4. Update Address\n"+
                "5. Exit"
            );
        }

        static void PrintSeparator()
        {
            Console.WriteLine("\n\n-----------------------------------------\n\n");
        }
    }
}
