using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePayCalculator
{
    /*
     smit mukeshbhai kalavadiya
     IT-PA 2021
     ID - 5047957
    */
    public partial class Form1 : Form
    {
        private const decimal DEDUCTION = 15;
        private const decimal MINIMUM_WORKHOURS = 40;
        private const decimal OVERTIME_RATE = 1.5m;

        public Form1()
        {
            InitializeComponent();
            this.Text = "The Pay Calculator";
            txtHoursWork.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoursWork.Text = string.Empty;
            txtPayrate.Text = string.Empty;
            lblAnswer.Text = string.Empty;
            lblOverTimehours.Text = string.Empty;
            txtHoursWork.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //getting values from the user
                decimal hoursWorked = Convert.ToDecimal(txtHoursWork.Text);
                decimal payRate = Convert.ToDecimal(txtPayrate.Text);

                //doing calculation
                decimal overTime = hoursWorked - MINIMUM_WORKHOURS;
                lblOverTimehours.Text = overTime.ToString();
                decimal grossSalary = (MINIMUM_WORKHOURS * payRate) + (payRate * OVERTIME_RATE * overTime);
                decimal deducation = (grossSalary * DEDUCTION) / 100;
                decimal netSalary = grossSalary - deducation;

                string message = $"Your Gross Pay is {grossSalary:c}{Environment.NewLine}" +
                                 $"Your Net Pay is {netSalary:c}{Environment.NewLine}";

                lblAnswer.Text = message;
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.GetType().ToString());
            } 
        }
    }
}
