namespace FitnessClubApp.Entities
{
    public class Client
    {
        public int Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;

        public static Client CreateEntity(int id, string fullName)
        {
            return new Client
            {
                Id = id,
                FullName = fullName ?? string.Empty
            };
        }
    }
}