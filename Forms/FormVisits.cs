using FitnessClubApp.Repositories;
using Unity;

namespace FitnessClubApp.Forms
{
    public partial class FormVisits : Form
    {
        private readonly IUnityContainer _container;
        private readonly IVisitRepository _visitRepository;

        public FormVisits(IUnityContainer container, IVisitRepository visitRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _visitRepository = visitRepository ?? throw new ArgumentNullException(nameof(visitRepository));
        }

        private void FormVisits_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() => dataGridViewData.DataSource = _visitRepository.ReadVisits().ToList();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormVisit>().ShowDialog();
            LoadList();
        }
    }
}