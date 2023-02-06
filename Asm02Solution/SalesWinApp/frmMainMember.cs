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
    public partial class frmMainMember : Form
    {
        private IMemberRepo _memberAccount = new MemberRepo();
        private IMemberRepo _memberRepo = null;
        public static string acc;
        public static int accid;
        public frmMainMember()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void frmMainMember_Load(object sender, EventArgs e)
        {
            LoadMainMember();
        }


        private void LoadMainMember()
        {
            _memberAccount = new MemberRepo();
            var account = _memberAccount.GetMembers().Where(a => a.Email == acc).FirstOrDefault();
            lbWelcome.Text = "Hello " + account.Email.ToString();
            txtEmail.Text = account.Email.ToString();
            txtCompany.Text = account.CompanyName.ToString();
            txtCity.Text = account.City.ToString();
            txtCountry.Text = account.Country.ToString();
            accid = account.MemberId;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            _memberRepo = new MemberRepo();
            Member mem = _memberRepo.GetMembers().Where(c => c.Email.ToString() == acc).First();
            frmUpdateProfile frmUpdateProfile = new frmUpdateProfile
            {            
                mem = mem,
            };
            if (frmUpdateProfile.ShowDialog() == DialogResult.OK)
            {
                /*frmMainMember frmMainMember = new frmMainMember();
                frmMainMember.Refresh();*/
                frmUpdateProfile.Close();
                LoadMainMember();
            }
        }

        private void btnViewOrderDetail_Click(object sender, EventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail();
            frmOrderDetail.Show();
            this.Dispose();
        }
    }
}
