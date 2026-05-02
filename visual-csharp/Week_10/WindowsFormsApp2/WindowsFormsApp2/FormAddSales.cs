using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormAddSales : Form
    {

        public delegate void AddNewSaleData(int year, double amount);
        public event AddNewSaleData AddNewSaleEvent;
        public FormAddSales()
        {
            InitializeComponent();
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            int year = -1;
            double amount = -1;
            if (!int.TryParse(txtYear.Text, out year) || !double.TryParse(txtAmount.Text, out amount))
                return;


            AddNewSaleEvent(year, amount);
            this.Close();
        }
    }
}
