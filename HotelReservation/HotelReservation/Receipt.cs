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
    public partial class Receipt : Form
    {
        public static Receipt instance;
        public Label Lname;
        public Label Lcontact;
        public Label Lemail;
        public Label Lcheckin;
        public Label Lcheckout;
        public Label Lrtype;
        public Label Lprice;
        public Label Lnumberdays;
        public Label Lroom;
        public Receipt()
        {
            InitializeComponent();
            instance = this;
            Lname = LBname;
            Lcontact = LBContact;
            Lemail = LBEmail;
            Lcheckin = LCheckIn;
            Lcheckout = LCheckOut;
            Lrtype = RoomType;
            Lprice = LBPrice;
            Lnumberdays = LNumberofDays;
            Lroom = LRoomID;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            Hide();


        }
    }
}
