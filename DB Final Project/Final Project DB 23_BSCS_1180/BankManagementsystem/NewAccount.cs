using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

namespace BankManagementsystem
{
    public partial class NewAccount : Form
    {
        static bool admin;
        public NewAccount()
        {
            InitializeComponent();
            DisplayAccountonGV();
        }
        public NewAccount(bool c)
        {
            InitializeComponent();
            admin = c;
        }
       
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-618RHUU;Initial Catalog=BankDataBase;Integrated Security=True");
        
        private void DisplayAccountonGV()
        {
            conn.Open();
            string Query = "Select * From Add_Account";
            SqlDataAdapter Sda = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder Builder = new SqlCommandBuilder(Sda);
            var ds = new DataSet();
            Sda.Fill(ds);
            AccDGV.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void AccPhonelbl_Click(object sender, EventArgs e)
        {

        }

        private void GenderLbl_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void NewAcclbl_Click(object sender, EventArgs e)
        {

        }


        private void Reset()
        {
            //AccNumTb.Text = "";
            AccNameTbl.Text = "";
            AccPhoneTb.Text = "";
            AccAddressT.Text = "";
            AccGenderComo.SelectedIndex = -1;
            AccOccupationTb.Text = "";
            AccBalTb.Text = "";
            AccEduTB.Text = "";

        }
       
        private void Sumitbtn_Click(object sender, EventArgs e)
        {
            if (AccNameTbl.Text == "" || AccPhoneTb.Text == "" || AccAddressT.Text == "" || AccEduTB.Text == "" || AccGenderComo.SelectedIndex == -1 || AccOccupationTb.Text == "" || AccBalTb.Text == ""  ) 
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    //string Query = "INSERT INTO Add_Account (AcName, AcPhone, AcAddress, ACGender, ACEdu, AcOccupation, AcCNIN) Values  ( @AcName, @AcPhone, @AcAddress, @ACGender, @ACEdu, @AcOccupation, @AcCNIN)";
                    SqlCommand cmd = new SqlCommand("INSERT INTO Add_Account (AcName, AcPhone, AcAddress, ACGender, ACEdu, AcOccupation, AcBal) Values  ( @AcName, @AcPhone, @AcAddress, @ACGender, @ACEdu, @AcOccupation, @Acbal)", conn);

                    //cmd.Parameters.AddWithValue("@AC_Num", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@AcName", AccNameTbl.Text);
                    cmd.Parameters.AddWithValue("@AcPhone", AccPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AcAddress", AccAddressT.Text);
                    cmd.Parameters.AddWithValue("@ACGender", AccGenderComo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ACEdu", AccEduTB.Text);
                    cmd.Parameters.AddWithValue("@AcOccupation", AccOccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AcBal", AccBalTb.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Created");
                    conn.Close();
                    Reset();
                    DisplayAccountonGV();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                //finally
                //{
                //    conn.Close();
                //}
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (AccNameTbl.Text == "" || AccPhoneTb.Text == "" || AccAddressT.Text == "" || AccEduTB.Text == "" || AccGenderComo.SelectedIndex == -1 || AccOccupationTb.Text == "" || AccBalTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Update Add_Account Set AcName=@AcName, AcPhone=@AcPhone, AcAddress=@AcAddress, ACGender=@ACGender, ACEdu=@ACEdu, AcOccupation=@AcOccupation, AcBal=@Acbal Where AC_Num=@AcKey ", conn);

                    cmd.Parameters.AddWithValue("@AcName", AccNameTbl.Text);
                    cmd.Parameters.AddWithValue("@AcPhone", AccPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AcAddress", AccAddressT.Text);
                    cmd.Parameters.AddWithValue("@ACGender", AccGenderComo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ACEdu", AccEduTB.Text);
                    cmd.Parameters.AddWithValue("@AcOccupation", AccOccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AcBal", AccBalTb.Text);
                    cmd.Parameters.AddWithValue("@AcKey", key);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Updated");
                    conn.Close();
                    Reset();
                    DisplayAccountonGV();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
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
                    SqlCommand cmd = new SqlCommand("delete from Add_Account Where AC_Num=@AcKey", conn);
                    cmd.Parameters.AddWithValue("@AcKey", key);    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Deleted!!");
                    conn.Close();
                    Reset();
                    DisplayAccountonGV();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

                int key = 0;
        private void AccDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = AccDGV.Rows[e.RowIndex];

                AccNameTbl.Text = row.Cells[1].Value.ToString();
                AccPhoneTb.Text = row.Cells[2].Value.ToString();
                AccAddressT.Text = row.Cells[3].Value.ToString();
                AccGenderComo.SelectedItem = row.Cells[4].Value.ToString();
                AccEduTB.Text = row.Cells[5].Value.ToString();
                AccOccupationTb.Text = row.Cells[6].Value.ToString();
                AccBalTb.Text = row.Cells[7].Value.ToString();

                if (string.IsNullOrEmpty(AccNameTbl.Text))
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }
        }

        private void BackbtnAddAent_Click(object sender, EventArgs e)
        {
            if (admin)
            {
                AdminPanel obj = new AdminPanel();
                obj.Show();
                this.Hide();
            }
            else
            {
                MainMenuf2 obj = new MainMenuf2();
                obj.Show();
                this.Hide();
            }
        }

        private void AccEduTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AccEduTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetter(c) && c != 8 && c != 46)
            {
                e.Handled = true;

            }
        }

        private void AccPhoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {
                            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }

                if (AccPhoneTb.Text.Length >= 11 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }

        private void AccBalTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }

                if (AccBalTb.Text.Length >= 6 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            

        }
    }
    }

