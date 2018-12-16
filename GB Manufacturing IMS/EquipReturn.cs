using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GB_Manufacturing_IMS
{
    public partial class EquipReturn : Form
    {
        projectDB mydb = new projectDB();
        user currentUser = new user();
        public EquipReturn(user clone)
        {
            InitializeComponent();
            currentUser = clone;
        }

        private void EquipReturn_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnSubmit_Click(object sender, EventArgs e)
        {
            //Passes values to right and adds Job Code so User can confirm he is returning the correct equipment
            bool comboEmpty = true;
        
            if (comboStatus.Text != "")
            {
                comboEmpty = false;
            }
            //Job Code query to add to right side of view to confirm return.
            if (comboEmpty == false && txtReturnItem.Text != "")
            {
                switch (comboStatus.Text)
                {
                    case "Working":
                        {
                            lblChkBox1.Text = "In Stock";
                            break;
                        }
                    case "Not Working":
                        {
                            lblChkBox1.Text = "Damaged";
                            break;
                        }
                    case "Missing":
                        {
                            lblChkBox1.Text = "Lost";
                            break;
                        }
                    case "Stolen":
                        {
                            lblChkBox1.Text = "Shrink";
                            break;
                        }
                }
                //Clears left side and populates right side for confirmation.
                comboStatus.Text = "";
                lblChkBox2.Text = txtReturnItem.Text;
                txtReturnItem.Text = "";
                
                //MySQL query to pull Job Code to confirm which item you are returning.
                //This step is to insure the User does not accidentally return the wrong item.
                string input1 = lblChkBox2.Text;
                string query1 = "SELECT jobCode FROM EquipmentRental WHERE equipmentID = " + input1 + "";
                mydb.fill(dgReturnJob, query1);
                lblReturnError.Text = "";
            }
            else
            {
                lblReturnError.Text = "Please fill out both fields.";
                txtReturnItem.Text = "";
                comboStatus.Text = "";
                lblChkBox1.Text = "";
                lblChkBox2.Text = "";
                dgReturnJob.DataSource = null;
            }
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturnConfirm_Click(object sender, EventArgs e)
        {
            //Query sent to DB to add item back to stock depending on Status
            /*
            string input2 = lblChkBox1.Text;
            string input3 = lblChkBox2.Text;
            string query2 = "SELECT jobCode FROM EquipmentRental WHERE equipmentID = " + input1 + "";
            */
            //mydb.fill(dgReturnJob, query2);
            //lblReturnError.Text = "";
            
            //Empties field so it is ready for another return
            lblChkBox1.Text = "";
            lblChkBox2.Text = "";
            dgReturnJob.DataSource = null;
            MessageBox.Show("Return complete");
        }
    }
}
