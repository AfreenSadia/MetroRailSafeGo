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
    public partial class Bookings : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public Bookings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome manager = new ManagerHome();
            manager.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                dgvBTicket.DataSource = dc.DataRetrivation("SELECT Id,D_To,D_From,Date_Time,Price FROM [Bookings]");

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
            try
            {
                if (cmbTo.Text == "")
                {
                    MessageBox.Show("Please enter destination", "Destination Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(cmbFrom.Text == cmbTo.Text)
                {
                    MessageBox.Show("Both destination cannot be same", "Destination Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbFrom.Text == "")
                {
                    MessageBox.Show("Please enter destination", "Destination Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /*else if (DateTime.Today == dtpTickets.Value)
                {
                    MessageBox.Show("Please enter date & time", "Date Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                else if (dtpTickets.Text == "")
                {
                    MessageBox.Show("Please enter date & time", "Date Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbTPrice.Text== "")
                {
                    MessageBox.Show("Please enter a valid price", "Email Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    DataConnect dc = new DataConnect();
                    bool decision = dc.Add_Update_Delete(@"INSERT INTO [Bookings] (D_To,D_From,Date_Time,Price)
                                              VALUES('" + cmbTo.Text + "','" + cmbFrom.Text + "', '" + dtpTickets.Text + "','" + cmbTPrice.Text + "')");

                    cmbTo.Text = "";
                    cmbFrom.Text = "";
                    dtpTickets.Text = "";
                    cmbTPrice.Text = "";

                    if (decision)
                    {
                        MessageBox.Show("Data Saved Successfully");
                        btnShowDetails_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                

                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("DELETE FROM [Bookings] WHERE Id= '" + loc + "'  ");

                if (decision)
                {
                    MessageBox.Show("Data Removed Successfully");
                    btnShowDetails_Click(sender, e);
                    btnclear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Data Removed Failed");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("UPDATE [Customer] SET " +
                "D_To = '" + cmbTo.Text + "', " +
                "D_From = '" + cmbFrom.Text + "'," +
                "Date_Time = '" + dtpTickets.Text + "', " +
                "Price = '" + cmbTPrice.Text + "' WHERE Id ='" + loc + "' ");

                if (decision)
                {
                    MessageBox.Show("Data Updated Successfully");
                    btnShowDetails_Click(sender, e);
                    btnclear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Data Updated Failed");
                }

                
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

        private void dgvBTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvBTicket.SelectedRows[0].Cells[0].Value.ToString();
                loc = txtId.Text;
                cmbTo.Text = dgvBTicket.SelectedRows[0].Cells[1].Value.ToString();
                cmbFrom.Text = dgvBTicket.SelectedRows[0].Cells[2].Value.ToString();
                dtpTickets.Text = dgvBTicket.SelectedRows[0].Cells[3].Value.ToString();
                cmbTPrice.Text = dgvBTicket.SelectedRows[0].Cells[4].Value.ToString();
               /* string price = dgvBTicket.SelectedRows[0].Cells[4].Value.ToString();
                if (price == "Tk50")
                {
                    cmbTPrice.SelectedIndex = 0;
                }
                else if (price == "Tk100")
                {
                    cmbTPrice.SelectedIndex = 1;
                }
                else if (price == "Tk150")
                {
                    cmbTPrice.SelectedIndex = 2;
                }
                else if (price == "Tk200")
                {
                    cmbTPrice.SelectedIndex = 3;
                }
                else
                {
                    MessageBox.Show("Please select Price", "Price Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               */
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.cmbTo.SelectedIndex = 0;
            this.cmbFrom.SelectedIndex = 0;
            this.cmbTPrice.SelectedIndex = 0;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgvBTicket.Width, dgvBTicket.Height);
            dgvBTicket.DrawToBitmap(imagebmp, new Rectangle(0, 0, dgvBTicket.Width, dgvBTicket.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
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
