using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembership
{
    public partial class frmGymMembership : Form
    {
        /*
         Smit kalavadiya
         */
        public frmGymMembership()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal cost = 0;
            if (rdoStudent.Checked)
            {
                cost += 30;
            }
            if (rdoAdult.Checked)
            {
                cost += 60;
            }
            if(rdoSenior.Checked)
            {
                cost += 40;
            }

            if (chkPrivateLockerRoom.Checked)
            {
                cost += 10;
            }
            if (chkSpaAccess.Checked)
            {
                cost += 20;
            }
            if(chkTowelService.Checked)
            {
                cost += 15;
            }


            lblTotalFee.Text = cost.ToString("c");
        }
    }
}
