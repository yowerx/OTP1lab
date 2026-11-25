namespace FitnessClubApp.Entities
{
    public class Visit
    {
        public int Id { get; private set; }
        public DateTime VisitDate { get; private set; }
        public int MembershipId { get; private set; }
        public int ClassId { get; private set; }
        public int ClientId { get; private set; }
        public int TrainerId { get; private set; }

        public static Visit CreateOperation(int id, DateTime visitDate, int membershipId, int classId, int clientId, int trainerId)
        {
            return new Visit
            {
                Id = id,
                VisitDate = visitDate,
                MembershipId = membershipId,
                ClassId = classId,
                ClientId = clientId,
                TrainerId = trainerId
            };
        }
    }
}