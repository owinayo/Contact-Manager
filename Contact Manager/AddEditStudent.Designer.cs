namespace Contact_Manager
{
    partial class AddEditStudent
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
            this.components = new System.ComponentModel.Container();
            this.StudentFirstNameLabel = new System.Windows.Forms.Label();
            this.StudentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentLastNameLabel = new System.Windows.Forms.Label();
            this.StudentAcademicDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.StudentAcademicDepartmentLabel = new System.Windows.Forms.Label();
            this.StudentGraduationYearTextBox = new System.Windows.Forms.TextBox();
            this.StudentGraduationYearLabel = new System.Windows.Forms.Label();
            this.StudentAddButton = new System.Windows.Forms.Button();
            this.StudentCancelButton = new System.Windows.Forms.Button();
            this.StudentAddressTextBox = new System.Windows.Forms.TextBox();
            this.StudentEmailLabel = new System.Windows.Forms.Label();
            this.StudentAddressLabel = new System.Windows.Forms.Label();
            this.StudentEmailTextBox = new System.Windows.Forms.TextBox();
            this.ContactInformationLabel = new System.Windows.Forms.Label();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseListLabel = new System.Windows.Forms.Label();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentFirstNameLabel
            // 
            this.StudentFirstNameLabel.Location = new System.Drawing.Point(8, 6);
            this.StudentFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentFirstNameLabel.Name = "StudentFirstNameLabel";
            this.StudentFirstNameLabel.Size = new System.Drawing.Size(112, 15);
            this.StudentFirstNameLabel.TabIndex = 0;
            this.StudentFirstNameLabel.Text = "First Name:";
            this.StudentFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentFirstNameTextBox
            // 
            this.StudentFirstNameTextBox.Location = new System.Drawing.Point(124, 4);
            this.StudentFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentFirstNameTextBox.Name = "StudentFirstNameTextBox";
            this.StudentFirstNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.StudentFirstNameTextBox.TabIndex = 0;
            this.StudentFirstNameTextBox.TextChanged += new System.EventHandler(this.StudentFirstNameTextBox_TextChanged);
            // 
            // StudentLastNameTextBox
            // 
            this.StudentLastNameTextBox.Location = new System.Drawing.Point(124, 24);
            this.StudentLastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentLastNameTextBox.Name = "StudentLastNameTextBox";
            this.StudentLastNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.StudentLastNameTextBox.TabIndex = 1;
            this.StudentLastNameTextBox.TextChanged += new System.EventHandler(this.StudentLastNameTextBox_TextChanged);
            // 
            // StudentLastNameLabel
            // 
            this.StudentLastNameLabel.Location = new System.Drawing.Point(8, 27);
            this.StudentLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentLastNameLabel.Name = "StudentLastNameLabel";
            this.StudentLastNameLabel.Size = new System.Drawing.Size(112, 15);
            this.StudentLastNameLabel.TabIndex = 2;
            this.StudentLastNameLabel.Text = "Last Name:";
            this.StudentLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentAcademicDepartmentTextBox
            // 
            this.StudentAcademicDepartmentTextBox.Location = new System.Drawing.Point(124, 46);
            this.StudentAcademicDepartmentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentAcademicDepartmentTextBox.Name = "StudentAcademicDepartmentTextBox";
            this.StudentAcademicDepartmentTextBox.Size = new System.Drawing.Size(150, 20);
            this.StudentAcademicDepartmentTextBox.TabIndex = 2;
            this.StudentAcademicDepartmentTextBox.TextChanged += new System.EventHandler(this.StudentAcademicDepartmentTextBox_TextChanged);
            // 
            // StudentAcademicDepartmentLabel
            // 
            this.StudentAcademicDepartmentLabel.AutoSize = true;
            this.StudentAcademicDepartmentLabel.Location = new System.Drawing.Point(8, 47);
            this.StudentAcademicDepartmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentAcademicDepartmentLabel.Name = "StudentAcademicDepartmentLabel";
            this.StudentAcademicDepartmentLabel.Size = new System.Drawing.Size(115, 13);
            this.StudentAcademicDepartmentLabel.TabIndex = 4;
            this.StudentAcademicDepartmentLabel.Text = "Academic Department:";
            this.StudentAcademicDepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentGraduationYearTextBox
            // 
            this.StudentGraduationYearTextBox.Location = new System.Drawing.Point(124, 147);
            this.StudentGraduationYearTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentGraduationYearTextBox.Name = "StudentGraduationYearTextBox";
            this.StudentGraduationYearTextBox.Size = new System.Drawing.Size(150, 20);
            this.StudentGraduationYearTextBox.TabIndex = 5;
            this.StudentGraduationYearTextBox.TextChanged += new System.EventHandler(this.StudentGraduationYearTextBox_TextChanged);
            // 
            // StudentGraduationYearLabel
            // 
            this.StudentGraduationYearLabel.Location = new System.Drawing.Point(8, 149);
            this.StudentGraduationYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentGraduationYearLabel.Name = "StudentGraduationYearLabel";
            this.StudentGraduationYearLabel.Size = new System.Drawing.Size(112, 15);
            this.StudentGraduationYearLabel.TabIndex = 7;
            this.StudentGraduationYearLabel.Text = "Graduation Year:";
            this.StudentGraduationYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentAddButton
            // 
            this.StudentAddButton.Location = new System.Drawing.Point(167, 386);
            this.StudentAddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentAddButton.Name = "StudentAddButton";
            this.StudentAddButton.Size = new System.Drawing.Size(51, 20);
            this.StudentAddButton.TabIndex = 7;
            this.StudentAddButton.Text = "Add";
            this.StudentAddButton.UseVisualStyleBackColor = true;
            this.StudentAddButton.Click += new System.EventHandler(this.StudentAddButton_Click);
            // 
            // StudentCancelButton
            // 
            this.StudentCancelButton.Location = new System.Drawing.Point(222, 386);
            this.StudentCancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentCancelButton.Name = "StudentCancelButton";
            this.StudentCancelButton.Size = new System.Drawing.Size(51, 20);
            this.StudentCancelButton.TabIndex = 8;
            this.StudentCancelButton.Text = "Cancel";
            this.StudentCancelButton.UseVisualStyleBackColor = true;
            this.StudentCancelButton.Click += new System.EventHandler(this.StudentCancelButton_Click);
            // 
            // StudentAddressTextBox
            // 
            this.StudentAddressTextBox.Location = new System.Drawing.Point(124, 112);
            this.StudentAddressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentAddressTextBox.Name = "StudentAddressTextBox";
            this.StudentAddressTextBox.Size = new System.Drawing.Size(150, 20);
            this.StudentAddressTextBox.TabIndex = 4;
            this.StudentAddressTextBox.TextChanged += new System.EventHandler(this.StudentAddressTextBox_TextChanged);
            // 
            // StudentEmailLabel
            // 
            this.StudentEmailLabel.Location = new System.Drawing.Point(15, 91);
            this.StudentEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentEmailLabel.Name = "StudentEmailLabel";
            this.StudentEmailLabel.Size = new System.Drawing.Size(105, 17);
            this.StudentEmailLabel.TabIndex = 14;
            this.StudentEmailLabel.Text = "Email Address:";
            this.StudentEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentAddressLabel
            // 
            this.StudentAddressLabel.Location = new System.Drawing.Point(15, 112);
            this.StudentAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentAddressLabel.Name = "StudentAddressLabel";
            this.StudentAddressLabel.Size = new System.Drawing.Size(105, 17);
            this.StudentAddressLabel.TabIndex = 16;
            this.StudentAddressLabel.Text = "Address:";
            this.StudentAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentEmailTextBox
            // 
            this.StudentEmailTextBox.Location = new System.Drawing.Point(124, 91);
            this.StudentEmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentEmailTextBox.Name = "StudentEmailTextBox";
            this.StudentEmailTextBox.Size = new System.Drawing.Size(150, 20);
            this.StudentEmailTextBox.TabIndex = 3;
            this.StudentEmailTextBox.TextChanged += new System.EventHandler(this.StudentEmailTextBox_TextChanged);
            // 
            // ContactInformationLabel
            // 
            this.ContactInformationLabel.AutoSize = true;
            this.ContactInformationLabel.Location = new System.Drawing.Point(20, 72);
            this.ContactInformationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContactInformationLabel.Name = "ContactInformationLabel";
            this.ContactInformationLabel.Size = new System.Drawing.Size(102, 13);
            this.ContactInformationLabel.TabIndex = 18;
            this.ContactInformationLabel.Text = "Contact Information:";
            this.ContactInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentListBox
            // 
            this.StudentListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.Location = new System.Drawing.Point(10, 211);
            this.StudentListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(276, 160);
            this.StudentListBox.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // CourseListLabel
            // 
            this.CourseListLabel.AutoSize = true;
            this.CourseListLabel.Location = new System.Drawing.Point(17, 184);
            this.CourseListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseListLabel.Name = "CourseListLabel";
            this.CourseListLabel.Size = new System.Drawing.Size(59, 13);
            this.CourseListLabel.TabIndex = 20;
            this.CourseListLabel.Text = "Course List";
            this.CourseListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(10, 386);
            this.AddCourseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(86, 20);
            this.AddCourseButton.TabIndex = 6;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // AddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 414);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.CourseListLabel);
            this.Controls.Add(this.StudentListBox);
            this.Controls.Add(this.ContactInformationLabel);
            this.Controls.Add(this.StudentAddressTextBox);
            this.Controls.Add(this.StudentEmailLabel);
            this.Controls.Add(this.StudentCancelButton);
            this.Controls.Add(this.StudentAddressLabel);
            this.Controls.Add(this.StudentAddButton);
            this.Controls.Add(this.StudentEmailTextBox);
            this.Controls.Add(this.StudentGraduationYearTextBox);
            this.Controls.Add(this.StudentGraduationYearLabel);
            this.Controls.Add(this.StudentAcademicDepartmentTextBox);
            this.Controls.Add(this.StudentAcademicDepartmentLabel);
            this.Controls.Add(this.StudentLastNameTextBox);
            this.Controls.Add(this.StudentLastNameLabel);
            this.Controls.Add(this.StudentFirstNameTextBox);
            this.Controls.Add(this.StudentFirstNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEditStudent";
            this.Text = "AddEditStudent";
            this.Load += new System.EventHandler(this.AddEditStudent_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentFirstNameLabel;
        private System.Windows.Forms.TextBox StudentFirstNameTextBox;
        private System.Windows.Forms.TextBox StudentLastNameTextBox;
        private System.Windows.Forms.Label StudentLastNameLabel;
        private System.Windows.Forms.TextBox StudentAcademicDepartmentTextBox;
        private System.Windows.Forms.Label StudentAcademicDepartmentLabel;
        private System.Windows.Forms.TextBox StudentGraduationYearTextBox;
        private System.Windows.Forms.Label StudentGraduationYearLabel;
        private System.Windows.Forms.Button StudentAddButton;
        private System.Windows.Forms.Button StudentCancelButton;
        private System.Windows.Forms.TextBox StudentAddressTextBox;
        private System.Windows.Forms.Label StudentEmailLabel;
        private System.Windows.Forms.Label StudentAddressLabel;
        private System.Windows.Forms.TextBox StudentEmailTextBox;
        private System.Windows.Forms.Label ContactInformationLabel;
        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Label CourseListLabel;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}