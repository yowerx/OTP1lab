using FitnessClubApp.Entities;
using FitnessClubApp.Enums;

namespace FitnessClubApp.Repositories.Implementations
{
    public class MembershipTypeRepository : IMembershipTypeRepository
    {
        public IEnumerable<MembershipType> ReadMembershipTypes() => [];

        public MembershipType ReadMembershipTypeById(int id) =>
            MembershipType.CreateEntity(0, string.Empty, 0, MembershipPeriod.None, ClubZone.None);

        public void CreateMembershipType(MembershipType membershipType) { }

        public void UpdateMembershipType(MembershipType membershipType) { }

        public void DeleteMembershipType(int id) { }
    }
}