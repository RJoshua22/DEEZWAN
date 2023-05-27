using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO__
{
    public partial class Workout : Form
    {
        public Workout()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.FindForm().Hide();
        }

        private void Workout_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shop1 s1 = new shop1();
            s1.Dock = DockStyle.Fill;
            this.Controls.Add(s1);
            s1.BringToFront(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();

            Workout wr = new Workout();
            wr.Close();
            this.Visible = false;
        }
    }
}
