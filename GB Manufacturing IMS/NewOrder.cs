/************************************
 * NewOrder.cs                      *
 * Created: 11/28/18                *
 *                                  *
 * *********************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace GB_Manufacturing_IMS
{
    public partial class NewOrder : Form
    {
        projectDB mydb = new projectDB();
        /*
         * 4-Dimensional array for storing order items temporarily
         * itemNumber | jobCode | description | quantity
         * ******************************/
        string[,] tempOrderInfo;

        int itemCount = 0;      // Tracks the number of items ordered. Used for array placement
        string findMaxIDQuery = "SELECT MAX(orderID) FROM MaterialOrder LIMIT 1";

        public NewOrder()
        {
            InitializeComponent();
        }

        private void itemNumber_TextChanged(object sender, EventArgs e)
        {
            if (itemNumber.Text != "" && itemNumber.Text != " ")
            {
                verifyBtn.Enabled = true;
                itemValidityMessage.Visible = false;
            }
            else
            {
                verifyBtn.Enabled = false;
                itemValidityMessage.Visible = false;
            }
            
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            bool match = Regex.IsMatch(itemNumber.Text.ToString(), @"\0-9");        // Verify only numeric data present in input

            if (match)
            {
                string materialSearch = "SELECT description FROM Materials WHERE itemID = '" + itemNumber.Text + "' LIMIT 1";

                // Search database for equipment
                // If no match found, check material
                // If no match found in either table, set visibility of itemValidityMsg to true
                // If match found, display description and set text of itemValidityMsg to "Valid item" and change color to blue
                // Set quantity to 1
                // Enable add button
            }
            else
            {
                // Display error if item number contains non numeric data
                MessageBox.Show("Invalid item number. The item number must contain only numbers.", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                itemValidityMessage.Text = "Invalid Item Number";
                itemValidityMessage.Visible = true;
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string itemDescription = mydb.runQuery("SELECT descrption FROM Materials WHERE itemID = " + itemNumber.Text + " LIMIT 1");
            tempOrderInfo[itemCount, 0] = itemNumber.Text;
            tempOrderInfo[itemCount, 1] = jobCode.Text;
            tempOrderInfo[itemCount, 2] = itemDescription;          // Retrieved from database
            tempOrderInfo[itemCount, 3] = itemQuantity.Text;

            // Add item to an array and display in order preview
            // Verify quantity is numeric and between 1 and 100
        }

        private void submitOrderBtn_Click(object sender, EventArgs e)
        {
            // Create order entry in database
            // Display success message
            // Reset form
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Clear all form data
            // Delete items array
        }
    }
}
