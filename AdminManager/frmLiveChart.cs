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
using LiveCharts;
using LiveCharts.Wpf;

namespace AdminManager
{
    public partial class frmLiveChart : Form
    {
        ShopWatchesContextDB db = new ShopWatchesContextDB();
        
        public frmLiveChart()
        {
            InitializeComponent();
            loadData();
        }
     
        // load chart
        private void LiveChart_Load(object sender, EventArgs e)
        {
            revenueBindingSource.DataSource = new List<Revenue>();
            // định dạng cột ngang
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",                
                Labels = new[] { "Jan", "Mar", "May", "Jul", "Sep", "Nov" }
            });
            // định dạng cột đứng
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right; // vị trí show chú thích
        }
        void loadData()
        {
            var item = db.Orders.OrderByDescending(x => x.requested).ToList();

            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            for (int i = 0; i < item.Count; i++)
            {

                dataGridView1.Rows.Add(item[i].requested.Value.Year, item[i].requested.Value.Month, item[i].totalMoney);
            }  
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
          
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            //  List<int> years = from o in db.Orders.ToList() select new {o.requested.Value.Year}
            var years =( from o in db.Orders.ToList()
                        orderby o.requested.Value.Year descending
                        select new {o.requested.Value.Year}).Distinct();
          
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                    {
                        double value = 0;
                        var data = from o in db.Orders.ToList()
                                   where o.requested.Value.Year.Equals(year.Year) && o.requested.Value.Month.Equals(month)
                                   orderby o.requested.Value.Month descending
                                   select new { o.totalMoney, o.requested.Value.Month };
                    
                        if (data.SingleOrDefault() != null)
                        {
                            value = (double)data.SingleOrDefault().totalMoney;
                           
                            values.Add(value);
                        }                  
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart1.Series = series;
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}

