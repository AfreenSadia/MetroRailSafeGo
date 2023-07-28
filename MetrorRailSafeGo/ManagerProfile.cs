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
    public partial class ManagerProfile : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;



        public ManagerProfile()
        {
            InitializeComponent();
            extractData();
        }

        private void bntback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome home = new ManagerHome();
            home.Show();
        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome home = new ManagerHome();
            home.Show();
        }

        private void ManagerProfile_Load(object sender, EventArgs e)
        {
        }

        private void dgvProfile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void ShowData(DataTable table)
        {
            dgvProfile.DataSource = table;

            txtId.Text = dgvProfile.Rows[0].Cells[0].Value.ToString();
            txtName.Text = dgvProfile.Rows[0].Cells[1].Value.ToString();
            txtAge.Text = dgvProfile.Rows[0].Cells[2].Value.ToString();
            txtEmail.Text = dgvProfile.Rows[0].Cells[3].Value.ToString();
            txtAddress.Text = dgvProfile.Rows[0].Cells[4].Value.ToString();
            txtPassword.Text = dgvProfile.Rows[0].Cells[5].Value.ToString();
            cmbGender.Text = dgvProfile.Rows[0].Cells[6].Value.ToString();


            extractData();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?","Update Profile",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [Employee] SET " +
                    "name = '" + txtName.Text + "', " +
                    "Age = '" + txtAge.Text + "'," +
                    "Email = '" + txtEmail.Text + "', " +
                    "Address = '" + txtAddress.Text + "', " +
                    "Password = '" + txtPassword.Text + "', " +
                    "Gender = '" + cmbGender.Text + "' WHERE Id ='" + loc + "' ", sc);

                    sc.Open();
                    cmd.ExecuteNonQuery();
                    sc.Close();



                    MessageBox.Show("Data Updated Successfully");
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
            else
            {
                txtId.Text = CurrentUser.Id; 
                txtName.Text = CurrentUser.Name;
                txtAge.Text = CurrentUser.Age;
                txtEmail.Text = CurrentUser.Email;
                txtAddress.Text = CurrentUser.Address;
                txtPassword.Text = CurrentUser.Password;
                cmbGender.Text= CurrentUser.Gender;
            }
        }





        private void extractData()
        {
            CurrentUser.Id = txtId.Text;
            CurrentUser.Name = txtName.Text;
            CurrentUser.Age = txtAge.Text;
            CurrentUser.Email= txtEmail.Text;
            CurrentUser.Address = txtAddress.Text;
            CurrentUser.Password = txtPassword.Text;
            CurrentUser.Gender = cmbGender.Text;
        }




    }
}
