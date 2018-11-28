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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //See if user is already logged in

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Login as user
            Main f = new Main();
            f.currentUser.set(9999, 3, "Shaun", "Cadwell", "Employed");
            string message = "You have been logged in as " + f.currentUser.getFullName() ;
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
