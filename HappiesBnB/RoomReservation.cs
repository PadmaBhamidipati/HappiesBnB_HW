using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappiesBnB
{
    /// <summary>
    /// This class captures the details required to reserve a room at the BnB are captured.
    /// </summary>
    public class RoomReservation
    {
        //The PaymentMode enum specifies the possible options for payment to the BnB.
        public enum PaymentMode
        {
            Credit,
            Debit,
            Cash,
            Cheque
        }

        //The TypeOfCard enum specifies the possible options for the types of cards that may be used for payment.
        public enum TypeOfCard
        {
            Visa,
            MasterCard,
            AmericanExpress,
            Discover            
        }
        /// <summary>
        /// This class currently does not capture the case where the guest could be the same person making the reservation as well.
        /// </summary>

        #region Properties

        public string ReservationMadeByName { get; set; }
        public Guest guestName { get; set; } //link to Guest class: 

        //ContactDetailsForReservation must contain the contact details of the person making the reservation
        public Customer ContactDetailsForReservation { get; set; }//phone no., email ID, Address of the person making the reservation


        public BnB.TypeOfRoom RoomPreference { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime EstimatedCheckOutDateDate { get; set; }
        public DateTime ActualCheckOutDate { get; set; }
        public PaymentMode paymentMode { get; set; }

        public TypeOfCard TypeOfCardUsed { get; set; }
        public long CardNumber { get; set; }
        public DateTime CardExpiryMMYY { get; set; }
        public short CardCVVNumber { get; set; }
        public long ChequeNumber { get; set; }
        public long BankRoutingNumber { get; set; }
        #endregion
            
    }
}
