using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepairBill
{
    /*
     
    Smit kalavadiya
    IT-PA 2021
    5047957
     
     */
    public partial class frmAutoBill : Form
    {   
        //Constant variables 
        const decimal TAX_RATE = 15;
        const decimal LABOR_COST = 85;
        const decimal IMPORT_FEE = 5;
         
        //Form level variables
        decimal totalPartCost,totalLabour,totalTax;
        int counter = 1; // for counting each item in the invoice

        public frmAutoBill()
        {
            InitializeComponent();
        }

        
        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            //declare variable for total invoice
            decimal totalBill = 0;
            
            // calculating total invoice 
            totalBill = totalLabour + totalPartCost + totalTax;
            
            // writing back to textbox
            txtBill.Text += $"----YOUR INVOICE----{Environment.NewLine}"+
                $"Total Labour: {totalLabour:c}{Environment.NewLine}" +
                $"Total Parts: {totalPartCost:c}{Environment.NewLine}" +
                $"Total Tax: {totalTax:c}{Environment.NewLine}" +
                $"Total Invoice: {totalBill:c}{Environment.NewLine}" +
                $"{Environment.NewLine}";
        }
        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            // declare varibles
            
            decimal Tax, PartCost, labourCost;

            // getting values of each record
            string pName = txtPartName.Text;
            decimal Labor = Convert.ToDecimal(txtLabourHours.Text);
            decimal Cost = Convert.ToDecimal(txtPartCost.Text); 
             
            // Calculation
            PartCost = Cost + (Cost * IMPORT_FEE) / 100;   
            labourCost = Labor * LABOR_COST;
            Tax = (PartCost + labourCost) * TAX_RATE / 100;

            totalPartCost += PartCost;
            totalLabour += labourCost;
            totalTax += Tax;
            

            //printing in textbox
            txtBill.Text += $"----ITEM #: {counter++}{Environment.NewLine}" +
                $"Part Name: {pName}{Environment.NewLine}" +
                $"Part Cost: {PartCost:c}{Environment.NewLine}" +
                $"Labour Cost : {labourCost:c}{Environment.NewLine}" +
                $"Tax: {Tax:c}{Environment.NewLine}" +
                $"{Environment.NewLine}";

            

            // Empty textboxes and focus back to the Part name textbox
            txtPartCost.Text = string.Empty;
            txtPartName.Text = string.Empty;
            txtLabourHours.Text = string.Empty;
            txtPartName.Focus();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBill.Text = string.Empty;
            totalPartCost = 0;
            totalLabour = 0;
            totalTax = 0;
            counter = 1;
            txtPartName.Focus();
          
        }

    }
}
