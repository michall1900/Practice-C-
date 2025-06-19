using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotatoGame {
    public class Controller {

        private Queue<string> _players = new Queue<string>();
        private bool _isRandomSequence = false;
        private int _eliminatedSequence;
        private Random _random = new Random();
        public void Run()
        {
            Console.WriteLine("Welcome to Hot Potato Game!\n\n");
            fillPlayerList();
            fillRandomSequence();
            if (!_isRandomSequence)
            {
                fillEliminatedSequence();
            }


        }

        private void fillEliminatedSequence()
        {
            bool valid = false;

            do
            {
                try
                {
                    Console.WriteLine("Enter the elimination number: ");
                    string input = Console.ReadLine();
                    InputValidator.CheckIfPositiveInt(input);
                    _eliminatedSequence = int.Parse(input);
                    valid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            } while (!valid);
        }

        private int getEliminatedSequence(int realSize)
        {
            return (_isRandomSequence) ? _eliminatedSequence : 
                _random.Next(1, realSize); 
        }

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

        private void addPlayersNamesToQueue(string input)
        {
            string [] listOfNames = input.Split(',');
            foreach (string name in listOfNames)
            {
                InputValidator.CheckIfNullOrEmptyString(name, "one of the player's name in the list");
                _players.Enqueue(name.Trim());
            }
        }

        private void fillRandomSequence()
        {
            
            bool valid = false;
            do
            {
                Console.Write("Do you want that players will eliminate in a random sequence (y/n)?");
                switch (Console.ReadLine()){
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
