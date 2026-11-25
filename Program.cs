using FitnessClubApp.Forms;
using FitnessClubApp.Repositories;
using FitnessClubApp.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace FitnessClubApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormMain>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IClientRepository, ClientRepository>(new TransientLifetimeManager());
            container.RegisterType<ITrainerRepository, TrainerRepository>(new TransientLifetimeManager());
            container.RegisterType<IMembershipTypeRepository, MembershipTypeRepository>(new TransientLifetimeManager());
            container.RegisterType<IClassRepository, ClassRepository>(new TransientLifetimeManager());
            container.RegisterType<IMembershipRepository, MembershipRepository>(new TransientLifetimeManager());
            container.RegisterType<IVisitRepository, VisitRepository>(new TransientLifetimeManager());
            return container;
        }
    }
}