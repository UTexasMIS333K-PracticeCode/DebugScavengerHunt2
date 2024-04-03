using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DebugScavengerHunt2.Models
{
    public class Department
    {
        public Int32 DepartmentID { get; set; }

        [Display(Name = "Department Name")]
        public String DepartmentName { get; set; }

        [Display(Name = "Department Office Location")]
        public String DepartmentLocation { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }

        public List<Course> Courses { get; set; }


        // It will create new (empty) list of Books if the navigational property is null.
        // //This is helpful because you can’t iterate over a null list
        // //You can’t add or remove from a null list, and you can’t count a null list.
        // //Putting this code into a constructor prevents null reference errors throughout the application.

        public Department()
        {
            if (Courses == null)
            {
                Courses = new List<Course>();
            }
        }

    }
}