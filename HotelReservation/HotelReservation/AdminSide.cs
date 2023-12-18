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
    public partial class AdminSide : Form
    {
        public AdminSide()
        {
            InitializeComponent();
        }

        private void AdminSide_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet.reserve_table' table. You can move, or remove it, as needed.
            this.reserve_tableTableAdapter.Fill(this.hRDataSet.reserve_table);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            Hide();

        }

        private void RefreshData()
        {
            try
            {
                // Assuming you have a DataGridView named dataGridView1
                this.reserve_tableTableAdapter.Fill(this.hRDataSet.reserve_table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True"))
                {
                    conn.Open();

                    string ClassType = string.Empty;
                    if (Classic.Checked)
                    {
                        ClassType = "Classic";
                    }
                    else if (Deluxe.Checked)
                    {
                        ClassType = "Deluxe";
                    }
                    else
                    {
                        ClassType = "Executive";
                    }

                    using (SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT reserve_table ON; INSERT INTO reserve_table (Room_ID, Room_Class, Available_Date, Price) VALUES (@Room_ID, @Room_Class, @Available_Date, @Price); SET IDENTITY_INSERT reserve_table OFF;", conn))
                    {
                        cmd.Parameters.AddWithValue("@Room_ID", Room_ID.Text);
                        cmd.Parameters.AddWithValue("@Room_Class", ClassType);
                        cmd.Parameters.AddWithValue("@Available_Date", Avail.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Price", Price.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Saved");
                    }

                    // Refresh the data or update the UI with the latest information
                    RefreshData(); // Call the method to refresh your data
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // SQL Server error number for primary key violation
                {
                    MessageBox.Show("Duplicate Room_ID. Please choose a different Room_ID.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True"))
                {
                    conn.Open();

                    string ClassType = string.Empty;
                    if (Classic.Checked)
                    {
                        ClassType = "Classic";
                    }
                    else if (Deluxe.Checked)
                    {
                        ClassType = "Deluxe";
                    }
                    else
                    {
                        ClassType = "Executive";
                    }

                    SqlCommand cmd = new SqlCommand("UPDATE reserve_table SET Room_Class = @Room_Class, Available_Date = @Available_Date, Price = @Price WHERE Room_ID = @Room_ID", conn);
                    cmd.Parameters.AddWithValue("@Room_ID", Room_ID.Text);
                    cmd.Parameters.AddWithValue("@Room_Class", ClassType);
                    cmd.Parameters.AddWithValue("@Available_Date", Avail.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Price", Price.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful");
                        // Refresh the data or update the UI with the latest information
                        RefreshData(); // Call the method to refresh your data
                    }
                    else
                    {
                        MessageBox.Show("Room_ID not found. No update performed.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int roomIDColumnIndex = 0; // Change this index based on the actual position of Room_ID in your DataGridView
                string roomIDToDelete = dataGridView1.Rows[selectedIndex].Cells[roomIDColumnIndex].Value.ToString();


                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True"))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM reserve_table WHERE Room_ID = @Room_ID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Room_ID", roomIDToDelete);
                        cmd.ExecuteNonQuery();
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
