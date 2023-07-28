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
    public partial class ViewBookedTickets : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public ViewBookedTickets()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome home = new AdminHome();
            home.Show();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id,D_To,D_From,Date_Time,Price FROM [Bookings]", sc);
                sc.Open();
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dgvViewTicket.DataSource = table;

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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgvViewTicket.Width, dgvViewTicket.Height);
            dgvViewTicket.DrawToBitmap(imagebmp, new Rectangle(0, 0, dgvViewTicket.Width, dgvViewTicket.Height));
            e.Graphics.DrawImage(imagebmp, 120, 50);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();*/

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
