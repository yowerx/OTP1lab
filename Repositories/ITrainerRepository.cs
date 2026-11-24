using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories
{
    public interface ITrainerRepository
    {
        IEnumerable<Trainer> ReadTrainers();
        Trainer ReadTrainerById(int id);
        void CreateTrainer(Trainer trainer);
        void UpdateTrainer(Trainer trainer);
        void DeleteTrainer(int id);
    }
}