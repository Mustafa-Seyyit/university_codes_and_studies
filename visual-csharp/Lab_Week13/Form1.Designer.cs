
namespace Lab_Week13
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnShowOrder = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnGiveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(458, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 523);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(2, 12);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(450, 37);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.Location = new System.Drawing.Point(2, 55);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(450, 37);
            this.btnShowOrder.TabIndex = 1;
            this.btnShowOrder.Text = "Orders";
            this.btnShowOrder.UseVisualStyleBackColor = true;
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(12, 204);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(440, 264);
            this.lstCart.TabIndex = 2;
            // 
            // btnGiveOrder
            // 
            this.btnGiveOrder.Location = new System.Drawing.Point(30, 475);
            this.btnGiveOrder.Name = "btnGiveOrder";
            this.btnGiveOrder.Size = new System.Drawing.Size(422, 36);
            this.btnGiveOrder.TabIndex = 3;
            this.btnGiveOrder.Text = "Order";
            this.btnGiveOrder.UseVisualStyleBackColor = true;
            this.btnGiveOrder.Click += new System.EventHandler(this.btnGiveOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 523);
            this.Controls.Add(this.btnGiveOrder);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.btnShowOrder);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnShowOrder;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnGiveOrder;
    }
}

