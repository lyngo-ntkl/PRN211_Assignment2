using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Objects;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmAddNewProduct : Form
    {
        private IProductRepository _productRepo = new ProductRepository();
        public bool AddOrUpdate;
        public Product pro;
        public frmAddNewProduct()
        {
            InitializeComponent();
        }

        private void frmAddNewProduct_Load(object sender, EventArgs e)
        {
            if (AddOrUpdate) // Add
            {

            }
            else //Update
            {
                txtProductID.Text = pro.ProductId.ToString();
                txtCategoryID.Text = pro.CategoryId.ToString();
                txtProductName.Text = pro.ProductName;
                txtWeight.Text = pro.Weight;
                txtUnitPrice.Text = (decimal.ToInt32(pro.UnitPrice)).ToString();
                txtUnitStock.Text = pro.UnitsInStock.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" || txtCategoryID.Text == "" || txtProductName.Text == "" || txtWeight.Text == "" || txtUnitPrice.Text == "" || txtUnitStock.Text == "")
            {
                MessageBox.Show("Please input all field");
            }
            else
            {
                _productRepo = new ProductRepository();
                Product pro = new Product
                {
                    ProductId = Int32.Parse(txtProductID.Text),
                    CategoryId = Int32.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = Int32.Parse(txtUnitStock.Text),
                };
                if (AddOrUpdate) //Add
                {
                    _productRepo.AddProduct(pro);
                    this.DialogResult = DialogResult.OK;
                }
                else // Update
                {
                    _productRepo.UpdateProduct(pro);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
