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
    public partial class Train_Scheme : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public Train_Scheme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            ManagerHome mhome = new ManagerHome();
            mhome.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id,J_Start,J_End,Arrival_Time,Departure_Time FROM [TimeScheduleMR]", sc);
                sc.Open();
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dgvShowSchedule.DataSource = table;

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

        private void dgvShowSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgvShowSchedule.Width, dgvShowSchedule.Height);
            dgvShowSchedule.DrawToBitmap(imagebmp, new Rectangle(0, 0, dgvShowSchedule.Width, dgvShowSchedule.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("SELECT * FROM [TimeScheduleMR] WHERE J_Start = '" + this.txtSearch.Text + "'  ");
                if (decision)
                {
                    MessageBox.Show("Data Found Successfully");
                    btnShowDetails_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Couldn't found data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
