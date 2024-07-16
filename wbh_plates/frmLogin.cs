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
    public partial class frmLogin : Form
    {
        string query;
        SqlConnection con = new SqlConnection("data source= DESKTOP-MQGUVVP; database= wbh_minisystem; integrated security=true");
        SqlCommand cmd = new SqlCommand();

        string status;
        string userType;


        string attemptedUser, message="Are you sure you want to reset your password ?", title = "Confirmation dialog";
        int attempt = 0;

        DialogResult result;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }


        // forgot link for resetting the PASSWORD - Shows the resetting feature
        private void forgotlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;

            cbbQuestion.Visible = false;

            lblMain.Text = "Recover your account";

            btnRecover.Text = "Recover";

        }

        private void btnSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("only admin can create account!, if you are admin - login to your account then create a new account");
        }

        // code for userType selection - FUNCTION
        public void checkRadiobutton()
        {
            if (rdbAdminstrator.Checked == true)
            {
                userType = "Admin";
            }
            else if (rdbEmployee.Checked == true)
            {
                userType = "User";
            }
            else
            {
                MessageBox.Show("usertype not selected !");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;

                checkRadiobutton();

                string userName, password;

                userName = txtUserName.Text.ToString();
                password = txtPassword.Text.ToString();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblUser WHERE usertype='" +
                    userType + "' AND username='" + userName + "' AND password='" + password + "'AND userStatus='Active'", con);
                /* in above line the program is selecting the whole data from table and the matching it with the username,usertype and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  

                sda.Fill(dt);

                SqlDataAdapter daValidationForSecurity = new SqlDataAdapter("select username,userType,userStatus from tblUser where username = '" + userName + "'", con);
                DataTable dtValidationForSecurity = new DataTable(); //this is creating a virtual table  
                daValidationForSecurity.Fill(dtValidationForSecurity);


                SqlDataAdapter checkExistense = new SqlDataAdapter("SELECT COUNT(username) FROM tblUser WHERE username = '" + userName + "'", con);
                DataTable check = new DataTable();
                checkExistense.Fill(check);


                if (check.Rows[0][0].ToString() == "0")
                {
                    MessageBox.Show("This username is not valid at the system !");
                }
                else if (dt.Rows[0][0].ToString() == "1")
                {
                    /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                    this.Hide();
                    frmDashboard frm = new frmDashboard();

                    // PREPARING to move to Dashboard
                    if (userType == "Admin")
                    {
                        // this code changes the label up-right corner to the selected userPower

                    }
                    else
                    {

                    }
                    frm.lblUsername.Text = userName;
                    frm.ShowDialog();
                }
                else if (dtValidationForSecurity.Rows[0][2].ToString() == "Blocked")
                {
                    MessageBox.Show("you have too many failed attempts! so we have blocked your username for security reason, contact to your manager soon ");

                }
                else if (dtValidationForSecurity.Rows[0][0].ToString() == "")
                {
                    MessageBox.Show("Invalid username or password if you are new to the system, create your account or contact to your admin ");
                }
                else if (userName == dtValidationForSecurity.Rows[0][0].ToString() && dtValidationForSecurity.Rows[0][1].ToString() != "Admin")
                {
                    attemptedUser = dtValidationForSecurity.Rows[0][0].ToString();
                    limitAttempt();
                }
                else if (dtValidationForSecurity.Rows[0][1].ToString() == "Admin" && dt.Rows[0][0].ToString() != "1")
                {
                    MessageBox.Show("Invalid username or password ensure your details ");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void limitAttempt()
        {
            try
            {
                query = "update tblUser set userStatus='Blocked' where userName = '" + txtUserName.Text.ToString() + "'";

                if (attempt < 5 && attemptedUser == lblActive.Text)
                {
                    attempt++;

                    int chancesLeft;
                    chancesLeft = 5 - attempt;

                    MessageBox.Show("Invalid username or password otherwise check if your account disabled");
                    progressBar1.Value = progressBar1.Value + 20;
                    MessageBox.Show(chancesLeft + " attempts left for blocking " + attemptedUser);

                    lblActive.Text = txtUserName.Text.ToString();
                }
                else if (attempt >= 5 && attemptedUser == lblActive.Text)
                {
                    cmd = new SqlCommand(query, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    progressBar1.Value = 0;
                    MessageBox.Show("you have too many failed attempts! so we have blocked your username for security reason, contact to your manager soon ");
                    attempt = 0;
                }
                else if (attemptedUser != lblActive.Text)
                {
                    attempt = 0;
                    attempt++;

                    progressBar1.Value = 0;

                    int chancesLeft;
                    chancesLeft = 5 - attempt;

                    MessageBox.Show(attemptedUser + " will be blocked if too many wrong attempts, please be carefull.");
                    progressBar1.Value = progressBar1.Value + 20;
                    MessageBox.Show(chancesLeft + " attempts left for blocking " + attemptedUser);

                    lblActive.Text = txtUserName.Text.ToString();
                }
                else
                {
                    attempt = 0;
                    attempt++;
                    progressBar1.Value = 0;

                    int chancesLeft;
                    chancesLeft = 5 - attempt;
                    MessageBox.Show("Invalid username or password otherwise check if your account disabled !!!  attempt : " + attempt);

                    progressBar1.Value = progressBar1.Value + 20;
                    MessageBox.Show(chancesLeft + " attempts left for blocking " + attemptedUser);

                    lblActive.Text = txtUserName.Text.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // make the password VISIBLE - or Hide RECOVER VIEW
        private void btnShow1_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShow1.Text = "Show";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShow1.Text = "Hide";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        // does the Reset-Password process - FUNCTION
        public void resetPassword()
        {
            try
            {
                // trying to verify who want to reset this account
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblUser WHERE employee_id='" +
                  cbbEmployeeId.Text + "' AND username='" + cbbUserName.Text + "' AND recoveryAnswer='" + cbbAnswer.Text + "'", con);
                /* in above line the program is selecting the whole data from table and the matching it with the user name,usertype and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);


                if (dt.Rows[0][0].ToString() == "1")
                {
                    try
                    {
                        result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("update tblUser set password='" + cbbNewPassword.Text + "' where employee_id=" + cbbEmployeeId.Text + "", con);
                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Successfully resetted, please remember it");
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Canceled by user, not resetted");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Password not resetted, there is an issue !");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Your verification is invalid, please ensure that your entry relates to you.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRecover_Click(object sender, EventArgs e)
        {
            resetPassword();
        }
    }
}
