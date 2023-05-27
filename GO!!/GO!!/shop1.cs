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
    public partial class shop1 : UserControl
    {
        public shop1()
        {
            InitializeComponent();
        }

        private void shop1_Load(object sender, EventArgs e)
        {
            buy1.Hide();
            addtocart1.Hide();
            addtocart11.Hide();
            shoes1.Hide();
            addtocart21.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           buy1.Show();
           buy1.BringToFront();


        }

        private void addtocart1_Load(object sender, EventArgs e)
        {

        }

        private void addtocart1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buy1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            shoes1.Show();
            shoes1.BringToFront();
        }
    }
}
