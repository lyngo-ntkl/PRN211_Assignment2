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
    public partial class frmAddNewMember : Form
    {
        private readonly IMemberRepo _memberRepo = new MemberRepo();

        //private readonly ICustomerAccountRepo _customerAccountRepo = new CustomerAccountRepo();
        public bool AddOrUpdate;
        public Member mem;
        public frmAddNewMember()
        {
            InitializeComponent();
        }

        private void frmAddNewMember_Load(object sender, EventArgs e)
        {
            if (AddOrUpdate) // Add
            {

            }
            else //Update
            {
                txtMemberID.Text = mem.MemberId.ToString();
                txtEmail.Text = mem.Email;
                txtCompany.Text = mem.CompanyName;
                txtCity.Text = mem.City;
                txtCountry.Text = mem.Country;
                txtPassword.Text = mem.Password;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text == "" || txtEmail.Text == "" || txtCompany.Text == "" || txtCity.Text == "" || txtCountry.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please input all field");
            }
            else
            {
                Member mem = new Member
                {
                    MemberId = Int32.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompany.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Password = txtPassword.Text,
                };
                if (AddOrUpdate) //Add
                {
                    _memberRepo.CreateMember(mem);
                    this.DialogResult = DialogResult.OK;
                }
                else // Update
                {
                    _memberRepo.UpdateMember(mem);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
