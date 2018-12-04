﻿/************************************
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
        private projectDB dbconn = new projectDB();
        private Color successColor = System.Drawing.Color.Blue;
        private Color errorColor = System.Drawing.Color.DarkRed;

        /* List to store itemNumber, jobCode, description, and quantity
         * Uses TempOrderInfo.cs
         * Reference: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2
         * ************************************************************/
        private List<TempOrderInfo> orderInfo = new List<TempOrderInfo>();

        public NewOrder()
        {
            InitializeComponent();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            // Get item descipriton and determine if itemNumber exists in the database
            string materialSearch = "SELECT description FROM Materials WHERE itemID = '" + itemNumber.Text + "' LIMIT 1";
            string result = dbconn.getData(materialSearch);

            if (result == null)
            {
                MessageBox.Show("Item number doesn't exist. Please try another item number.", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                itemValidityMessage.Text = "Invalid Item Number";
                itemValidityMessage.Visible = true;
                itemValidityMessage.ForeColor = errorColor;
                if (addItemBtn.Enabled == true)
                    addItemBtn.Enabled = false;
            }
            else
            {
                itemValidityMessage.Visible = false;

                // Retrieve item description from database
                string itemDescription = result;

                // Adds new order item to list
                orderInfo.Add(new TempOrderInfo()
                {
                    itemNumber = Convert.ToInt32(itemNumber.Text),
                    jobCode = Convert.ToInt32(jobCode.Text),
                    description = itemDescription,
                    quantity = Convert.ToInt32(itemQuantity.Text)
                });

                // Displays item in summary box and increments itemCount
                if (Convert.ToInt32(itemQuantity.Text) < 1 || Convert.ToInt32(itemQuantity.Text) > 100)
                {
                    MessageBox.Show("Please enter an item quantity between 1 and 100.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Populate "Order Summary Box"
                    string orderSummaryText = "";
                    foreach (TempOrderInfo order in orderInfo)
                    {
                        orderSummaryText += order.displayEntry();
                    }
                    orderSummary.Text = orderSummaryText;

                    submitOrderBtn.Enabled = true;
                    cancelBtn.Enabled = true;
                }
            }
        }

        /*  Inputs order data into database and resets the form
         *  ***************************************/
        private void submitOrderBtn_Click(object sender, EventArgs e)
        {
            int employeeID = 1;     // Get from stored variable when login working

            string findMaxIDQuery = "SELECT MAX(orderID) FROM MaterialOrder LIMIT 1";
            string maxOrderID = dbconn.getData(findMaxIDQuery);
            int orderID = Convert.ToInt32(maxOrderID) + 1;

            foreach (TempOrderInfo item in orderInfo)
            {
                string insertQuery = "INSERT INTO MaterialOrder (orderID, orderDate, itemID, quantity, employeeID, jobCode) " +
                                    "VALUES("+ orderID +", CURDATE(), "+ item.itemNumber +", "+ item.quantity +", "+ employeeID +", "+ item.jobCode +")";
                
                bool querySuccess = dbconn.Insert(insertQuery); // Error here - runQuery always returns true but insert is failing
                
                // Handle query failure
                if (!querySuccess)
                {
                    MessageBox.Show("Failed to place order. Please contact system administrator if problem persists.", "Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;  // Kick out of for loop if error encountered
                }
            }

            MessageBox.Show("Order placed successfully.", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetForm();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        /*  Clears all data in the form and deletes orderInfo list
         *  ***************************************/
        private void resetForm()
        {
            // Clear all form data
            jobCode.Text = "";
            itemNumber.Text = "";
            itemQuantity.Text = "";
            orderSummary.Text = "";
            submitOrderBtn.Enabled = false;
            cancelBtn.Enabled = false;
            addItemBtn.Enabled = false;

            // Delete items list
            orderInfo.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void itemNumber_TextChanged(object sender, EventArgs e)
        {
            addItemBtn.Enabled = true;
        }
    }
}
