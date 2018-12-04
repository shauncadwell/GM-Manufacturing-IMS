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
    public partial class userManagement : Form
    {
        user currentUser = new user();
        public userManagement(user clone)
        {
            InitializeComponent();
            currentUser = clone;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployee_TextChanged(object sender, EventArgs e)
        {
            /*
            if (txtEmployee != NULL)
            {
                string query = "SELECT * FROM Employees WHERE firstName LIKE '%" + txtEmployee.Text + "%'";
                mydb.fill(searchTable, query);
                lblError.Text = null;
            }
            else
            {
                lblError.Text = "An error has occurred. Please fill out all fields.";
            }
            */
        }


    }
}
