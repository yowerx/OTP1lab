namespace FitnessClubApp.Entities
{
    public class Membership
    {
        public int Id { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int ClientId { get; private set; }
        public int MembershipTypeId { get; private set; }

        public static Membership CreateOperation(int id, DateTime startDate, DateTime endDate, int clientId, int membershipTypeId)
        {
            return new Membership
            {
                Id = id,
                StartDate = startDate,
                EndDate = endDate,
                ClientId = clientId,
                MembershipTypeId = membershipTypeId
            };
        }
    }
}