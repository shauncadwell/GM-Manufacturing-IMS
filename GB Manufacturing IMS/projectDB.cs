using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GB_Manufacturing_IMS
{
    class projectDB
    {

        string dbconn = "Server=104.248.117.10; Database=CEIS400;Uid=CEIS400;Pwd=group5;";

       public void fill(DataGridView dgv, string query)
        {
            /* This function takes a targetted datagridview and sql query and submits results into the DGV. */

            //Establish connection to database
            MySqlConnection conn = new MySqlConnection(dbconn);
            conn.Open();

            //Store data from database
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(query, conn);

            //Store data from adapter to table
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            //Store in binding source
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            //display on correct datagridview
            dgv.DataSource = bSource;
            conn.Close();
        }

        public bool runQuery(string cmd)
        {
            /* Function takes MySQL Query and manipulates database and will return success */

            return true;
        }

        public string getData(string query)
        {
            /*Function takes query and returns data as a string.*/

            string data;
            //Establish connection to database
            MySqlConnection conn = new MySqlConnection(dbconn);
        try
            {
                MySqlCommand myCommand = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader myReader;
      
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                //Store data from database
                data = myReader.GetString(0);
            }
            catch
            {
                // MessageBox.Show("No result found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                data = null;
            }
            conn.Close();
            return data;
        }

        


    }
}
