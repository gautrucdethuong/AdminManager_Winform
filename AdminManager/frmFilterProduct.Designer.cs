namespace AdminManager
{
    partial class frmFilterProduct
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantities = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwarrantyTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloriginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldetail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.productBindingSource;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl.Location = new System.Drawing.Point(25, 14);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1151, 541);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(AdminManager.Model.Product);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSupplierID,
            this.colname,
            this.colprice,
            this.colquantities,
            this.colstatus,
            this.colwarrantyTime,
            this.coloriginName,
            this.coldetail});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 31;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 117;
            // 
            // colSupplierID
            // 
            this.colSupplierID.FieldName = "SupplierID";
            this.colSupplierID.MinWidth = 31;
            this.colSupplierID.Name = "colSupplierID";
            this.colSupplierID.Visible = true;
            this.colSupplierID.VisibleIndex = 1;
            this.colSupplierID.Width = 117;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.MinWidth = 31;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 2;
            this.colname.Width = 117;
            // 
            // colprice
            // 
            this.colprice.FieldName = "price";
            this.colprice.MinWidth = 31;
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 3;
            this.colprice.Width = 117;
            // 
            // colquantities
            // 
            this.colquantities.FieldName = "quantities";
            this.colquantities.MinWidth = 31;
            this.colquantities.Name = "colquantities";
            this.colquantities.Visible = true;
            this.colquantities.VisibleIndex = 4;
            this.colquantities.Width = 117;
            // 
            // colstatus
            // 
            this.colstatus.FieldName = "status";
            this.colstatus.MinWidth = 31;
            this.colstatus.Name = "colstatus";
            this.colstatus.Visible = true;
            this.colstatus.VisibleIndex = 5;
            this.colstatus.Width = 117;
            // 
            // colwarrantyTime
            // 
            this.colwarrantyTime.FieldName = "warrantyTime";
            this.colwarrantyTime.MinWidth = 31;
            this.colwarrantyTime.Name = "colwarrantyTime";
            this.colwarrantyTime.Visible = true;
            this.colwarrantyTime.VisibleIndex = 6;
            this.colwarrantyTime.Width = 117;
            // 
            // coloriginName
            // 
            this.coloriginName.FieldName = "originName";
            this.coloriginName.MinWidth = 31;
            this.coloriginName.Name = "coloriginName";
            this.coloriginName.Visible = true;
            this.coloriginName.VisibleIndex = 7;
            this.coloriginName.Width = 117;
            // 
            // coldetail
            // 
            this.coldetail.FieldName = "detail";
            this.coldetail.MinWidth = 31;
            this.coldetail.Name = "coldetail";
            this.coldetail.Visible = true;
            this.coldetail.VisibleIndex = 8;
            this.coldetail.Width = 117;
            // 
            // frmFilterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 638);
            this.Controls.Add(this.gridControl);
            this.Name = "frmFilterProduct";
            this.Text = "frmFilterProduct";
            this.Load += new System.EventHandler(this.frmFilterProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierID;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colquantities;
        private DevExpress.XtraGrid.Columns.GridColumn colstatus;
        private DevExpress.XtraGrid.Columns.GridColumn colwarrantyTime;
        private DevExpress.XtraGrid.Columns.GridColumn coloriginName;
        private DevExpress.XtraGrid.Columns.GridColumn coldetail;
    }
}