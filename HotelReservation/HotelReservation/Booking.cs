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
using HotelReservation;

namespace HotelReservation
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet.reserve_table' table. You can move, or remove it, as needed.
            this.reserve_tableTableAdapter.Fill(this.hRDataSet.reserve_table);

            dataGridView1.DataSource = null;


        }

        private void Search_Click(object sender, EventArgs e)
        {
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

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog=HR;Integrated Security=True"))
            {
                conn.Open();

                // Check availability
                string availabilityQuery = "SELECT Room_ID, Room_Class, Available_Date, Price FROM reserve_table WHERE Room_Class = @Room_Class AND Available_Date = @Available_Date";
                using (SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, conn))
                {
                    availabilityCmd.Parameters.AddWithValue("@Room_Class", ClassType);
                    availabilityCmd.Parameters.AddWithValue("@Available_Date", Avail.Value.ToString("yyyy-MM-dd"));

                    using (SqlDataReader reader = availabilityCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Room is available, display the results
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            // Room is not available, show a message
                            MessageBox.Show("Room not available for the selected date and type.");

                            dataGridView1.DataSource = null;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var myForm = new Booking2();
            myForm.Show();
            Hide();
        }
    }
}
