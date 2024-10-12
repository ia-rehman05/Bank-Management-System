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
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BluePnael.Width += 6;
            if (BluePnael.Width >= 370)
            {
                timer1.Stop();
                this.Hide();
                LoginFoam f = new LoginFoam();
                f.Show();
            }
            int percentage = (BluePnael.Width * 99) / 370;
            Percent.Text = $"{percentage}%";

        }

        private void BluePnael_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
