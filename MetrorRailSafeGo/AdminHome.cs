using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MetrorRailSafeGo
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void lblemp_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee emp = new AddEmployee();
            emp.Show();

        }

        private void lblstations_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStation station = new AddStation();
            station.Show();
        }

        private void lblearnings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Outlay earn = new Outlay();
            earn.Show();
        }

        private void lblbookings_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBookedTickets book = new ViewBookedTickets();
            book.Show();
        }

        private void lblschedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Train_schedule_admin scheme = new Train_schedule_admin();
            scheme.Show();
        }

        private void lblfeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FeedbackAdmin adminF = new FeedbackAdmin();
            adminF.Show();
        }

        private void pictureBox_logout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login log = new Login();
            log.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureBox_bg_Click(object sender, EventArgs e)
        {

        }

        private void AdminHome_Load_1(object sender, EventArgs e)
        {
            panel_employee.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_booking.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_earning.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_station.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_trainScheme.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_feedback.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_customer.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_notice.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel_salary.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void lblCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomer customer = new ViewCustomer();
            customer.Show();

        }

        private void lblEmpSalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeSalary empSalary = new EmployeeSalary();
            empSalary.Show();

        }

        private void lblNotice_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoticeSend notice = new NoticeSend();
            notice.Show();
        }
    }
}
