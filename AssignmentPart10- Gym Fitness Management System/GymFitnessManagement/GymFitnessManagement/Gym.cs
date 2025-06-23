namespace GymFitnessManagement {
    /// <summary>
    /// Represents a gym that manages its members.
    /// Implements member management operations defined by 
    /// <see cref="IGymManagement"/>.
    /// </summary>
    internal class Gym : IGymManagement {
        private readonly List<Member> _members = [];

        /// <summary>
        /// Adds a new member to the gym.
        /// </summary>
        /// <param name="newMember">The member to add.</param>
        /// <remarks>
        /// The <paramref name="newMember"/> must be a valid 
        /// instance of a <see cref="Member"/>-derived class.
        /// Any exceptions thrown by the member's constructor or 
        /// property setters (such as <see cref="ArgumentException"/>)
        /// will propagate to the caller.
        /// </remarks>
        public void AddMember(Member newMember)
        {
            _members.Add(newMember);
        }

        /// <summary>
        /// Displays details of all gym members.
        /// </summary>
        /// <remarks>
        /// Calls <see cref="Member.DisplayDetails"/> 
        /// for each member in the gym.
        /// </remarks>
        public void DisplayAllMembers()
        {
            foreach (Member member in _members)
            {
                member.DisplayDetails();
            }
        }
    }
}