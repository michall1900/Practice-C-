using PersonInformation.Utilities;

namespace PersonInformation {
    public class Person {

        private int _personId;
        private string _name;
        private int _age;
        private string _address;

        public string Address {
            get { return string.IsNullOrEmpty(_address) ? "Unknown" : _address; }
            set { _address = value; }
        }
        public int PersonId {
            get { return _personId; }
            private set {
                InputValidator.CheckIfIntInRange(value, 0, int.MaxValue,
                    "Person's id must be a positive integer");
                _personId = value;
            }
        }
        public int Age {
            private set {
                InputValidator.CheckIfIntInRange(value, 0, 120,
                    "Person's age must be a positive integer and less than or equal to 120");

                _age = value;
            }
            get {
                return _age;
            }
        }
        
        public string Name {
            get { return _name; }
            private set {
                InputValidator.CheckIfNoneEmptyOrWhiteSpaceString(value, "Name can't be null or empty");
                string[] splitName = value.Split(' ');
                string[] realSplitName = new string [splitName.Length];
                for (int i = 0, j =0; i < splitName.Length; i++)
                {
                    if (!String.IsNullOrWhiteSpace(splitName[i]))
                    {
                        realSplitName[j++] = capitalizeWord(splitName[i]);
                    }
                        
                }
                _name = String.Join(' ', realSplitName);
            }
        }
        public Person(int personId, int age, string name, string address)
        {
            PersonId = personId;
            Name = name;
            Age = age;
            Address = address;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Person ID: {_personId}, Name: {_name}, Age: {_age}, Address: " +
                $"{Address}");

        }

        private string capitalizeWord(string word)
        {
            word = word.Trim();
            word = word.ToLower();
            return char.ToUpper(word[0]) + ((word.Length > 1) ? word[1..] : "");
        }
    }
}
