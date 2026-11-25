using FitnessClubApp.Enums;

namespace FitnessClubApp.Entities
{
    public class Class
    {
        public int Id { get; private set; }
        public int MaxParticipants { get; private set; }
        public int TrainerId { get; private set; }
        public ClubZone Zone { get; private set; }

        public static Class CreateEntity(int id, int maxParticipants, int trainerId, ClubZone zone)
        {
            return new Class
            {
                Id = id,
                MaxParticipants = maxParticipants,
                TrainerId = trainerId,
                Zone = zone
            };
        }
    }
}