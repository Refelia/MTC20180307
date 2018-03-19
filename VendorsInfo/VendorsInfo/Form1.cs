using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace VendorsInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            // Set the data source of this control.
            vendorsListdataGridView.DataSource = GetvendorsList();
        }

        private DataTable GetvendorsList()
        {
            //Define the data table
            DataTable dtaVendors = new DataTable();

            //Declare a string variable
            string connstring = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connstring))

            {
                using (SqlCommand cmd = new SqlCommand("execute VendorsInformation", con))
                {
                    //Open the connection
                    con.Open();

                    //Get the data from database
                    SqlDataReader reader = cmd.ExecuteReader();

                    //Load data into the dtaVendors table.
                    dtaVendors.Load(reader);

                }
            }

                return dtaVendors;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form 
            this.Close();
        }
    }
}
