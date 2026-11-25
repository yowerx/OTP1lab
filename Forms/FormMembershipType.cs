using System.ComponentModel;
using FitnessClubApp.Entities;
using FitnessClubApp.Enums;
using FitnessClubApp.Repositories;

namespace FitnessClubApp.Forms
{
    public partial class FormMembershipType : Form
    {
        private readonly IMembershipTypeRepository _membershipTypeRepository;
        private int? _id;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { set => _id = value; }

        public FormMembershipType(IMembershipTypeRepository membershipTypeRepository)
        {
            InitializeComponent();
            _membershipTypeRepository = membershipTypeRepository ?? throw new ArgumentNullException(nameof(membershipTypeRepository));
        }

        private void FormMembershipType_Load(object sender, EventArgs e)
        {
            comboBoxPeriod.DataSource = Enum.GetValues<MembershipPeriod>();
            foreach (var zone in Enum.GetValues<ClubZone>())
            {
                if (zone != ClubZone.None) checkedListBoxZones.Items.Add(zone);
            }

            if (_id.HasValue)
            {
                var item = _membershipTypeRepository.ReadMembershipTypeById(_id.Value);
                if (item != null)
                {
                    textBoxName.Text = item.Name;
                    numericUpDownPrice.Value = item.Price;
                    comboBoxPeriod.SelectedItem = item.Period;
                    for (int i = 0; i < checkedListBoxZones.Items.Count; i++)
                    {
                        var z = (ClubZone)checkedListBoxZones.Items[i];
                        checkedListBoxZones.SetItemChecked(i, item.AvailableZones.HasFlag(z));
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Укажите цену больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxPeriod.SelectedItem is not MembershipPeriod period || period == MembershipPeriod.None)
            {
                MessageBox.Show("Выберите период", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var zones = ClubZone.None;
            foreach (ClubZone item in checkedListBoxZones.CheckedItems) zones |= item;

            if (zones == ClubZone.None)
            {
                MessageBox.Show("Выберите хотя бы одну зону", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entity = MembershipType.CreateEntity(_id ?? 0, textBoxName.Text.Trim(), numericUpDownPrice.Value, period, zones);
            if (_id.HasValue) _membershipTypeRepository.UpdateMembershipType(entity);
            else _membershipTypeRepository.CreateMembershipType(entity);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}