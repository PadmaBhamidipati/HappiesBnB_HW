using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappiesBnB
{
    /// <summary>
    /// This is the base class for the customers of the BnB. It captures the properties of the customer staying at the BnB. 
    /// This person may be booking for self or for someone else.
    /// </summary>
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
