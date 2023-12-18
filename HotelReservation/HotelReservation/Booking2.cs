using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelReservation
{
    public partial class Booking2 : Form
    {
        public static Booking2 instance;
        public DateTimePicker DTPcheckIn;
        public DateTimePicker DTPcheckOut;
        public RadioButton RBclassic;
        public RadioButton RBdeluxe;
        public RadioButton RBexecutive;
        public TextBox TBname;
        public TextBox TBcontact;
        public TextBox TBemail;
        private int selectedRoomID;
        public Booking2()
        {
            InitializeComponent();
            instance = this;
            DTPcheckIn = Avail;
            DTPcheckOut = CheckOut;
            RBclassic = Classic;
            RBdeluxe = Deluxe;
            RBexecutive = Executive;
            TBname = TName;
            TBcontact = TContact;
            TBemail = TEmail;
        }



        private void Booking2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet.reserve_table' table. You can move, or remove it, as needed.
            this.reserve_tableTableAdapter.Fill(this.hRDataSet.reserve_table);

            dataGridView1.DataSource = null;
            TBcontact.KeyPress += TBcontact_KeyPress;

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

        private void BOOK_Click(object sender, EventArgs e)
        {
            if (DTPcheckOut.Value < DTPcheckIn.Value)
            {
                MessageBox.Show("Check-out date cannot be earlier than check-in date.");
                return; // Exit the method
            }

            // Check if a room is selected
            if (selectedRoomID == 0)
            {
                MessageBox.Show("Please select a room before booking.");
                return; // Exit the method
            }

            var myForm = new Receipt();

           




            // Check which Room type is selected
            string ClassType = Classic.Checked ? "Classic" : (Deluxe.Checked ? "Deluxe" : "Executive");

            // Calculate the number of days
            int numberOfDays = (int)(DTPcheckOut.Value - DTPcheckIn.Value).TotalDays + 1;

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
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;


                            // Display Room_ID in the Lroom.Text
                            Receipt.instance.Lroom.Text = selectedRoomID.ToString();

                            decimal roomPrice = Convert.ToDecimal(dataTable.Rows[0]["Price"]);
                            decimal totalPrice = roomPrice * numberOfDays;

                            Receipt.instance.Lprice.Text = totalPrice.ToString();
                            Receipt.instance.Lrtype.Text = ClassType;
                            Receipt.instance.Lname.Text = TBname.Text;
                            Receipt.instance.Lcontact.Text = TBcontact.Text;
                            Receipt.instance.Lemail.Text = TBemail.Text;
                            Receipt.instance.Lcheckin.Text = DTPcheckIn.Value.ToString("yyyy-MM-dd");
                            Receipt.instance.Lcheckout.Text = DTPcheckOut.Value.ToString("yyyy-MM-dd");
                            Receipt.instance.Lnumberdays.Text = numberOfDays.ToString();

                            myForm.Show();
                            Hide();

                            //_________________________________________________________________________________________________
                            // Insert customer name and check-in date into the database
                            string insertBookingQuery = "INSERT INTO customer_table (Customer_Name, CheckIn, Price, Room_Class, Customer_Email, Customer_Contact, CheckOut) " +
                              "VALUES (@Customer_Name, @CheckIn, @Price, @Room_Class, @Customer_Email, @Customer_Contact, @CheckOut)";
                            // ...


                            using (SqlCommand insertBookingCmd = new SqlCommand(insertBookingQuery, conn))
                            {
                                insertBookingCmd.Parameters.AddWithValue("@Customer_Name", TBname.Text);
                                insertBookingCmd.Parameters.AddWithValue("@CheckIn", Avail.Value.ToString("yyyy-MM-dd"));
                                insertBookingCmd.Parameters.AddWithValue("@Price", totalPrice); // Remove ToString() here
                                insertBookingCmd.Parameters.AddWithValue("@Room_Class", ClassType);
                                insertBookingCmd.Parameters.AddWithValue("@Customer_Email", TBemail.Text);
                                insertBookingCmd.Parameters.AddWithValue("@Customer_Contact", TBcontact.Text);
                                insertBookingCmd.Parameters.AddWithValue("@CheckOut", DTPcheckOut.Value.ToString("yyyy-MM-dd"));


                                // Execute the INSERT operation
                                insertBookingCmd.ExecuteNonQuery();
                                //_________________________________________________________________________________________________
                            }
                            // Remove the booked room from the reserve_table
                            string removeRoomQuery = "DELETE FROM reserve_table WHERE Room_ID = @Room_ID";
                            using (SqlCommand removeRoomCmd = new SqlCommand(removeRoomQuery, conn))
                            {
                                removeRoomCmd.Parameters.AddWithValue("@Room_ID", selectedRoomID);

                                // Execute the DELETE operation
                                removeRoomCmd.ExecuteNonQuery();
                            }

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

        private void Select_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the selected Room_ID from the first selected cell in the first selected row
                selectedRoomID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["roomIDDataGridViewTextBoxColumn"].Value);

                MessageBox.Show($"Room {selectedRoomID} is selected.");
            }
            else
            {
                MessageBox.Show("No rows selected in the data grid view.");
            }
        }
        private void TBcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input and control keys (e.g., backspace, delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the character
            }
        }
    }
}
