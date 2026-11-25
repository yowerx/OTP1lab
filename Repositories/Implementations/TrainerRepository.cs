using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories.Implementations
{
    public class TrainerRepository : ITrainerRepository
    {
        public IEnumerable<Trainer> ReadTrainers() => [];

        public Trainer ReadTrainerById(int id) => Trainer.CreateEntity(0, string.Empty);

        public void CreateTrainer(Trainer trainer) { }

        public void UpdateTrainer(Trainer trainer) { }

        public void DeleteTrainer(int id) { }
    }
}