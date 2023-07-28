using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetrorRailSafeGo
{
    public partial class ManagerHome : Form
    {
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void pictureBox_stations_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblemp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddCustomer customer = new AddCustomer();
            customer.Visible = true;

        }

        private void lblstations_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ViewStations stations = new ViewStations();
            stations.Visible = true;
        }

        private void lblschedule_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            Train_Scheme Tscheme = new Train_Scheme();
            Tscheme.Visible = true;
        }

        private void lblearnings_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Outlay outlay = new Outlay();
            outlay.Visible = true;
        }

        private void ManagerHome_load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void pictureBox_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();

        }

        private void lblbookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bookings book = new Bookings();
            book.Show();
        }

        private void lblMyProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrentUser.Profile.Show();
        }

        private void lblfeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback text = new Feedback();
            text.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnstations_Click(object sender, EventArgs e)
        {
            
        }

        private void lblNotice_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoticeRecieve recieve = new NoticeRecieve();
            recieve.Show();
        }

        private void lblAvailableSt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAvailableStations Available = new ViewAvailableStations();
            Available.Show();
        }

        private void ManagerHome_Load_1(object sender, EventArgs e)
        {
            panel_availableStations.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_bookings.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_customers.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_feedback.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_notice.BackColor = Color.FromArgb(100, 0, 0, 0);  
            panel_outlay.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_profile.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_stations.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_trainScheme.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
