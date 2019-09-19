namespace Contact_Manager
{
    partial class AddEditFaculty
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
            this.FacultyFirstNameLabel = new System.Windows.Forms.Label();
            this.FacultyFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FacultyLastNameTextBox = new System.Windows.Forms.TextBox();
            this.FacultyLastNameLabel = new System.Windows.Forms.Label();
            this.FacultyAcademicDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.FacultyAcademicDepartmentLabel = new System.Windows.Forms.Label();
            this.FacultyAddButton = new System.Windows.Forms.Button();
            this.FacultyCancelButton = new System.Windows.Forms.Button();
            this.FacultyAddressTextBox = new System.Windows.Forms.TextBox();
            this.FacultyEmailLabel = new System.Windows.Forms.Label();
            this.FacultyAddressLabel = new System.Windows.Forms.Label();
            this.FacultyEmailTextBox = new System.Windows.Forms.TextBox();
            this.ContactInformationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FacultyFirstNameLabel
            // 
            this.FacultyFirstNameLabel.Location = new System.Drawing.Point(8, 6);
            this.FacultyFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacultyFirstNameLabel.Name = "FacultyFirstNameLabel";
            this.FacultyFirstNameLabel.Size = new System.Drawing.Size(112, 15);
            this.FacultyFirstNameLabel.TabIndex = 0;
            this.FacultyFirstNameLabel.Text = "First Name:";
            this.FacultyFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FacultyFirstNameTextBox
            // 
            this.FacultyFirstNameTextBox.Location = new System.Drawing.Point(124, 4);
            this.FacultyFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacultyFirstNameTextBox.Name = "FacultyFirstNameTextBox";
            this.FacultyFirstNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.FacultyFirstNameTextBox.TabIndex = 0;
            this.FacultyFirstNameTextBox.TextChanged += new System.EventHandler(this.FacultyFirstNameTextBox_TextChanged);
            // 
            // FacultyLastNameTextBox
            // 
            this.FacultyLastNameTextBox.Location = new System.Drawing.Point(124, 24);
            this.FacultyLastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacultyLastNameTextBox.Name = "FacultyLastNameTextBox";
            this.FacultyLastNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.FacultyLastNameTextBox.TabIndex = 1;
            this.FacultyLastNameTextBox.TextChanged += new System.EventHandler(this.FacultyLastNameTextBox_TextChanged);
            // 
            // FacultyLastNameLabel
            // 
            this.FacultyLastNameLabel.Location = new System.Drawing.Point(8, 27);
            this.FacultyLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacultyLastNameLabel.Name = "FacultyLastNameLabel";
            this.FacultyLastNameLabel.Size = new System.Drawing.Size(112, 15);
            this.FacultyLastNameLabel.TabIndex = 2;
            this.FacultyLastNameLabel.Text = "Last Name:";
            this.FacultyLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FacultyAcademicDepartmentTextBox
            // 
            this.FacultyAcademicDepartmentTextBox.Location = new System.Drawing.Point(124, 46);
            this.FacultyAcademicDepartmentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacultyAcademicDepartmentTextBox.Name = "FacultyAcademicDepartmentTextBox";
            this.FacultyAcademicDepartmentTextBox.Size = new System.Drawing.Size(150, 20);
            this.FacultyAcademicDepartmentTextBox.TabIndex = 2;
            this.FacultyAcademicDepartmentTextBox.TextChanged += new System.EventHandler(this.FacultyAcademicDepartmentTextBox_TextChanged);
            // 
            // FacultyAcademicDepartmentLabel
            // 
            this.FacultyAcademicDepartmentLabel.AutoSize = true;
            this.FacultyAcademicDepartmentLabel.Location = new System.Drawing.Point(8, 47);
            this.FacultyAcademicDepartmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacultyAcademicDepartmentLabel.Name = "FacultyAcademicDepartmentLabel";
            this.FacultyAcademicDepartmentLabel.Size = new System.Drawing.Size(115, 13);
            this.FacultyAcademicDepartmentLabel.TabIndex = 4;
            this.FacultyAcademicDepartmentLabel.Text = "Academic Department:";
            this.FacultyAcademicDepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FacultyAddButton
            // 
            this.FacultyAddButton.Location = new System.Drawing.Point(167, 156);
            this.FacultyAddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacultyAddButton.Name = "FacultyAddButton";
            this.FacultyAddButton.Size = new System.Drawing.Size(51, 20);
            this.FacultyAddButton.TabIndex = 5;
            this.FacultyAddButton.Text = "Add";
            this.FacultyAddButton.UseVisualStyleBackColor = true;
            this.FacultyAddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FacultyCancelButton
            // 
            this.FacultyCancelButton.Location = new System.Drawing.Point(222, 156);
            this.FacultyCancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacultyCancelButton.Name = "FacultyCancelButton";
            this.FacultyCancelButton.Size = new System.Drawing.Size(51, 20);
            this.FacultyCancelButton.TabIndex = 6;
            this.FacultyCancelButton.Text = "Cancel";
            this.FacultyCancelButton.UseVisualStyleBackColor = true;
            this.FacultyCancelButton.Click += new System.EventHandler(this.FacultyCancelButton_Click);
            // 
            // FacultyAddressTextBox
            // 
            this.FacultyAddressTextBox.Location = new System.Drawing.Point(128, 119);
            this.FacultyAddressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacultyAddressTextBox.Name = "FacultyAddressTextBox";
            this.FacultyAddressTextBox.Size = new System.Drawing.Size(146, 20);
            this.FacultyAddressTextBox.TabIndex = 4;
            this.FacultyAddressTextBox.TextChanged += new System.EventHandler(this.FacultyAddressTextBox_TextChanged);
            // 
            // FacultyEmailLabel
            // 
            this.FacultyEmailLabel.Location = new System.Drawing.Point(19, 98);
            this.FacultyEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacultyEmailLabel.Name = "FacultyEmailLabel";
            this.FacultyEmailLabel.Size = new System.Drawing.Size(105, 17);
            this.FacultyEmailLabel.TabIndex = 13;
            this.FacultyEmailLabel.Text = "Email Address:";
            this.FacultyEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FacultyAddressLabel
            // 
            this.FacultyAddressLabel.Location = new System.Drawing.Point(19, 119);
            this.FacultyAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacultyAddressLabel.Name = "FacultyAddressLabel";
            this.FacultyAddressLabel.Size = new System.Drawing.Size(105, 17);
            this.FacultyAddressLabel.TabIndex = 15;
            this.FacultyAddressLabel.Text = "Address:";
            this.FacultyAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FacultyEmailTextBox
            // 
            this.FacultyEmailTextBox.Location = new System.Drawing.Point(128, 98);
            this.FacultyEmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacultyEmailTextBox.Name = "FacultyEmailTextBox";
            this.FacultyEmailTextBox.Size = new System.Drawing.Size(146, 20);
            this.FacultyEmailTextBox.TabIndex = 3;
            this.FacultyEmailTextBox.TextChanged += new System.EventHandler(this.FacultyEmailTextBox_TextChanged);
            // 
            // ContactInformationLabel
            // 
            this.ContactInformationLabel.AutoSize = true;
            this.ContactInformationLabel.Location = new System.Drawing.Point(5, 77);
            this.ContactInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContactInformationLabel.Name = "ContactInformationLabel";
            this.ContactInformationLabel.Size = new System.Drawing.Size(99, 13);
            this.ContactInformationLabel.TabIndex = 17;
            this.ContactInformationLabel.Text = "Contact Information";
            this.ContactInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddEditFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 184);
            this.Controls.Add(this.ContactInformationLabel);
            this.Controls.Add(this.FacultyAddressTextBox);
            this.Controls.Add(this.FacultyEmailLabel);
            this.Controls.Add(this.FacultyAddressLabel);
            this.Controls.Add(this.FacultyEmailTextBox);
            this.Controls.Add(this.FacultyCancelButton);
            this.Controls.Add(this.FacultyAddButton);
            this.Controls.Add(this.FacultyAcademicDepartmentTextBox);
            this.Controls.Add(this.FacultyAcademicDepartmentLabel);
            this.Controls.Add(this.FacultyLastNameTextBox);
            this.Controls.Add(this.FacultyLastNameLabel);
            this.Controls.Add(this.FacultyFirstNameTextBox);
            this.Controls.Add(this.FacultyFirstNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEditFaculty";
            this.Text = "AddEditFaculty";
            this.Load += new System.EventHandler(this.AddEditFaculty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FacultyFirstNameLabel;
        private System.Windows.Forms.TextBox FacultyFirstNameTextBox;
        private System.Windows.Forms.TextBox FacultyLastNameTextBox;
        private System.Windows.Forms.Label FacultyLastNameLabel;
        private System.Windows.Forms.TextBox FacultyAcademicDepartmentTextBox;
        private System.Windows.Forms.Label FacultyAcademicDepartmentLabel;
        private System.Windows.Forms.Button FacultyAddButton;
        private System.Windows.Forms.Button FacultyCancelButton;
        private System.Windows.Forms.TextBox FacultyAddressTextBox;
        private System.Windows.Forms.Label FacultyEmailLabel;
        private System.Windows.Forms.Label FacultyAddressLabel;
        private System.Windows.Forms.TextBox FacultyEmailTextBox;
        private System.Windows.Forms.Label ContactInformationLabel;
    }
}