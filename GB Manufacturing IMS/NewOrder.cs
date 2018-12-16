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
        private projectDB dbconn = new projectDB();
        private Color successColor = System.Drawing.Color.Blue;
        private Color errorColor = System.Drawing.Color.DarkRed;
        private user currentUser = new user();
        private DataTable orderSummaryTable = new DataTable();
        private DataTable inventorySearchTable = new DataTable();

        /* List to store itemNumber, jobCode, description, and quantity
         * Uses TempOrderInfo.cs
         * Reference: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.7.2
         * ************************************************************/
        private List<TempOrderInfo> orderInfo = new List<TempOrderInfo>();

        public NewOrder(user clone)
        {
            InitializeComponent();
            populateSummaryTable();                     // Add data grid view headers
            populateInventoryTable();
            currentUser = clone;
        }

        /* Create and populate Data Grid View headers
         * *  ***************************************/
        private void populateSummaryTable()
        {
            orderSummaryTable.Columns.Add("Item Number", typeof(int));
            orderSummaryTable.Columns.Add("Description", typeof(string));
            orderSummaryTable.Columns.Add("Quantity", typeof(int));

            orderSummary.DataSource = orderSummaryTable;    // Populate table headers
        }

        /* Create and populate Data Grid View headers
         * *  ***************************************/
        private void populateInventoryTable()
        {
            inventorySearchTable.Columns.Add("Item Number", typeof(int));
            inventorySearchTable.Columns.Add("Description", typeof(string));
            inventorySearchTable.Columns.Add("Number Available", typeof(int));

            intentoryTable.DataSource = inventorySearchTable;    // Populate table headers

            string query = "SELECT itemID AS 'Item Number', description AS Description, currentStock AS 'Number Available' FROM Materials WHERE (location = 'Warehouse 1' AND currentStock > 0)";
            dbconn.fill(intentoryTable, query);
        }

        /*  Adds item data to orderInfo list and displays it in order summary
         *  ***************************************/
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            // Get item descipriton and determine if itemNumber exists in the database
            string materialSearch = "SELECT description FROM Materials WHERE itemID = '" + itemNumber.Text + "' LIMIT 1";
            string result = dbconn.getString(materialSearch);

            // Hanle no matching item found in database
            if (result == null)
            {
                MessageBox.Show("Item number doesn't exist. Please try another item number.", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                itemValidityMessage.Text = "Invalid Item Number";
                itemValidityMessage.Visible = true;
                itemValidityMessage.ForeColor = errorColor;
                itemQuantity.Clear();
                itemNumber.Clear();
                itemNumber.Select();
            }
            else
            {
                itemValidityMessage.Visible = false;            // Hide invalid item number message

                // Retrieve item description from database
                string itemDescription = result;

                // Displays item in summary box and increments itemCount
                try
                {
                    if (Convert.ToInt32(itemQuantity.Text) < 1 || Convert.ToInt32(itemQuantity.Text) > 100)
                    {
                        MessageBox.Show("Please enter an item quantity between 1 and 100.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        // Add new order item to list
                        orderInfo.Add(new TempOrderInfo()
                        {
                            itemNumber = Convert.ToInt32(itemNumber.Text),
                            jobCode = Convert.ToInt32(jobCode.Text),
                            description = itemDescription,
                            quantity = Convert.ToInt32(itemQuantity.Text)
                        });

                        // Add item to data grid view
                        TempOrderInfo lastEntry = orderInfo.Last();
                        orderSummaryTable.Rows.Add(lastEntry.itemNumber, lastEntry.description, lastEntry.quantity);

                        submitOrderBtn.Enabled = true;
                        cancelBtn.Enabled = true;
                        itemNumber.Clear();
                        itemQuantity.Clear();
                        itemNumber.Select();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        /*  Inputs order data into database and resets the form
         *  ***************************************/
        private void submitOrderBtn_Click(object sender, EventArgs e)
        {
            int employeeID = currentUser.getID();     // Get from stored variable when login working

            string findMaxIDQuery = "SELECT MAX(orderID) FROM MaterialOrder LIMIT 1";
            string maxOrderID = dbconn.getString(findMaxIDQuery);
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
            submitOrderBtn.Enabled = false;
            cancelBtn.Enabled = false;
            addItemBtn.Enabled = false;

            // Delete list and data grid view
            orderInfo.Clear();
            orderSummaryTable.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void itemNumber_TextChanged(object sender, EventArgs e)
        {
            addItemBtn.Enabled = true;
        }

        /*  Populates inventory DGV based on search results
         *  ***************************************/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchDescription = searchBox.Text;
            string query = "SELECT itemID AS 'Item Number', description AS Description, currentStock AS 'Number Available' FROM Materials WHERE location = 'Warehouse 1' AND description LIKE '%"+ searchDescription + "%';";
            dbconn.fill(intentoryTable, query);
        }

        /*  Resets inventory DGV
         *  ***************************************/
        private void btnInventoryReset_Click(object sender, EventArgs e)
        {
            string query = "SELECT itemID AS 'Item Number', description AS Description, currentStock AS 'Number Available' FROM Materials WHERE (location = 'Warehouse 1' AND currentStock > 0)";
            dbconn.fill(intentoryTable, query);
        }

        /*  Populates item number when item clicked
         *  ***************************************/
        private void intentoryTable_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in intentoryTable.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                itemNumber.Text = row.Cells["Item Number"].Value.ToString();
            }
        }
    }
}
