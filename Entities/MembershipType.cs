using FitnessClubApp.Enums;

namespace FitnessClubApp.Entities
{
    public class MembershipType
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public decimal Price { get; private set; }
        public MembershipPeriod Period { get; private set; }
        public ClubZone AvailableZones { get; private set; }

        public static MembershipType CreateEntity(int id, string name, decimal price, MembershipPeriod period, ClubZone availableZones)
        {
            return new MembershipType
            {
                Id = id,
                Name = name ?? string.Empty,
                Price = price,
                Period = period,
                AvailableZones = availableZones
            };
        }
    }
}