using AdminManager.Model;
using DGVPrinterHelper;
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
    public partial class frmOrderByDate : Form
    {
        ShopWatchesContextDB db = new ShopWatchesContextDB();
        public frmOrderByDate()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Orders.ToList();
        }

        public void SUM()
        { //ham sum doanh thu cua cua hang
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            lblTable.Text = sum.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Where(x => x.requested > dateTimePicker1.Value && x.requested < dateTimePicker2.Value).ToList();
            SUM();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Where(p => p.totalMoney > 1000).OrderByDescending(p => p.totalMoney).ToList();

            //tong hop nhung don hang co gia tri cao va sap xep cac don hang co gia tri giam dan
            SUM();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter dGV = new DGVPrinter();
            dGV.Title = "Report";
            dGV.SubTitle = string.Format("Date: {0}", DateTime.Now.TimeOfDay); // header
            dGV.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dGV.PageNumbers = true;
            dGV.PageNumberInHeader = false;
            dGV.PorportionalColumns = true;
            dGV.HeaderCellAlignment = StringAlignment.Near;
            dGV.Footer = "Shop Online Watches System"; // footer
            dGV.FooterSpacing = 10;
            dGV.PrintDataGridView(dataGridView1);
            //dGV.printDocument();
        }
    }
}
