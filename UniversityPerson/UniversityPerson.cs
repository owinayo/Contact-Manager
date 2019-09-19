using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Owiny Ayorech
 * Purpose: Base class for different types of university people
 * Date: September 5, 2019
 * */

namespace UniversityPeople
{
    public abstract class UniversityPerson
    {
        //Private class variables
        private string firstName;
        private string lastName;
        private string academicDepartment;
        private string emailAddress;
        private string address;
        private string personType;

        //Class property with getters and setters
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First Name cannot be null or empty");
                }
                else
                {
                    firstName = value;
                }

            }
        }

        //Class property with getters and setters
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last Name cannot be null or empty");
                }
                else
                {
                    lastName = value;
                }

            }
        }

        //Class property with getters and setters
        public string AcademicDepartment
        {
            get
            {
                return academicDepartment;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Academic Department cannot be null or empty");
                }
                else
                {
                    academicDepartment = value;
                }

            }
        }

        //Class property with getters and setters
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Email Address cannot be null");
                }
                else
                {
                    emailAddress = value;
                }
            }
        }

        //Class property with getters and setters
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Address cannot be null");
                }
                else
                {
                    address = value;
                }
            }
        }

        //Class property with getters and setters
        public string PersonType
        {
            get
            {
                return personType;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Person type cannot be null");
                }
                else
                {
                    personType = value;
                }
            }
        }


        //Class constructor with multiple input parameters relevant to a person
        public UniversityPerson(string fName,string lName, string aDepartment, string eAddress,string mainAddress,string pType)
        {
            FirstName = fName;
            LastName = lName;
            AcademicDepartment = aDepartment;
            EmailAddress = eAddress;
            Address = mainAddress;
            PersonType = pType;
        }

        //Class method returns string of properties
        public virtual string ToFileString()
        {
            string personFile = "";

            personFile += $"{personType}|";
            personFile += $"{firstName}|";
            personFile += $"{lastName}|";
            personFile += $"{academicDepartment}|";
            personFile += $"{emailAddress}|";
            personFile += $"{address}";
            

            return personFile;
        }

        //Class method returns formated string
        public virtual string ToFormattedString()
        {
            string personInfo = "";

            personInfo += $"{firstName,-30}";
            personInfo += $"{lastName,-15}";
            personInfo += $"{academicDepartment,15}";
            personInfo += $"{personType,20}";

            return personInfo;
        }

        //overriden class method returns display string
        public override string ToString()
        {
            return $"First Name:'{FirstName}' Last Name:'{LastName}' Academic Department:'{AcademicDepartment}'";
        }
    }
}
