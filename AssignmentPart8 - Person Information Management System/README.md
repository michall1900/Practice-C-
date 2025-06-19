# Person Information Management System

This is a simple C# console application for managing personal information such as ID, name, age, and address. The application allows users to add new people, view all registered people, search by name or ID, and update a person's address.

## Features

- Add a new person with validated ID, name, age, and address
- Display a list of all registered people
- Search for a person by ID or partial name
- Update the address of an existing person
- Input validation and error handling to ensure safe and accurate data

## Technologies Used

- C# (.NET)
- Console-based UI
- Dictionary for internal data storage
- Basic input validation logic

## Project Structure

- `Program.cs` – Entry point of the application. Handles the main menu and user interaction.
- `PersonManager.cs` – Core logic for adding, searching, displaying, and updating persons.
- `Person.cs` – Defines the `Person` class and enforces validation on creation.
- `InputValidator.cs` – Contains utility methods for input validation (e.g., checking age, ID, and non-empty strings).
- `HandleError.cs` – Wraps actions with a generic error handler to simplify exception management.

## Usage

1. Compile and run the application.
2. Follow the on-screen menu to:
   - Add new persons
   - List all people
   - Search by name or ID
   - Update a person's address
   - Exit the program

## Input Validation

- IDs must be positive integers and unique.
- Names must be non-empty strings.
- Ages must be between 0 and 120.
- Addresses are optional; if omitted or empty, they will be shown as "Unknown".

## Error Handling

All user input operations are wrapped in a generic error handler (`HandleError.RunWithValidation`) that catches:
- `FormatException`
- `OverflowException`
- `ArgumentException`

This ensures the program does not crash on invalid input and gives clear feedback to the user.

## License

This project is for educational purposes and may be freely modified or reused.
