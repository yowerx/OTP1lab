using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories.Implementations
{
    public class ClassRepository : IClassRepository
    {
        public IEnumerable<Class> ReadClasses() => [];

        public Class ReadClassById(int id) => Class.CreateEntity(0, 0, 0, 0);

        public void CreateClass(Class fitnessClass) { }

        public void UpdateClass(Class fitnessClass) { }

        public void DeleteClass(int id) { }
    }
}