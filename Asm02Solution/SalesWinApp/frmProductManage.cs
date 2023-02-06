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
    public partial class frmProductManage : Form
    {
        private IProductRepository _productRepo = null;

        private BindingSource _bindingSource;
        public frmProductManage()
        {
            InitializeComponent();
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void frmProductManage_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void LoadProduct(string content = null)
        {
            _productRepo = new ProductRepository();
            var products = _productRepo.GetProducts();
            if (txtSearch.Text != "")
            {
                products = products.Where(a => a.ProductName.ToUpper().Contains(content.ToUpper().Trim()));
            }
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = products;
            dgvProductManage.DataSource = null;
            dgvProductManage.DataSource = _bindingSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var content = txtSearch.Text;
            LoadProduct(content);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewProduct frmAddNewProduct = new frmAddNewProduct
            {
                AddOrUpdate = true, //Add
            };
            if (frmAddNewProduct.ShowDialog() == DialogResult.OK)
            {
                LoadProduct();
                frmAddNewProduct.Close();
                _bindingSource.Position = _bindingSource.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductManage.SelectedRows)
            {
                _productRepo = new ProductRepository();
                Product pro = _productRepo.GetProducts().Where(c => c.ProductId.ToString() == row.Cells[0].Value.ToString()).First();
                frmAddNewProduct frmAddNewProduct = new frmAddNewProduct
                {
                    AddOrUpdate = false, //Update               
                    pro = pro,
                };
                if (frmAddNewProduct.ShowDialog() == DialogResult.OK)
                {
                    LoadProduct();
                    frmAddNewProduct.Close();
                    _bindingSource.Position = 1;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductManage.SelectedRows)
            {
                IEnumerable<Product> pro = _productRepo.GetProducts().Where(c => c.ProductId.ToString() == row.Cells[0].Value.ToString());
                _productRepo.DeleteProduct(pro.First());
                LoadProduct();
            }
        }
    }
}
