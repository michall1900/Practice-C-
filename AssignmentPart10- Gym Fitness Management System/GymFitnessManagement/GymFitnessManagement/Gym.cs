
namespace GymFitnessManagement {
    internal class Gym : IGymManagement {
        private readonly List<Member> _members = [];

        public void AddMember(Member newMember)
        {
            _members.Add(newMember);
        }

        public void DisplayAllMembers()
        {
            foreach (Member member in _members)
            {
                member.DisplayDetails();
            }
        }
    }
}
