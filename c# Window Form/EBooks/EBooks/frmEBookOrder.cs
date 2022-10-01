using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBooks
{
    /*
    
    Smit Kalavadiya
    5047957
    IT-PA 2021

     */
    public partial class frmEBookOrder : Form
    {
        private const decimal BOOK_PRICE = 19.99m;
        private const decimal EXPEDITED_SHIPPING_PRICE = 5.99m;
        private string bookName;
        int totalQty = 0;

        public frmEBookOrder()
        {
            InitializeComponent();
        }

        private void frmEBookOrder_Load(object sender, EventArgs e)
        {
            Setup();

            cboAvailableBooks.Sorted = true;

            cboAvailableBooks.Items.Add("SQL Server 2017");
            cboAvailableBooks.Items.Add("Visual Studio 2017");
            cboAvailableBooks.Items.Add("C# 2015");
            cboAvailableBooks.Items.Add("ASP.NET 4.7");
            cboAvailableBooks.Items.Add("Database Systems");
            cboAvailableBooks.Items.Add("Class Design");
            cboAvailableBooks.Items.Add("SQL Server 2017 Administration");
            cboAvailableBooks.Items.Add("UML Patterns and Design");
        }

        #region Methods
        // YOU MUST PUT YOUR USER-DEFINED METHODS IN THIS REGION

        private void Setup()
        {
            lblShipping.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            lblTotal.Text = string.Empty;
            grpOrderInfo.Enabled = false;
            btnCheckout.Enabled = false;
            txtQuantity.Text = string.Empty;
            lstCart.Items.Clear();
            grpChooseBooks.Enabled = true;
            txtMemberNumber.Text = string.Empty;
            cboAvailableBooks.SelectedIndex = -1;
            totalQty = 0;
            btnCheckout.Text = "Checkout";
        }

        private decimal GetOrderTotal(decimal subtotal, decimal shippingCost)
        {
            return subtotal + shippingCost;
        }

        private bool IsValidMemberNumber(string memberNum)
        {
            if (memberNum.Length == 6 && memberNum.EndsWith("X") && memberNum.Contains("B"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            Setup();
        }

        private void cboAvailableBooks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bookName = cboAvailableBooks.SelectedItem.ToString();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(bookName))
                {
                    MessageBox.Show("Please select an e-book", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (int.TryParse(txtQuantity.Text, out int number))
                {
                    string msg = string.Empty;
                  
                    totalQty += int.Parse(txtQuantity.Text);
                    msg = $"({txtQuantity.Text}) {bookName}";
                    lstCart.Items.Add(msg);
                    btnCheckout.Enabled = true;
                    btnCheckout.Text = $"Checkout:{totalQty}";
                }
                else
                {
                    MessageBox.Show("Please Enter a valid quantity","Invalid Data",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.GetType().ToString());
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int count = lstCart.Items.Count;
            if (count <= 0)
            {
                MessageBox.Show("must have books in the cart", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            grpOrderInfo.Enabled = true;
            grpOrderConfirmation.Enabled = false;
            btnCalculateOrder.Enabled = true;
            grpChooseBooks.Enabled = false;
        }

        private void btnCalculateOrder_Click(object sender, EventArgs e)
        {
            grpOrderConfirmation.Enabled = true;

            decimal subTotal = 0;
            decimal shippingCharge = 0;
            decimal Total = 0;

            subTotal = BOOK_PRICE * totalQty;
            if (chkExpedited.Checked)
            {
                shippingCharge = EXPEDITED_SHIPPING_PRICE;
                Total = GetOrderTotal(subTotal, shippingCharge);
                lblSubtotal.Text = subTotal.ToString("c");
                lblShipping.Text = shippingCharge.ToString("c");
                lblTotal.Text = Total.ToString("c");
            }
            else
            {
                Total = GetOrderTotal(subTotal, 0);
                lblSubtotal.Text = subTotal.ToString("c");
                lblShipping.Text = shippingCharge.ToString("c");
                lblTotal.Text = Total.ToString("c");
            }
            btnCalculateOrder.Enabled = false;
        }

        private void chkExpedited_CheckedChanged(object sender, EventArgs e)
        {

            if (chkExpedited.Checked)
            {
                lblSubtotal.Text = string.Empty;
                lblShipping.Text = string.Empty;
                lblTotal.Text = string.Empty;
                btnCalculateOrder.Enabled = true;
                grpOrderConfirmation.Enabled = false;
            }
            else
            {
                lblSubtotal.Text = string.Empty;
                lblShipping.Text = string.Empty;
                lblTotal.Text = string.Empty;
                btnCalculateOrder.Enabled = true;
                grpOrderConfirmation.Enabled = false;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (IsValidMemberNumber(txtMemberNumber.Text))
            {
                MessageBox.Show("Thank you for your order!.","Order Processed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please Enter a valid member number", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberNumber.Focus();
                txtMemberNumber.SelectAll();
            }
        }

        private void frmEBookOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
