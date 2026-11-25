namespace FitnessClubApp.Forms
{
    partial class FormClient
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelFullName;
        private TextBox textBoxFullName;
        private Button buttonSave;
        private Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();

            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(15, 20);
            labelFullName.Name = "labelFullName";
            labelFullName.Text = "ФИО клиента:";

            textBoxFullName.Location = new Point(120, 17);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(240, 23);

            buttonSave.Location = new Point(120, 60);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.Click += buttonSave_Click;

            buttonCancel.Location = new Point(250, 60);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(110, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.Click += buttonCancel_Click;

            ClientSize = new Size(384, 111);
            Controls.AddRange(new Control[] { labelFullName, textBoxFullName, buttonSave, buttonCancel });
            Name = "FormClient";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Клиент";
            Load += FormClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}