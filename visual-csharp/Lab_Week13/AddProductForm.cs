using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_Week13.models;
namespace Lab_Week13
{
    public partial class AddProductForm : Form
    {
        public delegate void AddProductDelegate(string category, string product_name);
        public event AddProductDelegate AddProductEvent;
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            AddProductEvent(txtCategory.Text, txtProductName.Text);
        }
    }
}
