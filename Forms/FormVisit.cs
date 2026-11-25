using FitnessClubApp.Entities;
using FitnessClubApp.Repositories;

namespace FitnessClubApp.Forms
{
    public partial class FormVisit : Form
    {
        private readonly IVisitRepository _visitRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IMembershipRepository _membershipRepository;
        private readonly IClassRepository _classRepository;

        public FormVisit(IVisitRepository visitRepository, IClientRepository clientRepository, IMembershipRepository membershipRepository, IClassRepository classRepository)
        {
            InitializeComponent();
            _visitRepository = visitRepository ?? throw new ArgumentNullException(nameof(visitRepository));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _membershipRepository = membershipRepository ?? throw new ArgumentNullException(nameof(membershipRepository));
            _classRepository = classRepository ?? throw new ArgumentNullException(nameof(classRepository));
        }

        private void FormVisit_Load(object sender, EventArgs e)
        {
            comboBoxClient.DataSource = _clientRepository.ReadClients().ToList();
            comboBoxClient.DisplayMember = "FullName";
            comboBoxClient.ValueMember = "Id";

            comboBoxMembership.DataSource = _membershipRepository.ReadMemberships().ToList();
            comboBoxMembership.DisplayMember = "Id";
            comboBoxMembership.ValueMember = "Id";

            comboBoxClass.DataSource = _classRepository.ReadClasses().ToList();
            comboBoxClass.DisplayMember = "Id";
            comboBoxClass.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxMembership.SelectedValue == null)
            {
                MessageBox.Show("Выберите абонемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxClass.SelectedValue == null)
            {
                MessageBox.Show("Выберите занятие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entity = Visit.CreateOperation(
                0,
                dateTimePickerVisitDate.Value.Date,
                Convert.ToInt32(comboBoxMembership.SelectedValue),
                Convert.ToInt32(comboBoxClass.SelectedValue),
                Convert.ToInt32(comboBoxClient.SelectedValue),
                Convert.ToInt32(comboBoxClient.SelectedValue)
                );

            _visitRepository.CreateVisit(entity);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}