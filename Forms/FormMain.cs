using Unity;

namespace FitnessClubApp.Forms
{
    public partial class FormMain : Form
    {
        private readonly IUnityContainer _container;

        public FormMain(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e) =>
            _container.Resolve<FormClients>().ShowDialog();

        private void тренерыToolStripMenuItem_Click(object sender, EventArgs e) =>
            _container.Resolve<FormTrainers>().ShowDialog();

        private void типыАбонементовToolStripMenuItem_Click(object sender, EventArgs e) =>
            _container.Resolve<FormMembershipTypes>().ShowDialog();

        private void занятияToolStripMenuItem_Click(object sender, EventArgs e) =>
            _container.Resolve<FormClasses>().ShowDialog();

        private void оформлениеАбонементовToolStripMenuItem_Click(object sender, EventArgs e) =>
            _container.Resolve<FormMemberships>().ShowDialog();

        private void посещенияToolStripMenuItem_Click(object sender, EventArgs e) =>
            _container.Resolve<FormVisits>().ShowDialog();

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}