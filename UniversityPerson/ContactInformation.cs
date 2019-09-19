using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 * Author: Owiny Ayorech
 * Purpose: Contact information base class
 * Date: September 5, 2019
 * */

namespace UniversityPeople
{
    public abstract class ContactInformation
    {
        private string emailAddress;//private class variable emailAddress

        /// <summary>
        /// Public class property EmailAddress
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                //Boolean regex to verify value being set is valid email address
                bool isEmail = Regex.IsMatch(value, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

                //If email is valid set value else throw exception
                if (isEmail)
                {
                    emailAddress = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Email");
                }
            }
        }
        
        

    }
}
