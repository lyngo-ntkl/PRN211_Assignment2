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
using Microsoft.Identity.Client;

namespace SalesWinApp
{
    public partial class frmMemberManage : Form
    {
        private IMemberRepo _memberRepo = null;

        private BindingSource _bindingSource;

        private string memberID = null;
        public frmMemberManage()
        {
            InitializeComponent();
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void frmMemberManage_Load(object sender, EventArgs e)
        {
            LoadMemberAccount();
        }

        private void LoadMemberAccount(string content = null)
        {
            _memberRepo = null;
            _memberRepo = new MemberRepo();
            var memberAccounts = _memberRepo.GetMembers();
            if (txtSearch.Text != "")
            {
                memberAccounts = memberAccounts.Where(a => a.Email.ToUpper().Contains(content.ToUpper().Trim()));
            }
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = memberAccounts;
            dgvMemberManage.DataSource = null;
            dgvMemberManage.DataSource = _bindingSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var content = txtSearch.Text;
            LoadMemberAccount(content);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dgvMemberManage_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvMemberManage.SelectedRows)
                {
                    memberID = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewMember frmAddNewMember = new frmAddNewMember
            {
                AddOrUpdate = true, //Add
            };
            if (frmAddNewMember.ShowDialog() == DialogResult.OK)
            {
                LoadMemberAccount();
                frmAddNewMember.Close();
                _bindingSource.Position = _bindingSource.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMemberManage.SelectedRows)
            {
                _memberRepo = new MemberRepo();
                Member mem = _memberRepo.GetMembers().Where(c => c.MemberId.ToString() == row.Cells[0].Value.ToString()).First();
                frmAddNewMember frmAddNewMember = new frmAddNewMember
                {
                    AddOrUpdate = false, //Update               
                    mem = mem,
                };
                if (frmAddNewMember.ShowDialog() == DialogResult.OK)
                {
                    LoadMemberAccount();
                    frmAddNewMember.Close();
                    _bindingSource.Position = 1;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMemberManage.SelectedRows)
            {
                IEnumerable<Member> mem = _memberRepo.GetMembers().Where(c => c.MemberId.ToString() == row.Cells[0].Value.ToString());
                _memberRepo.DeleteMember(mem.First());
                LoadMemberAccount();
            }
        }
    }
}
