using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alexissfurnigrabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string st;
            st = textBox5.Text;
            System.Diagnostics.Process.Start("https://cdn.habnet.io/nitro/furniture/" + st + ".nitro");
            System.Diagnostics.Process.Start("https://cdn.habnet.io/swf/furni/FURNI-20205867/" + st + ".swf");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string re;
            re = textBox6.Text;
            System.Diagnostics.Process.Start("https://habnet.re/game/dcr/hof_furni/" + re + ".swf");
            System.Diagnostics.Process.Start("https://habnet.re/nitrov3/swf/bundled/furniture/" + re + ".nitro");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string leet;
            leet = textBox4.Text;
            System.Diagnostics.Process.Start("https://images.leethotel.biz/library/hof_furni/" + leet + ".swf");
            System.Diagnostics.Process.Start("https://images.leethotel.biz/leet-asset-bundles/libraries/furniture/" + leet +".nitro");
        }
    }
}
