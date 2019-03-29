using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedPerformanceMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                float fcpu = CPU.NextValue();
                float dram = RAM.NextValue();
                bunifuCircleProgressbar1.Value = (int)fcpu;
                bunifuCircleProgressbar1.Text = string.Format("{0:0.00}%", fcpu);

                bunifuCircleProgressbar2.Value = (int)dram;
                bunifuCircleProgressbar2.Text = string.Format("{0:0.00}%", dram);
            }
            catch (Exception)
            {
            }
        }
    }
}
