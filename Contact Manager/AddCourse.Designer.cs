namespace Contact_Manager
{
    partial class AddCourse
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
            this.AddCourseTextBox = new System.Windows.Forms.TextBox();
            this.AddCourseLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCourseTextBox
            // 
            this.AddCourseTextBox.Location = new System.Drawing.Point(30, 66);
            this.AddCourseTextBox.Name = "AddCourseTextBox";
            this.AddCourseTextBox.Size = new System.Drawing.Size(172, 22);
            this.AddCourseTextBox.TabIndex = 0;
            this.AddCourseTextBox.TextChanged += new System.EventHandler(this.AddCourseTextBox_TextChanged);
            // 
            // AddCourseLabel
            // 
            this.AddCourseLabel.Location = new System.Drawing.Point(27, 30);
            this.AddCourseLabel.Name = "AddCourseLabel";
            this.AddCourseLabel.Size = new System.Drawing.Size(175, 23);
            this.AddCourseLabel.TabIndex = 1;
            this.AddCourseLabel.Text = "Enter Course Name";
            this.AddCourseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(99, 116);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(56, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "OK";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(162, 116);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(69, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 155);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddCourseLabel);
            this.Controls.Add(this.AddCourseTextBox);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddCourseTextBox;
        private System.Windows.Forms.Label AddCourseLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
    }
}