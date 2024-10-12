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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool check = true;
            SettingForm SF = new SettingForm(check);
            SF.Show();
        }
       


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
           ManageUser obh = new ManageUser();
            obh.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TransactionForm Trans = new TransactionForm();
            Trans.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoginFoam obj = new LoginFoam();
            obj.Show();
            this.Hide();
        }

        private void AdduserbtnAP_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewAccount newAccount = new NewAccount();
            newAccount.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
