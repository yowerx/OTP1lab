using FitnessClubApp.Repositories;
using Unity;

namespace FitnessClubApp.Forms
{
    public partial class FormTrainers : Form
    {
        private readonly IUnityContainer _container;
        private readonly ITrainerRepository _trainerRepository;

        public FormTrainers(IUnityContainer container, ITrainerRepository trainerRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _trainerRepository = trainerRepository ?? throw new ArgumentNullException(nameof(trainerRepository));
        }

        private void FormTrainers_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() => dataGridViewData.DataSource = _trainerRepository.ReadTrainers().ToList();

        private bool TryGetId(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Не выбрана запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormTrainer>().ShowDialog();
            LoadList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;
            var form = _container.Resolve<FormTrainer>();
            form.Id = id;
            form.ShowDialog();
            LoadList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _trainerRepository.DeleteTrainer(id);
                LoadList();
            }
        }
    }
}