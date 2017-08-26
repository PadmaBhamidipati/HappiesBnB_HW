using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappiesBnB
{
    /// <summary>
    /// In the following class, the types and methods specific to the Bed and Breakfast set of activities that shall be accessed and executed 
    /// by the owner, employee or other authorised personnel of the BnB are specified.
    /// </summary>
    public class BnB
    {
        // The TypeOfRoom enum specifies the different types of rooms at the BnB that a guest can reserve for use, if available.
        public enum TypeOfRoom
        {
            Single,
            Double,
            Deluxe
        }

        //The BreakfastTypesOfferd enum specifies the different types of breakfast options that the BnB management offers for a guest to choose from.
        public enum BreakfastTypesOffered
        {
            FullEnglish,
            Continental,
            SouthIndian,
            NorthIndian,
            Light
        }

        #region Methods



        #endregion

        static void Main(string[] args)
        {
        }
    }
}
