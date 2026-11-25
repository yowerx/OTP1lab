using FitnessClubApp.Entities;
using FitnessClubApp.Repositories;

namespace FitnessClubApp.Forms
{
    public partial class FormMembership : Form
    {
        private readonly IMembershipRepository _membershipRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IMembershipTypeRepository _membershipTypeRepository;

        public FormMembership(IMembershipRepository membershipRepository, IClientRepository clientRepository, IMembershipTypeRepository membershipTypeRepository)
        {
            InitializeComponent();
            _membershipRepository = membershipRepository ?? throw new ArgumentNullException(nameof(membershipRepository));
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _membershipTypeRepository = membershipTypeRepository ?? throw new ArgumentNullException(nameof(membershipTypeRepository));
        }

        private void FormMembership_Load(object sender, EventArgs e)
        {
            comboBoxClient.DataSource = _clientRepository.ReadClients().ToList();
            comboBoxClient.DisplayMember = "FullName";
            comboBoxClient.ValueMember = "Id";

            comboBoxMembershipType.DataSource = _membershipTypeRepository.ReadMembershipTypes().ToList();
            comboBoxMembershipType.DisplayMember = "Name";
            comboBoxMembershipType.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxMembershipType.SelectedValue == null)
            {
                MessageBox.Show("Выберите тип абонемента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateTimePickerEndDate.Value.Date < dateTimePickerStartDate.Value.Date)
            {
                MessageBox.Show("Дата окончания меньше даты начала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entity = Membership.CreateOperation(
                0,
                dateTimePickerStartDate.Value.Date,
                dateTimePickerEndDate.Value.Date,
                Convert.ToInt32(comboBoxClient.SelectedValue),
                Convert.ToInt32(comboBoxMembershipType.SelectedValue));

            _membershipRepository.CreateMembership(entity);
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}