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
        //Establish user and database connections
        user currentUser = new user();
        projectDB db = new projectDB();
        public int selectedID;
        public userManagement(user clone)
        {
            InitializeComponent();
            currentUser = clone;
            refreshTable();         
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text != null)
            {
                string query = "SELECT employeeID,  firstName, lastName, username, rank, employeeStatus FROM Employees WHERE CONCAT(firstName, ' ', lastName) LIKE '%" + txtSearchEmployee.Text + "%'";

                db.fill(dgvSearchEmployees, query);
                           
            }
            else
            {
            }
        }

        private void dgvSearchEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvSearchEmployees.Rows[index];

            selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
            txtFirst.Text = selectedRow.Cells[1].Value.ToString();
            txtLast.Text = selectedRow.Cells[2].Value.ToString();
            txtUsername.Text = selectedRow.Cells[3].Value.ToString();
            cbRank.Text = selectedRow.Cells[4].Value.ToString();
            cboStatus.Text = selectedRow.Cells[5].Value.ToString();
            btnResetPw.Enabled = true;
            }
            catch

            {

            }
       
        }

        private void lnkEditFirst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtFirst.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void lnkEditLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtLast.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void lblEditUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsername.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void lnkEditRank_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbRank.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void lnkEditStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cboStatus.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void cboStatus_DisplayMemberChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to commit these changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Update database with correseponding information
                int rank =Convert.ToInt32(cbRank.Text);
                string fname = txtFirst.Text;
                string lname = txtLast.Text;
                string username = txtUsername.Text;
                string status = cboStatus.Text;
                int id = selectedID;

                string query = "UPDATE Employees SET firstName = '" + fname + "', lastName ='" + lname + "', username = '" + username + "', rank =" + rank + ", employeeStatus = '" + status + "' WHERE employeeID =" + id + ";";
                if (db.Update(query))
                {
                    MessageBox.Show("Successfully updated user.");
                    resetFields();
                }
                else
                {
                    MessageBox.Show("An error occurred while updating this employees data. Contact Technicial Support. ID # ID10T");
                }
            }
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset this users password?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Force user to create new password next time he logs in.

                MessageBox.Show("Not yet implemented.");
            }
        }

        private void resetFields()
        {
            //lock all data down again
            txtFirst.Clear();
            txtLast.Clear();
            txtUsername.Clear();
            cbRank.Text = "0";
            cboStatus.Text = "Inactive";

            //set selected out of range as precaution
            selectedID = 999999;

            //Disable controls
            txtFirst.Enabled = false;
            txtLast.Enabled = false;
            txtUsername.Enabled = false;
            cbRank.Enabled = false;
            cboStatus.Enabled = false;

            //reset buttons
            btnUpdate.Enabled = false;
            btnResetPw.Enabled = false;


            //select search field
            txtSearchEmployee.Select();
            refreshTable();
        }

        private void refreshTable()
        {
            string query = "SELECT employeeID, firstName, lastName, username, rank, employeeStatus FROM Employees";

            db.fill(dgvSearchEmployees, query);

            dgvSearchEmployees.Columns[0].HeaderText = "ID";
            dgvSearchEmployees.Columns[1].HeaderText = "First";
            dgvSearchEmployees.Columns[2].HeaderText = "Last";
            dgvSearchEmployees.Columns[3].HeaderText = "Username";
            dgvSearchEmployees.Columns[4].HeaderText = "Rank";
            dgvSearchEmployees.Columns[5].HeaderText = "Status";
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            //set variables
            string first, last, status, rank, username, password;
            first = txtAddFName.Text;
            last = txtAddLName.Text;
            rank = cbAddRank.Text;
            status = cbNewStatus.Text;
            username = txtAddUsername.Text;
            password = txtAddPassword.Text;

            //encrypt password
            password = db.encrypt(password);


            //Attempt to insert into database
            string query = "INSERT INTO Employees(firstName, lastName, username, userPass, rank, employeeStatus) " +
                " VALUES ('" + first + "', '" + last + "', '" + username + "', '" + password + "', " + rank + ", '" + status + "')";

            if (db.Insert(query))
            {
                MessageBox.Show("Employee was successfully added.");
            }
            else
            {
                MessageBox.Show("An error has occured while connecting to the database. Please contact Technicial Support.");
            }

       

        }
    }
}
