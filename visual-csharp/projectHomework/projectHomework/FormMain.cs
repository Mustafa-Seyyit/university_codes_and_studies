using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            
        }

        private void menuOgrenci_Click(object sender, EventArgs e)
        {
            FormStudent fs = new FormStudent();
            fs.MdiParent = this;  
            fs.Show();
        }

        private void menuOgrenciGrafik_Click(object sender, EventArgs e)
        {
            FormChart fc = new FormChart();
            fc.MdiParent = this;
            fc.Show();
        }


        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogForm lf = new LogForm();
            lf.MdiParent = this;
            lf.Show();

        }

        

       

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                                           "Çıkış yapmak istiyor musunuz?",
                                           "Çıkış",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question
                                            );

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
