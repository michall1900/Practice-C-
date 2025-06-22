
namespace HotPotatoGame
{
    /// <summary>
    /// Controls the flow and logic of the Hot Potato Game.
    /// Handles player input, game initialization, and the main game loop.
    /// </summary>
    public class Controller
    {

        private readonly Queue<string> _players = new();
        private bool _isRandomSequence = false;
        private int _eliminatedSequence;
        private readonly Random _random = new();

        /// <summary>
        /// Starts the Hot Potato Game by initializing and running the game loop.
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Welcome to Hot Potato Game!\n\n");
            InitializeGame();
            Console.WriteLine("\n");
            RunGame();
        }

        /// <summary>
        /// Initializes the game by collecting player names and elimination sequence settings.
        /// </summary>
        private void InitializeGame()
        {
            FillPlayerList();
            FillRandomSequence();
            if (!_isRandomSequence)
            {
                FillEliminatedSequence();
            }
        }

        /// <summary>
        /// Runs the main game loop, eliminating players until a winner is determined.
        /// </summary>
        private void RunGame()
        {

            while (_players.Count > 1)
            {
                UpdateEliminatedSequence();
                for (int i = 1; i < _eliminatedSequence; i++)
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
        private void FillEliminatedSequence()
        {
            bool valid = false;

            do
            {
                try
                {
                    Console.Write("Enter the elimination number: ");
                    string? input = Console.ReadLine();
                    InputValidator.CheckIfPositiveInt(input);
                    _eliminatedSequence = int.Parse(input!) % _players.Count;
                    valid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            } while (!valid);
        }

        /// <summary>
        /// Updates the elimination sequence number for the current round.
        /// If random sequence is enabled, sets the elimination number to a 
        /// random value between 1 and the number of players (inclusive).
        /// Otherwise, retains the previously set elimination number.
        /// </summary>
        private void UpdateEliminatedSequence()
        {
            if(_isRandomSequence)
            {
                _eliminatedSequence = _random.Next(1, _players.Count + 1);
            }
                
        }

        /// <summary>
        /// Prompts the user to enter a list of player names and adds them to the queue.
        /// </summary>
        private void FillPlayerList()
        {
            bool isValid = false;
            do
            {
                Console.WriteLine("Please enter a list of names (seperated by commas)");
                string? names = Console.ReadLine();
                try
                {
                    InputValidator.CheckIfNullOrEmptyString(names, "players' list");
                    AddPlayersNamesToQueue(names!);
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
        private void AddPlayersNamesToQueue(string input)
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
        private void FillRandomSequence()
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