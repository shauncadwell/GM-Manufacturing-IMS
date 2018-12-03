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
    public partial class Intro : Form
    {
        appForm f = new appForm();
        NewOrder orderMaterials = new NewOrder();
        OrderEquipment orderEquipment = new OrderEquipment();
        SearchInventory search = new SearchInventory();

        public Intro()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrderMaterials_Click(object sender, EventArgs e)
        {
            f.createWindow("Order Form", this, orderMaterials, false, true);
        }

        private void btnOrderEquipment_Click(object sender, EventArgs e)
        {
            f.createWindow("Order Equipment", this, orderEquipment, false, true);
        }

        private void btnSearchInv_Click(object sender, EventArgs e)
        {
            f.createWindow("Inventory", this, search, false, true);
        }
    }
}
