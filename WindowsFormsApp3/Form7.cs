using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public void RedVelvet()
        {
            Image image = Properties.Resources.Lipstick_red;
            //truck.Image = image;
            //truck.SizeMode = PictureBoxSizeMode.StretchImage;

            int red_lip_X, red_lip_Y;

            red_lip_X = redlip.Location.X.GetHashCode();
            red_lip_Y = redlip.Location.Y.GetHashCode();


            int i, j;
            i = 35;
            j = 197;
            redlip.Location = new Point(i, j);
            while (j < 300)
            {
                j += 10;
                Thread.Sleep(10);
                redlip.Location = new Point(i, j);
            }
            while (i < 700)
            {
                i += 10;
                Thread.Sleep(7);
                redlip.Location = new Point(i, j);
            }

            redlip.Location = new Point(red_lip_X, red_lip_Y);

        }

        Thread red;
        private void Red_bel1_Click(object sender, EventArgs e)
        {
            red = new Thread(RedVelvet);
            red.Start();
            truck.Enabled = true;
        }

        private void redlip_Click(object sender, EventArgs e)
        {

        }
    }
}
