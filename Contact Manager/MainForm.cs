using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityPeople;
using System.IO;

/*
 * Author: Owiny Ayorech
 * Purpose: Main program - launches all other program features
 * Date: September 5, 2019
 * */

namespace Contact_Manager
{
    public partial class MainForm : Form
    {
        public List<UniversityPerson> mainContactList = new List<UniversityPerson>();//main contact list
        public string mainFilePath = "";//variable used to store file path of file open from 'Open File' menu option 
        public int mainSearchIndex;//variable to store value of contact list box selected index 
        public bool saveChanges =  false;//Boolean value used to check if changes have been made to current contact list
        public int SearchMode;//Value used to to set mode of current search;1-first name, 2-last name, 3-first and last name

        public MainForm()
        {
            InitializeComponent();//initializes form component

            //Configures main contact manager label text with offset
            ContactTitleLabel.Text = "";
            ContactTitleLabel.Text += $"{"FirstName",-30}";
            ContactTitleLabel.Text += $"{"LastName",-15}";
            ContactTitleLabel.Text += $"{"Department",15}";
            ContactTitleLabel.Text += $"{"Type",20}";

        }

        /// <summary>
        /// Main menu Exit option; closes application
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        /// <summary>
        /// Main Menu About option; provides information about the application
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact List Application" +
                "\n\nWelcome to the help text section.\n" +
                "\nRight click the main contact list to select from the following list of options:\n" +
                "\nContact Details ..." +
                "\nAdd Contact -> Faculty or Student" +
                "\nEdit Contact" +
                "\nDelete Contact" +
                "\nSearch For -> First Name or Last name or First and Last Name\n" +
                "\nFor additional help press help button\n" +
                "\n\nDeveloped By: Owiny Ayorech © 2019", "Contact List Help Menu", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "https://docs.microsoft.com/en-us/dotnet/?view=netframework-4.8", "keyword");
        }

        /// <summary>
        /// Add Faculty member submenu option; adds faculty member to contact list
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void FacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditFaculty AddFaculty = new AddEditFaculty();//create instance of addeditfaculty window

            DialogResult result = AddFaculty.ShowDialog(this);//variable the stores result returned from modal dialog form; shows add faculty form

            if (result == DialogResult.OK)
            {
                //create instance of student class with the newly added student info
                FacultyPerson addedFaculty = new FacultyPerson(AddFaculty.addedFirstName, AddFaculty.addedLastName, AddFaculty.addedAcademicDepartment, AddFaculty.addedEmailAddress, AddFaculty.addedAddress, "Faculty");

                ContactListBox.Items.Add(addedFaculty.ToFormattedString());//display the info in our student list
                mainContactList.Add(addedFaculty);//add faculty person to our contact list
                saveChanges = true;//update public boolean variable that indicates some changes have been made so prompt will be given on exit
            }
            AddFaculty.Dispose();

        }

        /// <summary>
        /// Add Student submenu option; adds student to contact list
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditStudent addStudent = new AddEditStudent();//create instance of addeditstudent window

            DialogResult result = addStudent.ShowDialog(this);//variable the stores result returned from modal dialog form; shows add student form

            if (result == DialogResult.OK)
            {
                //create instance of student class with the newly added student info
                Student addedStudent = new Student(addStudent.addedFirstName, addStudent.addedLastName, addStudent.addedAcademicDepartment, addStudent.addedEmailAddress, addStudent.addedAddress, int.Parse(addStudent.addedGraduationYear), "Student", addStudent.CoursesList);

                ContactListBox.Items.Add(addedStudent.ToFormattedString());//display the info in our student list
                mainContactList.Add(addedStudent);//add student to our contact list
                saveChanges = true;//update public boolean variable that indicates some changes have been made so prompt will be given on exit
            }
        }

        /// <summary>
        /// Delete contact menu option; deletes contact from contact list
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prompts user to select a contact if none is selected; deletes contact from contact list box and list if one is selected
            if (ContactListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select person to delete");
            }
            else if(ContactListBox.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select one contact at a time to delete");
                return;
            }
            else
            {
                mainContactList.RemoveAt(ContactListBox.SelectedIndex);//remove value from our course list
                ContactListBox.Items.RemoveAt(ContactListBox.SelectedIndex);//remove value from our list box
                saveChanges = true;//update public boolean variable that indicates some changes have been made so prompt will be given on exit
            }
        }

        /// <summary>
        /// Edit contact menu option; edits contact from contact list
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = ContactListBox.SelectedIndex;//variable that stores selected index of contact list box
            
            try
            {
                //Prompts user to select a contact if none is selected; edits contact from contact list box and list if one is selected, does not allow selecting more than one
                if (index == -1)
                {
                    MessageBox.Show("You must select person to edit");
                }
                else if (ContactListBox.SelectedItems.Count > 1)
                {
                    MessageBox.Show("You must select one contact at a time to edit");
                    return;
                }
                else
                {
                    //Checks what the type of person being selected for editing is then populates their respective modal dialog form for editing
                    if (mainContactList[index].PersonType == "Student")
                    {
                        AddEditStudent editStudent = new AddEditStudent();//create instance of addeditstudent window
                        editStudent.EditMode = true;//enable edit mode

                        //create instance of student class utlizing the selected index
                        Student personToEdit = (Student)mainContactList[index];

                        //update form fields with values from contact list for selected person
                        editStudent.addedFirstName = personToEdit.FirstName;
                        editStudent.addedLastName = personToEdit.LastName;
                        editStudent.addedAcademicDepartment = personToEdit.AcademicDepartment;
                        editStudent.addedEmailAddress = personToEdit.EmailAddress;
                        editStudent.addedAddress = personToEdit.Address;
                        editStudent.addedGraduationYear = personToEdit.ExpectedGraduationYear.ToString();
                        //editStudent.CoursesList = personToEdit.CourseList;
                        editStudent.CoursesList = new List<string>(personToEdit.CourseList);

                        DialogResult result = editStudent.ShowDialog();// show the dialog and wait for an OK.

                        // if answer was OK update the contact list with the new values and update display
                        if (result != DialogResult.OK)
                        {
                            return;
                        }

                        //create an instance of student class initialized with updated values
                        Student updatedStudent = new Student(editStudent.addedFirstName,
                                                 editStudent.addedLastName,
                                                 editStudent.addedAcademicDepartment,
                                                 editStudent.addedEmailAddress,
                                                 editStudent.addedAddress,
                                                 int.Parse(editStudent.addedGraduationYear),
                                                 "Student",
                                                 editStudent.CoursesList);

                        mainContactList[index] = updatedStudent;//Populate contact list with updated values
                        ContactListBox.Items[index] = updatedStudent.ToFormattedString();//populate contact listbox with updated values
                        saveChanges = true;//update public boolean variable that indicates some changes have been made so prompt will be given on exit
                    }
                    else if (mainContactList[index].PersonType == "Faculty")
                    {
                        AddEditFaculty editFaculty = new AddEditFaculty();//create instance of addeditfaculty window
                        editFaculty.EditMode = true;//enable edit mode

                        //create instance of student class utlizing the selected index
                        FacultyPerson personToEdit = (FacultyPerson)mainContactList[index];

                        //update form fields with values from contact list for selected person
                        editFaculty.addedFirstName = personToEdit.FirstName;
                        editFaculty.addedLastName = personToEdit.LastName;
                        editFaculty.addedAcademicDepartment = personToEdit.AcademicDepartment;
                        editFaculty.addedEmailAddress = personToEdit.EmailAddress;
                        editFaculty.addedAddress = personToEdit.Address;

                        DialogResult result = editFaculty.ShowDialog();// show the dialog and wait for an OK.

                        // if answer was OK update the contact list with the new values and update display
                        if (result != DialogResult.OK)
                        {
                            return;
                        }

                        //create an instance of faculty person class initialized with updated values
                        FacultyPerson updatedFaculty = new FacultyPerson(editFaculty.addedFirstName,
                                                 editFaculty.addedLastName,
                                                 editFaculty.addedAcademicDepartment,
                                                 editFaculty.addedEmailAddress,
                                                 editFaculty.addedAddress,
                                                 "Faculty");

                        mainContactList[index] = updatedFaculty;//Populate contact list with updated values
                        ContactListBox.Items[index] = updatedFaculty.ToFormattedString();//populate contact listbox with updated values
                        saveChanges = true;//update public boolean variable that indicates some changes have been made so prompt will be given on exit
                        editFaculty.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                //string msg = "You must select a person before editing their details"; //string variable message; warning message
                //string capt = "Edit Contact Information";//string variable caption; warning caption
                                                         //initiate an instance of DialogResult class with return value of CustomMsgBoxes method call 
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Method that is called to populate contact details for viewing
        /// </summary>
        /// <param name="index"></param>
        private void viewPersonBySelectedIndex(int index)
        {
            try
            {
                //Checks what the type of person being selected for viewing is then populates their respective modal dialog form for viewing
                if (mainContactList[index].PersonType == "Student")
                {
                    AddEditStudent viewStudent = new AddEditStudent();//create instance of addeditstudent window
                    viewStudent.ViewMode = true;//enable view mode

                    //create instance of student class utlizing the selected index
                    Student personToView = (Student)mainContactList[index];

                    //update form fields with values from contact list for selected person
                    viewStudent.addedFirstName = personToView.FirstName;
                    viewStudent.addedLastName = personToView.LastName;
                    viewStudent.addedAcademicDepartment = personToView.AcademicDepartment;
                    viewStudent.addedEmailAddress = personToView.EmailAddress;
                    viewStudent.addedAddress = personToView.Address;
                    viewStudent.addedGraduationYear = personToView.ExpectedGraduationYear.ToString();
                    viewStudent.CoursesList = personToView.CourseList;

                    DialogResult result = viewStudent.ShowDialog();// show the dialog and wait for an OK.

                    // if answer was OK update the contact list with the new values and update display
                    if (result != DialogResult.OK)
                    {
                        return;
                    }
                }
                else if (mainContactList[index].PersonType == "Faculty")
                {
                    AddEditFaculty viewFaculty = new AddEditFaculty();//create instance of addeditfaculty window
                    viewFaculty.ViewMode = true;//enable view mode

                    //create instance of student class utlizing the selected index
                    FacultyPerson personToView = (FacultyPerson)mainContactList[index];

                    //update form fields with values from contact list for selected person
                    viewFaculty.addedFirstName = personToView.FirstName;
                    viewFaculty.addedLastName = personToView.LastName;
                    viewFaculty.addedAcademicDepartment = personToView.AcademicDepartment;
                    viewFaculty.addedEmailAddress = personToView.EmailAddress;
                    viewFaculty.addedAddress = personToView.Address;

                    DialogResult result = viewFaculty.ShowDialog();// show the dialog and wait for an OK.

                    // if answer was OK update the contact list with the new values and update display
                    if (result != DialogResult.OK)
                    {
                        return;
                    }

                    viewFaculty.Dispose();//disposes of all resources used by the control
                }
            }
            catch (Exception)
            {

                string msg = "You must select a person before viewing their details"; //string variable message; warning message
                string capt = "View Contact Information";//string variable caption; warning caption
                                                         //initiate an instance of DialogResult class with return value of CustomMsgBoxes method call 
                MessageBox.Show(msg, capt, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        /// <summary>
        /// View contact details menu option (button click event); shows contact details from contact list
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void contactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prompts user to select a contact if none is selected; edits contact from contact list box and list if one is selected, does not allow selecting more than one
            if (ContactListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select person to view contact details");
            }
            else if (ContactListBox.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select one contact at a time to view details");
                return;
            }
            else
            {
                viewPersonBySelectedIndex(ContactListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// View contact details menu option (button double click event); shows contact details from contact list
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void ContactListBox_DoubleClick(object sender, EventArgs e)
        {
            viewPersonBySelectedIndex(ContactListBox.SelectedIndex);
        }

        /// <summary>
        /// Open file menu option; opens contact list file and populates main contact info list box
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactListBox.Items.Count > 0)
            {
                DialogResult saveBeforeOpen = MessageBox.Show("Would You like to Save the current data before loading new data?", "Save Before Open", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                //If we have any data in our contact list and attempt to open a file, prompt the user if they want to save that data
                if (saveBeforeOpen == DialogResult.Yes)
                {
                    saveContactsToolStripMenuItem_Click(sender, e);
                }
                else if (saveBeforeOpen == DialogResult.Cancel)
                {
                    return;
                }
            }

            OpenFileDialog ofd = new OpenFileDialog();//Create open file dialog popup

            ofd.Title = "Select a contact list";//Set title of open file dialog popup

            ofd.Filter = "Text Files|*.txt|All Files|*.*";//create filter of open file dialog popup
            ofd.FilterIndex = 1;//set filter index of open file dialog popup

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//set initial directory of open file dialog popup

            DialogResult result = ofd.ShowDialog();//set return value of popup dialog to variable; shows open file dialog popup

            //If a file was not opened close dialog popup
            if (result != DialogResult.OK)
            {
                return;
            }

            ContactListBox.Items.Clear();//clear contact listbox before opening file
            mainContactList.Clear();//clear contact list before opening file
            // all inside a try/catch
            //
            // open a stream reader on contact list file on the desktop
            // for each line in the file call the constructor that takes single string
            // and get a product object back. Add that object to my list and to the display list
            // close the file

            mainFilePath = ofd.FileName;//Grab the file path and assign it to public variable for saving

            UniversityPerson uPerson = null;//create null class instance variable 

            try
            {
                StreamReader input = new StreamReader(ofd.FileName);//create stream reader object for reading file contents

                //While loop that reads lines of file
                while (!input.EndOfStream)
                {
                    string personType = input.ReadLine();//variable to store line (all a persons details) from file

                    string[] items = personType.Split('|');//put each line into an array to check

                    //Create a variable for each persons info
                    string filePersonType = items[0];
                    string fileFirstName = items[1];
                    string fileLastName = items[2];
                    string fileAcademicDepartment = items[3];
                    string fileEmailAddress = items[4];
                    string fileAddress = items[5];
                    List<string> fileCoursesList = new List<string>();

                    //switch that creates instances of each person based on their type read from the file
                    switch (filePersonType)
                    {
                        case "Student":
                            string fileGraduationYear = items[6];
                            string fileCourseList = items[7];

                            List<string> convertedCourseList = fileCourseList.Split(',').Select(x => x).ToList();//take the course list items into an array; split my string by commas, select each value and turn into a list
                            //Create instance of student with values selected from file
                            uPerson = new Student(fileFirstName, fileLastName, fileAcademicDepartment, fileEmailAddress, fileAddress, int.Parse(fileGraduationYear), filePersonType, convertedCourseList);
                            break;
                        case "Faculty":
                            //Create instance of student with values selected from file
                            uPerson = new FacultyPerson(fileFirstName, fileLastName, fileAcademicDepartment, fileEmailAddress, fileAddress, filePersonType);
                            break;
                        default:
                            MessageBox.Show("Unknown person in the file");
                            uPerson = null;
                            break;
                    }

                    //If we have a valid person add them to our contact list box and contact list; set the changes saved boolean to false as this is an open file
                    if (uPerson != null)
                    {
                        mainContactList.Add(uPerson);
                        ContactListBox.Items.Add(uPerson.ToFormattedString());
                        saveChanges = false;
                    }
                    
                }
                input.Close();//close stream reader object
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File was unable to load. {ex.Message}",ex.GetType().Name);
                return;
            }
        }

        /// <summary>
        /// Saves contact list to file; default save
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void saveContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();//create save file dialog 

            //If we have no mainFilePath set..; no file was opened
            if (mainFilePath == "")
            {
                sfd.Title = "Save New Contact List to File";//Set title for save file dialog

                sfd.Filter = "Text Files|*.txt|All Files|*.*";//create filter for save file dialog
                sfd.FilterIndex = 1;//set filter index for save file dialog

                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//set initial directory for save file dialog

                DialogResult result = sfd.ShowDialog();//variable to store result from save file dialog; shows save file dialog

                //File if ok not pressed close dialog
                if (result != DialogResult.OK)
                {
                    return;
                }

                mainFilePath = sfd.FileName;//set mainfile path to saved file name for next save
            }

            try
            { 
                StreamWriter output = new StreamWriter(mainFilePath);
                //StreamWriter output = new StreamWriter(sfd.FileName);
                foreach (UniversityPerson uPerson in mainContactList)
                {
                    //save the person onbject,if they are a student save grad year and course list
                    if (uPerson.PersonType == "Student")
                    {
                        Student fileStudent = (Student)uPerson;
                        string joinedListValues = string.Join(",", fileStudent.CourseList.Select(x => x));//break list down into comma seperated string

                        output.WriteLine(uPerson.ToFileString() + $"|{fileStudent.ExpectedGraduationYear.ToString()}" + $"|{joinedListValues}");//save a line of 
                    }
                    else
                    {
                        output.WriteLine(uPerson.ToFileString());//save contact to file
                    }
                }
                output.Close();//close streamwriter object
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File did not write. {ex.Message}");
                return;
            }

            MessageBox.Show($"Contacts have been saved in {mainFilePath}");
        }

        /// <summary>
        /// Save file as; prompts user to save file
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();//creates save file dialog

            sfd.Title = "Select File to Save Contact List";//title for save file dialog

            sfd.Filter = "Text Files|*.txt|All Files|*.*";//filter for save file dialog
            sfd.FilterIndex = 1;//filter index for save file dialog

            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//initial save directory for save file dialog

            DialogResult result = sfd.ShowDialog();//shows save file dialog sets result

            if (result != DialogResult.OK)
            {
                return;
            }

            //try to open file 
            try
            {
                StreamWriter output = new StreamWriter(sfd.FileName);//create new streamwriter object

                //
                foreach (UniversityPerson uPerson in mainContactList)
                {
                    //save the person onbject,if they are a student save grad year and course list
                    if (uPerson.PersonType == "Student")
                    {
                        Student fileStudent = (Student)uPerson;//create instance of student class
                        string joinedListValues = string.Join(",", fileStudent.CourseList.Select(x => x));//break list down into comma seperated string

                        output.WriteLine(uPerson.ToFileString() + $"|{fileStudent.ExpectedGraduationYear.ToString()}" + $"|{joinedListValues}");//save a line of 
                    }
                    else
                    {
                        output.WriteLine(uPerson.ToFileString());//write file to string
                    }

                }
                output.Close();//close streamwriter
            }
            catch (Exception ex)
            {
                MessageBox.Show($"File did not write. {ex.Message}");
                return;
            }

            MessageBox.Show($"Contacts have been save in {mainFilePath}");
        }

        /// <summary>
        /// Search by first name menu option
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void FirstNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactListBox.ClearSelected();//unselect all items in contact list box
            SearchMode = 1;//set seach mode value for switch case in modal dialog
            SearchPeople firstNameSearch = new SearchPeople(SearchMode, mainContactList);//creates form instance variable
          
            DialogResult result = firstNameSearch.ShowDialog();//show modal dialog and return result

            if (result == DialogResult.OK)
            {
                //If our search returned any matches, deselect all list items and select the matching rows
                //MessageBox.Show();
                if (firstNameSearch.indexesToSelect.Count > 0)
                {
                    ContactListBox.ClearSelected();
                    //ContactListBox.SelectionMode = ;
                    for (int i = 0; i < firstNameSearch.indexesToSelect.Count; i++)
                    {
                        ContactListBox.SetSelected(firstNameSearch.indexesToSelect[i], true);
                    }
                }
            }
        }

        /// <summary>
        /// Search by last name menu option
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void LastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactListBox.ClearSelected();//unselect all items in contact list box
            SearchMode = 2;//set seach mode value for switch case in modal dialog
            SearchPeople lastNameSearch = new SearchPeople(SearchMode, mainContactList);//creates form instance variable

            DialogResult result = lastNameSearch.ShowDialog(this);//show modal dialog and return result

            if (result == DialogResult.OK)
            {
                //If our search returned any matches, deselect all list items and select the matching rows
                if (lastNameSearch.indexesToSelect.Count > 0)
                {
                    ContactListBox.ClearSelected();
                    for (int i = 0; i < lastNameSearch.indexesToSelect.Count; i++)
                    {
                        ContactListBox.SetSelected(lastNameSearch.indexesToSelect[i], true);
                    }
                }
            }

        }

        /// <summary>
        /// Search by first and last name menu option
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void FirstAndLastNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactListBox.ClearSelected();//unselect all items in contact list box
            SearchMode = 3;//set seach mode value for switch case in modal dialog
            SearchPeople firstLastNameSearch = new SearchPeople(SearchMode, mainContactList);//creates form instance variable

            DialogResult result = firstLastNameSearch.ShowDialog(this);//show modal dialog and return result

            if (result == DialogResult.OK)
            {
                //If our search returned any matches, deselect all list items and select the matching rows
                if (firstLastNameSearch.indexesToSelect.Count > 0)
                {
                    ContactListBox.ClearSelected();
                    for (int i = 0; i < firstLastNameSearch.indexesToSelect.Count; i++)
                    {
                        ContactListBox.SetSelected(firstLastNameSearch.indexesToSelect[i], true);
                    }
                }
            }
        }

        /// <summary>
        /// Form closing event
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //check our boolean value to see if any updates where made
            //If the flag was set prompt the user to confirm save and exit
            //If no changes exit
            if (saveChanges)
            {
                DialogResult exitPrompt = MessageBox.Show("There are unsaved changes to the Contact List, would you like to save and exit?",
                                "File Save on Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                //If we have a file path and they want to save
                if (exitPrompt == DialogResult.Yes && saveChanges == true)
                {
                    saveContactsToolStripMenuItem_Click(sender, e);
                }
                else if(exitPrompt == DialogResult.No)
                {
                    ExitToolStripMenuItem_Click(sender, e);
                }
                else if(exitPrompt == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Contact list box selected index change event
        /// </summary>
        /// <param name="sender">Method parameter for the component that fires the event</param>
        /// <param name="e">Method parameter for the events tied to the component</param>
        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainSearchIndex = ContactListBox.SelectedIndex;//when the selected index changes set it to our public search variable
        }
    }
    
}
