# Assignment – Grading System for Students

This program is part of the **Complete C# Programming Master Class** on Udemy.

## Description

An interactive console application that allows users to enter student marks and receive a corresponding grade and feedback. The system supports continuous input for multiple students, with robust validation and friendly error handling.

## Features

- **Grade Calculation**  
  Converts numeric marks (0–100) into grades based on standard grading criteria:
  - A (90–100)
  - B (80–89)
  - C (70–79)
  - D (60–69)
  - Fail (below 60)

- **Remarks System**  
  Provides qualitative feedback for each grade:
  - A → Excellent  
  - B → Very Good  
  - C → Good  
  - D → Needs Improvement  
  - Fail → Better Luck Next Time

- **User Interaction Loop**  
  The application asks the user after each entry whether they want to input marks for another student.

- **Input Validation**  
  - Ensures marks are integers between 0 and 100  
  - Validates Yes/No input for continuing  
  - Handles and displays informative error messages via `ArgumentException`

## Example Run

Enter marks for the student: 88
Grade: B
Remarks: Very Good
Do you want to enter marks for another student? (Yes/No): yes
Enter marks for the student: 45
Grade: Fail
Remarks: Better Luck Next Time
Do you want to enter marks for another student? (Yes/No): no
Goodbye!

## Learning Objectives

- Apply `if-else` and `switch` expressions for decision making
- Use exception handling (`try-catch`) to enforce input constraints
- Implement reusable methods for clean separation of concerns
- Reinforce loop-based program structure with conditional logic
