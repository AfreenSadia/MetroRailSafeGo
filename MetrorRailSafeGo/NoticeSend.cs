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
    public partial class NoticeSend : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public NoticeSend()
        {
            InitializeComponent();
        }
        private void bntback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome home = new AdminHome();
            home.Show();

        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
          Application.Exit();   

        }

        private void txtSender_Enter(object sender, EventArgs e)
        {
            if (txtSender.Text != "" || txtSender.Text == "Post A Notice Here")
            {
                txtSender.Text = "";
                txtSender.ForeColor = Color.Black;
            }
        }

        private void txtSender_Leave(object sender, EventArgs e)
        {
            if (txtSender.Text == "")
            {
                txtSender.Text = "Post A Notice Here";
                txtSender.ForeColor = Color.FromArgb(178, 190, 181);
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
           if (txtSender.Text != "" && txtSender.Text != "Post a notice here")
            {
                try
                {

                    DataConnect dc = new DataConnect();
                    bool decision = dc.Add_Update_Delete("UPDATE [Notice] SET SendNotice = '" + txtSender.Text + "' WHERE Id =" + 1);


                    txtSender.Text = "";
                    if (decision)
                    {
                        MessageBox.Show("Message Send Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Message Send Failed");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sc.Close();
                }

           }
            else
            {
                MessageBox.Show("Please write a notice first!");
            }
        }
    }
}
