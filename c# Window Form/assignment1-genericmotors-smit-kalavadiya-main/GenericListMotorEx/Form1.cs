using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericListMotorEx
{
    public partial class Form1 : Form
    {
        List<Motor> motor = new List<Motor>();
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string status = "";
                if (rdoOn.Checked)
                {
                    status = rdoOn.Tag.ToString();
                }


                if (rdoOff.Checked)
                {
                    status = rdoOff.Tag.ToString();
                }


                if (rdoMNT.Checked)
                {
                    status = rdoMNT.Tag.ToString();
                }


                if (rdoNA.Checked)
                {
                    status = rdoNA.Tag.ToString();
                }

                Motor m = new Motor() { MotorId = txtMotorId.Text, Des = txtDesc.Text, Rpm = int.Parse(txtRPM.Text), Status = status, Voltage = int.Parse(txtVoltage.Text) };

                if (count < 5)
                {
                    motor.Add(m);
                    lstDisplay.DataSource = null;
                    lstDisplay.DataSource = motor;
                    lstDisplay.DisplayMember = "Des";
                    MessageBox.Show("Motor has been added.");
                    ClearForm();
                    count++;
                }
                else
                {
                    MessageBox.Show("You alerady entered five motors");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            txtMotorId.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtRPM.Text = string.Empty;
            txtVoltage.Text = string.Empty;
            txtMotorToPrint.Text = string.Empty;
            txtMotorId.Focus();
            txtMotorId.SelectAll();
            rdoOn.Checked = true;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int Listlen = motor.Count;
            if (int.TryParse(txtMotorToPrint.Text, out int printNumber) && printNumber <= 5 && printNumber > 0)
            {
                if (printNumber <= Listlen)
                {
                    MessageBox.Show($"Motor id:{motor[printNumber - 1].MotorId}\n" +
                    $"Desciption: {motor[printNumber - 1].Des}\n" +
                    $"RPM: {motor[printNumber - 1].Rpm}\n" +
                    $"Voltage: {motor[printNumber - 1].Voltage}\n" +
                    $"Status: {motor[printNumber - 1].Status}"
                    );
                }
                else
                {
                    MessageBox.Show("that is invalid");
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("that is invalid");
            }
        }

        private void txtMotorId_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (int.TryParse(txtMotorId.Text, out int id) && txtMotorId.TextLength == 5)
                {
                    errorProvider1.SetError(txtMotorId, null);
                }
                else
                {
                    errorProvider1.SetError(txtMotorId, "MotorId must be 5 numeric characters in length.");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMotorId,ex.Message);
            }
        }

        private void txtDesc_Validating(object sender, CancelEventArgs e)
        {
            
                if (!string.IsNullOrWhiteSpace(txtDesc.Text))
                {
                    errorProvider1.SetError(txtDesc, null);
                }
                else
                {
                    errorProvider1.SetError(txtDesc, "Description is required.");
                }
            
        }

        private void txtRPM_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (int.TryParse(txtRPM.Text, out int rpm) && rpm >= 10 && rpm <= 10000)
                {
                    errorProvider1.SetError(txtRPM, null);
                }
                else
                {
                    throw new ConstraintException("RPM must be an integer between 10 and 1000.");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtRPM, ex.Message);

            }
        }

        private void txtVoltage_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (int.TryParse(txtVoltage.Text, out int voltage) && voltage >= 1 && voltage <= 500)
                {
                    errorProvider1.SetError(txtVoltage, null);
                }
                else
                {
                    throw new ConstraintException("Voltage must be an integer between 1 and 500.");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtVoltage, ex.Message);
            }
        }
    }
}
