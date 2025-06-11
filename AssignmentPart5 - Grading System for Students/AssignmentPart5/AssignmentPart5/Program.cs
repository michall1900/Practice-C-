using System.Diagnostics;

namespace GradingSystemForStudents {
    /// <summary>
    /// Entry point and logic for the Grading System for Students application.
    /// </summary>
    public class Program {
        /// <summary>
        /// Prompts the user to determine if marks should be entered for another student.
        /// </summary>
        /// <returns>True if the user wants to continue; otherwise, false.</returns>
        /// <exception cref="ArgumentException">Thrown when input is not 'Yes' or 'No'.</exception>
        private static bool IsNeedsToContinue() {

            Console.Write("Do you want to enter marks for another student? (Yes/No): ");
            string toContinue = Console.ReadLine();

            if (!string.IsNullOrEmpty(toContinue)) {
                toContinue = toContinue.Trim().ToLower();
            }
            if (string.Equals(toContinue, "no")) {
                Console.WriteLine("Goodbye!");
                return false; // Exit the loop if user says no
            }
            else if (!string.Equals(toContinue, "yes")) {
                throw new ArgumentException("Invalid input! Please enter 'Yes' or 'No'."); // Ask again if input is invalid
            }
            return true; // Continue if user says yes
        }

        /// <summary>
        /// Prompts the user to enter marks for a student and validates the input.
        /// </summary>
        /// <returns>The valid marks entered by the user.</returns>
        /// <exception cref="ArgumentException">Thrown when input is not a valid integer between 0 and 100.</exception>
        private static int GetMarksFromUser() {
            Console.Write("Enter marks for the student: ");
            string? marksInput = Console.ReadLine();
            if (int.TryParse(marksInput, out int marks) && marks >= 0 && marks <= 100) {
                return marks; // Return valid marks
            }
            else {
                throw new ArgumentException("Invalid input! Please enter an integer number between 0 and 100.");
            }
        }

        /// <summary>
        /// Determines the grade based on the provided marks.
        /// </summary>
        /// <param name="marks">The marks obtained by the student.</param>
        /// <returns>The grade as a string.</returns>
        private static string GetGrade(int marks) {
            if (marks >= 90) {
                return "A";
            }
            else if (marks >= 80) {
                return "B";
            }
            else if (marks >= 70) {
                return "C";
            }
            else if (marks >= 60) {
                return "D";
            }
            else {
                return "Fail";
            }
        }

        /// <summary>
        /// Provides remarks based on the grade.
        /// </summary>
        /// <param name="grade">The grade obtained by the student.</param>
        /// <returns>Remarks as a string.</returns>
        private static string GetReamarks(string grade) {
            return grade switch {
                "A" => "Excellent",
                "B" => "Very Good",
                "C" => "Good",
                "D" => "Needs Improvement",
                _ => "Better Luck Next Time"
            };
        }

        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        public static void Main() {
            bool isFirstTime = true;
            string grade;
            string remarks;

            while (true) {
                try {
                    if (!isFirstTime && !IsNeedsToContinue()) {
                        break;
                    }
                    else {
                        isFirstTime = false; // Set to false after the first iteration
                    }
                    int marks = GetMarksFromUser(); // Get valid marks from user
                    grade = GetGrade(marks); // Get grade based on marks
                    remarks = GetReamarks(grade); // Get remarks based on grade 
                    Console.WriteLine($"Grade: {grade}");
                    Console.WriteLine($"Remarks: {remarks}");
                }
                catch (ArgumentException ex) {
                    Console.WriteLine($"Error: {ex.Message}"); // Print the error message
                }
            }
        }
    }
}
