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

        private void btnLogin_Click(object sender, EventArgs e)
        {
        //    Main f = new Main("Shaun Cadwell");
            //remove this once program is ready   
         //   this.Hide();
         //   f.Show();
     
            //Remove close
            try
            {
               if(verifyCredentials(Convert.ToInt32(txtEmpID.Text), txtPW.Text))
                {
                    txtEmpID.Clear();
                    txtPW.Clear();
                    lblError.Visible = false;

 
                }
                
            }
            catch
            {
                lblError.Visible = true;
            }
        }

        private bool verifyCredentials(int userID, string password)
        //Function to verify user information and return whether access is permitted or denied.
        {
            //Create database and user objects
            projectDB db = new projectDB();
            user currentUser = new user();

            //local variables
            int uid, rank = 0;
            string fname, lname, employmentStatus = null;
            bool verified = false;
      


            //************************************************encrypt password DISABLE FOR NOW
           // password = db.encrypt(password);

            //Try to find the user int the database.
            try
            {
                //See if username and password match on database
                string query = "SELECT employeeID FROM Employees WHERE employeeID='" + userID + "' AND userPass ='" + password + "';";
                verified = db.getData(query, true);

                if (verified)
                {
                    //Set user information
                    uid = Convert.ToInt32(db.getData("SELECT employeeID FROM Employees WHERE employeeID = '" + userID + "' AND userPass = '" + password + "'; "));
                    rank = Convert.ToInt32(db.getData("SELECT rank FROM Employees WHERE employeeID = '" + userID + "' AND userPass = '" + password + "'; "));
                    fname = db.getData("SELECT firstName FROM Employees WHERE employeeID = '" + userID + "' AND userPass = '" + password + "'; ");
                    lname = db.getData("SELECT lastName FROM Employees WHERE employeeID = '" + userID + "' AND userPass = '" + password + "'; ");
                    employmentStatus = db.getData("SELECT employeeStatus FROM Employees WHERE employeeID = '" + userID + "' AND userPass = '" + password + "'; ");

                    currentUser.set(uid, rank, fname, lname, employmentStatus);
                    //verify everything worked
                    string msg = currentUser.getID() + " " + currentUser.getRank() + " " + currentUser.getFullName() + " " + currentUser.getStatus();
                    MessageBox.Show(msg);

                    //Proceed with login
                    Main form = new Main(currentUser);
                    form.Show();
                    this.Hide();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
