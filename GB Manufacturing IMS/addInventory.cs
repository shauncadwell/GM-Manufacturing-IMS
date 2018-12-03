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
  
    public partial class addInventory : Form
    {
        projectDB db = new projectDB();
        public addInventory()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Testing insert 
            bool isInserted;
            isInserted = db.Insert(txtItemNumber.Text);
            MessageBox.Show("Result of insert is: " + isInserted);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
