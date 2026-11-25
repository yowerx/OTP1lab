namespace FitnessClubApp.Forms
{
    partial class FormMembership
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelClient;
        private ComboBox comboBoxClient;
        private Label labelType;
        private ComboBox comboBoxMembershipType;
        private Label labelStart;
        private DateTimePicker dateTimePickerStartDate;
        private Label labelEnd;
        private DateTimePicker dateTimePickerEndDate;
        private Button buttonSave;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelClient = new Label();
            comboBoxClient = new ComboBox();
            labelType = new Label();
            comboBoxMembershipType = new ComboBox();
            labelStart = new Label();
            dateTimePickerStartDate = new DateTimePicker();
            labelEnd = new Label();
            dateTimePickerEndDate = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();

            labelClient.AutoSize = true;
            labelClient.Location = new Point(15, 20);
            labelClient.Text = "Клиент:";

            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClient.Location = new Point(135, 17);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(225, 23);

            labelType.AutoSize = true;
            labelType.Location = new Point(15, 55);
            labelType.Text = "Тип абонемента:";

            comboBoxMembershipType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMembershipType.Location = new Point(135, 52);
            comboBoxMembershipType.Name = "comboBoxMembershipType";
            comboBoxMembershipType.Size = new Size(225, 23);

            labelStart.AutoSize = true;
            labelStart.Location = new Point(15, 90);
            labelStart.Text = "Дата начала:";

            dateTimePickerStartDate.Location = new Point(135, 87);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(225, 23);

            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(15, 125);
            labelEnd.Text = "Дата окончания:";

            dateTimePickerEndDate.Location = new Point(135, 122);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(225, 23);

            buttonSave.Location = new Point(135, 165);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.Click += buttonSave_Click;

            buttonCancel.Location = new Point(255, 165);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.Click += buttonCancel_Click;

            ClientSize = new Size(384, 211);
            Controls.AddRange(new Control[] { labelClient, comboBoxClient, labelType, comboBoxMembershipType, labelStart, dateTimePickerStartDate, labelEnd, dateTimePickerEndDate, buttonSave, buttonCancel });
            Name = "FormMembership";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Оформление абонемента";
            Load += FormMembership_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}