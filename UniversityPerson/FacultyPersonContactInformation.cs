using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Owiny Ayorech
 * Purpose: Contact information derived class for faculty member
 * Date: September 5, 2019
 * */

namespace UniversityPeople
{
    public class FacultyPersonContactInformation : ContactInformation
    {
        /// Public class property BuildingLocation
        public string BuildingLocation { get; set; }

        //Class constructor with a number of input parameters
        public FacultyPersonContactInformation(string emailAddress, string buildingLocation)
        {
            EmailAddress = emailAddress;
            BuildingLocation = buildingLocation;
        }
        
    }
}
