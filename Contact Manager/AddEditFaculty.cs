using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Owiny Ayorech
 * Purpose: Add/Edit Faculty member Modal dialog
 * Date: September 5, 2019
 * */

namespace Contact_Manager
{
    public partial class AddEditFaculty : Form
    {
        //Declare public class variables
        public string addedFirstName;
        public string addedLastName;
        public string addedAcademicDepartment;
        public string addedEmailAddress;
        public string addedAddress;
        public bool EditMode = false;
        public bool ViewMode = false;

        public AddEditFaculty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add Faculty member button click event
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            bool isFacultyValid;//boolean variable that will determine if faculty info to store is valid

            foreach (Control ctrl in this.Controls)//iterate through the form controls
            {
                if (ctrl is TextBox)//if the current control is a textbox
                {
                    isFacultyValid = Validator.ValidateFields((TextBox)ctrl);//call Validator Class ValidateFields method on the textbox control and assigns the return value to a variable
                    //If field is invalid go back to add/edit Faculty window
                    if (!isFacultyValid)
                    {
                        MessageBox.Show("Please enter valid values before closing the form");
                    }
                }
            }

            DialogResult = DialogResult.OK;//all fields are valid so set the dialog response to ok and close the form
        }

        /// <summary>
        /// Closes the modal dialog
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void FacultyCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void FacultyFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            addedFirstName = FacultyFirstNameTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void FacultyLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            addedLastName = FacultyLastNameTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void FacultyAcademicDepartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            addedAcademicDepartment = FacultyAcademicDepartmentTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void FacultyEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            addedEmailAddress = FacultyEmailTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void FacultyAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            addedAddress = FacultyAddressTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Populates and configures controls based on mode when form loads
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void AddEditFaculty_Load(object sender, EventArgs e)
        {
            FacultyCancelButton.Visible = true;

            //On edit mode populates fields with selected users data and allows editing; sets controls to required states
            if (EditMode)
            {
                FacultyFirstNameTextBox.Text = addedFirstName;
                FacultyLastNameTextBox.Text = addedLastName;
                FacultyAcademicDepartmentTextBox.Text = addedAcademicDepartment;
                FacultyEmailTextBox.Text = addedEmailAddress;
                FacultyAddressTextBox.Text = addedAddress;

                FacultyAddButton.Text = "Update";
                this.Text = "Edit Faculty ";
            }

            //on view mode populates fields with selected users data and does not allow editing; sets controls to required states
            if (ViewMode)
            {
                FacultyFirstNameTextBox.Text = addedFirstName;
                FacultyFirstNameTextBox.ReadOnly = true;
                FacultyLastNameTextBox.Text = addedLastName;
                FacultyLastNameTextBox.ReadOnly = true;
                FacultyAcademicDepartmentTextBox.Text = addedAcademicDepartment;
                FacultyAcademicDepartmentTextBox.ReadOnly = true;
                FacultyEmailTextBox.Text = addedEmailAddress;
                FacultyEmailTextBox.ReadOnly = true;
                FacultyAddressTextBox.Text = addedAddress;
                FacultyAddressTextBox.ReadOnly = true;

                FacultyAddButton.Text = "OK";
                FacultyCancelButton.Visible = false;
                this.Text = "View Faculty";
            }
        }
    }
}
