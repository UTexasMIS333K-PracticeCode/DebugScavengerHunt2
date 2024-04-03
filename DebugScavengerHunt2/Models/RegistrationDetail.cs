using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DebugScavengerHunt2.Models
{
    public class RegistrationDetail
    {
        public Int32 RegistrationDetailID { get; set; }

        [Required(ErrorMessage = "You must specify a number of students to enroll")]
        [Display(Name = "Number of students to enroll")]
        [Range(1, 1000, ErrorMessage = "Number of students must be between 1 and 1000")]
        public Int32 NumberOfStudents { get; set; }

        [Display(Name = "Course Fee")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CourseFee { get; set; }

        [Display(Name = "Total Fees")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalFees { get; set; }


        public Registration Registration { get; set; }
        public Course Course { get; set; }
    }
}