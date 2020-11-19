using AdminManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminManager
{
    public partial class frmStatusOrder : Form
    {
        ShopWatchesContextDB db = new ShopWatchesContextDB();

        public frmStatusOrder()
        {
            InitializeComponent();
            //dgvData.DataSource = db.Orders.ToList();
            dgvData.DataSource = db.Orders.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var od = db.Orders.Find(Convert.ToInt32(txtID.Text));
            od.statusOrder = cbbOder.SelectedItem.ToString();
            db.Entry(od).State = EntityState.Modified;
            db.SaveChanges();
            dgvData.DataSource = db.Orders.ToList();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbbOder.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

    }
}
