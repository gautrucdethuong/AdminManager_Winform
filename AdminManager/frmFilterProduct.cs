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

namespace AdminManager
{
    public partial class frmFilterProduct : Form
    {
        ShopWatchesContextDB db = new Model.ShopWatchesContextDB();
        public frmFilterProduct()
        {
            InitializeComponent();
        }

        private void frmFilterProduct_Load(object sender, EventArgs e)
        {
            try
            {
                productBindingSource.DataSource = db.Products.ToList();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
