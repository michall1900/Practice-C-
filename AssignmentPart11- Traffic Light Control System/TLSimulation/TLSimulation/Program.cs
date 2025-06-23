

namespace TLSimulation {
    /// <summary>
    /// Entry point for the Traffic Light Simulation application.
    /// Prompts the user for the number of cycles and runs the traffic 
    /// light controller accordingly.
    /// </summary>
    public class Program {

        /// <summary>
        /// Main method to start the traffic light simulation.
        /// </summary>
        /// <param name="_">Command-line arguments (not used).</param>
        public static void Main(string[] _)
        {
            Console.Write("Enter the number of cycles: ");
            

            if(!int.TryParse(Console.ReadLine(), out int numOfCycles) ||
                numOfCycles <=0 )
            {
                Console.Error.WriteLine("Invalid integer, you should " +
                    "enter a positive integer > 0.\nExit program..");
                return;
            }

            TrafficLightController trafficLight = new();

            for (int i = 0; i < numOfCycles; i++)
            {
                trafficLight.SwitchLight();
            }

            Console.WriteLine("Simulation completed.");
        }
    }
}