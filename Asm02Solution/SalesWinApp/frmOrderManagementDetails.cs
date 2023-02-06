using BusinessObject.Objects;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Detail = BusinessObject.Objects.Detail;

namespace SalesWinApp
{
    public partial class frmOrderManagementDetails : Form
    {
        public Order? Order { get; set; }
        public bool CreateOrUpdate { get; set; } //true: create, false: update

        private IOrderRepository orderRepository = new OrderRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private IMemberRepo memberRepo = new MemberRepo();
        private IEnumerable<Detail>? details;
        private BindingSource source;
        public frmOrderManagementDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrderManagementDetails_Load(object sender, EventArgs e)
        {
            //load cboMemberID items
            if (cboMemberID.Items.Count != memberRepo.GetMembers().Count() + 1)
            {
                cboMemberID.Items.Clear();
                var memberId = memberRepo.GetMembers().Select(x => x.MemberId);
                foreach (int m in memberId)
                {
                    cboMemberID.Items.Add(m);
                }
            }

            if (!CreateOrUpdate)
            {
                //initiate value
                txtOrderID.Text = Order.OrderId.ToString();
                txtOrderID.ReadOnly = true;
                txtFreight.Value = (decimal)Order.Freight;
                dtOrderDate.Value = Order.OrderDate;
                dtRequiredDate.Value = (DateTime)(Order.RequiredDate != null ? Order.RequiredDate : dtRequiredDate.Value);
                dtShipDate.Value = (DateTime)(Order.ShippedDate != null ? Order.ShippedDate : dtShipDate.Value);
                cboMemberID.SelectedItem = Order.MemberId;
            }
            //load dgvDetail
            LoadDetail();
            //calculate total
            LoadTotal();
        }

        private void LoadDetail()
        {
            if(Order != null)
            {
                int orderID = Order.OrderId;
                details = orderDetailRepository.GetDetails().Where(o => o.OrderId == orderID);
            }
            else
            {
                details = new List<Detail>();
            }
            source = new BindingSource();
            source.DataSource = details;
            dgvDetails.DataSource = null;
            dgvDetails.DataSource = source;
            dgvDetails.Columns[0].ReadOnly = true;
            dgvDetails.Columns[2].ReadOnly = true;
            if (!CreateOrUpdate)
            {
                dgvDetails.Columns[1].ReadOnly = true;
            }
        }

        private void LoadTotal()
        {
            decimal total = 0;
            if(details != null)
            {
                foreach (Detail d in details)
                {
                    total += (decimal)(1 - d.Discount) * d.Quantity * d.UnitPrice;
                }
            }
            total += txtFreight.Value;
            txtTotal.Value = total;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgvDetails.SelectedRows;
            int selectedRowsCount = selectedRows.Count;
            if (selectedRowsCount > 0)
            {
                if (MessageBox.Show("Do you want to remove this item?", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        IEnumerable<Detail> de = orderDetailRepository.GetDetails().Where(c => c.OrderId == Order.OrderId && c.ProductId == (int)row.Cells[0].Value);
                        orderDetailRepository.Delete(de.First());
                    }
                    LoadDetail();
                    LoadTotal();
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any row");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Detail> updateDetails = new List<Detail>();
            if (txtOrderID.Text == "" || cboMemberID.Text == "" || dgvDetails.RowCount == 0)
            {
                MessageBox.Show("Please input all fields");
            }
            else if (!int.TryParse(txtOrderID.Text, out int orderID) || orderID <= 0)
            {
                MessageBox.Show("Order ID must be positive integer");
            } else if (CreateOrUpdate && orderRepository.GetOrders().FirstOrDefault(o => o.OrderId == orderID) != null)
            {
                MessageBox.Show("Order ID existed");
            }
            else
            {
                int memberId = int.Parse(cboMemberID.Text);
                this.Order = new Order()
                {
                    OrderId = orderID,
                    MemberId = memberId,
                    OrderDate = dtOrderDate.Value,
                    RequiredDate = dtRequiredDate.Value,
                    ShippedDate = dtShipDate.Value,
                    Freight = txtFreight.Value,
                };
                foreach (DataGridViewRow row in dgvDetails.Rows)
                {
                    row.Cells[0].Value = orderID;
                }
                updateDetails = dgvDetails.SelectedRows.Cast<Detail>().ToList();
            }
            if (CreateOrUpdate)
            {
                orderRepository.AddOrder(Order);
                orderDetailRepository.Add(details.ToArray());
                this.DialogResult = DialogResult.OK;
            } else
            {
                orderRepository.UpdateOrder(Order);
                orderDetailRepository.Update(updateDetails.ToArray());
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtFreight_ValueChanged(object sender, EventArgs e)
        {
            LoadTotal();
        }
    }
}
