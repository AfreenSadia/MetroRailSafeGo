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
    public partial class Feedback : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public Feedback()
        {
            InitializeComponent();
            TextReceiver();

        }

        private void bntback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome Mhome = new ManagerHome();
            Mhome.Show();
        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtSender.Text != "" && txtSender.Text != "Write your feedback Here")
            {
                try
                {

                    DataConnect dc = new DataConnect();
                    bool decision = dc.Add_Update_Delete("UPDATE [Feedback] SET Sender = '" + txtSender.Text + "' WHERE Id =" + 2);


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
                MessageBox.Show("Please write your message first!");
            }

        }


        private void TextReceiver()
        {
            DataConnect dc = new DataConnect();
            dgvFeedback.DataSource = dc.DataRetrivation("SELECT Reciver FROM [Feedback] WHERE Id = "+2);
            if(dgvFeedback.Rows.Count > 0)
            {
                txtReceiver.Text = dgvFeedback.Rows[0].Cells[0].Value.ToString();
                CurrentUser.Sender = txtReceiver.Text;
            }
            
        }

        private void txtSender_Enter(object sender, EventArgs e)
        {
            if(txtSender.Text != "" || txtSender.Text == "Write your feedback Here")
            {
                txtSender.Text = "";
                txtSender.ForeColor = Color.Black;
            }
        }

        private void txtSender_Leave(object sender, EventArgs e)
        {
            if (txtSender.Text == "")
            {
                txtSender.Text = "Write your feedback Here";
                txtSender.ForeColor = Color.FromArgb(178, 190, 181);
            }
        }
    }
}
