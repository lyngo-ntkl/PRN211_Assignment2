namespace SalesWinApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnMemberManage = new System.Windows.Forms.Button();
            this.btnProductManage = new System.Windows.Forms.Button();
            this.btnOrderManage = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbPermission = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWelcome.Location = new System.Drawing.Point(45, 36);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(86, 38);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Hello";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(45, 91);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(129, 31);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "Profile Info:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(45, 138);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(63, 28);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email:";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCompany.Location = new System.Drawing.Point(45, 180);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(100, 28);
            this.lbCompany.TabIndex = 3;
            this.lbCompany.Text = "Company:";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(45, 221);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(50, 28);
            this.lbCity.TabIndex = 4;
            this.lbCity.Text = "City:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(45, 262);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(86, 28);
            this.lbCountry.TabIndex = 5;
            this.lbCountry.Text = "Country:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(164, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(165, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(164, 184);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(165, 27);
            this.txtCompany.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(164, 225);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(165, 27);
            this.txtCity.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(164, 266);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(165, 27);
            this.txtCountry.TabIndex = 9;
            // 
            // btnMemberManage
            // 
            this.btnMemberManage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemberManage.Location = new System.Drawing.Point(473, 91);
            this.btnMemberManage.Name = "btnMemberManage";
            this.btnMemberManage.Size = new System.Drawing.Size(240, 58);
            this.btnMemberManage.TabIndex = 10;
            this.btnMemberManage.Text = "Member Management";
            this.btnMemberManage.UseVisualStyleBackColor = true;
            this.btnMemberManage.Click += new System.EventHandler(this.btnMemberManage_Click);
            // 
            // btnProductManage
            // 
            this.btnProductManage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductManage.Location = new System.Drawing.Point(473, 164);
            this.btnProductManage.Name = "btnProductManage";
            this.btnProductManage.Size = new System.Drawing.Size(240, 58);
            this.btnProductManage.TabIndex = 11;
            this.btnProductManage.Text = "Product Management";
            this.btnProductManage.UseVisualStyleBackColor = true;
            this.btnProductManage.Click += new System.EventHandler(this.btnProductManage_Click);
            // 
            // btnOrderManage
            // 
            this.btnOrderManage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrderManage.Location = new System.Drawing.Point(473, 235);
            this.btnOrderManage.Name = "btnOrderManage";
            this.btnOrderManage.Size = new System.Drawing.Size(240, 58);
            this.btnOrderManage.TabIndex = 12;
            this.btnOrderManage.Text = "Order Management";
            this.btnOrderManage.UseVisualStyleBackColor = true;
            this.btnOrderManage.Click += new System.EventHandler(this.btnOrderManage_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(331, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 33);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPermission.Location = new System.Drawing.Point(473, 36);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(182, 31);
            this.lbPermission.TabIndex = 14;
            this.lbPermission.Text = "Your permission:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(622, 329);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 33);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 388);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lbPermission);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOrderManage);
            this.Controls.Add(this.btnProductManage);
            this.Controls.Add(this.btnMemberManage);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbWelcome);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbWelcome;
        private Label lbInfo;
        private Label lbEmail;
        private Label lbCompany;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtEmail;
        private TextBox txtCompany;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnMemberManage;
        private Button btnProductManage;
        private Button btnOrderManage;
        private Button btnClose;
        private Label lbPermission;
        private Button btnLogOut;
    }
}