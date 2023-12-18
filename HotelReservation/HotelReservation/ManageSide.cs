using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class ManageSide : Form
    {
        public ManageSide()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            try
            {
                // Assuming you have a DataGridView named dataGridView1
                this.customer_tableTableAdapter.Fill(this.hRDataSet.customer_table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        private void ManageSide_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet1.customer_table' table. You can move, or remove it, as needed.
            this.customer_tableTableAdapter1.Fill(this.hRDataSet1.customer_table);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int CustomerIDColumnIndex = 0; // Change this index based on the actual position of Room_ID in your DataGridView
                string CustomerIDToDelete = dataGridView1.Rows[selectedIndex].Cells[CustomerIDColumnIndex].Value.ToString();


                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True"))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM customer_table WHERE Customer_ID = @Customer_ID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Customer_ID", CustomerIDToDelete);
                        cmd.ExecuteNonQuery();
                    }

                  //____________________________________________________________________________________________________
                    string resetIdentityQuery = "DBCC CHECKIDENT (customer_table, RESEED, 0)";
                    using (SqlCommand resetIdentityCmd = new SqlCommand(resetIdentityQuery, conn))
                    {
                        resetIdentityCmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView or update your data source
                // dataGridView1.DataSource = ...; // Update your data source here
                MessageBox.Show("Item deleted successfully.");
                // Refresh the data or update the UI with the latest information
                RefreshData(); // Call the method to refresh your data

            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
