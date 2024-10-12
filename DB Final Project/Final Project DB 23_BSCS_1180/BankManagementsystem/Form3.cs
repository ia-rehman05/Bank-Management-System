using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementsystem
{
    public partial class TransactionForm : Form
    {

        static bool Admin;
        public TransactionForm()
        {
            InitializeComponent();
        }
        public TransactionForm(bool b)
        {
            InitializeComponent();
            Admin = b;
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-618RHUU;Initial Catalog=BankDataBase;Integrated Security=True");

        int Balance;
        private void CheckBalance()
        {
            string connectionString = (@"Data Source=DESKTOP-618RHUU;Initial Catalog=BankDataBase;Integrated Security=True");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT AcBal FROM Add_Account WHERE AC_Num = @accountNumber";
                    using (SqlCommand sqlcom = new SqlCommand(query, conn))
                    {
                        sqlcom.Parameters.AddWithValue("@accountNumber", CheckBalanceTB.Text);

                        object result = sqlcom.ExecuteScalar();
                        if (result != null)
                        {
                            BalanceLbl.Text = "Rs " + result.ToString();
                            Balance = Convert.ToInt32(result.ToString());
                        }
                        else
                        {
                            BalanceLbl.Text = "Account not found.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    BalanceLbl.Text = "Error retrieving balance: " + ex.Message;
                }
            }
        }
        private void GetNewBalance()
        {
            string connectionString = (@"Data Source=DESKTOP-618RHUU;Initial Catalog=BankDataBase;Integrated Security=True");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT AcBal FROM Add_Account WHERE AC_Num = @accountNumber";
                    using (SqlCommand sqlcom = new SqlCommand(query, conn))
                    {
                        sqlcom.Parameters.AddWithValue("@accountNumber", CheckBalanceTB.Text);

                        object result = sqlcom.ExecuteScalar();
                        if (result != null)
                        {
                            Balance = Convert.ToInt32(result.ToString());
                        }
                        else
                        {
                            BalanceLbl.Text = "Account not found.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    BalanceLbl.Text = "Error retrieving balance: " + ex.Message;
                }
            }
        }
        private void TransChkbtn_Click(object sender, EventArgs e)
        {
            if (CheckBalanceTB.Text == "")
            {
                MessageBox.Show("Enter Accout Number");
            }
            else
            {
                CheckBalance();
                if (BalanceLbl.Text == "YourBalance")
                {
                    MessageBox.Show("Account Not Found");

                    CheckBalanceTB.Text = "";
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            if (AccNumDepositTb.Text == "" || AmountDepositTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();

                    // Retrieve the current balance
                    SqlCommand getBalanceCmd = new SqlCommand("SELECT AcBal FROM Add_Account WHERE Ac_Num=@AcNum", conn);
                    getBalanceCmd.Parameters.AddWithValue("@AcNum", AccNumDepositTb.Text);
                    int currentBalance = Convert.ToInt32(getBalanceCmd.ExecuteScalar());

                    // Calculate the new balance
                    int depositAmount = Convert.ToInt32(AmountDepositTb.Text);
                    int newBal = currentBalance + depositAmount;

                    // Update the balance
                    SqlCommand cmd = new SqlCommand("UPDATE Add_Account SET AcBal=@AB WHERE Ac_Num=@AcKey", conn);
                    cmd.Parameters.AddWithValue("@AB", newBal);
                    cmd.Parameters.AddWithValue("@AcKey", AccNumDepositTb.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Money Deposited!!!");
                    conn.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Withdrawtn_Click(object sender, EventArgs e)
        {
            if (AccNumDepositTb.Text == "" || AmountDepositTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    conn.Open();

                    SqlCommand getBalanceCmd = new SqlCommand("SELECT AcBal FROM Add_Account WHERE Ac_Num=@AcNum", conn);
                    getBalanceCmd.Parameters.AddWithValue("@AcNum", AccNumDepositTb.Text);
                    int currentBalance = Convert.ToInt32(getBalanceCmd.ExecuteScalar());

                    int WithdrawnAmount = Convert.ToInt32(AmountDepositTb.Text);
                    int newBal = currentBalance - WithdrawnAmount;

                    SqlCommand cmd = new SqlCommand("UPDATE Add_Account SET AcBal=@AB WHERE Ac_Num=@AcKey", conn);
                    cmd.Parameters.AddWithValue("@AB", newBal);
                    cmd.Parameters.AddWithValue("@AcKey", AccNumDepositTb.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Money Withdrawned!!!");
                    conn.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

        }

        private void AccNoLbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (Admin)
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

        private void ResetTrans_Click(object sender, EventArgs e)
        {

        }

        private void AccNumWithdrawTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transferbtn2_Click(object sender, EventArgs e)
        {

            
                if (FromTransferTB.Text == "" || TbTransferTb.Text == "" || AmountTransferTB.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        conn.Open();

                        // Check if sender account exists
                        if (!AccountExists(FromTransferTB.Text))
                        {
                            MessageBox.Show("Sender Account does not exist.");
                            conn.Close();
                            return;
                        }

                        // Check if receiver account exists
                        if (!AccountExists(TbTransferTb.Text))
                        {
                            MessageBox.Show("Receiver Account does not exist.");
                            conn.Close();
                            return;
                        }

                        // Retrieve the current balance of the sender
                        SqlCommand getSenderBalanceCmd = new SqlCommand("SELECT AcBal FROM Add_Account WHERE Ac_Num=@FromAcNum", conn);
                        getSenderBalanceCmd.Parameters.AddWithValue("@FromAcNum", FromTransferTB.Text);
                        int senderBalance = Convert.ToInt32(getSenderBalanceCmd.ExecuteScalar());

                        // Retrieve the current balance of the receiver
                        SqlCommand getReceiverBalanceCmd = new SqlCommand("SELECT AcBal FROM Add_Account WHERE Ac_Num=@ToAcNum", conn);
                        getReceiverBalanceCmd.Parameters.AddWithValue("@ToAcNum", TbTransferTb.Text);
                        int receiverBalance = Convert.ToInt32(getReceiverBalanceCmd.ExecuteScalar());

                        int transferAmount = Convert.ToInt32(AmountTransferTB.Text);

                        // Check if sender has enough balance
                        if (senderBalance < transferAmount)
                        {
                            MessageBox.Show("Insufficient Balance in Sender's Account");
                        }
                        else
                        {
                            // Calculate new balances
                            int newSenderBalance = senderBalance - transferAmount;
                            int newReceiverBalance = receiverBalance + transferAmount;

                            // Update sender's balance
                            SqlCommand updateSenderCmd = new SqlCommand("UPDATE Add_Account SET AcBal=@SenderNewBal WHERE Ac_Num=@FromAcNum", conn);
                            updateSenderCmd.Parameters.AddWithValue("@SenderNewBal", newSenderBalance);
                            updateSenderCmd.Parameters.AddWithValue("@FromAcNum", FromTransferTB.Text);
                            updateSenderCmd.ExecuteNonQuery();

                            // Update receiver's balance
                            SqlCommand updateReceiverCmd = new SqlCommand("UPDATE Add_Account SET AcBal=@ReceiverNewBal WHERE Ac_Num=@ToAcNum", conn);
                            updateReceiverCmd.Parameters.AddWithValue("@ReceiverNewBal", newReceiverBalance);
                            updateReceiverCmd.Parameters.AddWithValue("@ToAcNum", TbTransferTb.Text);
                            updateReceiverCmd.ExecuteNonQuery();

                            MessageBox.Show("Transfer Successful!!!");
                        }

                        conn.Close();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            



        }

        private void AccNumDepositTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool AccountExists(string accountNumber)
        {
            SqlCommand checkAccountCmd = new SqlCommand("SELECT COUNT(*) FROM Add_Account WHERE Ac_Num=@AcNum", conn);
            checkAccountCmd.Parameters.AddWithValue("@AcNum", accountNumber);
            int accountCount = Convert.ToInt32(checkAccountCmd.ExecuteScalar());
            return accountCount > 0;
        }
        private void Searchfrom_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (AccountExists(FromTransferTB.Text))
                {
                    MessageBox.Show("Sender Account exists.");
                }
                else
                {
                    MessageBox.Show("Sender Account does not exist.");
                }
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        
    }

        private void SearchTo_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (AccountExists(TbTransferTb.Text))
                {
                    MessageBox.Show("Receiver Account exists.");
                }
                else
                {
                    MessageBox.Show("Receiver Account does not exist.");
                }
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
    }
}
