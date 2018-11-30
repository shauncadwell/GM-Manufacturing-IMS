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
                string equipmentSearch = "SELECT description FROM Equipment WHERE equipmentID = '" + itemNumber.Text + "' LIMIT 1";
                string materialSearch = "SELECT description FROM Materials WHERE itemID = '" + itemNumber.Text + "' LIMIT 1";

                // Search database for equipment
                // If no match found, check material
                // If no match found in either table, set visibility of itemValidityMsg to true
                // If match found, display description and set text of itemValidityMsg to "Valid item" and change color to blue
                // Set quantity to 1
                // Enable add button
            }
            
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
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
