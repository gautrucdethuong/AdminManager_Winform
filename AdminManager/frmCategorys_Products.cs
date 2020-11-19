using AdminManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopWatches_Winform
{
    public partial class Categorys_Products : Form
    {
        ShopWatchesContextDB db = new ShopWatchesContextDB();
        public Categorys_Products()
        {
            InitializeComponent();
            loadProduct();
            loadCate();
        }
        void loadProduct()
        {
            cbbProducts.DataSource = db.Products.ToList();
            cbbProducts.DisplayMember = "name";
            cbbProducts.ValueMember = "ID";        
        }
        void loadCate()
        {
            clbCategory.DataSource = db.Categories.ToList();
            clbCategory.DisplayMember = "name";
            cbbProducts.ValueMember = "ID";
            cbbProducts_SelectionChangeCommitted(null,null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product Pro = (Product)cbbProducts.SelectedItem;
            for (int i = 0; i < clbCategory.Items.Count; i++)
            {
                if (clbCategory.GetItemChecked(i))
                {
                    Category c = (Category)clbCategory.Items[i];
                    Boolean check = db.Categories_Product.Where(x => x.ProductID == Pro.ID && x.CategoriesID == c.ID).Count() > 0;
                    if (!check)
                    {
                        Categories_Product cp = new Categories_Product();
                        cp.CategoriesID = c.ID;
                        cp.ProductID = Pro.ID;
                        db.Categories_Product.Add(cp);
                    }
                }
                else
                {
                    Category c = (Category)clbCategory.Items[i];
                    Categories_Product cp = db.Categories_Product.Where(x => x.ProductID == Pro.ID && x.CategoriesID == c.ID).FirstOrDefault();
                    if (cp != null) 
                    {
                        db.Categories_Product.Remove(cp);
                    }
                }
            }
            MessageBox.Show("Update Success");
            clbCategory.ClearSelected();
           
            db.SaveChanges();
        }

        private void cbbProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {       
            Product Pro = (Product) cbbProducts.SelectedItem;
            clbCategory.ClearSelected();
            List<Categories_Product> list = db.Categories_Product.ToList();
            for (int i = 0; i < clbCategory.Items.Count; i++)
            {
                clbCategory.SetItemChecked(i, false);
                Category cte = (Category)clbCategory.Items[i];
                foreach (var item in list)
                {
                    if(item.CategoriesID == cte.ID && item.ProductID == Pro.ID)
                    {
                        clbCategory.SetItemChecked(i, true);
                    }
                    
                }
            }
        }

        private void lblListCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
