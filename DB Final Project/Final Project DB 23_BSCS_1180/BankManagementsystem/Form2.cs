using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementsystem
{
    public partial class MainMenuf2 : Form
    {
        public MainMenuf2()
        {
            InitializeComponent();
        }

        private void MainMenuf2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFoam loginFoam = new LoginFoam();
            loginFoam.Show();
        }

        private void Accountslbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewAccount NAcc = new NewAccount();
            NAcc.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewAccount NAcc = new NewAccount();
            NAcc.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Transcationslbl_Click(object sender, EventArgs e)
        {
            TransactionForm obj = new TransactionForm();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TransactionForm obj = new TransactionForm();
            obj.Show();
            this.Hide();
        }

        private void Settinglbl_Click(object sender, EventArgs e)
        {
            SettingForm obj = new SettingForm();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SettingForm obj = new SettingForm();
            obj.Show();
            this.Hide();
        }
    }
}
