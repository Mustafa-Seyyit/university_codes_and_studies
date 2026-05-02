using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\musta\\OneDrive\\Masaüstü\\finalgörsel\\hafta6\\ListBox\\Ornek2\\pilots.txt");
            
            while(sr.ReadLine() != null)
            {
                lst_bx1.Items.Add(sr.ReadLine());
            }

        }
    }
}
