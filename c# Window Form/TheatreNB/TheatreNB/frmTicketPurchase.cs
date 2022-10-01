using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreNB
{
    public partial class frmTicketPurchase : Form
    {
        /*
         
        Smit Kalavadiya
        5047957
         
         */
        public frmTicketPurchase()
        {
            InitializeComponent();
        }

        private void frmTicketPurchase_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Setup();
        }

        #region Methods
        private void Setup()
        {
            rdoBalcony.Checked = true;
            chk1979.Checked = false;
            chkAnnie.Checked = false;
            chkBoysGirls.Checked = false;
            chkWonderfulLife.Checked = false;
            txtCreditCard.Text = string.Empty;
            lblDisplay.Text = string.Empty;
        }

        private bool IsValidCreditCard(string data)
        {
            string firstTwonumber = data.Substring(0, 2);

            if (long.TryParse(data, out long Number) == true && data.Length == 16 && firstTwonumber == "45")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClearLebel(object sender, EventArgs e)
        {
            lblDisplay.Text = String.Empty;
        }

        #endregion

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int counter = 0;
            decimal discount,totalPrice = 0;
            decimal ticketCost = 0;
            string msg;
            string creditCardNumber = txtCreditCard.Text.Trim();

            if (chk1979.Checked)
            {
                counter++;
            }
            if (chkAnnie.Checked)
            {
                counter++;
            }
            if (chkBoysGirls.Checked)
            {
                counter++;
            }
            if (chkWonderfulLife.Checked)
            {
                counter++;
            }

            if (rdoBalcony.Checked)
            {
                ticketCost = 50 * counter;
            }
            else if (rdoOrchestra.Checked)
            {
                ticketCost = 85 * counter;
            }
            else if (rdoBox.Checked)
            {
                ticketCost = 110 * counter;
            }

            try
            {
                if (counter >= 1)
                {
                    int firstTwoindexVal = Convert.ToInt32(creditCardNumber.Substring(0, 2));

                    if (IsValidCreditCard(creditCardNumber))
                    {
                        MessageBox.Show("Credit card is invalid", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCreditCard.Focus();
                        txtCreditCard.SelectAll();
                        return;
                    }

                    if (counter >= 2 && rdoBox.Checked)
                    {
                        discount = ticketCost * 0.15m;
                        totalPrice = ticketCost - discount;
                    }
                    else
                    {
                        totalPrice = ticketCost;
                    }

                    msg = $"{totalPrice:c} has been charged to your credit card ending in " +
                        $"{creditCardNumber.Substring(12, 4)}";

                    lblDisplay.Text = msg;
                }
                else
                {
                    MessageBox.Show("You must select at least 1 play.", "Invalid Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Credit card is invalid", "Invalid Data", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                txtCreditCard.Focus();
                txtCreditCard.SelectAll();
            }

        }
    }
}
