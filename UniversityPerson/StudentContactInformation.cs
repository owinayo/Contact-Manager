using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Owiny Ayorech
 * Purpose: Contact information derived class for student
 * Date: September 5, 2019
 * */

namespace UniversityPeople
{
    public class StudentContactInformation : ContactInformation
    {
        private string mailingAddress;//public class variable
       
        /// Public class property BuildingLocation
        public string MailingAddress
        {
            get
            {
                return mailingAddress;
            }

            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Mailing Address cannot be null or empty");
                }
                else
                {
                    mailingAddress = value;
                }

            }

        }

        //Class constructor with a number of input parameters
        public StudentContactInformation(string emailAddress, string mailingAddress)
        {
            EmailAddress = emailAddress;
            MailingAddress = mailingAddress;
        }
    }
}
