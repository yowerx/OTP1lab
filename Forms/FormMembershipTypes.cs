using FitnessClubApp.Repositories;
using Unity;

namespace FitnessClubApp.Forms
{
    public partial class FormMembershipTypes : Form
    {
        private readonly IUnityContainer _container;
        private readonly IMembershipTypeRepository _membershipTypeRepository;

        public FormMembershipTypes(IUnityContainer container, IMembershipTypeRepository membershipTypeRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _membershipTypeRepository = membershipTypeRepository ?? throw new ArgumentNullException(nameof(membershipTypeRepository));
        }

        private void FormMembershipTypes_Load(object sender, EventArgs e) => LoadList();

        private void LoadList() => dataGridViewData.DataSource = _membershipTypeRepository.ReadMembershipTypes().ToList();

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
            _container.Resolve<FormMembershipType>().ShowDialog();
            LoadList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;
            var form = _container.Resolve<FormMembershipType>();
            form.Id = id;
            form.ShowDialog();
            LoadList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _membershipTypeRepository.DeleteMembershipType(id);
                LoadList();
            }
        }
    }
}