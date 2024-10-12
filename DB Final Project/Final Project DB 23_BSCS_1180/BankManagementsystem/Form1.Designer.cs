namespace BankManagementsystem
{
    partial class LoginFoam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Userloginlbl = new System.Windows.Forms.Label();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.AdNameT = new System.Windows.Forms.TextBox();
            this.AdPassTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Quitbtn = new System.Windows.Forms.Button();
            this.RoleComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Reset_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.errLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Userloginlbl
            // 
            this.Userloginlbl.AutoSize = true;
            this.Userloginlbl.BackColor = System.Drawing.Color.Transparent;
            this.Userloginlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Userloginlbl.Location = new System.Drawing.Point(87, 148);
            this.Userloginlbl.Name = "Userloginlbl";
            this.Userloginlbl.Size = new System.Drawing.Size(238, 40);
            this.Userloginlbl.TabIndex = 13;
            this.Userloginlbl.Text = "USER LOGIN";
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.BackColor = System.Drawing.Color.MediumBlue;
            this.UserNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserNamelbl.Location = new System.Drawing.Point(92, 286);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(110, 25);
            this.UserNamelbl.TabIndex = 14;
            this.UserNamelbl.Text = "User Name";
            this.UserNamelbl.Click += new System.EventHandler(this.UserNamelbl_Click_1);
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.BackColor = System.Drawing.Color.MediumBlue;
            this.Passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Passlbl.Location = new System.Drawing.Point(92, 346);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(98, 25);
            this.Passlbl.TabIndex = 14;
            this.Passlbl.Text = "Password";
            this.Passlbl.Click += new System.EventHandler(this.UserNamelbl_Click_1);
            // 
            // AdNameT
            // 
            this.AdNameT.Location = new System.Drawing.Point(237, 286);
            this.AdNameT.Name = "AdNameT";
            this.AdNameT.Size = new System.Drawing.Size(336, 26);
            this.AdNameT.TabIndex = 1;
            this.AdNameT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdNameT_KeyPress);
            // 
            // AdPassTB
            // 
            this.AdPassTB.Location = new System.Drawing.Point(237, 343);
            this.AdPassTB.Name = "AdPassTB";
            this.AdPassTB.Size = new System.Drawing.Size(336, 26);
            this.AdPassTB.TabIndex = 2;
            this.AdPassTB.UseSystemPasswordChar = true;
            this.AdPassTB.TextChanged += new System.EventHandler(this.AdPassTB_TextChanged);
            // 
            // Quitbtn
            // 
            this.Quitbtn.BackColor = System.Drawing.Color.White;
            this.Quitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbtn.Location = new System.Drawing.Point(284, 461);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(290, 45);
            this.Quitbtn.TabIndex = 5;
            this.Quitbtn.Text = "Quit the Application";
            this.Quitbtn.UseVisualStyleBackColor = false;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.RoleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComboBox.FillColor = System.Drawing.Color.AliceBlue;
            this.RoleComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoleComboBox.ItemHeight = 30;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Agent"});
            this.RoleComboBox.Location = new System.Drawing.Point(237, 218);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(336, 36);
            this.RoleComboBox.TabIndex = 0;
            this.RoleComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(92, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Role";
            this.label1.Click += new System.EventHandler(this.UserNamelbl_Click_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Loginbtn
            // 
            this.Loginbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Loginbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Loginbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Loginbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Loginbtn.FillColor = System.Drawing.Color.White;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.Black;
            this.Loginbtn.Location = new System.Drawing.Point(284, 410);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(142, 45);
            this.Loginbtn.TabIndex = 3;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.Click += new System.EventHandler(this.LoginbtnLoginf_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.Loginbtn;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 10;
            this.guna2Elipse4.TargetControl = this.Quitbtn;
            // 
            // Reset_btn
            // 
            this.Reset_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reset_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reset_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reset_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reset_btn.FillColor = System.Drawing.Color.White;
            this.Reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.ForeColor = System.Drawing.Color.Black;
            this.Reset_btn.Location = new System.Drawing.Point(432, 410);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(142, 45);
            this.Reset_btn.TabIndex = 4;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.Reset_btn;
            // 
            // errLbl
            // 
            this.errLbl.AutoSize = true;
            this.errLbl.Location = new System.Drawing.Point(390, 372);
            this.errLbl.Name = "errLbl";
            this.errLbl.Size = new System.Drawing.Size(0, 20);
            this.errLbl.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankManagementsystem.Properties.Resources.man;
            this.pictureBox2.Location = new System.Drawing.Point(79, 592);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BankManagementsystem.Properties.Resources.ameenfahmy_ccvj2ZQaYaw_unsplash__1_1;
            this.pictureBox6.Location = new System.Drawing.Point(616, 63);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(544, 535);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BankManagementsystem.Properties.Resources.wjzsi;
            this.pictureBox5.Location = new System.Drawing.Point(1132, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BankManagementsystem.Properties.Resources.Bank;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1190, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(123, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "About this Project";
            // 
            // LoginFoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 660);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.errLbl);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.AdPassTB);
            this.Controls.Add(this.AdNameT);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNamelbl);
            this.Controls.Add(this.Userloginlbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFoam";
            this.Text = "Login Foam";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Userloginlbl;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.TextBox AdNameT;
        private System.Windows.Forms.TextBox AdPassTB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Quitbtn;
        private Guna.UI2.WinForms.Guna2ComboBox RoleComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button Loginbtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Button Reset_btn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private System.Windows.Forms.Label errLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

