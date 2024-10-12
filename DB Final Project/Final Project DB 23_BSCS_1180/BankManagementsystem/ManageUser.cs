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

namespace BankManagementsystem
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
            DisplayAgentsOnDG();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-618RHUU;Initial Catalog=BankDataBase;Integrated Security=True");

        private void DisplayAgentsOnDG()
        {
            conn.Open();
            string Query = "Select * From Manage_User ";
            SqlDataAdapter Sda = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder Builder = new SqlCommandBuilder(Sda);
            var ds = new DataSet();
            Sda.Fill(ds);
            AgentDGV.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void Reset()
        {
            //AccNumTb.Text = "";
            UserNameTb.Text = "";
            UserpassTb.Text = "";
            UserAddressT.Text = "";
            UserPhoneTb.Text = "";

        }

        private void NewAcclbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sumitbtn_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "" || UserpassTb.Text == "" || UserPhoneTb.Text == "" || UserAddressT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    //string Query = "INSERT INTO Add_Account (AcName, AcPhone, AcAddress, ACGender, ACEdu, AcOccupation, AcCNIN) Values  ( @AcName, @AcPhone, @AcAddress, @ACGender, @ACEdu, @AcOccupation, @AcCNIN)";
                    SqlCommand cmd = new SqlCommand("INSERT INTO Manage_User (AgName, AgPass, AgPhone, AcAddress) Values  ( @UserName, @Userpass, @UserPhone, @UserAddress)", conn);

                    //cmd.Parameters.AddWithValue("@AC_Num", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@UserName", UserNameTb.Text);
                    cmd.Parameters.AddWithValue("@Userpass", UserpassTb.Text);
                    cmd.Parameters.AddWithValue("@UserPhone", UserPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@UserAddress", UserAddressT.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Agent Added");
                    conn.Close();
                    Reset();
                    DisplayAgentsOnDG();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {

            if (UserNameTb.Text == "" || UserpassTb.Text == "" || UserPhoneTb.Text == "" || UserAddressT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Manage_User SET AgName=@AgName, AgPass=@AgPass, AgPhone=@AgPhone, AcAddress=@AcAddress WHERE AgId=@AgKey";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@AgName", UserNameTb.Text);
                    cmd.Parameters.AddWithValue("@AgPass", UserpassTb.Text);
                    cmd.Parameters.AddWithValue("@AgPhone", UserPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AcAddress", UserAddressT.Text);
                    cmd.Parameters.AddWithValue("@AgKey", key);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Updated");
                    conn.Close();
                    Reset();
                    DisplayAgentsOnDG();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        int key = 0;
        private void AgentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserNameTb.Text = AgentDGV.SelectedRows[0].Cells[1].Value.ToString();
            UserpassTb.Text = AgentDGV.SelectedRows[0].Cells[2].Value.ToString();
            UserPhoneTb.Text = AgentDGV.SelectedRows[0].Cells[3].Value.ToString();
            UserAddressT.Text = AgentDGV.SelectedRows[0].Cells[4].Value.ToString();



            if (UserNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AgentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Account");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Manage_User Where AgId=@AcKey", conn);
                    cmd.Parameters.AddWithValue("@AcKey", key);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Deleted!!");
                    conn.Close();
                    Reset();
                    DisplayAgentsOnDG();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BackbtnManUSer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel Lg = new AdminPanel();
            Lg.Show();
        }

        private void UserpassTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserpassTb.Text))
            {
                Errlbl.Visible = false;

            }
            else if (UserpassTb.Text.Length >= 6 && UserpassTb.Text.Length <= 8)
            {
                Errlbl.Visible = false;
            }
            else
            {
                Errlbl.ForeColor = Color.Red;

                Errlbl.Text = "Between 6-8 digits";
                Errlbl.Visible = true;

            }

        }

        private void UserPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserPhoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (UserPhoneTb.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}



