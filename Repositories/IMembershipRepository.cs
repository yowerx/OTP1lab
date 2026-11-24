using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories
{
    public interface IMembershipRepository
    {
        IEnumerable<Membership> ReadMemberships();
        void CreateMembership(Membership membership);
    }
}