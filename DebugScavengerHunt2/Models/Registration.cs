using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DebugScavengerHunt2.Models
{
    public enum RegistrationStatus { Pending, Completed }
    public class Registration
    {
        private const Decimal SERVICE_FEE_RATE = 0.15m;

        public Int32 RegistrationID { get; set; }

        [Display(Name = "Registration Number:")]
        public Int32 RegistrationNumber { get; set; }

        [Display(Name = "Registration Date:")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Registration Notes:")]
        public String RegistrationNotes { get; set; }

        [Display(Name = "Registration Status:")]
        public RegistrationStatus Status { get; set; }

        [Display(Name = "Registration Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal RegistrationSubtotal
        {
            get { return RegistrationDetails.Sum(rd => rd.TotalFees); }
        }

        [Display(Name = "Service Fee (15%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ServiceFee
        {
            get { return RegistrationSubtotal * SERVICE_FEE_RATE; }
        }

        [Display(Name = "Registration Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal RegistrationTotal
        {
            get { return RegistrationSubtotal + ServiceFee; }
        }

        public List<RegistrationDetail> RegistrationDetails { get; set; }

        public AppUser User { get; set; }


        // It will create new (empty) list of Books if the navigational property is null.
        // //This is helpful because you can’t iterate over a null list
        // //You can’t add or remove from a null list, and you can’t count a null list.
        // //Putting this code into a constructor prevents null reference errors throughout the application.

        public Registration()
        {
            if (RegistrationDetails == null)
            {
                RegistrationDetails = new List<RegistrationDetail>();
            }

            //RegistrationDetails ??= new List<RegistrationDetail>(); //Alternate to if above
        }
    }
}