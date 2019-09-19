using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Owiny Ayorech
 * Purpose: university person derived class for faculty member
 * Date: September 5, 2019
 * */

namespace UniversityPeople
{
    public class FacultyPerson : UniversityPerson
    {
        //Class constructor with a number of input parameters and reference to base class
        public FacultyPerson(string fName, string lName, string aDepartment, string eAddress, string mainAddress,string pType) : base( fName,  lName,  aDepartment, eAddress, mainAddress, pType)
        {
            
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
