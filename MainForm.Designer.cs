namespace C969
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabScheduler = new TabControl();
            tabCustomers = new TabPage();
            buttonDeleteCustomer = new Button();
            buttonEditCustomer = new Button();
            buttonAddCustomer = new Button();
            dataGridCustomers = new DataGridView();
            tabAppointments = new TabPage();
            buttonAddAppointment = new Button();
            buttonEditAppointment = new Button();
            buttonDeleteAppointment = new Button();
            dataGridViewAppointments = new DataGridView();
            tabCalendar = new TabPage();
            tabReports = new TabPage();
            monthCalendarAppointments = new MonthCalendar();
            dataGridViewCalendarAppointments = new DataGridView();
            tabScheduler.SuspendLayout();
            tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).BeginInit();
            tabAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
            tabCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendarAppointments).BeginInit();
            SuspendLayout();
            // 
            // tabScheduler
            // 
            tabScheduler.Controls.Add(tabCustomers);
            tabScheduler.Controls.Add(tabAppointments);
            tabScheduler.Controls.Add(tabCalendar);
            tabScheduler.Controls.Add(tabReports);
            tabScheduler.Dock = DockStyle.Fill;
            tabScheduler.Location = new Point(0, 0);
            tabScheduler.Name = "tabScheduler";
            tabScheduler.SelectedIndex = 0;
            tabScheduler.Size = new Size(1452, 689);
            tabScheduler.TabIndex = 0;
            // 
            // tabCustomers
            // 
            tabCustomers.Controls.Add(buttonDeleteCustomer);
            tabCustomers.Controls.Add(buttonEditCustomer);
            tabCustomers.Controls.Add(buttonAddCustomer);
            tabCustomers.Controls.Add(dataGridCustomers);
            tabCustomers.Location = new Point(8, 46);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3);
            tabCustomers.Size = new Size(1436, 635);
            tabCustomers.TabIndex = 0;
            tabCustomers.Text = "Customers";
            tabCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Location = new Point(1280, 520);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(150, 46);
            buttonDeleteCustomer.TabIndex = 3;
            buttonDeleteCustomer.Text = "Delete";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            buttonDeleteCustomer.Click += buttonDeleteCustomer_Click;
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.Location = new Point(1124, 520);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(150, 46);
            buttonEditCustomer.TabIndex = 2;
            buttonEditCustomer.Text = "Edit";
            buttonEditCustomer.UseVisualStyleBackColor = true;
            buttonEditCustomer.Click += buttonEditCustomer_Click;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(968, 520);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(150, 46);
            buttonAddCustomer.TabIndex = 1;
            buttonAddCustomer.Text = "Add";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // dataGridCustomers
            // 
            dataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCustomers.Dock = DockStyle.Top;
            dataGridCustomers.Location = new Point(3, 3);
            dataGridCustomers.Name = "dataGridCustomers";
            dataGridCustomers.RowHeadersWidth = 82;
            dataGridCustomers.Size = new Size(1430, 511);
            dataGridCustomers.TabIndex = 0;
            // 
            // tabAppointments
            // 
            tabAppointments.Controls.Add(buttonAddAppointment);
            tabAppointments.Controls.Add(buttonEditAppointment);
            tabAppointments.Controls.Add(buttonDeleteAppointment);
            tabAppointments.Controls.Add(dataGridViewAppointments);
            tabAppointments.Location = new Point(8, 46);
            tabAppointments.Name = "tabAppointments";
            tabAppointments.Padding = new Padding(3);
            tabAppointments.Size = new Size(1436, 635);
            tabAppointments.TabIndex = 1;
            tabAppointments.Text = "Appointments";
            tabAppointments.UseVisualStyleBackColor = true;
            tabAppointments.Click += tabAppointments_Click;
            // 
            // buttonAddAppointment
            // 
            buttonAddAppointment.Location = new Point(968, 520);
            buttonAddAppointment.Name = "buttonAddAppointment";
            buttonAddAppointment.Size = new Size(150, 46);
            buttonAddAppointment.TabIndex = 4;
            buttonAddAppointment.Text = "Add";
            buttonAddAppointment.UseVisualStyleBackColor = true;
            buttonAddAppointment.Click += buttonAddAppointment_Click;
            // 
            // buttonEditAppointment
            // 
            buttonEditAppointment.Location = new Point(1124, 520);
            buttonEditAppointment.Name = "buttonEditAppointment";
            buttonEditAppointment.Size = new Size(150, 46);
            buttonEditAppointment.TabIndex = 3;
            buttonEditAppointment.Text = "Edit";
            buttonEditAppointment.UseVisualStyleBackColor = true;
            buttonEditAppointment.Click += buttonEditAppointment_Click;
            // 
            // buttonDeleteAppointment
            // 
            buttonDeleteAppointment.Location = new Point(1280, 520);
            buttonDeleteAppointment.Name = "buttonDeleteAppointment";
            buttonDeleteAppointment.Size = new Size(150, 46);
            buttonDeleteAppointment.TabIndex = 1;
            buttonDeleteAppointment.Text = "Delete";
            buttonDeleteAppointment.UseVisualStyleBackColor = true;
            buttonDeleteAppointment.Click += buttonDeleteAppointment_Click;
            // 
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Dock = DockStyle.Top;
            dataGridViewAppointments.Location = new Point(3, 3);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.RowHeadersWidth = 82;
            dataGridViewAppointments.Size = new Size(1430, 511);
            dataGridViewAppointments.TabIndex = 0;
            // 
            // tabCalendar
            // 
            tabCalendar.Controls.Add(dataGridViewCalendarAppointments);
            tabCalendar.Controls.Add(monthCalendarAppointments);
            tabCalendar.Location = new Point(8, 46);
            tabCalendar.Name = "tabCalendar";
            tabCalendar.Size = new Size(1436, 635);
            tabCalendar.TabIndex = 2;
            tabCalendar.Text = "Calendar";
            tabCalendar.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            tabReports.Location = new Point(8, 46);
            tabReports.Name = "tabReports";
            tabReports.Size = new Size(1436, 635);
            tabReports.TabIndex = 3;
            tabReports.Text = "Reports";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // monthCalendarAppointments
            // 
            monthCalendarAppointments.CalendarDimensions = new Size(3, 1);
            monthCalendarAppointments.Dock = DockStyle.Top;
            monthCalendarAppointments.Location = new Point(0, 0);
            monthCalendarAppointments.MaxSelectionCount = 1;
            monthCalendarAppointments.Name = "monthCalendarAppointments";
            monthCalendarAppointments.TabIndex = 0;
            monthCalendarAppointments.DateSelected += monthCalendarAppointments_DateSelected;
            // 
            // dataGridViewCalendarAppointments
            // 
            dataGridViewCalendarAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalendarAppointments.Dock = DockStyle.Bottom;
            dataGridViewCalendarAppointments.Location = new Point(0, 335);
            dataGridViewCalendarAppointments.Name = "dataGridViewCalendarAppointments";
            dataGridViewCalendarAppointments.RowHeadersWidth = 82;
            dataGridViewCalendarAppointments.Size = new Size(1436, 300);
            dataGridViewCalendarAppointments.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 689);
            Controls.Add(tabScheduler);
            Name = "MainForm";
            Text = "Scheduler";
            Load += MainForm_Load;
            tabScheduler.ResumeLayout(false);
            tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).EndInit();
            tabAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            tabCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendarAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabScheduler;
        private TabPage tabCustomers;
        private TabPage tabAppointments;
        private TabPage tabCalendar;
        private TabPage tabReports;
        private Button buttonEditCustomer;
        private Button buttonAddCustomer;
        private DataGridView dataGridCustomers;
        private Button buttonDeleteCustomer;
        private DataGridView dataGridViewAppointments;
        private Button buttonEditAppointment;
        private Button buttonDeleteAppointment;
        private Button buttonAddAppointment;
        private MonthCalendar monthCalendarAppointments;
        private DataGridView dataGridViewCalendarAppointments;
    }
}