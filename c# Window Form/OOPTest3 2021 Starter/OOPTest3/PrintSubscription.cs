using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest3
{
    //Inherit from Subscription
    public class PrintSubscription : Subscription
    {
        #region CONSTANTS

        private const decimal SHIPPING_RATE = 0.02m;
        private const decimal ECO_TAX = 0.01m;
        private const int MAILING_ADDRESS_MAX_LENGTH = 50;

        #endregion

        #region FIELDS

        private string mailingAdress;
        private string city;
        private string province;
        private string postalCode;

        #endregion

        #region CONSTRUCTORS

        //Implement Constructor

        public PrintSubscription(string firstName, string lastName, string mailingAddress, string city, string provice, string postalCode)
            :base(firstName,lastName)
        {
            MailingAddress = mailingAddress;
            City = city;
            Province = provice;
            PostalCode = postalCode;
        }

        #endregion

        #region Properties

        public string MailingAddress
        {
            get { return mailingAdress; }
            set
            {


                mailingAdress = value;
            }
        }

        public string City
        {
            get { return city; }
            set
            {


                city = value;
            }
        }

        public string Province
        {
            get { return province; }
            set
            {


                province = value;
            }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set
            {
                if (!Validate.IsValidPostalCode(value))
                    throw new ArgumentException("Postal code is not valid");

                postalCode = value;
            }
        }



        #endregion

        #region METHODS

        public override decimal CalculateSubscriptionPrice()
        {
            return base.CalculateSubscriptionPrice() * (1.0m + SHIPPING_RATE);
        }

        public override void AddPublication(Publication publication)
        {
            if (CanAddPublication(publication))
            {
                publication.IssuePrice += ECO_TAX;
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
