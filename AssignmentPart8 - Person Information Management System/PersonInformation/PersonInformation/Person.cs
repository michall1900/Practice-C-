using PersonInformation.Utilities;

namespace PersonInformation {
    /// <summary>
    /// Represents a person with an ID, name, age, and address.
    /// Provides validation and formatting for person data.
    /// </summary>
    public class Person {

        private int _personId;
        private string _name;
        private int _age;
        private string _address;

        /// <summary>
        /// Gets or sets the address of the person.
        /// Returns "Unknown" if the address is null or empty.
        /// </summary>
        public string Address {
            get { return string.IsNullOrEmpty(_address) ? "Unknown" : _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Gets the unique identifier for the person.
        /// The value must be a positive integer.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the value is not within the valid range (0 to int.MaxValue).</exception>
        public int PersonId {
            get { return _personId; }
            private set {
                InputValidator.CheckIfIntInRange(value, 0, int.MaxValue,
                    "Person's id must be a positive integer");
                _personId = value;
            }
        }

        /// <summary>
        /// Gets the age of the person.
        /// The value must be between 0 and 120.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the value is not within the valid range (0 to 120).</exception>
        public int Age {
            private set {
                InputValidator.ValidateAge(value);
                _age = value;
            }
            get {
                return _age;
            }
        }

        /// <summary>
        /// Gets the name of the person.
        /// The value cannot be null or whitespace. The name is 
        /// capitalized and trimmed.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the value is null, 
        /// empty, or whitespace.</exception>
        public string Name {
            get { return _name; }
            private set {
                InputValidator.CheckIfNoneEmptyOrWhiteSpaceString(value,
                    "Name can't be null or empty");
                string[] splitName = value.Split(' ');
                string[] realSplitName = new string[splitName.Length];
                int realNameLength = 0;
                for (int i = 0; i < splitName.Length; i++)
                {
                    if (!String.IsNullOrWhiteSpace(splitName[i]))
                    {
                        realSplitName[realNameLength++] = capitalizeWord(splitName[i]);
                    }
                }
                _name = String.Join(' ', realSplitName[..realNameLength]);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with the 
        /// specified ID, age, name, and address.
        /// </summary>
        /// <param name="personId">The unique identifier for the person.</param>
        /// <param name="age">The age of the person.</param>
        /// <param name="name">The name of the person.</param>
        /// <param name="address">The address of the person.</param>
        /// <exception cref="ArgumentException">
        /// Thrown if <paramref name="personId"/> is not within the 
        /// valid range (0 to int.MaxValue),
        /// or if <paramref name="age"/> is not within the valid range (0 to 120),
        /// or if <paramref name="name"/> is null, empty, or whitespace.
        /// </exception>
        public Person(int personId, int age, string name, string address)
        {
            PersonId = personId;
            Name = name;
            Age = age;
            Address = address;
        }

        /// <summary>
        /// Displays the person's information to the console.
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Person ID: {_personId}, Name: {_name}, Age: {_age}, Address: " +
                $"{Address}");
        }

        /// <summary>
        /// Capitalizes the first letter of a word and converts the 
        /// rest to lowercase.
        /// </summary>
        /// <param name="word">The word to capitalize.</param>
        /// <returns>The capitalized word.</returns>
        private string capitalizeWord(string word)
        {
            word = word.Trim();
            word = word.ToLower();
            return char.ToUpper(word[0]) + ((word.Length > 1) ? word[1..] : "");
        }
    }
}