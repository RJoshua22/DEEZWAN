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
    public partial class Buy : UserControl
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addtocart1 ac1 = new addtocart1();
            ac1.Dock = DockStyle.Fill;
            this.Controls.Add(ac1);
            ac1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addtocart ac = new addtocart();
            ac.Dock = DockStyle.Fill;
            this.Controls.Add(ac);
            ac.BringToFront();
        }
    }
}
