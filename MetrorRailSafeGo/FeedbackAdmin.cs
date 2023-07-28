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
    public partial class FeedbackAdmin : Form
    {
        SqlConnection sc = new SqlConnection(DataConnect.ConnReturn());
        string loc;
        public FeedbackAdmin()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TextReceiver();
        }
        private void TextReceiver()
        {
            DataConnect dc = new DataConnect();
            dgvFeedback.DataSource = dc.DataRetrivation("SELECT Sender FROM [Feedback] WHERE Id = "+2);
            txtReciever.Text = dgvFeedback.Rows[0].Cells[0].Value.ToString();
            CurrentUser.Sender = txtReciever.Text;
            //loc = txtReciever.Text;
        }

        private void bntback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome admin = new AdminHome();
            admin.Show();
        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtSender.Text != "" && txtSender.Text != "Write your feedback Here")
            {
                DataConnect dc = new DataConnect();
                bool decision = dc.Add_Update_Delete("UPDATE [Feedback] SET Reciver = '" + txtSender.Text + "' WHERE Id =" + 2);
                if (decision)
                {
                    MessageBox.Show("Message sent Successfully");
                    txtSender.Text = "";
                }
                else
                {
                    MessageBox.Show("Message sent Failed");
                }
            }
            else
            {
                MessageBox.Show("Please write your message first!");
            }
        }

        private void txtSender_Enter(object sender, EventArgs e)
        {
            if (txtSender.Text != "" || txtSender.Text == "Write your feedback Here")
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
