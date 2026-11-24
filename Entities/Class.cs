namespace FitnessClubApp.Entities
{
    public class Class
    {
        public int Id { get; private set; }
        public int MaxParticipants { get; private set; }
        public int TrainerId { get; private set; }
        public int DirectionId { get; private set; }

        public static Class CreateEntity(int id, int maxParticipants, int trainerId, int directionId)
        {
            return new Class
            {
                Id = id,
                MaxParticipants = maxParticipants,
                TrainerId = trainerId,
                DirectionId = directionId
            };
        }
    }
}