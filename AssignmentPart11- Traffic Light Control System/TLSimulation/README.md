# Traffic Light Simulation

This C# console application simulates the operation of a traffic light by cycling through red, green, and yellow lights. The user specifies the number of cycles, and the simulation displays messages and delays that represent the behavior of a real-world traffic light system.

## Features

- Simulates a traffic light system with three states: Red, Green, and Yellow.
- Uses `Thread.Sleep` to mimic real-world light durations.
- Validates user input to ensure it is a positive integer.

## How It Works

1. The user is prompted to enter the number of cycles.
2. The simulation runs for the specified number of cycles.
3. In each cycle:
   - Red light displays for 3 seconds.
   - Green light displays for 2 seconds.
   - Yellow light displays for 1 second.

## Example Output


Enter the number of cycles: 2
Red Light - Stop!
Green Light - Go!
Simulation completed.

## Project Structure

- `Program.cs`: Entry point that handles user input and runs the simulation.
- `TrafficLightController.cs`: Manages the state transitions of the traffic light.

## Requirements

- [.NET 6.0 or later](https://dotnet.microsoft.com/en-us/download)
- Console environment

## How to Run

1. Clone the repository or download the source files.
2. Open the project in Visual Studio or use the CLI.
3. Build and run the project:

```bash
dotnet run
