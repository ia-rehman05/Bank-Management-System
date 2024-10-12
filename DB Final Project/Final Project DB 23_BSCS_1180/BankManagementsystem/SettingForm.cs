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
    public partial class SettingForm : Form
    {
        static bool admin;
        static int acc_num;

        public SettingForm(bool c)
        {
            InitializeComponent();
            admin = c;
        }
       
            private string connectionString = "Data Source=DESKTOP-618RHUU;Initial Catalog=BankDataBase;Integrated Security=True";

            public SettingForm()
            {
                InitializeComponent();
                // Other initialization code
            }

            private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
            {
                if (PassCheck.Checked)
                {
                    NewPinTb.PasswordChar = '\0';
                    ConfirmPinTb.PasswordChar = '\0';
                }
                else
                {
                    NewPinTb.PasswordChar = '*';
                ConfirmPinTb.PasswordChar = '*';
                }
            }



            private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void Applybtn2_Click(object sender, EventArgs e)
        {


        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            //adminPassTb.Text = "";
            ThemeCB.SelectedIndex = -1;
        }

        private void ThemeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Applybtn1_Click(object sender, EventArgs e)
        {
            if (ThemeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Select A Theme");
            }
            else if (ThemeCB.SelectedIndex == 0)
            {
                panel1.BackColor = Color.Orange;
            }

            else if (ThemeCB.SelectedIndex == 1)
            {
                panel1.BackColor = Color.Red;
            }
            else if (ThemeCB.SelectedIndex == 2)
            {
                panel1.BackColor = Color.Blue;
            }
            else if (ThemeCB.SelectedIndex == 3)
            {
                panel1.BackColor = Color.Yellow;
            }
            else if (ThemeCB.SelectedIndex == 4)
            {
                panel1.BackColor = Color.Pink;
            }
            else
            {
                panel1.BackColor = Color.Green;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
        private void ChangeAgentPin(string agentId, string newPin)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Manage_User SET AgPass = @Password WHERE AgId = @AgId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AgId", agentId);
                cmd.Parameters.AddWithValue("@Password", newPin);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "PIN updated successfully." : "Agent not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
    private void guna2Button1_Click(object sender, EventArgs e)
        {
            string newPin = NewPinTb.Text;
            string confirmPin = ConfirmPinTb.Text;

            if (newPin == confirmPin)
            {
                string agentId = Prompt.ShowDialog("Enter Agent ID:", "Change PIN");

                if (!string.IsNullOrEmpty(agentId))
                {
                    ChangeAgentPin(agentId, newPin);
                }
            }
            else
            {
                MessageBox.Show("PINs do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        private void ConfirmPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46 && c != 13)
            {
                e.Handled = true;
                NewPinlbl.Visible = true;
                NewPinlbl.ForeColor = Color.Red;
                NewPinlbl.Text = "Only Digits are allowed";
            }
        }

        private void NewPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46 && c != 13)
            {
                e.Handled = true;
                ConfirmPinLbl.Visible = true;
                ConfirmPinLbl.ForeColor = Color.Red;
                ConfirmPinLbl.Text = "Only Digits are allowed";
            }
        }


        private void PassCheck_CheckedChanged(object sender, EventArgs e)
        {
           
                if (PassCheck.Checked)
                {
                    ConfirmPinTb.PasswordChar = '\0';
                    NewPinTb.PasswordChar = '\0';
                }
                else
                {
                ConfirmPinTb.PasswordChar = '*';
                NewPinTb.PasswordChar = '*';
                }

            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginFoam obj = new LoginFoam();
            obj.Show();
            this.Hide();
        }
    }
}
       
