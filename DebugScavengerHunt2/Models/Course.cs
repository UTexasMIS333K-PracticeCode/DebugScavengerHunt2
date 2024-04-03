using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DebugScavengerHunt2.Models
{
    public class Course
    {
        public Int32 CourseID { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [Display(Name = "Course Name")]
        public String CourseName { get; set; }

        [Required(ErrorMessage = "Course fee is required")]
        [Display(Name = "Course fee")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CourseFee { get; set; }

        public String Description { get; set; }

        public List<Department> Departments { get; set; }
        public List<RegistrationDetail> RegistrationDetails { get; set; }


        // It will create new (empty) list of Books if the navigational property is null.
        // //This is helpful because you can’t iterate over a null list
        // //You can’t add or remove from a null list, and you can’t count a null list.
        // //Putting this code into a constructor prevents null reference errors throughout the application.

        public Course()
        {
            if (Departments == null)
            {
                Departments = new List<Department>();
            }

            if (RegistrationDetails == null)
            {
                RegistrationDetails = new List<RegistrationDetail>();
            }
        }
    }
}