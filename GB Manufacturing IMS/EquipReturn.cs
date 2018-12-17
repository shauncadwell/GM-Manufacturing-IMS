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
            txtReturnEID.Text = currentUser.getID().ToString();
            comboStatus.SelectedIndex = 0;
            txtReturnItem.Select();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnSubmit_Click(object sender, EventArgs e)
        {
            //Passes values to right and adds Job Code so User can confirm he is returning the correct equipment
            bool comboEmpty = true;

            try {
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
                                lblChkBox1.Text = "Returned";
                                break;
                            }
                        case "Not Working":
                            {
                                lblChkBox1.Text = "Damaged";
                                break;
                            }
                    }
                    //Clears left side and populates right side for confirmation.
                    comboStatus.SelectedIndex = 0;
                    lblChkBox2.Text = txtReturnItem.Text;
                    txtReturnItem.Text = null;
                    lblChkBox3.Text = txtReturnEID.Text;


                    //MySQL query to pull Job Code to confirm which item you are returning.
                    //This step is to insure the User does not accidentally return the wrong item.
                    string input1 = lblChkBox2.Text;
                    string input2 = lblChkBox3.Text;
                    string query1 = "SELECT jobCode FROM EquipmentRental WHERE equipmentID LIKE '%" + input1 + "%' AND employeeID LIKE '%" + currentUser.getID().ToString() + "%'";
                    lblJobCode.Text = (mydb.getString(query1));
                    string query2 = "SELECT rentalID FROM EquipmentRental WHERE equipmentID LIKE '%" + input1 + "%' AND employeeID LIKE '%" + currentUser.getID().ToString() + "%'";
                    lblRentalID.Text = (mydb.getString(query2));;
                    lblReturnError.Text = "";
                }

                else
                {
                    lblReturnError.Text = "Please fill out both fields.";
                    txtReturnItem.Text = "";
                    comboStatus.Text = "";
                    lblChkBox1.Text = "";
                    lblChkBox2.Text = "";
                    lblChkBox3.Text = "";

                }
            }
        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
            //Pulls values from right side jobCode and rentalID for insert query
            string insert1 = lblChkBox1.Text;
            string insert2 = lblChkBox2.Text;
            string insert3 = lblChkBox3.Text;
            string insert4 = lblRentalID.Text = "...";
            string insert5 = lblJobCode.Text = "...";

           
                /*
                string isReturnedChk = "SELECT returnDate FROM EquipmentRental WHERE equipmentID LIKE '%" + insert2 + "%' AND employeeID LIKE '%" + insert3 + "%' AND jobCode LIKE '%" + insert4 + "%' AND rentalID LIKE '%" + insert5 + "%'";
                string checkReturn = mydb.getString(isReturnedChk);

                if (checkReturn != null)
                {
                */
                    string query3 = "UPDATE CEIS400.EquipmentRental SET returnDate=NOW() WHERE equipmentID='" + insert2 + "' AND employeeID='" + insert3 + "' AND jobCode='" + insert4 + "' AND rentalID='" + insert5 + "'";
                    mydb.Update(query3);
                    string query4 = "UPDATE CEIS400.Equipment SET available=available+1 WHERE equipmentStatus='" + insert1 + "' AND equipmentID= '" + insert2 + "'";
                    mydb.Update(query4);
                /*
                }
                else
                {
                    MessageBox.Show("This item has already been returned.");
                }
                */
             }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Empties field so it is ready for another return
            lblChkBox1.Text = "";
            lblChkBox2.Text = "";
            lblChkBox3.Text = "";
            MessageBox.Show("Return complete");
        }
    }
}
