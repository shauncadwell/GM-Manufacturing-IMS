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
       
        SearchInventory InventoryWindow = new SearchInventory();
        login loginWindow = new login();
        Intro startup = new Intro();
        NewOrder newOrder = new NewOrder();

        // Comment is awesome + 1

        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            //Load login dialog
            f.createWindow("Startup", this, startup, false, false);
            f.createWindow("login", this, loginWindow, true, false);
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
                f.createWindow("Inventory", this, InventoryWindow, false, false);
        }

        private void adminToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not yet implemented.
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //not yet implemented.
        }

        private void closeAllFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully.");
            //CLOSE ALL WINDOWS
            InventoryWindow.Hide();
            //Show login page
            f.createWindow("Login", this, loginWindow, true, false);

        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Create new order
            f.createWindow("New Order", this, newOrder, false, false);
        }
    }
}
