using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories.Implementations
{
    public class MembershipRepository : IMembershipRepository
    {
        public IEnumerable<Membership> ReadMemberships() => [];

        public void CreateMembership(Membership membership) { }
    }
}