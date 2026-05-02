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

namespace ProjeOdev
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("log.txt"))
            {
                txtLog.Text = File.ReadAllText("log.txt");
            }
            else
            {
                txtLog.Text = "Henüz log kaydı yok.";
            }
        }
    }
}
