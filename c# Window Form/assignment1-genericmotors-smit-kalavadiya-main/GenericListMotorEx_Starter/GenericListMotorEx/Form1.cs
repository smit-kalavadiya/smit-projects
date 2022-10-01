using System;
using System.Collections;
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

        List<Motor> array = new List<Motor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateData();
                string status = "";
                if (rdoOn.Checked)
                {
                    status = "ON";
                }


                if (rdoOff.Checked)
                {
                    status = "OFF";
                }


                if (rdoMNT.Checked)
                {
                    status = "Maintance";
                }


                if (rdoNA.Checked)
                {
                    status = "NA";
                }


                array.Add(new Motor(Convert.ToInt32(txtMotorId.Text), txtDesc.Text, Convert.ToInt32(txtRPM.Text), Convert.ToInt32(txtVoltage.Text), status));

            }
            catch (Exception ex)
            {

                MessageBox.Show("You have invalid data. Please fix all errors");
            }

        }

        public void ValidateData()
        {
            int len = txtMotorId.Text.Length;
            if (string.IsNullOrWhiteSpace(txtMotorId.Text.ToString()) || len < 5)
            {
                errorProvider1.SetError(txtMotorId, "MotorID must be 5 charachtets in length.");
            }
            else
            {
                errorProvider1.SetError(txtMotorId, "");
            }

            if (string.IsNullOrWhiteSpace(txtDesc.Text.ToString()))
            {
                errorProvider1.SetError(txtDesc, "Description is required");
            }
            else
            {
                errorProvider1.SetError(txtDesc, "");
            }

            if (string.IsNullOrWhiteSpace(txtRPM.Text.ToString()))
            {
                errorProvider1.SetError(txtRPM, "RPM must be an integer between 10 and 10000");
            }
            else
            {
                errorProvider1.SetError(txtRPM, "");
            }

            if (string.IsNullOrWhiteSpace(txtVoltage.Text.ToString()))
            {
                errorProvider1.SetError(txtVoltage, "Voltage must be between 1 and 500");
            }
            else
            {
                errorProvider1.SetError(txtVoltage, "");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
         

            MessageBox.Show($"Motor id:{array[Convert.ToInt32(txtMotorToPrint.Text)].MotorID}\n" +
                $"Desciption: {array[Convert.ToInt32(txtMotorToPrint.Text)].Des}\n" +
                $"RPM: {array[Convert.ToInt32(txtMotorToPrint.Text)].RPM}\n"+
                $"Voltage: {array[Convert.ToInt32(txtMotorToPrint.Text)].Voltage}\n"+
                $"Status: {array[Convert.ToInt32(txtMotorToPrint.Text)].Status}"
                );
        }
    }
}
