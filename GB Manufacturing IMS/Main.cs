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


        //LOAD ALL WINDOWS AND DIALOGS
        appForm f = new appForm();
        user currentUser = new user();
        //App form objects will need to be created for each forum. 
       
 
       // 
        // Comment is awesome + 1

        public Main(user userInfo)
        {
            InitializeComponent();
            //Set UserID information 
            currentUser = userInfo;
            
        }


        private void Main_Load(object sender, EventArgs e)
        {
            //Load login dialog  
            Intro startup = new Intro(currentUser);
            f.createWindow("Startup", this, startup, false, false);
            statusLabel.Text = "Logged in as " + currentUser.getFullName();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchInventory InventoryWindow = new SearchInventory(currentUser);
            f.createWindow("Inventory", this, InventoryWindow, false, false);
        }

        private void adminToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userManagement usermgmt = new userManagement(currentUser);
            f.createWindow("User Management", this, usermgmt, true, true);
   
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //not yet implemented.
        }

        private void closeAllFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully.");
            //CLOSE ALL WINDOWS
            this.Close();
            //Show login page
            login loginWindow = new login();
            f.createWindow("Login", this, loginWindow, true, false);

        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Create new order
            NewOrder newOrder = new NewOrder(currentUser);
            f.createWindow("New Order", this, newOrder, false, false);
        }

        private void enterInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addInventory invControl = new addInventory(currentUser);
            f.createWindow("enterInventory", this, invControl, false, false);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Show login page
            Application.Exit();
        }
    }


}
