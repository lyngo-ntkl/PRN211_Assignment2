namespace SalesWinApp
{
    partial class frmOrderManagementDetails
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
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.cboMemberID = new System.Windows.Forms.ComboBox();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.dtShipDate = new System.Windows.Forms.DateTimePicker();
            this.lbShipDate = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFreight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(58, 151);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(38, 19);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "Total";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Location = new System.Drawing.Point(58, 195);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowTemplate.Height = 28;
            this.dgvDetails.Size = new System.Drawing.Size(689, 267);
            this.dgvDetails.TabIndex = 3;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(58, 21);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(63, 19);
            this.lbOrderID.TabIndex = 4;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(370, 17);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(78, 19);
            this.lbOrderDate.TabIndex = 7;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(58, 109);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(52, 19);
            this.lbFreight.TabIndex = 8;
            this.lbFreight.Text = "Freight";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(58, 65);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(79, 19);
            this.lbMemberID.TabIndex = 9;
            this.lbMemberID.Text = "Member ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(143, 14);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(121, 26);
            this.txtOrderID.TabIndex = 10;
            // 
            // cboMemberID
            // 
            this.cboMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberID.FormattingEnabled = true;
            this.cboMemberID.Location = new System.Drawing.Point(143, 57);
            this.cboMemberID.Name = "cboMemberID";
            this.cboMemberID.Size = new System.Drawing.Size(121, 27);
            this.cboMemberID.TabIndex = 11;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(480, 10);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(200, 26);
            this.dtOrderDate.TabIndex = 13;
            // 
            // dtRequiredDate
            // 
            this.dtRequiredDate.Location = new System.Drawing.Point(480, 57);
            this.dtRequiredDate.Name = "dtRequiredDate";
            this.dtRequiredDate.Size = new System.Drawing.Size(200, 26);
            this.dtRequiredDate.TabIndex = 15;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(370, 64);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(96, 19);
            this.lbRequiredDate.TabIndex = 14;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // dtShipDate
            // 
            this.dtShipDate.Location = new System.Drawing.Point(480, 103);
            this.dtShipDate.Name = "dtShipDate";
            this.dtShipDate.Size = new System.Drawing.Size(200, 26);
            this.dtShipDate.TabIndex = 17;
            // 
            // lbShipDate
            // 
            this.lbShipDate.AutoSize = true;
            this.lbShipDate.Location = new System.Drawing.Point(370, 110);
            this.lbShipDate.Name = "lbShipDate";
            this.lbShipDate.Size = new System.Drawing.Size(68, 19);
            this.lbShipDate.TabIndex = 16;
            this.lbShipDate.Text = "Ship Date";
            // 
            // txtFreight
            // 
            this.txtFreight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtFreight.Location = new System.Drawing.Point(144, 103);
            this.txtFreight.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(120, 26);
            this.txtFreight.TabIndex = 18;
            this.txtFreight.ValueChanged += new System.EventHandler(this.txtFreight_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Location = new System.Drawing.Point(133, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 62);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(218, 19);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 31);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete Item";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTotal.Location = new System.Drawing.Point(143, 144);
            this.txtTotal.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 26);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // frmOrderManagementDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.dtShipDate);
            this.Controls.Add(this.lbShipDate);
            this.Controls.Add(this.dtRequiredDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.cboMemberID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.lbTotal);
            this.Name = "frmOrderManagementDetails";
            this.Text = "frmOrderManagementDetails";
            this.Load += new System.EventHandler(this.frmOrderManagementDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFreight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbTotal;
        private Button btnClose;
        private DataGridView dgvDetails;
        private Label lbOrderID;
        private Label lbOrderDate;
        private Label lbFreight;
        private Label lbMemberID;
        private TextBox txtOrderID;
        private ComboBox cboMemberID;
        private DateTimePicker dtOrderDate;
        private DateTimePicker dtRequiredDate;
        private Label lbRequiredDate;
        private DateTimePicker dtShipDate;
        private Label lbShipDate;
        private NumericUpDown txtFreight;
        private GroupBox groupBox1;
        private Button Delete;
        private Button btnSave;
        private NumericUpDown txtTotal;
    }
}