using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories
{
    public interface IClassRepository
    {
        IEnumerable<Class> ReadClasses();
        Class ReadClassById(int id);
        void CreateClass(Class fitnessClass);
        void UpdateClass(Class fitnessClass);
        void DeleteClass(int id);
    }
}