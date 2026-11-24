using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories
{
    public interface IDirectionRepository
    {
        IEnumerable<Direction> ReadDirections();
        Direction ReadDirectionById(int id);
        void CreateDirection(Direction direction);
        void UpdateDirection(Direction direction);
        void DeleteDirection(int id);
    }
}