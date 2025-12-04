
namespace C969
{
    partial class AppointmentForm
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
            labelCustomer = new Label();
            comboBoxCustomer = new ComboBox();
            labelType = new Label();
            comboBoxType = new ComboBox();
            textBoxTitle = new TextBox();
            labelName = new Label();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxLocation = new TextBox();
            labelLocation = new Label();
            textBoxContact = new TextBox();
            labelContact = new Label();
            textBoxUrl = new TextBox();
            labelUrl = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(83, 15);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(122, 32);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "Customer:";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(211, 12);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(242, 40);
            comboBoxCustomer.TabIndex = 1;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(135, 58);
            labelType.Name = "labelType";
            labelType.Size = new Size(70, 32);
            labelType.TabIndex = 2;
            labelType.Text = "Type:";
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(211, 58);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(242, 40);
            comboBoxType.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(211, 104);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(200, 39);
            textBoxTitle.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(140, 104);
            labelName.Name = "labelName";
            labelName.Size = new Size(65, 32);
            labelName.TabIndex = 5;
            labelName.Text = "Title:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(211, 149);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(200, 39);
            textBoxDescription.TabIndex = 6;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(65, 149);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(140, 32);
            labelDescription.TabIndex = 7;
            labelDescription.Text = "Description:";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(211, 194);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(200, 39);
            textBoxLocation.TabIndex = 8;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(96, 194);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(109, 32);
            labelLocation.TabIndex = 9;
            labelLocation.Text = "Location:";
            // 
            // textBoxContact
            // 
            textBoxContact.Location = new Point(211, 239);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.Size = new Size(200, 39);
            textBoxContact.TabIndex = 10;
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Location = new Point(104, 239);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(101, 32);
            labelContact.TabIndex = 11;
            labelContact.Text = "Contact:";
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(211, 284);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(200, 39);
            textBoxUrl.TabIndex = 12;
            // 
            // labelUrl
            // 
            labelUrl.AutoSize = true;
            labelUrl.Location = new Point(145, 287);
            labelUrl.Name = "labelUrl";
            labelUrl.Size = new Size(60, 32);
            labelUrl.TabIndex = 13;
            labelUrl.Text = "URL:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(65, 329);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(400, 39);
            dateTimePickerStart.TabIndex = 14;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(65, 374);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(400, 39);
            dateTimePickerEnd.TabIndex = 15;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(211, 451);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 46);
            buttonSave.TabIndex = 16;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(367, 451);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 46);
            buttonCancel.TabIndex = 17;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 509);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(labelUrl);
            Controls.Add(textBoxUrl);
            Controls.Add(labelContact);
            Controls.Add(textBoxContact);
            Controls.Add(labelLocation);
            Controls.Add(textBoxLocation);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(labelName);
            Controls.Add(textBoxTitle);
            Controls.Add(comboBoxType);
            Controls.Add(labelType);
            Controls.Add(comboBoxCustomer);
            Controls.Add(labelCustomer);
            Name = "AppointmentForm";
            Text = "Appointments";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomer;
        private ComboBox comboBoxCustomer;
        private Label labelType;
        private ComboBox comboBoxType;
        private TextBox textBoxTitle;
        private Label labelName;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private TextBox textBoxLocation;
        private Label labelLocation;
        private TextBox textBoxContact;
        private Label labelContact;
        private TextBox textBoxUrl;
        private Label labelUrl;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button buttonSave;
        private Button buttonCancel;
    }
}