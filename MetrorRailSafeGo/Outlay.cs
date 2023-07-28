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

namespace MetrorRailSafeGo
{
    public partial class Outlay : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public Outlay()
        {
            InitializeComponent();
            showEarning();
            ShowBookingEarn();  
        }

        

        private void showEarning()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SUM(Price) FROM [Customer];", sc);
                sc.Open();
                int result = (int)cmd.ExecuteScalar();
                lblEarning.Text = result.ToString() + " /- BDT";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error = " + ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }

        private void ShowBookingEarn()
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("SELECT SUM(Price) FROM [Bookings];", sc);
                sc.Open();
                int result1 = (int)cmd1.ExecuteScalar();
                lblEarnBooking.Text = result1.ToString() + " /- BDT";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error = " + ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }

        private void bntback_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (CurrentUser.isAdmin)
            {
                this.Hide();
                AdminHome home = new AdminHome();
                home.Show();
            }
            else
            {
                this.Hide();
                ManagerHome Mhome = new ManagerHome();
                Mhome.Show();   

            }
        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text =  DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
