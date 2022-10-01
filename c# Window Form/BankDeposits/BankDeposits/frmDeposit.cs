using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposits
{
    /*
     * smit kalavadiya
     * ITPA-2021
     * 2047957
     */
    public partial class frmDeposit : Form
    {
        private const decimal TRANSACTION_FEE_TWO_DESPOSIT = 3.75m;
        private const decimal TRANSACTION_FEE = 1m;
        private const decimal SURCHARGE = 0.5m;
        private const decimal CHECK_PROCESSING_FEE = 0.75m;
        private const decimal CHECK_PROCESSING_FEE_MORETHN_4_CHECK = 0.25m;
        decimal subtotalNetdeposite = 0;

        int counter = 0;
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void btnMakeDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                counter++;
                btnNewAccount.Enabled = true;
                txtAccountHolder.Enabled = false;
                string Name = txtAccountHolder.Text;
                string accountNumber = txtAccountNumber.Text;
                decimal totalCash = Convert.ToDecimal(txtCashAmt.Text);
                decimal totalCheckdeposit = Convert.ToDecimal(txtCheckAmt.Text);
                int numberOfCheck = Convert.ToInt32(txtNumChecks.Text);
                decimal transactionFee = 0;
                decimal checkProccesingFee = 0;
                decimal cashDepositafterSurcharge = 0;
                


                decimal surchargeTotal = totalCash * SURCHARGE / 100;
                cashDepositafterSurcharge = totalCash - surchargeTotal;

                if (numberOfCheck > 4)
                {
                    checkProccesingFee += numberOfCheck * CHECK_PROCESSING_FEE_MORETHN_4_CHECK;
                }
                else
                {
                    checkProccesingFee += numberOfCheck * CHECK_PROCESSING_FEE;
                }


                if (counter <= 2)
                {
                    transactionFee = TRANSACTION_FEE_TWO_DESPOSIT;
                }
                else
                {
                    transactionFee = TRANSACTION_FEE;
                }

                decimal netDeposite = cashDepositafterSurcharge + totalCheckdeposit - checkProccesingFee - transactionFee;
                subtotalNetdeposite += netDeposite;


                string Message = $"Deposit for {Name} {Environment.NewLine}" +
                    $"Account #: {accountNumber} {Environment.NewLine}" +
                    $"{Environment.NewLine}" +
                    $"Cash Deposit (after surcharge):{cashDepositafterSurcharge:c} {Environment.NewLine}" +
                    $"Check Deposit:{totalCheckdeposit:c} {Environment.NewLine}" +
                    $"Check Processing Fee: {checkProccesingFee:c} {Environment.NewLine}" +
                    $"Transaction Fee: {transactionFee:c}{Environment.NewLine}{Environment.NewLine}" +
                    $"Net Deposits: {netDeposite:c}";

                String Message_2 = $"Total deposits for all accounts belonging to {Name} is {subtotalNetdeposite:c}";

                lblDepositSummary.Text = Message;
                lblTotalDisplay.Text = Message_2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.GetType().ToString());
            }

           

        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = String.Empty;
            txtCashAmt.Text = String.Empty;
            txtCheckAmt.Text = String.Empty;
            txtNumChecks.Text = String.Empty;

            lblDepositSummary.Text = String.Empty;
            txtAccountNumber.Focus();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Net amount for your {counter} depostit were {subtotalNetdeposite:c}.{Environment.NewLine} Thank you for banking with us.","Come back again");
            Close();
        }
    }
}
