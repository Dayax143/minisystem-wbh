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

namespace wbh_plates
{
    public partial class frmDashboard : Form
    {
        string query;
        SqlConnection con = new SqlConnection("data source= Esmail; database= wbh_minisystem; integrated security=true");
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnPlates_Click(object sender, EventArgs e)
        {
            panels();
            u_Plates1.Visible = true;
            pnlPlates.Visible = true;
        }

        private void btnLora_Click(object sender, EventArgs e)
        {
            panels();
            pnlLora.Visible = true;
            u_RefLora1.Visible = true;
        }

        public void panels()
        {
            u_Plates1.Visible = false;
            uMReaders1.Visible = false;
            uRFM1.Visible = false;
            u_RefLora1.Visible = false;

            pnlPlates.Visible = false;
            pnlReader.Visible = false;
            pnlRFM.Visible = false;
            pnlLora.Visible = false;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.UtcNow.ToString();
            panels();
        }

        private void btnRFM_Click(object sender, EventArgs e)
        {
            panels();
            pnlRFM.Visible = true;
            uRFM1.Visible = true;
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            panels();
            uMReaders1.Visible = true;
            pnlReader.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin dashboard = new frmLogin();
            dashboard.ShowDialog();
        }
    }
}
