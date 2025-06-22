namespace HotPotatoGame {
    /// <summary>
    /// Entry point for the Hot Potato Game application.
    /// Initializes the controller and starts the game loop.
    /// </summary>
    internal class Program {
        /// <summary>
        /// Main method. Application execution starts here.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Run();
        }
    }
}