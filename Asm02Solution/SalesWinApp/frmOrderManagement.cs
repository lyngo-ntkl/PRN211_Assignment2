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
    public partial class frmOrderManagement : Form
    {
        private BindingSource source;
        private IOrderRepository orderRepository = new OrderRepository();
        private IMemberRepo memberRepo = new MemberRepo();
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            if(cboMemberId.Items.Count != memberRepo.GetMembers().Count()+1)
            {
                cboMemberId.Items.Clear();
                var memberId = memberRepo.GetMembers().Select(x => x.MemberId);
                cboMemberId.Items.Add("");
                foreach(int m in memberId)
                {
                    cboMemberId.Items.Add(m);
                }
            }
            LoadOrder();
        }

        private void LoadOrder(int? memberId = null)
        {
            var orders = orderRepository.GetOrders();
            if(memberId != null)
            {
                orders = orders.Where(x => x.MemberId == memberId);
            }
            source = new BindingSource();
            source.DataSource = orders;
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = source;
            dgvOrder.Columns[0].ReadOnly = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var memberId = cboMemberId.Text;
            if (memberId != null)
            {
                if (memberId.Equals(""))
                {
                    LoadOrder();
                }
                else
                {
                    LoadOrder(int.Parse(memberId));
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmOrderManagementDetails frmOrderManagementDetails = new frmOrderManagementDetails()
            {
                CreateOrUpdate = true
            };
            if(frmOrderManagementDetails.ShowDialog() == DialogResult.OK)
            {
                frmOrderManagementDetails.Hide();
                LoadOrder();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvOrder.CurrentCell.RowIndex;
            var orderId = (int?)dgvOrder.Rows[selectedRowIndex].Cells[0].Value;
            frmOrderManagementDetails frmOrderManagementDetails = new frmOrderManagementDetails()
            {
                CreateOrUpdate = false,
                Order = orderRepository.GetOrders().FirstOrDefault(o => o.OrderId == orderId)
            };
            frmOrderManagementDetails.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dgvOrder.SelectedRows;
            int selectedRowsCount = selectedRows.Count;
            if (selectedRowsCount > 0)
            {
                if (MessageBox.Show("Do you want to remove this order?", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        IEnumerable<Order> or = orderRepository.GetOrders().Where(c => c.OrderId == (int)row.Cells[0].Value);
                        orderRepository.DeleteOrder(or.First());
                    }
                    LoadOrder();
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any row");
            }
        }
    }
}
