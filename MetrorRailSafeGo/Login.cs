using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;

namespace MetrorRailSafeGo
{
    public partial class Login : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        

        /*private string Admin_username = "Avengers123";
        private string Admin_password = "1234";

        private string Username = "";
        private string User_password = "";*/
        public Login()
        {
            InitializeComponent();
            FillIDPass();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            btnlogin.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtpassword.Text != "")
            { 
                btnlogin.Enabled = true;
                btnlogin.BackColor = Color.Red;
                btnlogin.ForeColor = Color.White;
            }

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtpassword.Text != "")
            {
                btnlogin.Enabled = true;
                btnlogin.BackColor = Color.Red;
                btnlogin.ForeColor = Color.White;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpassword.Text;
            if (username == "")
            {
                MessageBox.Show("Please Enter a Username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(password == "")
            {
                MessageBox.Show("Please Enter a Valid Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    
                    string querry = "SELECT * FROM [Employee] WHERE Name = '" + username + "' AND Password = '" + password + "'";
                    DataConnect dc = new DataConnect();
                    DataTable dt = dc.Add(querry);

                    if (dt.Rows.Count > 0)
                    {

                        /*
                        *   Retriving  info for My profile
                        */
                        ManagerProfile profile = new ManagerProfile();
                        profile.ShowData(dc.DataRetrivation(querry));
                        CurrentUser.Profile = profile;
                        CurrentUser.isAdmin = false;

                        this.Hide();
                        ManagerHome Mhome = new ManagerHome();
                        Mhome.Show();
                    }
                    else if (username == "Avengers123" && password == "1234")
                    {
                        this.Hide();
                        AdminHome AHome = new AdminHome();
                        AHome.Show();
                        CurrentUser.isAdmin = true;
                    }
                    else
                    {
                        MessageBox.Show("Username and Password did not matched!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error = " + ex.Message);
                }
            }



            if (checkbox_remember.Checked)
            {
                

                DataConnect dc = new DataConnect();
                dc.Add_Update_Delete("UPDATE [RememberMe] SET " +
                "Username = '" + txtname.Text + "', " +
                "Password = '" + txtpassword.Text + "' WHERE Id ='" + 1 + "' ");



            }

        }
        
        private void FillIDPass()
        {
            DataConnect dc = new DataConnect();
            dgv_Login.DataSource = dc.DataRetrivation("SELECT * FROM RememberMe");

            if(dgv_Login.Rows.Count > 0)
            {
                txtname.Text = dgv_Login.Rows[0].Cells[1].Value.ToString();
                txtpassword.Text = dgv_Login.Rows[0].Cells[2].Value.ToString();
            }
        }


    }
}
