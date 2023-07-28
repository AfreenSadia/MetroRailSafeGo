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
    public partial class ViewStations : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public ViewStations()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManagerHome Mhome = new ManagerHome();
            Mhome.Visible = true;
        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT D_From,D_To,Price FROM [TrainStation]", sc);
                sc.Open();
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dgvViewStations.DataSource = table;

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("SELECT * FROM [TrainStation] WHERE D_From= '" + this.txtSearch.Text + "'  ");
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
