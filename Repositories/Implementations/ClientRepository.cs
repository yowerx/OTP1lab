using FitnessClubApp.Entities;

namespace FitnessClubApp.Repositories.Implementations
{
    public class ClientRepository : IClientRepository
    {
        public IEnumerable<Client> ReadClients() => [];

        public Client ReadClientById(int id) => Client.CreateEntity(0, string.Empty);

        public void CreateClient(Client client) { }

        public void UpdateClient(Client client) { }

        public void DeleteClient(int id) { }
    }
}