namespace FitnessClubApp.Forms
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem тренерыToolStripMenuItem;
        private ToolStripMenuItem типыАбонементовToolStripMenuItem;
        private ToolStripMenuItem занятияToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem оформлениеАбонементовToolStripMenuItem;
        private ToolStripMenuItem посещенияToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            тренерыToolStripMenuItem = new ToolStripMenuItem();
            типыАбонементовToolStripMenuItem = new ToolStripMenuItem();
            занятияToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            оформлениеАбонементовToolStripMenuItem = new ToolStripMenuItem();
            посещенияToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem, отчетыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { клиентыToolStripMenuItem, тренерыToolStripMenuItem, типыАбонементовToolStripMenuItem, занятияToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            справочникиToolStripMenuItem.Click += справочникиToolStripMenuItem_Click;
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(180, 22);
            клиентыToolStripMenuItem.Text = "Клиенты";
            клиентыToolStripMenuItem.Click += клиентыToolStripMenuItem_Click;
            // 
            // тренерыToolStripMenuItem
            // 
            тренерыToolStripMenuItem.Name = "тренерыToolStripMenuItem";
            тренерыToolStripMenuItem.Size = new Size(180, 22);
            тренерыToolStripMenuItem.Text = "Тренеры";
            тренерыToolStripMenuItem.Click += тренерыToolStripMenuItem_Click;
            // 
            // типыАбонементовToolStripMenuItem
            // 
            типыАбонементовToolStripMenuItem.Name = "типыАбонементовToolStripMenuItem";
            типыАбонементовToolStripMenuItem.Size = new Size(180, 22);
            типыАбонементовToolStripMenuItem.Text = "Типы абонементов";
            типыАбонементовToolStripMenuItem.Click += типыАбонементовToolStripMenuItem_Click;
            // 
            // занятияToolStripMenuItem
            // 
            занятияToolStripMenuItem.Name = "занятияToolStripMenuItem";
            занятияToolStripMenuItem.Size = new Size(180, 22);
            занятияToolStripMenuItem.Text = "Занятия";
            занятияToolStripMenuItem.Click += занятияToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оформлениеАбонементовToolStripMenuItem, посещенияToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(75, 20);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // оформлениеАбонементовToolStripMenuItem
            // 
            оформлениеАбонементовToolStripMenuItem.Name = "оформлениеАбонементовToolStripMenuItem";
            оформлениеАбонементовToolStripMenuItem.Size = new Size(224, 22);
            оформлениеАбонементовToolStripMenuItem.Text = "Оформление абонементов";
            оформлениеАбонементовToolStripMenuItem.Click += оформлениеАбонементовToolStripMenuItem_Click;
            // 
            // посещенияToolStripMenuItem
            // 
            посещенияToolStripMenuItem.Name = "посещенияToolStripMenuItem";
            посещенияToolStripMenuItem.Size = new Size(224, 22);
            посещенияToolStripMenuItem.Text = "Посещения";
            посещенияToolStripMenuItem.Click += посещенияToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(60, 20);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // FormMain
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фитнес-клуб";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}