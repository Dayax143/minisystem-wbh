using System;
using System.Collections;
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
    public partial class uMReaders : UserControl
    {
        string query;
        SqlConnection con = new SqlConnection("data source= DESKTOP-MQGUVVP; database= wbh_minisystem; integrated security=true");
        SqlCommand cmd = new SqlCommand();

        string status;
        DialogResult confirm;
        string message = "Are you sure you want to delete this record ?";
        string title= "Confirmation dialog ";

        public uMReaders()
        {
            InitializeComponent();
        }

        public void load_data()
        {
            try
            {
                query = "select * from tblMReaders ORDER BY m_id desc";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string query2 = "select * from tblRFMS";
                SqlDataAdapter da2 = new SqlDataAdapter(query2, con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                txtAsigned_rfm.DataSource = dt2;
                txtAsigned_rfm.DisplayMember = "rfm_mac";

                txtRFM_id.DataSource = dt2;
                txtRFM_id.DisplayMember = "rfm_id";

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uMReaders_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMReader_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMReader_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAsigned_rfm.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtArea.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Are you sure you want to update this record ?";
                confirm = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    query = "update tblMReaders set mreader_name='" + txtMReader_name.Text + "', rfm_id= " + txtRFM_id.Text + ", reading_area='" + txtArea.Text + "',phone_number = " + txtPhone.Text + ",date='" + DateTime.Now + "' where m_id = " + txtMReader_id.Text + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    load_data();

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
                    query = "delete from tblMReaders where m_id = " + txtMReader_id.Text + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    load_data();

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into tblMReaders (mreader_name,rfm_id,reading_area,phone_number,date) values ('" + txtMReader_name.Text + "'," + txtRFM_id.Text + ",'" + txtArea.Text + "'," + txtPhone.Text + ",'" + DateTime.Now + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                load_data();

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
    }
}
