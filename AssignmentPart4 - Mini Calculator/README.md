# Assignment 04 – Interactive Console Calculator

This program is part of the **Complete C# Programming Master Class** on Udemy.

## Description

This assignment implements an interactive calculator that runs in the console.  
It allows the user to perform basic arithmetic operations (addition, subtraction, multiplication, division) on two numbers, with full input validation and support for repeated calculations in a loop.

## Features

- **User Interaction**  
  Prompts the user to enter two numbers and select an operation via a simple menu.
  
- **Arithmetic Operations**  
  Supports addition, subtraction, multiplication, and division (with division-by-zero protection).

- **Input Validation**  
  - Uses `double.TryParse()` to ensure numeric inputs  
  - Handles invalid operation choices  
  - Trims and normalizes Yes/No answers to support user flexibility

- **Looping Behavior**  
  After each calculation, the user is asked whether they wish to continue. The program exits cleanly on `"no"` and continues on `"yes"`.

## Example Run

Enter the first number: 10
Enter the second number: 2
Select operation: (1) Addition (2) Subtraction (3) Multiplication (4) Division
Your choice: 3
Result: 20
Do you want to perform another calculation? (Yes/No): no
Goodbye!
