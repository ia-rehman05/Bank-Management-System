using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementsystem
{
    public partial class EditUser : Form
    {
        //private System.Windows.Forms.TextBox txtName;
        //private System.Windows.Forms.TextBox txtPhone;
        //private System.Windows.Forms.TextBox txtAddress;
        //private System.Windows.Forms.TextBox txtGender;
        //private System.Windows.Forms.TextBox txtEdu;
        //private System.Windows.Forms.TextBox txtOccupation;
        //private System.Windows.Forms.TextBox txtCNIC;
        //private System.Windows.Forms.Button btnSave;

        //private  void InitializeComponent()
        //{
        //    this.txtName = new System.Windows.Forms.TextBox();
        //    this.txtPhone = new System.Windows.Forms.TextBox();
        //    this.txtAddress = new System.Windows.Forms.TextBox();
        //    this.txtGender = new System.Windows.Forms.TextBox();
        //    this.txtEdu = new System.Windows.Forms.TextBox();
        //    this.txtOccupation = new System.Windows.Forms.TextBox();
        //    this.txtCNIC = new System.Windows.Forms.TextBox();
        //    this.btnSave = new System.Windows.Forms.Button();
        //    this.SuspendLayout();
        //    // 
        //    // txtName
        //    // 
        //    this.txtName.Location = new System.Drawing.Point(100, 30);
        //    this.txtName.Name = "txtName";
        //    this.txtName.Size = new System.Drawing.Size(200, 20);
        //    this.txtName.TabIndex = 0;
        //    // 
        //    // txtPhone
        //    // 
        //    this.txtPhone.Location = new System.Drawing.Point(100, 60);
        //    this.txtPhone.Name = "txtPhone";
        //    this.txtPhone.Size = new System.Drawing.Size(200, 20);
        //    this.txtPhone.TabIndex = 1;
        //    // 
        //    // txtAddress
        //    // 
        //    this.txtAddress.Location = new System.Drawing.Point(100, 90);
        //    this.txtAddress.Name = "txtAddress";
        //    this.txtAddress.Size = new System.Drawing.Size(200, 20);
        //    this.txtAddress.TabIndex = 2;
        //    // 
        //    // txtGender
        //    // 
        //    this.txtGender.Location = new System.Drawing.Point(100, 120);
        //    this.txtGender.Name = "txtGender";
        //    this.txtGender.Size = new System.Drawing.Size(200, 20);
        //    this.txtGender.TabIndex = 3;
        //    // 
        //    // txtEdu
        //    // 
        //    this.txtEdu.Location = new System.Drawing.Point(100, 150);
        //    this.txtEdu.Name = "txtEdu";
        //    this.txtEdu.Size = new System.Drawing.Size(200, 20);
        //    this.txtEdu.TabIndex = 4;
        //    // 
        //    // txtOccupation
        //    // 
        //    this.txtOccupation.Location = new System.Drawing.Point(100, 180);
        //    this.txtOccupation.Name = "txtOccupation";
        //    this.txtOccupation.Size = new System.Drawing.Size(200, 20);
        //    this.txtOccupation.TabIndex = 5;
        //    // 
        //    // txtCNIC
        //    // 
        //    this.txtCNIC.Location = new System.Drawing.Point(100, 210);
        //    this.txtCNIC.Name = "txtCNIC";
        //    this.txtCNIC.Size = new System.Drawing.Size(200, 20);
        //    this.txtCNIC.TabIndex = 6;
        //    // 
        //    // btnSave
        //    // 
        //    this.btnSave.Location = new System.Drawing.Point(225, 240);
        //    this.btnSave.Name = "btnSave";
        //    this.btnSave.Size = new System.Drawing.Size(75, 23);
        //    this.btnSave.TabIndex = 7;
        //    this.btnSave.Text = "Save";
        //    this.btnSave.UseVisualStyleBackColor = true;
        //    //this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        //    // 
        //    // EditForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(334, 281);
        //    this.Controls.Add(this.btnSave);
        //    this.Controls.Add(this.txtCNIC);
        //    this.Controls.Add(this.txtOccupation);
        //    this.Controls.Add(this.txtEdu);
        //    this.Controls.Add(this.txtGender);
        //    this.Controls.Add(this.txtAddress);
        //    this.Controls.Add(this.txtPhone);
        //    this.Controls.Add(this.txtName);
        //    this.Name = "EditForm";
        //    this.Text = "Edit Account";
        //    this.ResumeLayout(false);
        //    this.PerformLayout();
        //}


        private string connectionString = "Data Source=DESKTOP-618RHUU;Initial Catalog=BankDB;Integrated Security=True";
        private int accNum;

        public EditUser(int accNum)
        {
            this.accNum = accNum;
            LoadAccountData();
        }

        private void LoadAccountData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string Query = "SELECT * FROM Add_Account WHERE AC_Num = @Acc_Num";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Ac_Num", accNum);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtPhone.Text = reader["AcPhone"].ToString();
                    txtAddress.Text = reader["AcAddress"].ToString();
                    txtGender.Text = reader["ACGender"].ToString();
                    txtEdu.Text = reader["ACEdu"].ToString();
                    txtOccupation.Text = reader["AcOccupation"].ToString();
                    txtCNIC.Text = reader["AcCNIN"].ToString();
                }
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Accounts SET AcName = @AcName, AcPhone = @AcPhone, AcAddress = @AcAddress, ACGender = @ACGender, ACEdu = @ACEdu, AcOccupation = @AcOccupation, AcCNIN = @AcCNIN WHERE Acc_Num = @Acc_Num";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AcName", txtName.Text);
                cmd.Parameters.AddWithValue("@AcPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@AcAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@ACGender", txtGender.Text);
                cmd.Parameters.AddWithValue("@ACEdu", txtEdu.Text);
                cmd.Parameters.AddWithValue("@AcOccupation", txtOccupation.Text);
                cmd.Parameters.AddWithValue("@AcCNIN", txtCNIC.Text);
                cmd.Parameters.AddWithValue("@Acc_Num", accNum);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Account updated successfully.");
            this.Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
   