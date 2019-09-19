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

namespace Contact_Manager
{
    public partial class SearchPeople : Form
    {
        
        public int internalSearchMode;
        private List<UniversityPerson> internalSearchContactList = new List<UniversityPerson>();
        public List<int> indexesToSelect = new List<int>();//list that will store indexes to select on main page where matching search names were found

        public SearchPeople()
        {
            InitializeComponent();
        }

        public SearchPeople(int searchMode, List<UniversityPerson> searchContactList)
        {
            InitializeComponent();

            internalSearchMode = searchMode;

            internalSearchContactList = searchContactList;

            switch (searchMode)
            {
                case 1://first name search
                    SearchLastNameLabel.Visible = false;
                    SearchLastNameTextBox.Visible = false;

                    break;
                case 2://last name search
                    SearchFirstNameLabel.Visible = false;
                    SearchFirstNameTextBox.Visible = false;
                    break;
                case 3://first and last name search

                    break;
                default:
                    MessageBox.Show("Unknown search mode");
                    break;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm mainFormRef = new MainForm();
                bool isSearchValid;//boolean variable that will determine if search value is valid

                switch (internalSearchMode)
                {
                    case 1://first name search
                        isSearchValid = Validator.ValidateFields(SearchFirstNameTextBox);//call Validator Class ValidateFields method on the textbox control and assigns the return value to a variable

                        if (!isSearchValid)
                        {
                            return;
                        }

                        for (int i = 0; i < internalSearchContactList.Count; i++)
                        {
                            if (internalSearchContactList[i].FirstName.ToLower() == SearchFirstNameTextBox.Text.ToLower().Trim())
                            {
                                indexesToSelect.Add(i);
                            }
                        }

                        break;
                    case 2://last name search
                        isSearchValid = Validator.ValidateFields(SearchLastNameTextBox);//call Validator Class ValidateFields method on the textbox control and assigns the return value to a variable
                                                                                         //If field is invalid go back to search window
                        if (!isSearchValid)
                        {
                            return;
                        }

                        for (int i = 0; i < internalSearchContactList.Count; i++)
                        {
                            if (internalSearchContactList[i].LastName.ToLower() == SearchLastNameTextBox.Text.ToLower().Trim())
                            {
                                indexesToSelect.Add(i);
                            }
                        }

                        break;
                    case 3://first and last name search
                        foreach (Control ctrl in this.Controls)//iterate through the form controls
                        {
                            if (ctrl is TextBox)//if the current control is a textbox
                            {
                                isSearchValid = Validator.ValidateFields((TextBox)ctrl);//call Validator Class ValidateFields method on the textbox control and assigns the return value to a variable
                                                                                        //If field is invalid go back to search window
                                if (!isSearchValid)
                                {
                                    return;
                                }
                            }
                        }

                        for (int i = 0; i < internalSearchContactList.Count; i++)
                        {
                            if (internalSearchContactList[i].FirstName.ToLower() == SearchFirstNameTextBox.Text.ToLower().Trim() && internalSearchContactList[i].LastName.ToLower() == SearchLastNameTextBox.Text.ToLower().Trim())
                            {
                                indexesToSelect.Add(i);
                            }
                        }

                        break;
                    default:
                        MessageBox.Show("Unknown search mode");
                        break;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
