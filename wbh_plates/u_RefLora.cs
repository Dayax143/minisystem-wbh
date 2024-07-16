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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wbh_plates
{
    public partial class uRefLora : UserControl
    {
        string query;
        string query2;
        SqlConnection con = new SqlConnection("data source= DESKTOP-MQGUVVP; database= wbh_minisystem; integrated security=true");
        SqlCommand cmd = new SqlCommand();

        DateTime dateFilter;

        string status;
        DialogResult confirm;
        string message="Are you sure you want to delete this record ?";
        string title = "Confirmation Dialog ";
        public uRefLora()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            select_status();
            if (chbPlate.Checked == false)
            {
                try
                {
                    query = "insert into tblLora (cor_supply,status,refference,date,lora_serial,payment_rv) values('" + cmbSupply.Text + "','" + status + "','" + txtRef.Text + "','" + DateTime.Now + "','" + txtSerial.Text + "','" + txtRV.Text + "')";

                    con.Open();
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sucessfully Inserted");
                    load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "from saving");
                }
                finally
                {
                    con.Close();
                }
            }

            else if (chbPlate.Checked == true)
            {
                try
                {
                    query = "insert into tblLora (cor_supply,status,refference,date,lora_serial,payment_rv) values('" + cmbSupply.Text + "','" + status + "','" + txtRef.Text + "','" + DateTime.Now + "','" + txtSerial.Text + "','" + txtRV.Text + "')";
                    query2 = "insert into tblPlates (cor_supply, status, refference, date) values ('" + cmbSupply.Text + "','" + status + "','" + txtRef.Text + "','" + DateTime.Now + "')";

                    con.Open();
                    cmd = new SqlCommand(query + query2, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sucessfully Inserted with plates");
                    load_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "from saving");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            select_status();
            try
            {
                message = "Are you sure you want to update this record ?";
                confirm = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {

                    string query = "update tblLora set cor_supply='" + cmbSupply.Text + "',status= '" + status + "',refference='" + txtRef.Text + "',date='" + DateTime.Now + "',lora_serial='" + txtSerial.Text + "',payment_rv ='" + txtRV.Text + "' where lora_id=" + txtLora_id.Text + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Sucessfully Updated");
                    load_data();
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

        public void load_data()
        {
            select_status();

            try
            {
                query = "select * from tblLora ORDER BY lora_id desc";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void select_status()
        {
            try
            {
                if (chbStatus.Checked == true)
                {
                    status = "Taken";
                    txtRef.Enabled = true;
                }
                else if (chbStatus.Checked == false)
                {
                    status = "Pending";
                    txtRef.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "from select_status");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (confirm == DialogResult.Yes)
                {
                    string deleteQuery = "delete from tblLora where lora_id = " + txtLora_id.Text + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(deleteQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfully Deleted");
                    load_data();
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

        private void uRefLora_Load(object sender, EventArgs e)
        {
            load_data();
            txtRef.Enabled = false;
            pnlData.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                if(pnlData.Visible == false)
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

        public void filterData()
        {
            try
            {
                string searchQuery = "select * from tblLora where cor_supply like '%" + txtSearch.Text + "%' or status like '%" + txtSearch.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
                DataTable da = new DataTable();
                adapter.Fill(da);

                dataGridView1.DataSource = da;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtLora_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbSupply.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSerial.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtRV.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRef.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void chbStatus_CheckedChanged(object sender, EventArgs e)
        {
            select_status();
        }

        private void chbToday_CheckedChanged(object sender, EventArgs e)
        {
            if (chbToday.Checked == true)
            {
                txtSearch.Text = DateTime.Now.Date.ToString();

                try
                {
                    string searchQuery = "select * from tblLora where date like '%" + DateTime.Now.Date + "%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
                    DataTable da = new DataTable();
                    adapter.Fill(da);

                    dataGridView1.DataSource = da;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                filterData();
            }
        }
    }
}
