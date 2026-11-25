namespace FitnessClubApp.Forms
{
    partial class FormMemberships
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewData;
        private Button buttonAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewData = new DataGridView();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();

            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(12, 12);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.Size = new Size(560, 320);

            buttonAdd.Location = new Point(12, 345);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 30);
            buttonAdd.Text = "Добавить";
            buttonAdd.Click += buttonAdd_Click;

            ClientSize = new Size(584, 391);
            Controls.AddRange(new Control[] { dataGridViewData, buttonAdd });
            Name = "FormMemberships";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Оформление абонементов";
            Load += FormMemberships_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
        }
    }
}