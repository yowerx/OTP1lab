using System.ComponentModel;
using FitnessClubApp.Entities;
using FitnessClubApp.Enums;
using FitnessClubApp.Repositories;

namespace FitnessClubApp.Forms
{
    public partial class FormClass : Form
    {
        private readonly IClassRepository _classRepository;
        private readonly ITrainerRepository _trainerRepository;
        private int? _id;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { set => _id = value; }

        public FormClass(IClassRepository classRepository, ITrainerRepository trainerRepository)
        {
            InitializeComponent();
            _classRepository = classRepository ?? throw new ArgumentNullException(nameof(classRepository));
            _trainerRepository = trainerRepository ?? throw new ArgumentNullException(nameof(trainerRepository));
        }

        private void FormClass_Load(object sender, EventArgs e)
        {
            comboBoxTrainer.DataSource = _trainerRepository.ReadTrainers().ToList();
            comboBoxTrainer.DisplayMember = "FullName";
            comboBoxTrainer.ValueMember = "Id";

            comboBoxZone.DataSource = Enum.GetValues<ClubZone>();

            if (_id.HasValue)
            {
                var item = _classRepository.ReadClassById(_id.Value);
                if (item != null)
                {
                    numericUpDownMaxParticipants.Value = item.MaxParticipants;
                    comboBoxTrainer.SelectedValue = item.TrainerId;
                    comboBoxZone.SelectedItem = item.Zone;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxTrainer.SelectedValue == null)
            {
                MessageBox.Show("Выберите тренера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxZone.SelectedItem is not ClubZone zone || zone == ClubZone.None)
            {
                MessageBox.Show("Выберите направление", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownMaxParticipants.Value <= 0)
            {
                MessageBox.Show("Укажите количество участников больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entity = Class.CreateEntity(_id ?? 0, (int)numericUpDownMaxParticipants.Value, Convert.ToInt32(comboBoxTrainer.SelectedValue), zone);
            if (_id.HasValue) _classRepository.UpdateClass(entity);
            else _classRepository.CreateClass(entity);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}