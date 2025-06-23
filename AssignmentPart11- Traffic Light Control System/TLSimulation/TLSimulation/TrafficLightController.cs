namespace TLSimulation {
    /// <summary>
    /// Controls the state and transitions of a simulated traffic light.
    /// </summary>
    internal class TrafficLightController {

        /// <summary>
        /// Represents the possible states of the traffic light.
        /// </summary>
        public enum TrafficLight { Red, Yellow, Green }

        /// <summary>
        /// Gets or sets the current state of the traffic light.
        /// </summary>
        public TrafficLight CurrentLight { get; set; }

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="TrafficLightController"/> class
        /// and sets the initial light to Red.
        /// </summary>
        public TrafficLightController()
        {
            CurrentLight = TrafficLight.Red;
        }

        /// <summary>
        /// Switches the traffic light to the next state and displays the 
        /// corresponding message.
        /// </summary>
        public void SwitchLight()
        {
            switch (CurrentLight)
            {
                case TrafficLight.Red:
                    Console.WriteLine("Red Light - Stop!");
                    Thread.Sleep(3000);
                    CurrentLight = TrafficLight.Green;
                    break;
                case TrafficLight.Yellow:
                    Console.WriteLine("Yellow Light - Get Ready!");
                    Thread.Sleep(1000);
                    CurrentLight = TrafficLight.Red;
                    break;
                case TrafficLight.Green:
                    Console.WriteLine("Green Light - Go!");
                    Thread.Sleep(2000);
                    CurrentLight = TrafficLight.Yellow;
                    break;
            }
        }
    }
}