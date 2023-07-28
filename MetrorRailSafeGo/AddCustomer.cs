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
    public partial class AddCustomer : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public AddCustomer()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManagerHome Mhome = new ManagerHome();
            Mhome.Visible = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("UPDATE [Customer] SET " +
                "name = '" + txtName.Text + "', " +
                "Age = '" + txtAge.Text + "'," +
                "Gender = '" + cmbCustomer.Text + "', " +
                "PhoneNum = '" + txtPhoneNum.Text + "', " +
                "Address = '" + txtAddress.Text + "', " +
                "NoOfTicket = '" + numTicket.Text + "', " +
                "Price = '" + cmbPrice.Text + "' WHERE Id ='" + loc + "' ");

                if (decision)
                {
                    MessageBox.Show("Data Updated Successfully");
                    btnShowDetails_Click(sender, e);
                    btnClear_Click(sender, e);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("DELETE FROM [Customer] WHERE Id= '" + loc + "'  ");

                if (decision)
                {
                    MessageBox.Show("Data Removed Successfully");
                    btnShowDetails_Click(sender, e);
                    btnClear_Click(sender, e);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtAge.Clear();
            this.cmbCustomer.Visible = false;
            this.txtPhoneNum.Clear();
            this.txtAddress.Clear();
            this.numTicket.Value=0;
            this.cmbPrice.SelectedIndex = -1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please enter name", "Name Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAge.Text == "")
                {
                    MessageBox.Show("Please enter age", "Age Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbCustomer.Text == "")
                {
                    MessageBox.Show("Please enter gender", "Gender Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPhoneNum.Text == "")
                {
                    MessageBox.Show("Please enter phone number", "Phone Number Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (numTicket.Text == "")
                {
                        MessageBox.Show("Please enter number of tickets", "Count Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                else if (cmbPrice.Text == "")
                {
                    MessageBox.Show("Please enter the price", "Price Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    DataConnect dc = new DataConnect();
                    bool decision = dc.Add_Update_Delete(@"INSERT INTO [Customer] (Name,Age,Gender,PhoneNum,Address,NoOfTicket,Price)
                                              VALUES('" + txtName.Text + "','" + txtAge.Text + "', '" + cmbCustomer.Text + "','" + txtPhoneNum.Text + "','" + txtAddress.Text + "','" + numTicket.Text + "', '" + cmbPrice.Text + "')");

                    if (decision)
                    {
                        MessageBox.Show("Data Saved Successfully");
                        btnShowDetails_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Data Saved Failed");
                    }

                    txtName.Text = "";
                    txtAge.Text = "";
                    cmbCustomer.Text = "";
                    txtPhoneNum.Text = "";
                    txtAddress.Text = "";
                    numTicket.Text = "";
                    cmbPrice.Text = "";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dgvCustomer.Width, dgvCustomer.Height);
            dgvCustomer.DrawToBitmap(imagebmp, new Rectangle(0,0, dgvCustomer.Width, dgvCustomer.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
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

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                loc = txtId.Text;
                txtName.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
                txtAge.Text = dgvCustomer.SelectedRows[0].Cells[2].Value.ToString();
                string gender = dgvCustomer.SelectedRows[0].Cells[3].Value.ToString();
                if (gender == "Male")
                {
                    cmbCustomer.SelectedIndex = 0;
                }
                else if (gender == "Female")
                {
                    cmbCustomer.SelectedIndex = 1;
                }
                else if (gender == "Others")
                {
                    cmbCustomer.SelectedIndex = 2;
                }
                else
                {
                    MessageBox.Show("Please select Gender", "Gender Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtPhoneNum.Text = dgvCustomer.SelectedRows[0].Cells[4].Value.ToString();
                txtAddress.Text = dgvCustomer.SelectedRows[0].Cells[5].Value.ToString();
                numTicket.Text = dgvCustomer.SelectedRows[0].Cells[6].Value.ToString();
                cmbPrice.Text = dgvCustomer.SelectedRows[0].Cells[7].Value.ToString();
                
            }
        }

        private void txt_cont_keypress1(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error, A phone number cannot contain letters");
            }
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            if(txtPhoneNum.Text.Length == 11)
            {
                txtPhoneNum.ForeColor = Color.Black;
            }
            else
            {
                txtPhoneNum.ForeColor = Color.Red;
            }
        }
    }
}
