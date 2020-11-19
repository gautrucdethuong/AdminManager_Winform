namespace ShopWatches_Winform
{
    partial class Categorys_Products
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
            this.clbCategory = new System.Windows.Forms.CheckedListBox();
            this.cbbProducts = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblListCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbCategory
            // 
            this.clbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.clbCategory.FormattingEnabled = true;
            this.clbCategory.Location = new System.Drawing.Point(24, 164);
            this.clbCategory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.clbCategory.Name = "clbCategory";
            this.clbCategory.Size = new System.Drawing.Size(617, 246);
            this.clbCategory.TabIndex = 0;
            // 
            // cbbProducts
            // 
            this.cbbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbProducts.FormattingEnabled = true;
            this.cbbProducts.Location = new System.Drawing.Point(24, 65);
            this.cbbProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbProducts.Name = "cbbProducts";
            this.cbbProducts.Size = new System.Drawing.Size(509, 32);
            this.cbbProducts.TabIndex = 1;
            this.cbbProducts.SelectionChangeCommitted += new System.EventHandler(this.cbbProducts_SelectionChangeCommitted);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblProduct.Location = new System.Drawing.Point(24, 38);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(64, 18);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Product:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(543, 65);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblListCategory
            // 
            this.lblListCategory.AutoSize = true;
            this.lblListCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblListCategory.Location = new System.Drawing.Point(20, 137);
            this.lblListCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListCategory.Name = "lblListCategory";
            this.lblListCategory.Size = new System.Drawing.Size(113, 20);
            this.lblListCategory.TabIndex = 4;
            this.lblListCategory.Text = "List Category:";
            this.lblListCategory.Click += new System.EventHandler(this.lblListCategory_Click);
            // 
            // Categorys_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 451);
            this.Controls.Add(this.lblListCategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cbbProducts);
            this.Controls.Add(this.clbCategory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Categorys_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorys_Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbProducts;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblListCategory;
        private System.Windows.Forms.CheckedListBox clbCategory;
    }
}