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
using System.Collections;
namespace Lab_Week13
{
    public partial class Form1 : Form
    {
        storeEntities db = new storeEntities();

        Hashtable cart = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm frmAddProduct = new AddProductForm();
            frmAddProduct.AddProductEvent += addProduct;
            frmAddProduct.ShowDialog();
        }


        public void loadProducts()
        {

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = db.products.Select(product => new
            {
                ID=product.id,
                Category=product.category,
                Name = product.product_name
            }).ToList();

            DataGridViewButtonColumn bc = new DataGridViewButtonColumn();
            bc.HeaderText = "Order";
            bc.Text = "Add";
            bc.UseColumnTextForButtonValue = true;


            dataGridView1.Columns.Add(bc);
        }
       

        public void addProduct(string category_name, string product_name)
        {
            products p1 = new products();
            p1.category = category_name;
            p1.product_name = product_name;

            db.products.Add(p1);
            db.SaveChanges();

            loadProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 3)
                {
                    int productID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    string productName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    if (cart.ContainsKey(productID)) return;
                    cart.Add(productID, productName);
                    lstCart.Items.Add(productName);
                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnGiveOrder_Click(object sender, EventArgs e)
        {
            
            orders order = new orders();
            order.order_date = DateTime.Now;

            db.orders.Add(order);
            db.SaveChanges();
            

            foreach(int productId in cart.Keys)
            {
                order_product o1 = new order_product();
                o1.order_id = order.id;
                o1.product_id = productId;
                db.order_product.Add(o1);
            }

            db.SaveChanges();
            lstCart.Items.Clear();
            cart.Clear();
            MessageBox.Show("Order created !!");
        }
    }
}
