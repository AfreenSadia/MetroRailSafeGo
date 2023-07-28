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
    public partial class AddStation : Form
    {
        /// <summary>
        /// This is used to connect the database to this form
        /// </summary>
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public AddStation()
        {
            InitializeComponent();
        }

        private void AddStation_Load(object sender, EventArgs e)
        {

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

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {

                DataConnect dc = new DataConnect();
                dgv_Stations.DataSource = dc.DataRetrivation("SELECT D_From,D_To,Price FROM [TrainStation]");

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
          
           if (cmbFrom.Text == "")
            {
                MessageBox.Show("Please enter destination from", "Destination Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbTo.Text == "")
            {
                MessageBox.Show("Please enter destination to", "Destination Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbFrom.Text == cmbTo.Text)
            {
                MessageBox.Show("Both destination cannot be same!", "Destination Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbPrice.Text == "")
            {
                MessageBox.Show("Please select Price", "Gender Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    DataConnect dc = new DataConnect();
                    bool decison = dc.Add_Update_Delete(@"INSERT INTO [TrainStation] (D_From,D_To,Price)
                                              VALUES('aConn" + cmbFrom.Text + "','" + cmbTo.Text + "', '" + cmbPrice.Text + "')");


                    cmbFrom.Text = "";
                    cmbTo.Text = "";
                    cmbPrice.Text = "";
                    if (decison)
                    {
                        MessageBox.Show("Data Saved Successfully");
                        btnShowDetails_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Data Saved Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }


        private void dgv_Stations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbFrom.Text = dgv_Stations.SelectedRows[0].Cells[0].Value.ToString();
                loc = cmbFrom.Text;
                cmbTo.Text = dgv_Stations.SelectedRows[0].Cells[1].Value.ToString();
                cmbPrice.Text = dgv_Stations.SelectedRows[0].Cells[2].Value.ToString();

            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
          
                DataConnect dc = new DataConnect();
                bool decison = dc.Add_Update_Delete("UPDATE [TrainStation] SET " +
                "D_From = '" + cmbFrom.Text + "', " +
                "D_To = '" + cmbTo.Text + "'," +
                "Price = '" + cmbPrice.Text + "' WHERE D_From ='" + loc + "' ");

                cmbFrom.Text = "";
                cmbTo.Text = "";
                cmbPrice.Text = "";
                if (decison)
                {
                    MessageBox.Show("Data Saved Successfully");
                    btnShowDetails_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Data Saved Failed");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("DELETE FROM [TrainStation] WHERE D_From= '"+loc+"' ");

                if (decision)
                {
                    MessageBox.Show("Data Removed Successfully");
                    btnShowDetails_Click(sender, e);
                    btnReset_Click(sender, e);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.cmbFrom.SelectedIndex = 0;
            this.cmbTo.SelectedIndex = 0;
            this.cmbPrice.SelectedIndex = 0 ;
        }

        
    }
    }
    