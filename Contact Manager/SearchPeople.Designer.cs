namespace Contact_Manager
{
    partial class SearchPeople
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchFirstNameLabel = new System.Windows.Forms.Label();
            this.SearchFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchLastNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchLastNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(195, 127);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(60, 25);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(117, 127);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(60, 25);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchFirstNameLabel
            // 
            this.SearchFirstNameLabel.Location = new System.Drawing.Point(29, 41);
            this.SearchFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchFirstNameLabel.Name = "SearchFirstNameLabel";
            this.SearchFirstNameLabel.Size = new System.Drawing.Size(84, 17);
            this.SearchFirstNameLabel.TabIndex = 2;
            this.SearchFirstNameLabel.Text = "First Name";
            this.SearchFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchFirstNameTextBox
            // 
            this.SearchFirstNameTextBox.Location = new System.Drawing.Point(117, 41);
            this.SearchFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchFirstNameTextBox.Name = "SearchFirstNameTextBox";
            this.SearchFirstNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.SearchFirstNameTextBox.TabIndex = 3;
            // 
            // SearchLastNameTextBox
            // 
            this.SearchLastNameTextBox.Location = new System.Drawing.Point(117, 69);
            this.SearchLastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchLastNameTextBox.Name = "SearchLastNameTextBox";
            this.SearchLastNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.SearchLastNameTextBox.TabIndex = 5;
            // 
            // SearchLastNameLabel
            // 
            this.SearchLastNameLabel.Location = new System.Drawing.Point(29, 69);
            this.SearchLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLastNameLabel.Name = "SearchLastNameLabel";
            this.SearchLastNameLabel.Size = new System.Drawing.Size(84, 17);
            this.SearchLastNameLabel.TabIndex = 4;
            this.SearchLastNameLabel.Text = "Last Name";
            this.SearchLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 161);
            this.Controls.Add(this.SearchLastNameTextBox);
            this.Controls.Add(this.SearchLastNameLabel);
            this.Controls.Add(this.SearchFirstNameTextBox);
            this.Controls.Add(this.SearchFirstNameLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CancelButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchPeople";
            this.Text = "Search People";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearchFirstNameLabel;
        private System.Windows.Forms.TextBox SearchFirstNameTextBox;
        private System.Windows.Forms.TextBox SearchLastNameTextBox;
        private System.Windows.Forms.Label SearchLastNameLabel;
    }
}