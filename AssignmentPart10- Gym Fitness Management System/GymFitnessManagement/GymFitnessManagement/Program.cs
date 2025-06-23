

namespace GymFitnessManagement 
{
    public class Program {
        public static void Main(string[] _)
        {
            Gym gym = new();
            gym.AddMember(new RegularMember("John Doe", 25, 1, 20));
            gym.AddMember(new RegularMember("Jane Smith", 30, 2, 15));
            gym.AddMember(new PremiumMember("Mike Brown", 35, 3, 50,30));
            gym.AddMember(new PremiumMember("Anna White", 28, 4, 60, 25));

            gym.DisplayAllMembers();
        }
    }
}
