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
    public partial class uRFM : UserControl
    {
        string query;
        SqlConnection con = new SqlConnection("data source= DESKTOP-MQGUVVP; database= wbh_minisystem; integrated security=true");
        SqlCommand cmd = new SqlCommand();

        string status;
        DialogResult confirm;
        string message = "Are you sure you want to delete this record";
        string title = "Confirmation dialog";
        public uRFM()
        {
            InitializeComponent();
        }

        public void load_data()
        {
            try
            {
                query = "select * from tblRFMs ORDER BY rfm_id desc";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string query2 = "select * from tblMReaders";
                SqlDataAdapter da2 = new SqlDataAdapter(query2, con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                txtAssigned.DataSource = dt2;
                txtAssigned.DisplayMember = "mReader_name";

                txtRFM_mac.DataSource = dt;
                txtRFM_mac.DisplayMember = "rfm_mac";

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uRFM_Load(object sender, EventArgs e)
        {
            load_data();
            pnlData.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                if (pnlData.Visible == false)
                {
                    pnlData.Visible = true;
                }
                else
                {
                    pnlData.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void checkStatus()
        {
            try
            {
                if (chbStatus.Checked == true)
                {
                    status = "Taken";
                }
                else if (chbStatus.Checked == false)
                {
                    status = "Pending";
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkStatus();

                query = "insert into tblRFMs(rfm_mac,status,date,mReader_name) values('" + txtRFM_mac.Text + "','" + status + "','" + DateTime.Now + "','" + txtAssigned.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();

                load_data();
                MessageBox.Show("Successfully Inserted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                checkStatus();

                message = "Are you suer you want to update this record ?";
                confirm = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    query = "update tblRFMs set rfm_mac='" + txtRFM_mac.Text + "' ,status='" + status + "',date='" + DateTime.Now + "',mReader_name='" + txtAssigned.Text + "' where rfm_id= " + txtRFM_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    load_data();
                    MessageBox.Show("Successfully Updated");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                confirm = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    query = "delete from tblRFMs where rfm_id = " + txtRFM_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    load_data();
                    MessageBox.Show("Successfully Deleted");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRFM_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtRFM_mac.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAssigned.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtRFM_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                query = "select status from tblRFMs where rfm_id = " + txtRFM_id.Text + "";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable virtualTable = new DataTable();
                adapter.Fill(virtualTable);

                lblStatus.Text = virtualTable.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chbStatus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(chbStatus.Checked==true)
                {
                    status = "Taken";
                }
                else if(chbStatus.Checked == false)
                {
                    status = "Repeated";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
