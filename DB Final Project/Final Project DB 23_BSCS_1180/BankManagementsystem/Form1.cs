using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankManagementsystem
{
    public partial class LoginFoam : Form
    {
        public LoginFoam()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-618RHUU;Initial Catalog=BankDataBase;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuf2 MainMenu = new MainMenuf2();
            MainMenu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void UserNamelbl_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            InfoF obj = new InfoF();
            obj.Show();
            this.Hide();
        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LoginbtnLoginf_Click(object sender, EventArgs e)
        {
            if (RoleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Role");
            }
            else if (RoleComboBox.SelectedIndex == 0)
            {
                if (string.IsNullOrWhiteSpace(AdNameT.Text) || string.IsNullOrWhiteSpace(AdPassTB.Text))
                {
                    MessageBox.Show("Enter Both Admin Name and Password");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM Login_Credientials WHERE A_Name = @AdminName AND A_Pass = @AdminPass";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AdminName", AdNameT.Text);
                            cmd.Parameters.AddWithValue("@AdminPass", AdPassTB.Text);

                            int result = (int)cmd.ExecuteScalar();

                            if (result == 1)
                            {
                                AdminPanel obj = new AdminPanel();
                                obj.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Wrong Admin Name and Password");
                                AdNameT.Text = "";
                                AdPassTB.Text = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else if (RoleComboBox.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(AdNameT.Text) || string.IsNullOrWhiteSpace(AdPassTB.Text))
                {
                    MessageBox.Show("Enter Both Agent Name and Password");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM Manage_User WHERE AgName = @AdminName AND AgPass = @AdminPass";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AdminName", AdNameT.Text);
                            cmd.Parameters.AddWithValue("@AdminPass", AdPassTB.Text);

                            int result = (int)cmd.ExecuteScalar();

                            string userType = RoleComboBox.SelectedItem.ToString(); // Get the selected user type

                            if (result == 1)
                            {
                                MainMenuf2 M_MenuF = new MainMenuf2();
                                M_MenuF.Show();
                                this.Hide();
                            }
                           
                            else
                            {
                                MessageBox.Show("Wrong Agent Name and Password");
                                AdNameT.Text = "";
                                AdPassTB.Text = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            AdNameT.Text = "";
            AdPassTB.Text = "";
            RoleComboBox.SelectedIndex = -1;
            RoleComboBox.Text = "Role";
        }

        public void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdNameT_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetter(c) && c != 8 && c != 46)
            {
                e.Handled = true;
       
            }

        }

        private void AdPassTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AdPassTB.Text))
            {
                errLbl.Visible = false;

            }
            else if (AdPassTB.Text.Length >= 6 && AdPassTB.Text.Length <= 8)
            {
                errLbl.Visible = false;
            }
            else
            {
                errLbl.ForeColor = Color.Red;

                errLbl.Text = "PIN Must be between 6-8 digits";
                errLbl.Visible = true;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InfoF obj = new InfoF  ();
            obj.Show();
            this.Hide();
        }
    }
    }


