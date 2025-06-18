using PersonInformation.Utilities;

namespace PersonInformation {
    public class PersonManager {
        private Dictionary<int, Person> _peopleById = new Dictionary<int, Person>();

        public void AddPerson()
        {
            bool invalid = true;
            do
            {
                HandleError.RunWithValidation(()=> this.addPerson(ref invalid));
            } while (invalid);
        }

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

        private void checkIfIdAlreadyExist(int id)
        {
            if (_peopleById.ContainsKey(id))
                throw new ArgumentException($"Person with ID {id} already exists.");
        }
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

