namespace AdminManager
{
    partial class frmStatusOrder
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
            this.components = new System.ComponentModel.Container();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblID = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbOder = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.lblID.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.totalMoneyDataGridViewTextBoxColumn,
            this.statusOrderDataGridViewTextBoxColumn,
            this.statusPaymentDataGridViewTextBoxColumn,
            this.requested,
            this.customerID});
            this.dgvData.DataSource = this.orderBindingSource;
            this.dgvData.Location = new System.Drawing.Point(364, 50);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(774, 360);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(AdminManager.Model.Order);
            // 
            // lblID
            // 
            this.lblID.Controls.Add(this.txtID);
            this.lblID.Location = new System.Drawing.Point(38, 82);
            this.lblID.Margin = new System.Windows.Forms.Padding(4);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new System.Windows.Forms.Padding(4);
            this.lblID.Size = new System.Drawing.Size(303, 81);
            this.lblID.TabIndex = 6;
            this.lblID.TabStop = false;
            this.lblID.Text = "ID Order";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(0, 32);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(295, 26);
            this.txtID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbOder);
            this.groupBox2.Location = new System.Drawing.Point(39, 193);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(302, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status Order";
            // 
            // cbbOder
            // 
            this.cbbOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOder.FormattingEnabled = true;
            this.cbbOder.Items.AddRange(new object[] {
            "Approved",
            "Disapproved"});
            this.cbbOder.Location = new System.Drawing.Point(0, 31);
            this.cbbOder.Margin = new System.Windows.Forms.Padding(4);
            this.cbbOder.Name = "cbbOder";
            this.cbbOder.Size = new System.Drawing.Size(294, 28);
            this.cbbOder.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(134, 297);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Id";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalMoneyDataGridViewTextBoxColumn
            // 
            this.totalMoneyDataGridViewTextBoxColumn.DataPropertyName = "totalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.HeaderText = "Total Money";
            this.totalMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalMoneyDataGridViewTextBoxColumn.Name = "totalMoneyDataGridViewTextBoxColumn";
            this.totalMoneyDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusOrderDataGridViewTextBoxColumn
            // 
            this.statusOrderDataGridViewTextBoxColumn.DataPropertyName = "statusOrder";
            this.statusOrderDataGridViewTextBoxColumn.HeaderText = "Status Order";
            this.statusOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusOrderDataGridViewTextBoxColumn.Name = "statusOrderDataGridViewTextBoxColumn";
            this.statusOrderDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusPaymentDataGridViewTextBoxColumn
            // 
            this.statusPaymentDataGridViewTextBoxColumn.DataPropertyName = "statusPayment";
            this.statusPaymentDataGridViewTextBoxColumn.HeaderText = "Status Payment";
            this.statusPaymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusPaymentDataGridViewTextBoxColumn.Name = "statusPaymentDataGridViewTextBoxColumn";
            this.statusPaymentDataGridViewTextBoxColumn.Width = 125;
            // 
            // requested
            // 
            this.requested.DataPropertyName = "requested";
            this.requested.HeaderText = "Requested Date ";
            this.requested.MinimumWidth = 6;
            this.requested.Name = "requested";
            this.requested.Width = 125;
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            this.customerID.HeaderText = "Customer Id";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.Width = 125;
            // 
            // frmStatusOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 628);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvData);
            this.Name = "frmStatusOrder";
            this.Text = "frmStatusOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.lblID.ResumeLayout(false);
            this.lblID.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbOder;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requested;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
    }
}