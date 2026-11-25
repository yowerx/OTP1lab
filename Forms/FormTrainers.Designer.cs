namespace FitnessClubApp.Forms
{
    partial class FormTrainers
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewData;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewData = new DataGridView();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();

            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(12, 12);
            dataGridViewData.MultiSelect = false;
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.ReadOnly = true;
            dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewData.Size = new Size(560, 320);

            buttonAdd.Location = new Point(12, 345);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 30);
            buttonAdd.Text = "Добавить";
            buttonAdd.Click += buttonAdd_Click;

            buttonUpdate.Location = new Point(125, 345);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(100, 30);
            buttonUpdate.Text = "Изменить";
            buttonUpdate.Click += buttonUpdate_Click;

            buttonDelete.Location = new Point(238, 345);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 30);
            buttonDelete.Text = "Удалить";
            buttonDelete.Click += buttonDelete_Click;

            ClientSize = new Size(584, 391);
            Controls.AddRange(new Control[] { dataGridViewData, buttonAdd, buttonUpdate, buttonDelete });
            Name = "FormTrainers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Тренеры";
            Load += FormTrainers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
        }
    }
}