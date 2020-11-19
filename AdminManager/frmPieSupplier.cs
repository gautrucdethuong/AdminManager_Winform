using AdminManager.Model;
using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class frmPieSupplier : Form
    {
        ShopWatchesContextDB db = new ShopWatchesContextDB();
        public frmPieSupplier()
        {
            InitializeComponent();
            dataGridView.DataSource = db.Products.ToList();
        }
        Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation); 

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in db.Suppliers.ToList())
            {
                int total = 0;
                //    var sumP = from p in db.Products.Where(p => p.SupplierID == obj.IDSup)
                //               group p by new { p.Supplier.nameSup }
                //    into productgroup
                //               select new
                //               {
                //                   nameSup = productgroup.Key,
                //                   total = productgroup.Sum(x => x.ID)
                //               }; 
                var result = db.Products.Where(q => q.SupplierID == obj.IDSup).GroupBy(p => p.SupplierID).Select(g => new { nameSup = g.Key, total = g.Count() });
                // nhóm những thằng chuq nguồn gốc lại để hiện ra
                if (result.SingleOrDefault() != null)
                {
                    total = result.SingleOrDefault().total;
                }
                series.Add(new PieSeries()
                {
                    Title = obj.nameSup.ToString(),
                    Values = new ChartValues<int> { total },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
                pieChart.Series = series;



                /*var data = from o in db.Orders.ToList()
                           where o.requested.Value.Year.Equals(year.Year) && o.requested.Value.Month.Equals(month)
                           orderby o.requested.Value.Month descending
                           select new { o.totalMoney, o.requested.Value.Month };

                if (data.SingleOrDefault() != null)
                {
                    value = (double)data.SingleOrDefault().totalMoney;

                    values.Add(value);
                }*/
            }
        }

        private void frmPieSupplier_Load(object sender, EventArgs e)
        {
            pieChart.LegendLocation = LegendLocation.Bottom;
        }
    }
}
