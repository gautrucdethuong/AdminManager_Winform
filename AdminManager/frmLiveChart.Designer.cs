namespace AdminManager
{
    partial class frmLiveChart
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(19, 17);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(823, 347);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.month,
            this.value});
            this.dataGridView1.Location = new System.Drawing.Point(38, 381);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 136);
            this.dataGridView1.TabIndex = 1;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.Width = 125;
            // 
            // month
            // 
            this.month.HeaderText = "Month";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            this.month.Width = 125;
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.MinimumWidth = 6;
            this.value.Name = "value";
            this.value.Width = 125;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(570, 481);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 36);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Show";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataSource = typeof(AdminManager.Model.Revenue);
            // 
            // frmLiveChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 609);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cartesianChart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLiveChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiveChart";
            this.Load += new System.EventHandler(this.LiveChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
    }
}