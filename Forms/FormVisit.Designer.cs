namespace FitnessClubApp.Forms
{
    partial class FormVisit
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelClient;
        private ComboBox comboBoxClient;
        private Label labelMembership;
        private ComboBox comboBoxMembership;
        private Label labelClass;
        private ComboBox comboBoxClass;
        private Label labelDate;
        private DateTimePicker dateTimePickerVisitDate;
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
            labelMembership = new Label();
            comboBoxMembership = new ComboBox();
            labelClass = new Label();
            comboBoxClass = new ComboBox();
            labelDate = new Label();
            dateTimePickerVisitDate = new DateTimePicker();
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

            labelMembership.AutoSize = true;
            labelMembership.Location = new Point(15, 55);
            labelMembership.Text = "Абонемент:";

            comboBoxMembership.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMembership.Location = new Point(135, 52);
            comboBoxMembership.Name = "comboBoxMembership";
            comboBoxMembership.Size = new Size(225, 23);

            labelClass.AutoSize = true;
            labelClass.Location = new Point(15, 90);
            labelClass.Text = "Занятие:";

            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.Location = new Point(135, 87);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(225, 23);

            labelDate.AutoSize = true;
            labelDate.Location = new Point(15, 125);
            labelDate.Text = "Дата посещения:";

            dateTimePickerVisitDate.Location = new Point(135, 122);
            dateTimePickerVisitDate.Name = "dateTimePickerVisitDate";
            dateTimePickerVisitDate.Size = new Size(225, 23);

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
            Controls.AddRange(new Control[] { labelClient, comboBoxClient, labelMembership, comboBoxMembership, labelClass, comboBoxClass, labelDate, dateTimePickerVisitDate, buttonSave, buttonCancel });
            Name = "FormVisit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Посещение";
            Load += FormVisit_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}