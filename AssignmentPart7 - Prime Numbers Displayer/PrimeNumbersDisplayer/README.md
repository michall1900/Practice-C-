# Prime Numbers Displayer

This is a simple C# console application that prompts the user to input a range of integers and then displays all prime numbers within that range.

## Features

- **User Input:** The user is prompted to input a starting and ending range. The application ensures that the ending number is greater than or equal to the starting number.
- **Prime Number Calculation:** The program calculates all prime numbers between the given range using an efficient prime-checking algorithm.
- **Output:** Displays all prime numbers in the specified range. If no prime numbers are found, the program informs the user accordingly.

## Requirements

- .NET Core or .NET Framework (Compatible with C# projects)
- A terminal or console to run the application

## How to Use

1. **Clone or Download the Repository:**
   Clone the repository to your local machine or download the project files.

2. **Build and Run the Application:**
   - Open the project in your preferred C# IDE (such as Visual Studio).
   - Build the project and run the program.

3. **Provide the Range:**
   - You will be prompted to enter the start of the range.
   - Then, you will be prompted to enter the end of the range. The program ensures that the end is greater than or equal to the start.

4. **View the Output:**
   - The program will display all prime numbers in the specified range.
   - If no prime numbers are found, a message will inform you.

## Code Breakdown

### `Main(string[] args)`
The entry point of the application. It:
- Prompts the user for the start and end of the range.
- Calls the `printPrimes()` method to find and display prime numbers.

### `printPrimes(int start, int end)`
This method:
- Iterates through the numbers in the specified range.
- Checks if each number is prime using the `isPrime()` method.
- Prints the prime numbers to the console. If no primes are found, it returns `false`.

### `isPrime(int num)`
This method:
- Determines whether a number is prime by checking if it is divisible by any number other than 1 and itself. It only checks divisibility up to the square root of the number for efficiency.

### `readPositiveInteger(string message, int start = -1, string errorMessage = "")`
This method:
- Prompts the user to enter a positive integer, with optional validation to ensure that the number is greater than a specified starting value.

## Example

**Input:**
Enter the start of the range: 10
Enter the end of the range: 50

**Output:**
Prime numbers between 10 and 50 are: 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47

If no prime numbers are found in the specified range, the program will output:
No prime numbers found in the given range

## Contributing

If you'd like to contribute to this project, feel free to submit a pull request or open an issue. Any contributions are welcome!

## License

This project is open-source and available under the [MIT License](LICENSE).
