# Hot Potato Game
This is a simple console-based implementation of the classic **Hot Potato** game written in C#.
Players take turns passing a "hot potato", and at a certain count, a player is eliminated.
The game continues until only one player remains — the winner.

## Features
- Supports custom list of player names entered by the user.

- Option to eliminate players based on:

- A fixed elimination number.

- A random number generated each round.

- Validates all user input to prevent invalid or empty values.

## How to Play
1. Enter player names separated by commas (e.g. Alice, Bob, Charlie).

2. Choose elimination mode:

3. Type y for random elimination sequence.

4. Type n to manually specify the elimination number.

5. The game will simulate turns and display which player is eliminated each round.

6. When only one player remains, they are declared the winner.

### Example
Welcome to Hot Potato Game!

```text
Please enter a list of names (seperated by commas)
Alice, Bob, Charlie, Dana
Do you want that players will eliminate in a random sequence (y/n)?n
Enter the elimination number: 3
Player Bob eliminated!
Player Dana eliminated!
Player Alice eliminated!

The winner is Charlie!
```
## Project Structure
- Program.cs – Entry point of the application. Starts the controller.

- Controller.cs – Manages game flow, player input, and elimination logic.

- InputValidator.cs – Static helper class for validating user input.

## Requirements
- .NET 6.0 or higher

- Console environment (e.g., Windows Terminal, macOS Terminal, VS Code terminal)

## How to Run
1. Clone or download this repository.

2. Open the project folder in Visual Studio or any C# IDE.

3. Build and run the application.

4. Alternatively, using the terminal:
```code
dotnet run
```
## Educational Use
This project is suitable for practicing:

1. Queue data structures

2. Input validation

3. Control flow and user interaction in console applications

4. Basic object-oriented programming in C#

Note: This project was developed as part of a C# learning exercise.
