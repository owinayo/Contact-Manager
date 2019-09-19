using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

/*
 * Author: Owiny Ayorech
 * Purpose: Class used to validate text in various text boxes
 * Date: September 5, 2019
 * */

namespace Contact_Manager
{
    public static class Validator
    {
        //Static Class method takes a textbox and checks the text for invalid text
        public static bool ValidateFields(TextBox textBoxToBeValidated)
        {
            //boolean variable used to check that input text is just numerical digit
            bool checkGradYear = textBoxToBeValidated.Text.All(char.IsDigit);
            
            //boolean value to run regex against the entered email
            bool checkEmail = Regex.IsMatch(textBoxToBeValidated.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            //try catch block to test the various text boxes for valid entries
            try
            {
                if (String.IsNullOrWhiteSpace(textBoxToBeValidated.Text))
                {
                    throw new ArgumentException($"{textBoxToBeValidated.Name} cannot be null or empty");
                }
                else if (textBoxToBeValidated.Name == "StudentTextBox" && int.Parse(textBoxToBeValidated.Text) < DateTime.Now.Year)
                {
                    throw new ArgumentException("Graduation Year cannot be a value from the past\n", $"Check: {textBoxToBeValidated.Name}");
                }
                else if (textBoxToBeValidated.Name == "StudentTextBox" && checkGradYear == false)
                {
                    throw new ArgumentException("Graduation Year cannot be a value from the past\n", $"Check: {textBoxToBeValidated.Name}");
                }
                else if (textBoxToBeValidated.Name == "StudentEmailTextBox" && checkEmail == false)
                {
                    throw new ArgumentException("Please enter a valid email address\n", $"Check: {textBoxToBeValidated.Name}");
                }
            }
            catch (Exception e)//give the exception a handle e
            {
                string msg = e.Message; //string variable message; warning message
                string capt = e.GetType().Name + " Error";//string variable caption; warning caption
                //initiate an instance of DialogResult class with return value of CustomMsgBoxes method call 
                DialogResult confirmResult = CustomMsgBoxes(msg, capt, "error");
                return false;//Return false value
            }
            return true;
        }

        /// <summary>
        /// Function that builds a custom message box based on the type of input parameters
        /// </summary>
        /// <param name="msg">Messsage to be displayed parameter</param>
        /// <param name="capt">Caption for the box that is displayed</param>
        /// <param name="messageType">type parameter that is used to configure buttons and icons</param>
        /// <returns></returns>
        public static DialogResult CustomMsgBoxes(string msg, string capt, string messageType)
        {
            DialogResult result;//DialogResult class instance confirmResult; value used to check if OK was pressed
            MessageBoxButtons bttnsConfirm = MessageBoxButtons.YesNo;//MessageBoxButtons class instance bttns; used as method parameter to create yes or no button 
            MessageBoxIcon iconsConfirm = MessageBoxIcon.Question;//MessageBoxIcon class instance icons; used to display question icon
            MessageBoxButtons bttnsWarning = MessageBoxButtons.OK;//MessageBoxButtons class instance bttns; used as method parameter to create ok button 
            MessageBoxIcon iconsWarning = MessageBoxIcon.Warning;//MessageBoxIcon class instance icons; used to display warning icon
            MessageBoxButtons bttnsInfo = MessageBoxButtons.OK;//MessageBoxButtons class instance bttns; used as method parameter to create ok button 
            MessageBoxIcon iconsInfo = MessageBoxIcon.Information;//MessageBoxIcon class instance icons; used to display info icon
            MessageBoxButtons bttnsError = MessageBoxButtons.OK;//MessageBoxButtons class instance bttns; used as method parameter to create ok button 
            MessageBoxIcon iconsError = MessageBoxIcon.Error;//MessageBoxIcon class instance icons; used to display error icon
            if (messageType == "confirm")
            {
                //Assign result variable result of confirmation box button press 
                result = MessageBox.Show(msg, capt, bttnsConfirm, iconsConfirm);
                return result;
            }
            if (messageType == "warning")
            {
                //Assign result variable result of warning box button press 
                result = MessageBox.Show(msg, capt, bttnsWarning, iconsWarning);
                return result;
            }
            if (messageType == "info")
            {
                //Assign result variable result of warning box button press 
                result = MessageBox.Show(msg, capt, bttnsInfo, iconsInfo);
                return result;
            }
            if (messageType == "error")
            {
                //Assign result variable result of warning box button press 
                result = MessageBox.Show(msg, capt, bttnsError, iconsError);
                return result;
            }
            else
            {
                return DialogResult.Cancel;//just a dummy variable so that all return paths lead somewhere
            }
        }

    }
}
