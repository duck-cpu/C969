namespace C969
{
    partial class CustomerForm
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
            textBoxCustomerName = new TextBox();
            textBoxAddress1 = new TextBox();
            textBoxAddress2 = new TextBox();
            comboBoxCountry = new ComboBox();
            comboBoxCity = new ComboBox();
            textBoxPostal = new TextBox();
            textBoxPhone = new TextBox();
            buttonCustomerSave = new Button();
            buttonCustomerCancel = new Button();
            labelCustomerName = new Label();
            labelCustomerAddress1 = new Label();
            labelCustomerAddress2 = new Label();
            labelCustomerCountry = new Label();
            labelCustomerCity = new Label();
            labelCustomerPostal = new Label();
            labelCustomerPhone = new Label();
            SuspendLayout();
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(181, 12);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(200, 39);
            textBoxCustomerName.TabIndex = 0;
            // 
            // textBoxAddress1
            // 
            textBoxAddress1.Location = new Point(181, 57);
            textBoxAddress1.Name = "textBoxAddress1";
            textBoxAddress1.Size = new Size(200, 39);
            textBoxAddress1.TabIndex = 1;
            // 
            // textBoxAddress2
            // 
            textBoxAddress2.Location = new Point(181, 102);
            textBoxAddress2.Name = "textBoxAddress2";
            textBoxAddress2.Size = new Size(200, 39);
            textBoxAddress2.TabIndex = 2;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(181, 147);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(242, 40);
            comboBoxCountry.TabIndex = 3;
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(181, 193);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(242, 40);
            comboBoxCity.TabIndex = 4;
            // 
            // textBoxPostal
            // 
            textBoxPostal.Location = new Point(181, 239);
            textBoxPostal.Name = "textBoxPostal";
            textBoxPostal.Size = new Size(200, 39);
            textBoxPostal.TabIndex = 5;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(181, 284);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(200, 39);
            textBoxPhone.TabIndex = 6;
            // 
            // buttonCustomerSave
            // 
            buttonCustomerSave.Location = new Point(116, 392);
            buttonCustomerSave.Name = "buttonCustomerSave";
            buttonCustomerSave.Size = new Size(150, 46);
            buttonCustomerSave.TabIndex = 7;
            buttonCustomerSave.Text = "Save";
            buttonCustomerSave.UseVisualStyleBackColor = true;
            buttonCustomerSave.Click += buttonCustomerSave_Click;
            // 
            // buttonCustomerCancel
            // 
            buttonCustomerCancel.Location = new Point(272, 392);
            buttonCustomerCancel.Name = "buttonCustomerCancel";
            buttonCustomerCancel.Size = new Size(150, 46);
            buttonCustomerCancel.TabIndex = 8;
            buttonCustomerCancel.Text = "Cancel";
            buttonCustomerCancel.UseVisualStyleBackColor = true;
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(92, 15);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(83, 32);
            labelCustomerName.TabIndex = 9;
            labelCustomerName.Text = "Name:";
            // 
            // labelCustomerAddress1
            // 
            labelCustomerAddress1.AutoSize = true;
            labelCustomerAddress1.Location = new Point(56, 57);
            labelCustomerAddress1.Name = "labelCustomerAddress1";
            labelCustomerAddress1.Size = new Size(123, 32);
            labelCustomerAddress1.TabIndex = 10;
            labelCustomerAddress1.Text = "Address 1:";
            // 
            // labelCustomerAddress2
            // 
            labelCustomerAddress2.AutoSize = true;
            labelCustomerAddress2.Location = new Point(56, 105);
            labelCustomerAddress2.Name = "labelCustomerAddress2";
            labelCustomerAddress2.Size = new Size(123, 32);
            labelCustomerAddress2.TabIndex = 11;
            labelCustomerAddress2.Text = "Address 2:";
            // 
            // labelCustomerCountry
            // 
            labelCustomerCountry.AutoSize = true;
            labelCustomerCountry.Location = new Point(75, 150);
            labelCustomerCountry.Name = "labelCustomerCountry";
            labelCustomerCountry.Size = new Size(104, 32);
            labelCustomerCountry.TabIndex = 12;
            labelCustomerCountry.Text = "Country:";
            // 
            // labelCustomerCity
            // 
            labelCustomerCity.AutoSize = true;
            labelCustomerCity.Location = new Point(119, 193);
            labelCustomerCity.Name = "labelCustomerCity";
            labelCustomerCity.Size = new Size(60, 32);
            labelCustomerCity.TabIndex = 13;
            labelCustomerCity.Text = "City:";
            // 
            // labelCustomerPostal
            // 
            labelCustomerPostal.AutoSize = true;
            labelCustomerPostal.Location = new Point(98, 242);
            labelCustomerPostal.Name = "labelCustomerPostal";
            labelCustomerPostal.Size = new Size(81, 32);
            labelCustomerPostal.TabIndex = 14;
            labelCustomerPostal.Text = "Postal:";
            // 
            // labelCustomerPhone
            // 
            labelCustomerPhone.AutoSize = true;
            labelCustomerPhone.Location = new Point(92, 287);
            labelCustomerPhone.Name = "labelCustomerPhone";
            labelCustomerPhone.Size = new Size(87, 32);
            labelCustomerPhone.TabIndex = 15;
            labelCustomerPhone.Text = "Phone:";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 450);
            Controls.Add(labelCustomerPhone);
            Controls.Add(labelCustomerPostal);
            Controls.Add(labelCustomerCity);
            Controls.Add(labelCustomerCountry);
            Controls.Add(labelCustomerAddress2);
            Controls.Add(labelCustomerAddress1);
            Controls.Add(labelCustomerName);
            Controls.Add(buttonCustomerCancel);
            Controls.Add(buttonCustomerSave);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxPostal);
            Controls.Add(comboBoxCity);
            Controls.Add(comboBoxCountry);
            Controls.Add(textBoxAddress2);
            Controls.Add(textBoxAddress1);
            Controls.Add(textBoxCustomerName);
            Name = "CustomerForm";
            Text = "Add Customer";
            Load += CustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCustomerName;
        private TextBox textBoxAddress1;
        private TextBox textBoxAddress2;
        private ComboBox comboBoxCountry;
        private ComboBox comboBoxCity;
        private TextBox textBoxPostal;
        private TextBox textBoxPhone;
        private Button buttonCustomerSave;
        private Button buttonCustomerCancel;
        private Label labelCustomerName;
        private Label labelCustomerAddress1;
        private Label labelCustomerAddress2;
        private Label labelCustomerCountry;
        private Label labelCustomerCity;
        private Label labelCustomerPostal;
        private Label labelCustomerPhone;
    }
}