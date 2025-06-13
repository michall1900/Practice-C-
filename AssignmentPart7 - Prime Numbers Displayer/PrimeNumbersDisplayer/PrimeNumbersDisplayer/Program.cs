

namespace PrimeNumbersDisplayer 
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
            int start = getNumberFromUser("Enter the start of the range: ");
            int end = getNumberFromUser("Enter the end of the range: ", start, $" that is greater from {start}");
            if(!printPrimes(start, end))
            {
                Console.WriteLine("No prime numbers found in the given range ");
            }
        }

        private static bool printPrimes(int start, int end)
        {
            int i = start;
            bool isFound = false;
            while(i <= end)
            {
                if (isPrime(i))
                {
                    if(!isFound)
                    {
                        Console.Write($"Prime numbers between {start} and {end} are: ");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                    Console.Write(i);
                    isFound = true;
                }
                i++;
            }

            return isFound;
        }

        private static bool isPrime(int num)
        {
            if(num <= 2)
            {
                return num == 2;
            }
            else if(num % 2 == 0)
            {
                return false;
            }
            int squreRoot = (int) Math.Sqrt(num);
            for (int i = 3; i <= squreRoot; i+=2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static int getNumberFromUser(string message, int start=-1, string errorMessage="")
        {
            bool isValidNumber = false;
            int result;
            do
            {
                Console.Write(message);
                if(int.TryParse(Console.ReadLine(), out result) && 
                    result >= 0 && start <= result)
                {
                    isValidNumber = true;
                }
                else
                {
                    Console.WriteLine($"Error: Invalid input. Please enter a positive integer{errorMessage}.");
                }

            } while (!isValidNumber);

            return result;
        }
    }
}
