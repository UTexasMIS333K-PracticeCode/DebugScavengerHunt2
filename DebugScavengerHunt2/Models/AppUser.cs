using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DebugScavengerHunt2.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

        [Display(Name = "User Name:")]
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }

        //navigational property b/c user can have many registrations
        public List<Registration> Registrations { get; set; }


        // It will create new (empty) list of Books if the navigational property is null.
        // //This is helpful because you can’t iterate over a null list
        // //You can’t add or remove from a null list, and you can’t count a null list.
        // //Putting this code into a constructor prevents null reference errors throughout the application.
        public AppUser()
        {
            if (Registrations == null)
            {
                Registrations = new List<Registration>();
            }
        }
    }
}
