

namespace GymFitnessManagement {
    /// <summary>
    /// Entry point for the Gym Fitness Management System application.
    /// Demonstrates adding regular and premium members to the gym and 
    /// displaying their details.
    /// </summary>
    public class Program {
        /// <summary>
        /// Application entry point.
        /// Adds sample members to the gym and displays all member details.
        /// </summary>
        /// <param name="_">Command-line arguments (not used).</param>
        /// <exception cref="ArgumentException">
        /// Thrown if any member is created with invalid data (e.g., negative 
        /// member ID, invalid age, or non-positive fees).
        /// </exception>
        public static void Main(string[] _)
        {
            Gym gym = new();

            gym.AddMember(new RegularMember("John Doe", 25, 1, 20));
            gym.AddMember(new RegularMember("Jane Smith", 30, 2, 15));

            gym.AddMember(new PremiumMember("Mike Brown", 35, 3, 50, 30));
            gym.AddMember(new PremiumMember("Anna White", 28, 4, 60.15, 25.289));

            gym.DisplayAllMembers();
        }
    }
}
