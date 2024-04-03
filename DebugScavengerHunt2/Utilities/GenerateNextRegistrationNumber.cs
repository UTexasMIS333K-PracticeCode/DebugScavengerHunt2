using DebugScavengerHunt2.DAL;
using System;
using System.Linq;


namespace DebugScavengerHunt2.Utilities
{
    public static class GenerateNextRegistrationNumber
    {
        public static Int32 GetNextRegistrationNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_NUMBER = 1000;

            Int32 intMaxRegistrationNumber; //the current maximum course number
            Int32 intNextRegistrationNumber; //the course number for the next class

            if (_context.Registrations.Count() == 0) //there are no registrations in the database yet
            {
                intMaxRegistrationNumber = START_NUMBER; //registration numbers start at 10001
            }
            else
            {
                intMaxRegistrationNumber = _context.Registrations.Max(c => c.RegistrationNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxRegistrationNumber < START_NUMBER)
            {
                intMaxRegistrationNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextRegistrationNumber = intMaxRegistrationNumber + 1;

            //return the value
            return intNextRegistrationNumber;
        }

    }
}