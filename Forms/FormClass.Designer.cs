namespace FitnessClubApp.Forms
{
    partial class FormClass
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTrainer;
        private ComboBox comboBoxTrainer;
        private Label labelZone;
        private ComboBox comboBoxZone;
        private Label labelMax;
        private NumericUpDown numericUpDownMaxParticipants;
        private Button buttonSave;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTrainer = new Label();
            comboBoxTrainer = new ComboBox();
            labelZone = new Label();
            comboBoxZone = new ComboBox();
            labelMax = new Label();
            numericUpDownMaxParticipants = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxParticipants).BeginInit();
            SuspendLayout();

            labelTrainer.AutoSize = true;
            labelTrainer.Location = new Point(15, 20);
            labelTrainer.Text = "Тренер:";

            comboBoxTrainer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrainer.Location = new Point(135, 17);
            comboBoxTrainer.Name = "comboBoxTrainer";
            comboBoxTrainer.Size = new Size(225, 23);

            labelZone.AutoSize = true;
            labelZone.Location = new Point(15, 55);
            labelZone.Text = "Направление:";

            comboBoxZone.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxZone.Location = new Point(135, 52);
            comboBoxZone.Name = "comboBoxZone";
            comboBoxZone.Size = new Size(225, 23);

            labelMax.AutoSize = true;
            labelMax.Location = new Point(15, 90);
            labelMax.Text = "Макс. участников:";

            numericUpDownMaxParticipants.Location = new Point(135, 87);
            numericUpDownMaxParticipants.Maximum = 100;
            numericUpDownMaxParticipants.Name = "numericUpDownMaxParticipants";
            numericUpDownMaxParticipants.Size = new Size(225, 23);

            buttonSave.Location = new Point(135, 130);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.Click += buttonSave_Click;

            buttonCancel.Location = new Point(255, 130);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.Click += buttonCancel_Click;

            ClientSize = new Size(384, 176);
            Controls.AddRange(new Control[] { labelTrainer, comboBoxTrainer, labelZone, comboBoxZone, labelMax, numericUpDownMaxParticipants, buttonSave, buttonCancel });
            Name = "FormClass";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Занятие";
            Load += FormClass_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxParticipants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}