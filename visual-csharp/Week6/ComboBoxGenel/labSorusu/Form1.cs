using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labSorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int countForClickToButton = 0;
        Random rnd = new Random();
        double gecenSure = 0;
        private void btn_1_Click(object sender, EventArgs e)
        {
            countForClickToButton++;
            if (countForClickToButton == 1)
            {
                timer1.Start();
                timer_pb.Start();
                lbl.Text = "kalan Süre:" + (60-gecenSure).ToString();
                lbl.Visible = true;
            }else
            {
                timer1.Stop();
                timer_pb.Stop();
                MessageBox.Show("tebrikler kazandınız");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100 ;
            timer_pb.Interval = 1000;
            progressBar1.Step = 1;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 60;
            progressBar1.Value = 60;
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            gecenSure += 0.1;

            if (60 -(int)gecenSure <= 0)
            {
                timer_pb.Stop();
                timer1.Stop();
                MessageBox.Show("kazanamadınız");
                return;
            }

            lbl.Text = "kalan Süre:" + (60 - gecenSure).ToString();
            btn_1.Location = new Point(rnd.Next(0, ClientSize.Width), rnd.Next(0, ClientSize.Height));
        }

        private void timer_pb_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 1;
            }
        }
    }
}
