using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPTest3.UI
{
    public partial class Form1 : Form
    {
        /*
         smit kalavadiya
         */
        private List<Subscription> subscriptions = new List<Subscription>();
        private DigitalSubscription digitalSubscription;
        private PrintSubscription printSubscription;
        string name;
        decimal price;
        int volumenumber, issuenumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbVolume.DataSource = Subscription.OrderableVolumes(); 

            for (int i = 1; i <= Publication.AvailableIssues; i++)
            {
                cmbIssue.Items.Add(i);
            }


            cmbIssue.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //Implementation here
                name = txtPublicationName.Text;
                volumenumber = int.Parse(cmbVolume.SelectedItem.ToString());
                issuenumber = int.Parse(cmbIssue.SelectedItem.ToString());
                price = decimal.Parse(txtPrice.Text);
                Publication publication;

                if (rdoDigital.Checked == true)
                {
                    

                    publication = new Publication(name, volumenumber, issuenumber, price, MediaType.Digital);

                    if (digitalSubscription == null)
                    {
                        digitalSubscription = new DigitalSubscription(txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                        subscriptions.Add(digitalSubscription);
                        digitalSubscription.AddPublication(publication);
                        lblDigitalSubtotal.Text = digitalSubscription.CalculateSubscriptionPrice().ToString("c");
                        string data = name + ", " + volumenumber + ", " + issuenumber + ", " + price;
                        lstDigital.Items.Add(data);
                    }
                }
                if(rdoPrint.Checked == true)
                {
                    string fistName = txtFirstName.Text;
                    string lastName = txtLastName.Text;
                    string mailingAddress = txtMailingAddress.Text;
                    string city = txtCity.Text;
                    string province = txtProvince.Text;
                    string postalcode = txtPostalCode.Text;
                    publication = new Publication(name, volumenumber, issuenumber, price, MediaType.Print);
                    printSubscription = new PrintSubscription(fistName, lastName, mailingAddress, city, province, postalcode);
                    if (printSubscription == null)
                    {
                        subscriptions.Add(printSubscription);
                        printSubscription.AddPublication(publication);
                        lblPrint.Text = printSubscription.CalculateSubscriptionPrice().ToString("c");

                        string data = name + ", " + volumenumber + ", " + issuenumber + ", " + price;
                        lstPrint.Items.Add(data);
                    }
                }

                

                

                //End Implementation

                //Final step. Do not touch
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        
        #region [Given Helpers]

        private void ResetForm()
        {
            txtPublicationName.ResetText();
            txtPrice.ResetText();
            cmbIssue.SelectedIndex = 0;

            if (subscriptions.Count() > 0)
                grpPersonalInfo.Enabled = false;

            txtPublicationName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        { 
            RecurseControls(this.Controls);
            lstDigital.Items.Clear();
            lstPrint.Items.Clear();
            subscriptions = new List<Subscription>();
            lblDigitalSubtotal.ResetText();
            lblPrint.ResetText();
            lblTotal.ResetText();
            grpPersonalInfo.Enabled = true;
        }

        /// <summary>
        /// Call this to clear all the text of any texbox container in a container like a group box or panel
        /// </summary>
        /// <param name="controls"></param>
        private void RecurseControls(Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                switch (ctl)
                {
                    case GroupBox groupBox:
                        RecurseControls(ctl.Controls);
                        break;
                    case TextBox textBox:
                        textBox.ResetText();
                        break;
                }
            }
        }

        #endregion
    }
}
