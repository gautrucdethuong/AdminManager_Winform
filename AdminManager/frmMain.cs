using System;
using AdminManager.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopWatches_Winform;

namespace AdminManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmOrderByDate obj = new frmOrderByDate();
            obj.Show();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frmFilterProduct obj = new frmFilterProduct();
            
            obj.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            frmLiveChart obj = new frmLiveChart();
            obj.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            frmStatusOrder obj = new frmStatusOrder();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Categorys_Products obj = new Categorys_Products();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VoucherForm obj = new VoucherForm();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmPieSupplier obj = new frmPieSupplier();
            obj.Show();
        }
    }
}
