using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class SystemSP : Form
    {
        public SystemSP()
        {
            InitializeComponent();
            //gunaPanel19.Height = 34;
            //gunaPanel17.Height = 34;
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void SystemSP_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SystemSP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        //private void gunaPictureBox10_Click(object sender, EventArgs e)
        //{
        //    if(gunaPanel19.Height == 34) gunaPanel19.Height = 128;
        //    else gunaPanel19.Height = 34;
        //}

        //private void gunaPictureBox9_Click(object sender, EventArgs e)
        //{
        //    if (gunaPanel17.Height == 34) gunaPanel17.Height = 93;
        //    else gunaPanel17.Height = 34;
        //}
    }
}
