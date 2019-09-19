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
 * Purpose: Modal dialog for adding courses
 * Date: September 5, 2019
 * */

namespace Contact_Manager
{
    public partial class AddCourse : Form
    {
        public string addedCourse;//public class variable stores name of added course to be accessed by another form

        //Initializes form
        public AddCourse()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cancel add course button click event
        /// </summary>
        /// <param name="sender">Parameter for the control that fired the event</param>
        /// <param name="e">Parameter for the event</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Add course button click event
        /// </summary>
        /// <param name="sender">Parameter for the control that fired the event</param>
        /// <param name="e">Parameter for the event</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;//set the returned dialog result value to OK
        }

        /// <summary>
        /// Textbox Text changed event that assigns AddCourseTexbox text to our public property to expose it to other form 
        /// </summary>
        /// <param name="sender">Parameter for the control that fired the event</param>
        /// <param name="e">Parameter for the event</param>
        private void AddCourseTextBox_TextChanged(object sender, EventArgs e)
        {
            addedCourse = AddCourseTextBox.Text.Trim();
        }
    }
}
