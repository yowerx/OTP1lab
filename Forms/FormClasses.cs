using FitnessClubApp.Repositories;
using Unity;

namespace FitnessClubApp.Forms
{
    public partial class FormClasses : Form
    {
        private readonly IUnityContainer _container;
        private readonly IClassRepository _classRepository;

        public FormClasses(IUnityContainer container, IClassRepository classRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _classRepository = classRepository ?? throw new ArgumentNullException(nameof(classRepository));
        }

        private void FormClasses_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() => dataGridViewData.DataSource = _classRepository.ReadClasses().ToList();

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
            _container.Resolve<FormClass>().ShowDialog();
            LoadList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;
            var form = _container.Resolve<FormClass>();
            form.Id = id;
            form.ShowDialog();
            LoadList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _classRepository.DeleteClass(id);
                LoadList();
            }
        }
    }
}