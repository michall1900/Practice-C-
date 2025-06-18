using PersonInformation.Utilities;

namespace PersonInformation {
    /// <summary>
    /// Manages a collection of <see cref="Person"/> objects, providing methods to 
    /// add, search, display, and update person information.
    /// </summary>
    public class PersonManager {
        private Dictionary<int, Person> _peopleById = new Dictionary<int, Person>();

        /// <summary>
        /// Prompts the user to add a new person, validating input and ensuring 
        /// unique IDs.
        /// </summary>
        /// <remarks>
        /// Exceptions thrown by this method are handled internally via 
        /// <c>HandleError.RunWithValidation</c>.
        /// </remarks>
        public void AddPerson()
        {
            bool invalid = true;
            do
            {
                HandleError.RunWithValidation(() => this.addPerson(ref invalid));
            } while (invalid);
        }

        /// <summary>
        /// Handles the process of collecting and validating person details from 
        /// the user, and adds the person to the collection.
        /// </summary>
        /// <param name="invalid">Reference flag indicating if the input 
        /// was invalid.</param>
        /// <exception cref="ArgumentException">Thrown if the person ID 
        /// already exists, or if the name is null, empty, or whitespace, 
        /// or if the ID/age is not within the valid range.</exception>
        /// <exception cref="ArgumentNullException">Thrown if the name 
        /// input is null.</exception>
        /// <exception cref="FormatException">Thrown if the ID or age input 
        /// is not in a valid integer format.</exception>
        /// <exception cref="OverflowException">Thrown if the ID or age input 
        /// represents a number less than <see cref="int.MinValue"/> or greater 
        /// than <see cref="int.MaxValue"/>.</exception>
        private void addPerson(ref bool invalid)
        {
            Console.Write("Enter Person ID: ");
            int id = InputValidator.GetPositiveInteger();
            checkIfIdAlreadyExist(id);
            Console.Write("Enter Person Name: ");
            string name = Console.ReadLine();
            InputValidator.CheckIfNoneEmptyOrWhiteSpaceString(name);
            int age = InputValidator.GetAge();
            Console.Write("Enter Person Address: ");
            string address = Console.ReadLine();
            Person person = new Person(id, age, name, address);
            _peopleById.Add(id, person);
            invalid = false;
            Console.WriteLine("Person added successfully");
        }

        /// <summary>
        /// Checks if a person with the specified ID already exists in the 
        /// collection.
        /// </summary>
        /// <param name="id">The person ID to check.</param>
        /// <exception cref="ArgumentException">Thrown if the person ID 
        /// already exists.</exception>
        private void checkIfIdAlreadyExist(int id)
        {
            if (_peopleById.ContainsKey(id))
                throw new ArgumentException($"Person with ID {id} already exists.");
        }

        /// <summary>
        /// Displays information for all people in the collection.
        /// </summary>
        public void DisplayAllPeople()
        {
            if (_peopleById.Count == 0)
            {
                Console.WriteLine("No people to display.");
            }
            else
            {
                foreach (Person person in _peopleById.Values)
                {
                    person.DisplayInfo();
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Prompts the user to search for a person by name or ID 
        /// and displays the result.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the entered 
        /// ID is not within the valid range, or if the input is 
        /// empty or whitespace.</exception>
        /// <exception cref="ArgumentNullException">Thrown if the 
        /// input is null.</exception>
        /// <exception cref="FormatException">Thrown if the ID input is 
        /// not in a valid integer format.</exception>
        /// <exception cref="OverflowException">Thrown if the ID input 
        /// represents a number less than <see cref="int.MinValue"/> 
        /// or greater than <see cref="int.MaxValue"/>.</exception>
        public void SearchPerson()
        {
            Console.Write("Enter name or ID to search: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int id))
            {
                InputValidator.CheckIfIntInRange(id, 0, int.MaxValue,
                    "Person's id must be a positive integer");
                searchById(id);
            }
            else
            {
                InputValidator.CheckIfNoneEmptyOrWhiteSpaceString(input);
                searchByName(input);
            }
        }

        /// <summary>
        /// Searches for a person by their ID and displays their information 
        /// if found.
        /// </summary>
        /// <param name="id">The ID of the person to search for.</param>
        private void searchById(int id)
        {
            if (_peopleById.TryGetValue(id, out Person person))
            {
                person.DisplayInfo();
            }
            else
            {
                Console.WriteLine($"Person with ID {id} not found.");
            }
        }

        /// <summary>
        /// Searches for people by name (case-insensitive, partial match) and 
        /// displays their information if found.
        /// </summary>
        /// <param name="name">The name or partial name to search for.</param>
        private void searchByName(string name)
        {
            bool isFound = false;
            string newName = name.ToLower();
            foreach (Person person in _peopleById.Values)
            {
                if (person.Name.ToLower().Contains(newName))
                {
                    person.DisplayInfo();
                    if (!isFound)
                    {
                        isFound = true;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Person with the name {name} not found.");
            }
        }

        /// <summary>
        /// Prompts the user to update the address of a person by their ID.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the entered ID 
        /// is not within the valid range.</exception>
        /// <exception cref="ArgumentNullException">Thrown if the 
        /// ID input is null.</exception>
        /// <exception cref="FormatException">Thrown if the ID input is 
        /// not in a valid integer format.</exception>
        /// <exception cref="OverflowException">Thrown if the ID input 
        /// represents a number less than <see cref="int.MinValue"/> 
        /// or greater than <see cref="int.MaxValue"/>.</exception>
        public void ChangePersonAddress()
        {
            Console.Write("Enter Person ID to update address: ");
            int id = InputValidator.GetPositiveInteger();
            if (_peopleById.TryGetValue(id, out Person person))
            {
                Console.Write("Enter new address: ");
                person.Address = Console.ReadLine();
                Console.WriteLine("Address updated successfully");
            }
            else
                Console.WriteLine($"Person with ID {id} not found");
        }
    }
}