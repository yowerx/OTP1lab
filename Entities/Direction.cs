namespace FitnessClubApp.Entities
{
    public class Direction
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public static Direction CreateEntity(int id, string name)
        {
            return new Direction
            {
                Id = id,
                Name = name ?? string.Empty
            };
        }
    }
}