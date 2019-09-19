using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityPeople;

/*
 * Author: Owiny Ayorech
 * Purpose: Add/Edit Student Modal dialog
 * Date: September 5, 2019
 * */

namespace Contact_Manager
{
    public partial class AddEditStudent : Form
    {
        //Declare public class variables
        public List<string> CoursesList = new List<string>();//main contact list
        public string addedFirstName;
        public string addedLastName;
        public string addedAcademicDepartment;
        public string addedEmailAddress;
        public string addedAddress;
        public string addedGraduationYear;
        public bool EditMode = false;
        public bool ViewMode = false;

        public AddEditStudent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the price
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void StudentCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Add Student button click event
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void StudentAddButton_Click(object sender, EventArgs e)
        {

            bool isStudentValid;//boolean variable that will determine if student info to store is valid

            try
            {
                foreach (Control ctrl in this.Controls)//iterate through the form controls
                {
                    if (ctrl is TextBox)//if the current control is a textbox
                    {
                        isStudentValid = Validator.ValidateFields((TextBox)ctrl);//call Validator Class ValidateFields method on the textbox control and assigns the return value to a variable
                                                                                 //If field is invalid go back to add/edit student window
                        if (!isStudentValid)
                        {
                            MessageBox.Show("Please enter valid values before closing the form");
                        }
                    }
                }

                CoursesList = StudentListBox.Items.Cast<String>().ToList();//add current students courselist to courses for passing to mainform
                
                DialogResult = DialogResult.OK;//all fields are valid so set the dialog response to ok and close the form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Opens add course dialog and waits for result of entered values
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            AddCourse addDialog = new AddCourse();//create an instance of addcourse dialog form

            DialogResult result = addDialog.ShowDialog(this);//a variable that holds the value return by the modal dialog 

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (result == DialogResult.OK)
            {
                try
                {
                    // Read the contents of addDialog's TextBox.
                    if (!String.IsNullOrWhiteSpace(addDialog.addedCourse))
                    {
                        CoursesList.Add(addDialog.addedCourse);
                        StudentListBox.Items.Add(addDialog.addedCourse);
                    }
                    else
                    {
                        throw new ArgumentException("Cannot add a blank course name");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().Name,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
            addDialog.Dispose();//release resources held by the control

        }

        /// <summary>
        /// Deletes a course from the course list
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(StudentListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to delete");
            }
            else
            {
                CoursesList.RemoveAt(StudentListBox.SelectedIndex);//remove value from our course list
                StudentListBox.Items.RemoveAt(StudentListBox.SelectedIndex);//remove value from our list box
            }
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void StudentFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            addedFirstName = StudentFirstNameTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void StudentLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            addedLastName = StudentLastNameTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void StudentAcademicDepartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            addedAcademicDepartment = StudentAcademicDepartmentTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void StudentEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            addedEmailAddress = StudentEmailTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void StudentAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            addedAddress = StudentAddressTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Assigns value of text box to class variable
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void StudentGraduationYearTextBox_TextChanged(object sender, EventArgs e)
        {
            addedGraduationYear = StudentGraduationYearTextBox.Text.Trim();//Assign textbox value to class variable so it can be passed to another form
        }

        /// <summary>
        /// Populates and configures controls based on mode when form loads
        /// </summary>
        /// <param name="sender">the control that triggered the event parameter</param>
        /// <param name="e">the event type parameter</param>
        private void AddEditStudent_Load(object sender, EventArgs e)
        {
            //enables visibilty  of controls as default
            StudentCancelButton.Visible = true;
            AddCourseButton.Visible = true;
            StudentListBox.Visible = true;
            CourseListLabel.Visible = true;

            //On edit mode populates fields with selected users data and allows editing; sets controls to required states
            if (EditMode)
            {
                StudentFirstNameTextBox.Text = addedFirstName;
                StudentLastNameTextBox.Text = addedLastName;
                StudentAcademicDepartmentTextBox.Text = addedAcademicDepartment;
                StudentEmailTextBox.Text = addedEmailAddress;
                StudentAddressTextBox.Text = addedAddress;
                StudentGraduationYearTextBox.Text = addedGraduationYear.ToString();
                StudentListBox.Items.AddRange(CoursesList.ToArray());//populate listbox with courses list.

                StudentAddButton.Text = "Update";
                this.Text = "Edit Student ";
            }

            //on view mode populates fields with selected users data and does not allow editing; sets controls to required states
            if (ViewMode)
            {
                StudentFirstNameTextBox.Text = addedFirstName;
                StudentFirstNameTextBox.ReadOnly = true;
                StudentLastNameTextBox.Text = addedLastName;
                StudentLastNameTextBox.ReadOnly = true;
                StudentAcademicDepartmentTextBox.Text = addedAcademicDepartment;
                StudentAcademicDepartmentTextBox.ReadOnly = true;
                StudentEmailTextBox.Text = addedEmailAddress;
                StudentEmailTextBox.ReadOnly = true;
                StudentAddressTextBox.Text = addedAddress;
                StudentAddressTextBox.ReadOnly = true;
                StudentGraduationYearTextBox.Text = addedGraduationYear.ToString();
                StudentGraduationYearTextBox.ReadOnly = true;

                StudentAddButton.Text = "OK";
                AddCourseButton.Visible = false;
                StudentCancelButton.Visible = false;
                StudentListBox.Visible = false;
                CourseListLabel.Visible = false;
                this.Text = "View Student";
            }
        }
    }
}
