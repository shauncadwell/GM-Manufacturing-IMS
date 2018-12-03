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

    public partial class Main : Form
    {
        public user currentUser = new user();

        //LOAD ALL WINDOWS AND DIALOGS
        appForm f = new appForm();

        //App form objects will need to be created for each forum. 
        Inventory InventoryWindow = new Inventory();
        login loginWindow = new login();
        NewOrder newOrder = new NewOrder();

        // Comment is awesome + 1

        public Main()
        {
            InitializeComponent();
        }

        private void openForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void Main_Load(object sender, EventArgs e)
        {
        //Load login dialog
            f.createWindow("login", this, loginWindow, true);
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
                f.createWindow("Inventory", this, InventoryWindow, false);
        }

        private void adminToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeAllFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully.");
            //CLOSE ALL WINDOWS
            InventoryWindow.Hide();
            //Show login page
            f.createWindow("Login", this, loginWindow, true);

        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Create new order
            f.createWindow("New Order", this, newOrder, false);
        }
    }
}
