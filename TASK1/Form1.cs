using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK1
{
    public partial class Form1 : Form
    {
        DateTime dt =DateTime.Now;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dt =  dt.AddSeconds(1); 
            label1.Text = dt.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bakiBTN_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            this.BackgroundImage = Properties.Resources.BakuImage;
        }

        private void londonBTN_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now.AddHours(-3);
            this.BackgroundImage = Properties.Resources.LondonImage;

        }
    }
}
