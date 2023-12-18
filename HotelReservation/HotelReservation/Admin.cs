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
    public partial class Admin : Form
    {
        private string CONNECTION_STRING = @"Data Source=DESKTOP-NKHIKGR\SQLEXPRESS;Initial Catalog = HR; Integrated Security = True";
        public Admin()
        {
            InitializeComponent();
        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            string username = TFUSER.Text.ToString();
            string password = TFPASS.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("Enter Username and Password", "ERROR", MessageBoxButtons.OK);
            }
            else
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user_table WHERE username ='" + username + "' AND password = '" + password + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    AdminSide adm = new AdminSide();
                    adm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect");

                }

                conn.Close();
            }
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            Hide();
        }
    }
}
