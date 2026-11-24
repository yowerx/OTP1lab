namespace FitnessClubApp.Entities
{
    public class Trainer
    {
        public int Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;

        public static Trainer CreateEntity(int id, string fullName)
        {
            return new Trainer
            {
                Id = id,
                FullName = fullName ?? string.Empty
            };
        }
    }
}