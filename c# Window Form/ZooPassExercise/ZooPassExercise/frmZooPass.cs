using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPassExercise
{
    public partial class frmZooPass : Form
    {
        /*
         
        Smit kalavadiya
        5047957
         
         */
        public frmZooPass()
        {
            InitializeComponent();
        }

        private void frmZooPass_Load(object sender, EventArgs e)
        {
            cboPassLength.Items.Add("1 Day");
            cboPassLength.Items.Add("2 Day");
            cboPassLength.Items.Add("5 Day");
        }

        private void btnAddPass_Click(object sender, EventArgs e)
        {

            string passLength;
            string type = string.Empty;
            string option1, option2,option3;
            int counter = 0;
            string msg = string.Empty;

            if (cboPassLength.SelectedIndex != -1)
            {
                passLength = cboPassLength.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select a pass length.","Invalid data!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //Radio button
            if (rdoAdult.Checked)
            {
                type = rdoAdult.Text;
            }
            else
            {
                type = "Child";
            }

            // checkbox
            if (chkVip.Checked)
            {
                option1 = "VIP,";
                counter++;
            }
            else
            {
                option1 = string.Empty;
                
            }
            if (chkTrainor.Checked)
            {
                option2 = "Meet the Trainor,";
                counter++;
            }
            else
            {
                option2 = string.Empty;
                
            }

            if (chkMonkeyShow.Checked)
            {
                option3 = "Monkey Show.";
                counter++;
            }
            else
            {
                option3 = string.Empty;
                
            }

            msg = $"{passLength} - {type} - {option1}{option2}{option3}";

            if (counter >= 2)
            {
                lstPasses.Items.Add(msg);
                lblNumPasses.Text = lstPasses.Items.Count.ToString();
                chkMonkeyShow.Checked = false;
                chkTrainor.Checked = false;
                chkVip.Checked = false;
                rdoAdult.Checked = true;
                cboPassLength.ResetText();
            }
            else
            {
                MessageBox.Show("You must select at least 2 options.", "Invalid data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Item_Remove(object sender, EventArgs e)
        {
            if (lstPasses.SelectedIndex != -1)
            {
                lstPasses.Items.Remove(lstPasses.SelectedItem);
                lblNumPasses.Text = lstPasses.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Please select a pass to remove.", "Invalid selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            chkMonkeyShow.Checked = false;
            chkTrainor.Checked = false;
            chkVip.Checked = false;
            rdoAdult.Checked = true;
            cboPassLength.ResetText();
            lstPasses.Items.Clear();
            lblNumPasses.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void frmZooPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
