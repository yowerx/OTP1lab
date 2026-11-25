using System.ComponentModel;
using FitnessClubApp.Entities;
using FitnessClubApp.Repositories;

namespace FitnessClubApp.Forms
{
    public partial class FormClient : Form
    {
        private readonly IClientRepository _clientRepository;
        private int? _id;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { set => _id = value; }

        public FormClient(IClientRepository clientRepository)
        {
            InitializeComponent();
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var item = _clientRepository.ReadClientById(_id.Value);
                if (item != null) textBoxFullName.Text = item.FullName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Заполните ФИО клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entity = Client.CreateEntity(_id ?? 0, textBoxFullName.Text.Trim());
            if (_id.HasValue) _clientRepository.UpdateClient(entity);
            else _clientRepository.CreateClient(entity);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}