using Banking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingUI
{
    /*
    smit kalavadiya
    IT-PA-2021
    5047957
     */

    public partial class Form1 : Form
    {
        ChequingAccount chequingAccount;
        SavingsAccount savingsAccount;
        BankAccount account;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chequingAccount = new ChequingAccount(0);
            savingsAccount = new SavingsAccount(0);
            lstAccounts.Items.Add(chequingAccount.AccountType.ToString());
            lstAccounts.Items.Add(savingsAccount.AccountType.ToString());
        }

        private void lstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = "";
            if (lstAccounts.SelectedIndex == 0)
            {
                // code for chequing
                message = $"Number of Withdrawls {chequingAccount.NumberOfWithdrawl.ToString()}";
                txtBalance.Text = chequingAccount.Balance.ToString("c");
                txtExtraInfo.Text = message;
                lstTransactions.DataSource = null;
                lstTransactions.DataSource = chequingAccount.Transactions;
                lstTransactions.DisplayMember = "DisplayAmount";

            }
            else
            {
                // code for saving
                message = $"Number of Deposits {savingsAccount.NumberOfDeposite.ToString()}";
                txtBalance.Text = savingsAccount.Balance.ToString("c");
                txtExtraInfo.Text = message;
                lstTransactions.DataSource = null;
                lstTransactions.DataSource = savingsAccount.Transactions;
                lstTransactions.DisplayMember = "DisplayAmount";
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal Amount;
                if (decimal.TryParse(txtAmount.Text, out Amount))
                {
                    decimal balance;
                    if (lstAccounts.SelectedIndex == 0)
                    {
                        // For chequing
                        account = chequingAccount;
                        account.Deposite(Amount);
                        balance = account.Balance;
                        txtBalance.Text = balance.ToString("c");
                        txtExtraInfo.Text = $"Number of Withdrawl {chequingAccount.NumberOfWithdrawl}";
                        lstTransactions.DataSource = null;
                        lstTransactions.DataSource = account.Transactions;
                        lstTransactions.DisplayMember = "DisplayAmount";
                        ClearTextbox();

                    }
                    else
                    {
                        //For saving
                        account = savingsAccount;
                        account.Deposite(Amount);
                        balance = account.Balance;
                        txtBalance.Text = balance.ToString("c");
                        txtExtraInfo.Text = $"Number of deposit {savingsAccount.NumberOfDeposite}";
                        lstTransactions.DataSource = null;
                        lstTransactions.DataSource = account.Transactions;
                        lstTransactions.DisplayMember = "DisplayAmount";
                        ClearTextbox();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid deposit amount");
                    ClearTextbox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearTextbox();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtAmount.Text, out decimal Amount))
                {
                    decimal balance;
                    if (lstAccounts.SelectedIndex == 0)
                    {
                        // For chequing
                        account = chequingAccount;
                        account.Withdrawal(Amount);
                        balance = account.Balance;
                        txtBalance.Text = balance.ToString("c");
                        txtExtraInfo.Text = $"Number of Withdrawl {chequingAccount.NumberOfWithdrawl}";
                        lstTransactions.DataSource = null;
                        lstTransactions.DataSource = account.Transactions;
                        lstTransactions.DisplayMember = "DisplayAmount";
                        ClearTextbox();
                    }
                    else
                    {
                        //For saving
                        account = savingsAccount;
                        account.Withdrawal(Amount);
                        balance = account.Balance;
                        txtBalance.Text = balance.ToString("c");
                        txtExtraInfo.Text = $"Number of deposit {savingsAccount.NumberOfDeposite}";
                        lstTransactions.DataSource = null;
                        lstTransactions.DataSource = account.Transactions;
                        lstTransactions.DisplayMember = "DisplayAmount";
                        ClearTextbox();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid withdraw amount");
                    ClearTextbox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearTextbox();
            }
        }

        public void ClearTextbox()
        {
            txtAmount.Focus();
            txtAmount.SelectAll();
            txtAmount.Text = string.Empty;
        }  //clear the textbox
    }
}
