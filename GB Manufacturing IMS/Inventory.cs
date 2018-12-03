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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            projectDB mydb = new projectDB();
            string sqlcmd = "SELECT * FROM Equipment";
            mydb.fill(dataGridView1, sqlcmd);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Not needed.
        }

        private void btnSubimit(object sender, EventArgs e)
        {
            //Submit search
        }
    }
}
