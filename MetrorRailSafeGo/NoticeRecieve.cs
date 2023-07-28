using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetrorRailSafeGo
{
    public partial class NoticeRecieve : Form
    {
        public NoticeRecieve()
        {
            InitializeComponent();
        }

        private void bntback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHome home = new ManagerHome();
            home.Show();
        }

        private void bntcancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TextReceiver()
        {
            DataConnect dc = new DataConnect();
            dgvView.DataSource = dc.DataRetrivation("SELECT SendNotice FROM [Notice] WHERE Id = " + 1);
            lblReceive.Text = dgvView.Rows[0].Cells[0].Value.ToString();
            CurrentUser.Sender = lblReceive.Text;
            //loc = txtReciever.Text;
        }
        private void NoticeRecieve_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("There is a notice!");
            TextReceiver();
        }
    }
}
