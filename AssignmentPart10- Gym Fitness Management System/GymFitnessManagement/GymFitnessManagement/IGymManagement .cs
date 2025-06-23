namespace GymFitnessManagement {
    /// <summary>
    /// Defines methods for managing gym members.
    /// </summary>
    internal interface IGymManagement {
        /// <summary>
        /// Adds a new member to the gym.
        /// </summary>
        /// <param name="newMember">The member to add.</param>
        void AddMember(Member newMember);

        /// <summary>
        /// Displays details of all gym members.
        /// </summary>
        void DisplayAllMembers();
    }
}