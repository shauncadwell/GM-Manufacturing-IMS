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
        user currentUser = new user();

        public Intro(user clone)
        {
            InitializeComponent();
            currentUser = clone;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrderMaterials_Click(object sender, EventArgs e)
        {
            NewOrder orderMaterials = new NewOrder(currentUser);
            f.createWindow("Order Form", this, orderMaterials, true, true);
        }

        private void btnOrderEquipment_Click(object sender, EventArgs e)
        {


            OrderEquipment orderEquipment = new OrderEquipment(currentUser);
            f.createWindow("Order Equipment", this, orderEquipment, true, true);
        }

        private void btnSearchInv_Click(object sender, EventArgs e)
        {
            SearchInventory search = new SearchInventory(currentUser);
            f.createWindow("Inventory", this, search, true, true);
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            //testing cross object from main form;
        }

        private void btnReturnEquip_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This section is not yet available.", "Section Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EquipReturn equipRtn = new EquipReturn(currentUser);
            f.createWindow("Equipment Return", this, equipRtn, true, true);
        }
    }
}
