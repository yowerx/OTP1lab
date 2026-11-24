using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories
{
    public interface IVisitRepository
    {
        IEnumerable<Visit> ReadVisits();
        void CreateVisit(Visit visit);
    }
}