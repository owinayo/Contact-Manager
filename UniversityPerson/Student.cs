using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Owiny Ayorech
 * Purpose: university person derived class for student
 * Date: September 5, 2019
 * */

namespace UniversityPeople
{
    public class Student : UniversityPerson
    {
        private int expectedGraduationYear;//Expected graduation year private class variable

        //Class propery with getters and setters
        public int ExpectedGraduationYear
        {
            get
            {
                return expectedGraduationYear;
            }

            set
            {
                if (value >= DateTime.Now.Year)//If value is greater than current date time then set it
                {
                    expectedGraduationYear = value;
                }
                else
                {
                    throw new ArgumentException("Expected Graduation Year be greater than current date");
                }
            }
        }

        //Class propery with getters and setters
        public List<string> CourseList { get; set; }

        //Class constructor with a number of input parameters and reference to base class
        public Student(string fName, string lName, string aDepartment, string eAddress,string mainAddress, int eGraduationYear,string pType, List<string> cList) : base(fName, lName, aDepartment, eAddress, mainAddress, pType)
        {
            //Properties that are not derived
            ExpectedGraduationYear = eGraduationYear;
            CourseList = cList;
        }

        //overridden class method returns base class method value
        public override string ToFormattedString()
        {
            return base.ToFormattedString();
        }

        //overridden class method returns base class method value
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
