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
    public partial class uPlates : UserControl
    {

        string query;
        SqlConnection con = new SqlConnection("data source= DESKTOP-MQGUVVP; database= wbh_minisystem; integrated security=true");

        string status;

        DialogResult confirm;
        string message = "Are you sure you want to delete this record ?";
        string title = "Confirmation Dialog ";

        public uPlates()
        {
            InitializeComponent();
        }

        //public void checkDuplicate()
        //{
        //    try
        //    {
        //        query = "select * from tblPlates where cor_supply ='" + cmbSupply.Text + "'";
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

        //        DataTable virtualTable = new DataTable();
        //        dataAdapter.Fill(virtualTable);

        //        string searchSupply = cmbSupply.Text.ToString();

        //        if (virtualTable.Rows[0][0] == null)
        //        {

        //            lblCheck.Text = "Never created";
        //        }
        //        else if (virtualTable.Rows[0][0] != null)
        //        {
        //            lblCheck.Text = "All ready created";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        public void filterData()
        {
            try
            {
                string searchQuery = "select * from tblPlates where cor_supply like '%" + txtSearch.Text + "%' or refference like '%" + txtSearch.Text + "%'";
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
        public void load_data()
        {
            try
            {
                query = "select * from tblPlates ORDER BY plate_id desc";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                confirm = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    string deleteQuery = "delete from tblPlates where plate_id = " + txtPlate_id.Text + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(deleteQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Are you suer you want to update this record ?";
                confirm = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    string query = "update tblPlates set cor_supply = '" + cmbSupply.Text + "', status='" + status + "', refference='" + txtRef.Text + "', date='" + DateTime.Now + "', quantity='" + txtQty.Text + "' where plate_id = " + txtPlate_id.Text + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    load_data();
                    MessageBox.Show("Successfully Updated");
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void uPlates_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into tblPlates (cor_supply, status, refference, date, quantity) values ('" + cmbSupply.Text + "','" + status + "','" + txtRef.Text + "','" + DateTime.Now + "','" + txtQty.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                load_data();
                MessageBox.Show("Successfully Inserted");
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

        public void checkStatus()
        {
            try 
            {
                if(chbStatus.Checked == true)
                {
                    status = "Taken";
                    txtRef.Enabled = true;
                }
                else if(chbStatus.Checked == false)
                {
                    status = "Pending";
                    txtRef.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void chbStatus_CheckedChanged(object sender, EventArgs e)
        {
            checkStatus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtPlate_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbSupply.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRef.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
