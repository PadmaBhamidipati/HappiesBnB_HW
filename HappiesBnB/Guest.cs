using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappiesBnB
{
    /// <summary>
    /// This class represents the properties of a guest staying at the BnB.
    /// </summary>
    public class Guest: Customer
    {
        /*public string GuestName{ get; set; }
        public string GuestAddress { get; set; }
        public string GuestPhoneNumber { get; set; }
        public string GuestEmailAddress { get; set; }*/
        public BnB.TypeOfRoom GuestRoomPreference { get; set; }
        public BnB.BreakfastTypesOffered GuestBreakfastPreference { get; set; }
    }


}
