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

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (var comp in Controls)
            {
                if (comp is Button)
                {
                    Button btn1 = (Button)comp;
                    btn1.Text = rnd.Next(1, 6).ToString();
                }
            }
        }


       private void ChangeColor_withCheckbox(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox checkBox = (CheckBox)sender;

                if (checkBox.Checked)
                {
                    foreach (var comp in Controls)
                    {
                        if (comp is Button)
                        {
                            Button button = (Button)comp;

                            if (button.Text == checkBox.Text)
                            {
                                button.BackColor = DefaultBackColor;
                            }
                        }
                    }
                }
                else
                {
                    Random rnd = new Random();
                    Color randomcolor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                    foreach (var comp in Controls)
                    {
                        if (comp is Button)
                        {
                            Button button = (Button)(comp);
                            if (button.Text == checkBox.Text)
                            {
                                button.BackColor = randomcolor;
                            }     
                        }
                    }
                }
            }
        }
        
    }
}
