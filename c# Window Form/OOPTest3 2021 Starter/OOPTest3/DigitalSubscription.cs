using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest3
{
    //Inherit from Subscription
    public class DigitalSubscription : Subscription
    {
        #region CONSTANTS

        private const decimal CONSECUTIVE_ISSUE_DISCOUNT_RATE = 0.10m;

        #endregion

        #region[FIELDS

        private string emailAddress;

        #endregion

        #region CONSTRUCTORS

        //Implement Constructor
        public DigitalSubscription(string firstName, string lastName, string emailAddress)
            :base(firstName,lastName)
        {
            EmailAddress = emailAddress;
        }

        #endregion

        #region PROPERTIES

        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                if (!Validate.IsValidEmail(value))
                    throw new ArgumentException("Email address is invalid");

                emailAddress = value;
            }
        }



        #endregion

        #region METHODS

        //Implement AddPublication
        public override void AddPublication(Publication publication)
        {
            if (CanAddPublication(publication))
            {
                Publications.Add(publication);
            }
            else
            {
                throw new ArgumentException("Cannot order copies");
            }
            
        }


        #endregion
    }
}
