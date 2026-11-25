using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories
{
    public interface IMembershipTypeRepository
    {
        IEnumerable<MembershipType> ReadMembershipTypes();
        MembershipType ReadMembershipTypeById(int id);
        void CreateMembershipType(MembershipType membershipType);
        void UpdateMembershipType(MembershipType membershipType);
        void DeleteMembershipType(int id);
    }
}