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
    
    public partial class ViewCustomer : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome admin = new AdminHome();
            admin.Show();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                dgvCustomer.DataSource = dc.DataRetrivation("SELECT Id,Name,Age,Gender,PhoneNum,Address,NoOfTicket,Price FROM [Customer]");

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

        private void printDocument_Printpage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgvCustomer.Width, dgvCustomer.Height);
            dgvCustomer.DrawToBitmap(imagebmp, new Rectangle(0, 0, dgvCustomer.Width, dgvCustomer.Height));
            e.Graphics.DrawImage(imagebmp, 120, 50);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog1 = new PrintDialog();
            printdialog1.Document = printDocument1;
            DialogResult result = printdialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
