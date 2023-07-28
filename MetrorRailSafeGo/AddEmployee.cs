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
    public partial class AddEmployee : Form
    {

        /// <summary>
        /// This is used to connect the database to this form
        /// </summary>
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;



        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                dgvEmployee.DataSource = dc.DataRetrivation("SELECT Id,Name,Age,Email,Address,Password,Gender,Salary FROM [Employee]");                
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

        private void bntcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome home = new AdminHome();
            home.Show();
        }


        private void btnSave_Click(object sender, EventArgs e)
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
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter email", "Email Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!txtEmail.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Please enter a valid email", "Email Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Please enter address", "Address Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter password", "Password Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbGender.Text == "")
                {
                    MessageBox.Show("Please select Gender", "Gender Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtSalary.Text == "")
                {
                    MessageBox.Show("Please enter salary", "Salary Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
                else
                {
                    

                    
                    DataConnect dc = new DataConnect();
                    bool decision = dc.Add_Update_Delete(@"INSERT INTO [Employee] (Name,Age,Email,Address,Password,Gender,Salary)
                                              VALUES('" + txtName.Text + "','" + txtAge.Text + "', '" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtPassword.Text + "','" + cmbGender.Text + "', '" + txtSalary.Text + "')");

                    if (decision)
                    {
                        MessageBox.Show("Data Saved Successfully");
                        btnShowDetails_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Failed to Save");
                    }

                    txtName.Text = "";
                    txtAge.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";
                    txtPassword.Text = "";
                    cmbGender.Text = "";
                    txtSalary.Text = "";


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //private string idGenerator()
        //{
        //    string id = "";
        //    for (int i = 0; i < 8; i++)
        //    {
        //        id = id + Convert.ToString(new Random().Next(0, 10));
        //    }
        //    return id;
        //}


        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
                loc = txtId.Text;
                txtName.Text = dgvEmployee.SelectedRows[0].Cells[1].Value.ToString();
                txtAge.Text = dgvEmployee.SelectedRows[0].Cells[2].Value.ToString();
                txtEmail.Text = dgvEmployee.SelectedRows[0].Cells[3].Value.ToString();
                txtAddress.Text = dgvEmployee.SelectedRows[0].Cells[4].Value.ToString();
                txtPassword.Text = dgvEmployee.SelectedRows[0].Cells[5].Value.ToString();
                string gender = dgvEmployee.SelectedRows[0].Cells[6].Value.ToString();
                if (gender == "Male")
                {
                    cmbGender.Text = "Male";
                }
                else if (gender == "Female")
                {
                    cmbGender.Text = "Female";
                }
                else if (gender == "Others")
                {
                    cmbGender.Text = "Others";
                }
                else
                {
                    MessageBox.Show("Please select Gender", "Gender Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtSalary.Text = dgvEmployee.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("DELETE FROM [Employee] WHERE Id= '" + loc + "'  ");
                if (decision)
                {
                    MessageBox.Show("Data Removed Successfully");
                    btnShowDetails_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Data Remove failed");
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
                bool decision = dc.Add_Update_Delete("UPDATE [Employee] SET " +
                "name = '" + txtName.Text + "', " +
                "Age = '" + txtAge.Text + "'," +
                "Email = '" + txtEmail.Text + "', " +
                "Address = '" + txtAddress.Text + "', " +
                "Password = '" + txtPassword.Text + "', " +
                "Gender = '" + cmbGender.Text + "', " +
                "Salary = '" + txtSalary.Text + "' WHERE Id ='" + loc + "' ");

                if (decision)
                {
                    MessageBox.Show("Data Updated Successfully");
                    btnShowDetails_Click(sender, e);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.txtAge.Clear();
            this.txtEmail.Clear();
            this.txtAddress.Clear();
            this.txtPassword.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.txtSalary.Clear();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("SELECT * FROM [Employee] WHERE Name= '" + this.txtSearch.Text + "'  ");
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
