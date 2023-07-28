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
    public partial class EmployeeSalary : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public EmployeeSalary()
        {
            InitializeComponent();
            ShowTotalSalary();
        }
        private void ShowTotalSalary()
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("SELECT SUM(Salary) FROM [Employee];", sc);
                sc.Open();
                int result1 = (int)cmd1.ExecuteScalar();
                lblTotalSalary.Text = result1.ToString() + " /- BDT";
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

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome home = new AdminHome();
            home.Show();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
