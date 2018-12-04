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

        public OrderEquipment(user clone)
        {
            InitializeComponent();
            currentUser = clone;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Verify item and quantity are available in database and required rank
            string query = "SELECT count(*) FROM information_schema.columns WHERE table_name = 'Equipment'";
            int colCount = Convert.ToInt32(db.getData(query));
            DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            dgvPendingRental.Columns.Add(link);



            MessageBox.Show("info" + colCount);




            this.dgvPendingRental.Rows.Add("Five", "six", "seven", "eight", "[X]");
            //Add item to datagridview list to be put in pending


            
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            //Reduce available to available -quantity on Equipment table


            //If quantity = 0 then equipmentStatus will change to Out of Stock


            /*Create findMaxIDQuery = "SELECT MAX(orderID) FROM MaterialOrder LIMIT 1";
             * 
                string maxOrderID = dbconn.getData(findMaxIDQuery);

                int orderID = Convert.ToInt32(maxOrderID) + 1

                    INSERT INTO EquipmentRental (rentalID, rentalDate, rentalDue, employeeID, equipmentID, quantity, jobCode) VALUES
                    (1, NOW(), DATE_ADD(NOW(), INTERVAL 7 DAY), 1, 1, 2, 12345);
        
                 */

        }

        private void OrderEquipment_Load(object sender, EventArgs e)
        {
            dgvPendingRental.Columns.Clear();
            dgvPendingRental.Columns.Add("equipmentID", "Item Number");
            dgvPendingRental.Columns.Add("description", "Description");
            dgvPendingRental.Columns.Add("equipmentStatus", "Status");
            dgvPendingRental.Columns.Add("quantity", "Quantity");
        }
    }
}
