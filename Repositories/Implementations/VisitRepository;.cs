using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories.Implementations
{
    public class VisitRepository : IVisitRepository
    {
        public IEnumerable<Visit> ReadVisits() => [];

        public void CreateVisit(Visit visit) { }
    }
}