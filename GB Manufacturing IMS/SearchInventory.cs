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
    public partial class SearchInventory : Form
    {
        projectDB mydb = new projectDB();
        user currentUser = new user();
        public SearchInventory(user clone)
        {
            InitializeComponent();
            currentUser = clone;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            cbSelectTable.SelectedIndex = 0;
        }

        private void btnSubimit(object sender, EventArgs e)
        {
            if(cbSelectTable.Text != "")
            {
                
                string table = cbSelectTable.Text;
                string query = "SELECT * FROM " + table + " WHERE description LIKE '%" + txtKeyword.Text + "%'";
                mydb.fill(searchTable, query);
                lblError.Text = null;
            }
            else
            {
                lblError.Text = "An error has occurred. Please fill out all fields.";
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
