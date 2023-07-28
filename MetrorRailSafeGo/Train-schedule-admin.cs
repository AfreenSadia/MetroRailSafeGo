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
using System.Xml.Linq;

namespace MetrorRailSafeGo
{
    public partial class Train_schedule_admin : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public Train_schedule_admin()
        {
            InitializeComponent();
        }

        private void bntback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminHome admin = new AdminHome();
            admin.Visible = true;
        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id,J_Start,J_End,Arrival_Time,Departure_Time FROM [TimeScheduleMR]", sc);
                sc.Open();
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dgvSchedule.DataSource = table;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStart.Text == "")
            {
                MessageBox.Show("Please enter Start location", "Location Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbEnd.Text == "")
            {
                MessageBox.Show("Please enter End Location", "Destination Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cmbStart.Text == cmbEnd.Text)
            {
                MessageBox.Show("Start and end journey destination cannot be same", "Destination Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dtpArrival.Text == dtpDeparture.Text)
            {
                MessageBox.Show("Arrival time & departure time cannot be same", "Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpArrival.Text == "")
            {
                MessageBox.Show("Please select Arrival Time", "Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dtpDeparture.Text == "")
            {
                MessageBox.Show("Please select Departure Time", "Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand sm = new SqlCommand(@"INSERT INTO [TimeScheduleMR] (J_Start,J_End,Arrival_Time,Departure_Time)
                                              VALUES('" + cmbStart.Text + "','" + cmbEnd.Text + "','" + dtpArrival.Text + "', '" + dtpDeparture.Text + "')", sc);
                    sc.Open();
                    sm.ExecuteNonQuery();
                    sc.Close();

                    cmbStart.Text = "";
                    cmbEnd.Text = "";
                    dtpArrival.Text = "";
                    dtpDeparture.Text = "";

                    MessageBox.Show("Data Saved Successfully");
                    btnShowSchedule_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [TimeScheduleMR] WHERE Id= '" + loc + "'  ", sc);
                //cmd.Parameters
                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("Data Removed Successfully");
                btnShowSchedule_Click(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvSchedule.SelectedRows[0].Cells[0].Value.ToString();
                loc = txtId.Text;
                cmbStart.Text = dgvSchedule.SelectedRows[0].Cells[1].Value.ToString();
                cmbEnd.Text = dgvSchedule.SelectedRows[0].Cells[2].Value.ToString();
                dtpArrival.Text = dgvSchedule.SelectedRows[0].Cells[3].Value.ToString();
                dtpDeparture.Text = dgvSchedule.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE [TimeScheduleMR] SET " +
                "J_Start = '" + cmbStart.Text + "', " +
                "J_End = '" + cmbEnd.Text + "'," +
                "Arrival_Time = '" + dtpArrival.Text + "', " +
                "Departure_Time = '" + dtpDeparture.Text + "' WHERE Id ='" + loc + "' ", sc);

                sc.Open();
                cmd.ExecuteNonQuery();
                sc.Close();



                MessageBox.Show("Data Updated Successfully");
                btnShowSchedule_Click(sender, e);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.cmbStart.SelectedIndex = 0;
            this.cmbEnd.SelectedIndex = 0;
            this.dtpArrival.ResetText();
            this.dtpDeparture.ResetText();
        }

        private void Train_schedule_admin_Load_1(object sender, EventArgs e)
        {
            dtpArrival.Format = DateTimePickerFormat.Time;
            dtpDeparture.Format = DateTimePickerFormat.Time;
        }

        private void dtpArrival_ValueChanged(object sender, EventArgs e)
        {
            dtpArrival.Text = dtpArrival.Value.ToString();

        }

        private void dtpDeparture_ValueChanged(object sender, EventArgs e)
        {
            dtpDeparture.Text = dtpDeparture.Value.ToString();
        }
    }
}
