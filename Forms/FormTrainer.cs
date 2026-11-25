using System.ComponentModel;
using FitnessClubApp.Entities;
using FitnessClubApp.Repositories;

namespace FitnessClubApp.Forms
{
    public partial class FormTrainer : Form
    {
        private readonly ITrainerRepository _trainerRepository;
        private int? _id;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { set => _id = value; }

        public FormTrainer(ITrainerRepository trainerRepository)
        {
            InitializeComponent();
            _trainerRepository = trainerRepository ?? throw new ArgumentNullException(nameof(trainerRepository));
        }

        private void FormTrainer_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var item = _trainerRepository.ReadTrainerById(_id.Value);
                if (item != null) textBoxFullName.Text = item.FullName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Заполните ФИО тренера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entity = Trainer.CreateEntity(_id ?? 0, textBoxFullName.Text.Trim());
            if (_id.HasValue) _trainerRepository.UpdateTrainer(entity);
            else _trainerRepository.CreateTrainer(entity);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}