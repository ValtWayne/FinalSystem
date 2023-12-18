using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNBOOK_Click(object sender, EventArgs e)
        {
            var myForm = new Booking();
            myForm.Show();
            Hide();

        }

        private void BTNADMIN_Click(object sender, EventArgs e)
        {
            var myForm = new Admin();
            myForm.Show();
            Hide();

        }

        private void BTNMANAGE_Click(object sender, EventArgs e)
        {

            var myForm = new Manage();
            myForm.Show();
            Hide();
        }
    }
}
