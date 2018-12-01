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
        int row = 0;
        int col = 0;
        string dbconn = "Server=104.248.117.10; Database=CEIS400;Uid=CEIS400;Pwd=group5;";

       public void fill(DataGridView dgv, string cmd, bool needCart)
        {

            //Establish connection to database
            MySqlConnection conn = new MySqlConnection(dbconn);
            conn.Open();

            //Store data from database
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(cmd, conn);

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

        public void add(string cmd)
        {
            //Establish connection to database
            MySqlConnection conn = new MySqlConnection(dbconn);
            conn.Open();

            //Store data from database
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(cmd, conn);
            conn.Close();
        }


    }
}
