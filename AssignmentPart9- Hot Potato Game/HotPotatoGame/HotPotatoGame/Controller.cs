
namespace HotPotatoGame {
    /// <summary>
    /// Controls the flow and logic of the Hot Potato Game.
    /// Handles player input, game initialization, and the main game loop.
    /// </summary>
    public class Controller {

        private Queue<string> _players = new Queue<string>();
        private bool _isRandomSequence = false;
        private int _eliminatedSequence;
        private Random _random = new Random();

        /// <summary>
        /// Starts the Hot Potato Game by initializing and running the game loop.
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Welcome to Hot Potato Game!\n\n");
            initializeGame();
            Console.WriteLine("\n");
            runGame();
        }

        /// <summary>
        /// Initializes the game by collecting player names and elimination sequence settings.
        /// </summary>
        private void initializeGame()
        {
            fillPlayerList();
            fillRandomSequence();
            if (!_isRandomSequence)
            {
                fillEliminatedSequence();
            }
        }

        /// <summary>
        /// Runs the main game loop, eliminating players until a winner is determined.
        /// </summary>
        private void runGame()
        {
            int eliminatedSequence = 0;
            while (_players.Count > 1)
            {
                eliminatedSequence = getEliminatedSequence();
                for (int i = 1; i < eliminatedSequence; i++)
                {
                    string currentPlayer = _players.Dequeue();
                    _players.Enqueue(currentPlayer);
                }
                string eliminatedPlayer = _players.Dequeue();
                Console.WriteLine($"Player {eliminatedPlayer} eliminated!");
            }
            string winner = _players.Dequeue();
            Console.WriteLine($"\nThe winner is {winner}!\n");
        }

        /// <summary>
        /// Prompts the user to enter the elimination number and validates the input.
        /// </summary>
        private void fillEliminatedSequence()
        {
            bool valid = false;

            do
            {
                try
                {
                    Console.Write("Enter the elimination number: ");
                    string input = Console.ReadLine();
                    InputValidator.CheckIfPositiveInt(input);
                    _eliminatedSequence = int.Parse(input) % _players.Count;
                    valid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            } while (!valid);
        }

        /// <summary>
        /// Gets the number of passes before a player is eliminated.
        /// Returns a random number if random sequence is enabled, otherwise uses the set elimination number.
        /// </summary>
        /// <returns>The number of passes before elimination.</returns>
        private int getEliminatedSequence()
        {
            return (_isRandomSequence) ? _eliminatedSequence :
                _random.Next(1, _players.Count + 1);
        }

        /// <summary>
        /// Prompts the user to enter a list of player names and adds them to the queue.
        /// </summary>
        private void fillPlayerList()
        {
            bool isValid = false;
            do
            {
                Console.WriteLine("Please enter a list of names (seperated by commas)");
                string names = Console.ReadLine();
                try
                {
                    InputValidator.CheckIfNullOrEmptyString(names, "players' list");
                    addPlayersNamesToQueue(names);
                    isValid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            } while (!isValid);
        }

        /// <summary>
        /// Splits the input string and adds each trimmed player name to the queue.
        /// </summary>
        /// <param name="input">Comma-separated list of player names.</param>
        private void addPlayersNamesToQueue(string input)
        {
            string[] listOfNames = input.Split(',');
            foreach (string name in listOfNames)
            {
                InputValidator.CheckIfNullOrEmptyString(name, "one of the player's name in the list");
                _players.Enqueue(name.Trim());
            }
        }

        /// <summary>
        /// Asks the user if the elimination sequence should be random and sets the flag accordingly.
        /// </summary>
        private void fillRandomSequence()
        {
            bool valid = false;
            do
            {
                Console.Write("Do you want that players will eliminate in a random sequence (y/n)?");
                switch (Console.ReadLine())
                {
                    case "y":
                        _isRandomSequence = true;
                        valid = true;
                        break;
                    case "n":
                        _isRandomSequence = false;
                        valid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

            } while (!valid);
        }

    }
}