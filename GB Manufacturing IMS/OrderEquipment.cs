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
    public partial class OrderEquipment : Form
    {
        projectDB db = new projectDB();
        user currentUser = new user();
        DataTable dt = new DataTable();
        DataTable searchDT = new DataTable();
        int count = 0;
        //create lists for each column
        private List<TempOrderInfo> orderInfo = new List<TempOrderInfo>();


        public OrderEquipment(user clone)
        {
            InitializeComponent();
            currentUser = clone;
           
            loadTable();
        }

        public OrderEquipment(user clone, List<TempOrderInfo> order)
        {
            InitializeComponent();
            currentUser = clone;
            orderInfo = order;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Verify item and quantity are available in database and required rank
            try
            {
            string quantityReq = txtQuantity.Text;
                int currentQuantity = db.getInt("SELECT available FROM Equipment WHERE equipmentID =" + txtScanItem.Text + ";");

            int newQuantity = currentQuantity - Convert.ToInt32(quantityReq);
                if (newQuantity < 0)
                {
                    lblInformation.Text = "Not enough inventory to supply this order. \n\nContact Warehouse Personel or Inventory Management.";
                    lblInformation.ForeColor = Color.Red;
                    return;
                }

                string eqDescription = db.getString("SELECT description FROM Equipment WHERE equipmentID ='" + txtScanItem.Text + "';");
                

            string query = "SELECT equipmentID FROM Equipment WHERE (equipmentID = '"
            + txtScanItem.Text+"' AND equipmentStatus ='In Stock' AND requiredRank <='" 
            + currentUser.getRank()+ "' AND available>='"+quantityReq+"');";

        
             //If item is found:
            if (db.getBool(query, true))
                {
                        lblInformation.Text = "Item number: [" +txtScanItem.Text+ "]\n\nQuantity: ["+quantityReq+"] successfully added.";
                        lblInformation.ForeColor = Color.Blue;

                        // Add new order item to list
                        orderInfo.Add(new TempOrderInfo()
                        {
                            itemNumber = Convert.ToInt32(txtScanItem.Text),
                            jobCode = Convert.ToInt32(txtJobCode.Text),
                            description = eqDescription,
                            quantity = Convert.ToInt32(txtQuantity.Text)
                        });

                        // Add item to data grid view
                        TempOrderInfo lastEntry = orderInfo.Last();
                        dt.Rows.Add(lastEntry.itemNumber, lastEntry.description, lastEntry.quantity);    

            }
            else
            {
                lblInformation.Text = "Unable to add item. \nThis error will occur if the item is not in stock or does not exist. \n\n\nStock amount: " + currentQuantity + ". \n\n\nContact warehouse management if this problem persists.";
                lblInformation.ForeColor = Color.Red;          
            }
                      
            //Add item to datagridview list to be put in pending


            //Select field

            txtScanItem.Clear();
            txtScanItem.Select();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            count++;
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {

            int employeeID = currentUser.getID();     // Get from stored variable when login working

            string findMaxIDQuery = "SELECT MAX(rentalID) FROM EquipmentRental LIMIT 1";
            string maxOrderID = db.getString(findMaxIDQuery);
            int orderID = Convert.ToInt32(maxOrderID) + 1;

            foreach (TempOrderInfo item in orderInfo)
            {
                int setAvailable = (Convert.ToInt32(db.getInt("SELECT available FROM Equipment WHERE equipmentID='" + item.itemNumber + "';") - Convert.ToInt32(item.quantity)));
                string insertQuery = "INSERT INTO EquipmentRental (rentalID, rentalDate, rentalDue, employeeID, equipmentID, quantity, jobCode) " +
                                    "VALUES(" + orderID + ", CURDATE(), NOW()+INTERVAL 7 DAY,'" + employeeID + "'," + item.itemNumber + ", " + item.quantity + ", " + item.jobCode + "); ";
                           db.Update("UPDATE Equipment SET available = '" + setAvailable.ToString() + "' WHERE equipmentID= '"+ item.itemNumber + "';");

                //If equipment availability is 0 then set to Out of Stock
                if (setAvailable == 0)
                {
                    db.Insert("UPDATE Equipment SET equipmentStatus = 'Out of Stock' WHERE equipmentID = '" + item.itemNumber + "'");
                }

                bool querySuccess = db.Insert(insertQuery); // Error here - runQuery always returns true but insert is failing

                // Handle query failure
                if (!querySuccess)
                {
                    MessageBox.Show("Failed to place order. Please contact system administrator if problem persists.", "Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;  // Kick out of for loop if error encountered
                }
            }

            MessageBox.Show("Order placed successfully.", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetAll();
            //Reduce available to available -quantity on Equipment table


            //If quantity = 0 then equipmentStatus will change to Out of Stock


            /*Create findMaxIDQuery = "SELECT MAX(orderID) FROM MaterialOrder LIMIT 1";
             * 
                string maxOrderID = dbconn.getString(findMaxIDQuery);

                int orderID = Convert.ToInt32(maxOrderID) + 1

                    INSERT INTO EquipmentRental (rentalID, rentalDate, rentalDue, employeeID, equipmentID, quantity, jobCode) VALUES
                    (1, NOW(), DATE_ADD(NOW(), INTERVAL 7 DAY), 1, 1, 2, 12345);
        
                 */

        }

        private void OrderEquipment_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Item Number", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));

            searchDT.Columns.Add("Item Number", typeof(string));
            searchDT.Columns.Add("Description", typeof(string));
            searchDT.Columns.Add("Quantity", typeof(string));
        }

        private void loadTable()
        {




            dgvPendingRental.DataSource = dt;    // Populate table headers
            dgvSearch.DataSource = searchDT;

            string query = "SELECT equipmentID AS Equipment, description AS Description, available AS Available FROM Equipment WHERE (location = 'Warehouse 1' AND equipmentStatus = 'In Stock')";

            db.fill(dgvSearch, query);
        }

        private void resetAll()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear this order?", "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
            {
            orderInfo.Clear();
            dt.Clear();
                lblInformation.Text = null;
            }
   

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT equipmentID AS Equipment, description AS Description, available AS Available FROM Equipment WHERE (location = 'Warehouse 1' AND equipmentStatus = 'In Stock')";
            if (txtSearch.Text == null)
            {
                db.fill(dgvSearch, query);
            }
             query = "SELECT equipmentID AS Equipment, description AS Description, available AS Available FROM Equipment WHERE (location = 'Warehouse 1' AND equipmentStatus = 'In Stock' AND description LIKE '%"+ txtSearch.Text +"%')";
            db.fill(dgvSearch, query);

        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
