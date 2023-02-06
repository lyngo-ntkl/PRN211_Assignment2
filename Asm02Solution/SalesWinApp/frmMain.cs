using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        private readonly IMemberRepo _memberAccount = new MemberRepo();
        public static string acc;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var account = _memberAccount.GetMembers().Where(a => a.Email == acc).FirstOrDefault();
            lbWelcome.Text = "Hello " + account.Email.ToString();
            txtEmail.Text = account.Email.ToString();
            txtCompany.Text = account.CompanyName.ToString();
            txtCity.Text = account.City.ToString();
            txtCountry.Text = account.Country.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMemberManage_Click(object sender, EventArgs e)
        {
            frmMemberManage frmMemberManage = new frmMemberManage();
            this.Hide();
            frmMemberManage.Show();
        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            frmProductManage frmProductManage = new frmProductManage();
            this.Hide();
            frmProductManage.Show();
        }

        private void btnOrderManage_Click(object sender, EventArgs e)
        {
            frmOrderManagement frmOrderManagement = new frmOrderManagement();
            this.Hide();
            if(frmOrderManagement.ShowDialog() == DialogResult.Cancel)
            {
                frmOrderManagement.Hide();
                this.Show();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }
    }
}
