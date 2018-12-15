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
    public partial class EquipReturn : Form
    {
        projectDB mydb = new projectDB();
        user currentUser = new user();
        public EquipReturn(user clone)
        {
            InitializeComponent();
            currentUser = clone;
        }

        private void EquipReturn_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnSubmit_Click(object sender, EventArgs e)
        {
            //Passes values to right and adds Job Code so User can confirm he is returning the correct equipment
            lblChkBox1.Text = comboStatus.Text;
            comboStatus.Text = "";
            lblChkBox2.Text = txtReturnItem.Text;
            txtReturnItem.Text = "";
            //Job Code query to add to right side of view to confirm return.
            
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturnConfirm_Click(object sender, EventArgs e)
        {
            //Query sent to DB to add item back to stock depending on Status

            //Empties field so it is ready for another return
            lblChkBox1.Text = "";
            lblChkBox2.Text = "";
            lblChkBox3.Text = "";
            
        }
    }
}
