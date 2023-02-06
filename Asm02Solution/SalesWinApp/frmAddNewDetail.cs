using BusinessObject.Objects;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmAddNewDetail : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        IOrderDetailRepository detailRepository = new OrderDetailRepository();
        IProductRepository productRepository = new ProductRepository();
        public frmAddNewDetail()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var Order = new Order()
            {
                OrderId = Int32.Parse(txtOrderID.Text),
                MemberId = frmMainMember.accid,
                OrderDate = DateTime.Now,
                RequiredDate = DateTime.Now,
                ShippedDate = DateTime.Now,
                Freight = Int32.Parse(txtQuantity.Text)*10,
            };
            orderRepository.AddOrder(Order);

            var Detail = new Detail()
            {
                OrderId = Int32.Parse(txtOrderID.Text),
                ProductId = Int32.Parse(txtProductID.Text),
                Quantity = Int32.Parse(txtQuantity.Text),
                Discount = 0,
                UnitPrice = productRepository.GetProducts().Where(p => p.ProductId == Int32.Parse(txtProductID.Text)).First().UnitPrice,
            };
            detailRepository.Add(Detail);
            MessageBox.Show("Create Order Successfully!");
            this.Close();
            frmOrderDetail frmOrderDetail = new frmOrderDetail();
            frmOrderDetail.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
