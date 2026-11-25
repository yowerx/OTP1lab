namespace FitnessClubApp.Forms
{
    partial class FormMembershipType
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelPrice;
        private NumericUpDown numericUpDownPrice;
        private Label labelPeriod;
        private ComboBox comboBoxPeriod;
        private Label labelZones;
        private CheckedListBox checkedListBoxZones;
        private Button buttonSave;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxName = new TextBox();
            labelPrice = new Label();
            numericUpDownPrice = new NumericUpDown();
            labelPeriod = new Label();
            comboBoxPeriod = new ComboBox();
            labelZones = new Label();
            checkedListBoxZones = new CheckedListBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();

            labelName.AutoSize = true;
            labelName.Location = new Point(15, 20);
            labelName.Text = "Название:";

            textBoxName.Location = new Point(120, 17);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(240, 23);

            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(15, 55);
            labelPrice.Text = "Цена:";

            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(120, 52);
            numericUpDownPrice.Maximum = 1000000;
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(240, 23);

            labelPeriod.AutoSize = true;
            labelPeriod.Location = new Point(15, 90);
            labelPeriod.Text = "Период:";

            comboBoxPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPeriod.Location = new Point(120, 87);
            comboBoxPeriod.Name = "comboBoxPeriod";
            comboBoxPeriod.Size = new Size(240, 23);

            labelZones.AutoSize = true;
            labelZones.Location = new Point(15, 125);
            labelZones.Text = "Зоны клуба:";

            checkedListBoxZones.CheckOnClick = true;
            checkedListBoxZones.Location = new Point(120, 125);
            checkedListBoxZones.Name = "checkedListBoxZones";
            checkedListBoxZones.Size = new Size(240, 94);

            buttonSave.Location = new Point(120, 235);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.Click += buttonSave_Click;

            buttonCancel.Location = new Point(250, 235);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.Click += buttonCancel_Click;

            ClientSize = new Size(384, 281);
            Controls.AddRange(new Control[] { labelName, textBoxName, labelPrice, numericUpDownPrice, labelPeriod, comboBoxPeriod, labelZones, checkedListBoxZones, buttonSave, buttonCancel });
            Name = "FormMembershipType";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Тип абонемента";
            Load += FormMembershipType_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}