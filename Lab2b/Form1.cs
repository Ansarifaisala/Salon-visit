using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///I, Mohammed Faisal Ansari, 000812671 certify that this material is my original work.
///No other person's work has been used without due acknowledgement.
namespace Lab2b
{
    /// <summary>
    /// My program changes value of variables whenever user changes the options
    /// this makes my coding shorter and avoided coding everything on calculate button!
    /// </summary>
    public partial class Form1 : Form
    {
        double totalprice = 0;
        double baseprice = 30; // Base price for Hair Dresser
        double servicecharge = 0; // Service Price
        double clientdiscount = 0;
        double visitdiscount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        { 
        }


        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 45;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void HairDresserRB1_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 30;
        }

        private void ClientVisitTB_TextChanged(object sender, EventArgs e)
        {
            double check;
            if (Double.TryParse(ClientVisitTB.Text, out check) == true)
            {
                if (double.Parse(ClientVisitTB.Text) >= 4 && double.Parse(ClientVisitTB.Text) <= 8)
                {
                    visitdiscount = ((baseprice + servicecharge) * 5) / 100;
                }
                else if (double.Parse(ClientVisitTB.Text) >= 9 && double.Parse(ClientVisitTB.Text) <= 13)
                {
                    visitdiscount = ((baseprice + servicecharge) * 10) / 100;
                }
                else if (double.Parse(ClientVisitTB.Text) >= 14)
                {
                    visitdiscount = ((baseprice + servicecharge) * 15) / 100;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TotalPriceLabel.Text = "";
            HairDresserRB1.Focus();
            HairDresserRB2.Checked = false;
            HairDresserRB3.Checked = false;
            HairDresserRB4.Checked = false;
            HairDresserRB5.Checked = false;
            ClientRB1.Focus();
            ClientRB2.Checked = false;
            ClientRB3.Checked = false;
            ClientRB4.Checked = false;
            ClientVisitTB.Text = "";
            ServiceCB1.Checked = false;
            ServiceCB2.Checked = false;
            ServiceCB3.Checked = false;
            ServiceCB4.Checked = false;
            CalculateButton.Focus();
            totalprice = 0;
            servicecharge = 0;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double check;
            totalprice = 0;

            if (ServiceCB1.Checked == false && ServiceCB2.Checked == false && ServiceCB3.Checked == false && ServiceCB4.Checked == false)
            {
                MessageBox.Show("You Must Select At least one Services", "Missing Service(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ClientVisitTB.Text == "" || Double.TryParse(ClientVisitTB.Text, out check) == false)
            {
                MessageBox.Show("Please Provide a valid Number of visits!","Please provide A Numebr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClientVisitTB.Focus();
            }
            else
            {
               totalprice += baseprice+servicecharge-clientdiscount-visitdiscount;
                    TotalPriceLabel.Text = totalprice.ToString("0.00");
                
            }
            
        }

        private void ClientRB1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HairDresserRB3_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 40;
        }

        private void HairDresserRB4_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 50;
        }

        private void HairDresserRB5_CheckedChanged(object sender, EventArgs e)
        {
            baseprice = 55;
        }

        private void ServiceCB1_CheckedChanged(object sender, EventArgs e)
        {
            if (ServiceCB1.Checked)
            {
                servicecharge += 30;
            }
            else
            {
                servicecharge -= 30;
            }
        }

        private void ServiceCB2_CheckedChanged(object sender, EventArgs e)
        {
            if (ServiceCB2.Checked)
            {
                servicecharge += 40;
            }
            else
            {
                servicecharge -= 40;
            }
        }

        private void ServiceCB3_CheckedChanged(object sender, EventArgs e)
        {
            if (ServiceCB3.Checked)
            {
                servicecharge += 50;
            }
            else
            {
                servicecharge -= 50;
            }
        }

        private void ServiceCB4_CheckedChanged(object sender, EventArgs e)
        {
            if (ServiceCB4.Checked)
            {
                servicecharge += 200;
            }
            else
            {
                servicecharge -= 200;
            }
        }

        private void ClientRB2_CheckedChanged(object sender, EventArgs e)
        {
            clientdiscount = ((baseprice + servicecharge) * 10) / 100;
        }

        private void ClientRB3_CheckedChanged(object sender, EventArgs e)
        {
            clientdiscount = ((baseprice + servicecharge) * 5) / 100;
        }

        private void ClientRB4_CheckedChanged(object sender, EventArgs e)
        {
            clientdiscount = ((baseprice + servicecharge) * 15) / 100;
        }
    }
}
