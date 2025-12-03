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
            tabCalendar = new TabPage();
            tabReports = new TabPage();
            tabScheduler.SuspendLayout();
            tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).BeginInit();
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
            tabAppointments.Location = new Point(8, 46);
            tabAppointments.Name = "tabAppointments";
            tabAppointments.Padding = new Padding(3);
            tabAppointments.Size = new Size(1436, 635);
            tabAppointments.TabIndex = 1;
            tabAppointments.Text = "Appointments";
            tabAppointments.UseVisualStyleBackColor = true;
            // 
            // tabCalendar
            // 
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
    }
}