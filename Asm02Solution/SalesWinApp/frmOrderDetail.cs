using BusinessObject.Objects;
using DataAccess.Repository;
using Microsoft.Identity.Client;
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
    public partial class frmOrderDetail : Form
    {
        IOrderDetailRepository _orderDetail = new OrderDetailRepository();
        IOrderRepository _order = new OrderRepository();
        IEnumerable<Detail> details;
        IEnumerable<Order> orders;
        private BindingSource source;
        private int orderID;
        private int productID;


        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderDetail();
        }

        private void LoadOrderDetail()
        {
            _order = new OrderRepository();
            _orderDetail = new OrderDetailRepository();
            orders = _order.GetOrders();
            details = _orderDetail.GetDetails();

            var data = from order in orders
                       join detail in details on order.OrderId equals detail.OrderId
                       where order.MemberId == frmMainMember.accid
                       select new
                       {
                           detail.OrderId,
                           detail.ProductId,
                           detail.Quantity,
                           detail.Discount,
                           detail.UnitPrice,
                           order.OrderDate,
                           order.RequiredDate,
                           order.ShippedDate,
                           order.Freight
                       };
            source = new BindingSource();
            source.DataSource = data;
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = source;
        }

        private void dgvOrderDetail_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvOrderDetail.SelectedRows)
                {
                    orderID = int.Parse(row.Cells[0].Value.ToString());
                    productID = int.Parse(row.Cells[1].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _orderDetail = new OrderDetailRepository();
            IEnumerable<Detail> de = _orderDetail.GetDetails().Where(c => c.OrderId == orderID && c.ProductId == productID);
            _orderDetail.Delete(de.First());
            de = _orderDetail.GetDetails().Where(c => c.OrderId == orderID);
            if (de.Count() == 0)
            {
                _order = new OrderRepository();
                IEnumerable<Order> or = _order.GetOrders().Where(c => c.OrderId == orderID);
                _order.DeleteOrder(or.First());
            }
            LoadOrderDetail();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmAddNewDetail frmAddNewDetail = new frmAddNewDetail();
            this.Dispose();
            frmAddNewDetail.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            frmMainMember frmMainMember = new frmMainMember();
            this.Hide();
            frmMainMember.Show();
        }
    }
}
