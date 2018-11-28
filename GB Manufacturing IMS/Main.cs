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
        Inventory InventoryWindow = new Inventory();
        login loginWindow = new login();


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
            //validate rank before allowing to enter
            if(currentUser.getRank() < 0)
            {
                MessageBox.Show("You cannot access this area.");
            }
            else
            {  
                f.createWindow("Inventory", this, InventoryWindow, false);
            }
         
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


    }
}
