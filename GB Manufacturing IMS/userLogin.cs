﻿using System;
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
        bool isNewInstall = false;
        projectDB db = new projectDB();
        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {
            //Check if ANY users exist exit if program does not detect network to prevent exploit.
            bool ping = db.PingHost("104.248.117.10");
            if (ping == false)
            {
                MessageBox.Show("No network detected. Program will close.");
                Application.Exit();
            }
            string query = "SELECT MAX(employeeID) FROM Employees";
            string result = db.getString(query);
            if (result == "1")
            {
                MessageBox.Show("No users were found in the system. Contact Technicial Support. If this is a new install, please enter default credentials below.");
                isNewInstall = true;
            }
        

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isNewInstall)
            {
                newInstall();
            }
            try
            {
               if(verifyCredentials(txtEmpID.Text, txtPW.Text))
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

        private bool verifyCredentials(string userID, string password)
        //Function to verify user information and return whether access is permitted or denied.
        {
            //Create database and user objects
            projectDB db = new projectDB();
            user currentUser = new user();

            //local variables
            int uid, rank = 0;
            string fname, lname, username, employmentStatus = null;
            bool verified = false;

            //************************************************encrypt password 
           password = db.encrypt(password);

            //Try to find the user int the database.
            try
            {
                //See if username and password match on database
                string query = "SELECT employeeID FROM Employees WHERE username='" + userID + "' AND userPass ='" + password + "';";
                verified = db.getBool(query, true);

                if (verified)
                {
                    //Set user information
                    uid = Convert.ToInt32(db.getString("SELECT employeeID FROM Employees WHERE username = '" + userID + "' AND userPass = '" + password + "'; "));
                    rank = Convert.ToInt32(db.getString("SELECT rank FROM Employees WHERE username = '" + userID + "' AND userPass = '" + password + "'; "));
                    fname = db.getString("SELECT firstName FROM Employees WHERE username = '" + userID + "' AND userPass = '" + password + "'; ");
                    lname = db.getString("SELECT lastName FROM Employees WHERE username = '" + userID + "' AND userPass = '" + password + "'; ");
                    employmentStatus = db.getString("SELECT employeeStatus FROM Employees WHERE username = '" + userID + "' AND userPass = '" + password + "'; ");
                    username = txtEmpID.Text;
                    currentUser.set(uid, rank, fname, lname, employmentStatus, username);
                    //verify everything worked

                    if (employmentStatus != "Active")
                    {
                        lblError.Visible = true;
                        return false;
                    }
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
            lblError.Visible = true;
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newInstall()
        {
            user currentUser = new user();
            if ((txtEmpID.Text == "SuperTech") & (txtPW.Text == "password"))
            {
                MessageBox.Show("Successful");
                //Proceed with login
                Main form = new Main(currentUser);
                form.Show();
                this.Hide();
            }
        }

    }
}
