using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest3
{
    public class Publication
    {
        #region Constants

        private const int MIN_ISSUE_NAME_LENGTH = 5;
        private const int MAX_ISSUES_PER_VOLUME = 12;

        #endregion

        #region Fields

        private string publicationName;
        private int volumeNumber;
        private int issueNumber;
        private decimal issuePrice;

        public static int AvailableIssues
        {
            get
            {
                return MAX_ISSUES_PER_VOLUME;
            }
        }

        #endregion

        #region Constructors

        public Publication(string publicationName,int volumeNumber, int issueNumber, decimal issuePrice,MediaType media)
        {
            PublicationName = publicationName;
            VolumeNumber = volumeNumber;
            IssueNumber = issueNumber;
            IssuePrice = issuePrice;
            Media = media;
        }

        #endregion

        #region Properties

        //AvailableIssues

        public string PublicationName
        {
            get { return publicationName; }
            set
            {


                publicationName = value;
            }
        }

        public int VolumeNumber
        {
            get { return volumeNumber; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid volume number");

                volumeNumber = value;
            }
        }

        public int IssueNumber
        {
            get { return issueNumber; }
            set
            {
                //Use IsValidIssueNumber method to validate this setter
            }
        }

        public decimal IssuePrice
        {
            get { return issuePrice; }
            set
            {
                if (value <= 0.0m)
                    throw new ArgumentException("Invalid issue price");

                issuePrice = value;
            }
        }

        public MediaType Media { get; set; }

        #endregion

        #region Methods

        //Implement IsValidIssueNumber with specified access modifier

        private bool IsValidIssueNumber(int issueNumberToCheck)
        {
            if (issueNumberToCheck <= MAX_ISSUES_PER_VOLUME && issueNumberToCheck >= MAX_ISSUES_PER_VOLUME)
            {
                if (IsValidIssueNumber(issueNumber))
                {
                    issueNumber = issueNumberToCheck;
                    return true;
                }
                else
                {
                    throw new ConstraintException("invalid issue number");
                }
            }
            return false;
        }

        #endregion

    }

    public enum MediaType
    {
        Digital,
        Print
    }
}
