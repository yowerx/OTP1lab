using FitnessClubApp.Repositories;
using Unity;

namespace FitnessClubApp.Forms
{
    public partial class FormMemberships : Form
    {
        private readonly IUnityContainer _container;
        private readonly IMembershipRepository _membershipRepository;

        public FormMemberships(IUnityContainer container, IMembershipRepository membershipRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _membershipRepository = membershipRepository ?? throw new ArgumentNullException(nameof(membershipRepository));
        }

        private void FormMemberships_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() => dataGridViewData.DataSource = _membershipRepository.ReadMemberships().ToList();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormMembership>().ShowDialog();
            LoadList();
        }
    }
}
