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
        public OrderEquipment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Verify item is available in database

            //Add item to datagridview list to be put in pending


            
        }
    }
}
