using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        private readonly IMemberRepo _memberAccount = new MemberRepo();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Validation input data
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please input email!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please input Password");
            }
            else
            {
                var account = _memberAccount.GetMembers()
                    .Where(a => a.Email == txtEmail.Text
                     && a.Password == txtPassword.Text).FirstOrDefault();
                if (account == null)
                {
                    MessageBox.Show("Invalid username or password!");
                }
                else
                {
                    //check role admin
                    if (account.Email == "admin")
                    {
                        frmMain frmMain = new frmMain();
                        frmMain.acc = account.Email;
                        this.Hide();
                        frmMain.Show();
                    }
                    else
                    {
                        frmMainMember frmMainMember = new frmMainMember();
                        frmMainMember.acc = account.Email;

                        this.Hide();
                        frmMainMember.Show();
                    }
                }

            }
        }
    }
}