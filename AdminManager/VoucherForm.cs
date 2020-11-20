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
//Author:Minh Nghia
namespace ShopWatches_Winform
{
    public partial class VoucherForm : Form
    {
        ShopWatchesContextDB db = new ShopWatchesContextDB();
        public VoucherForm()
        {
            InitializeComponent();
            loadData();
            cbbEffTime.SelectedIndex = 0;
          
        }
        
        void loadData()
        {
          
            dgvVoucher.DataSource = (from v in db.Vouchers orderby v.status descending select v).ToList();
        }
        void addBinding(int rows)
        {
            try {   
            txtID.Text = dgvVoucher.Rows[rows].Cells["ID"].Value.ToString();
            txtEvents.Text = dgvVoucher.Rows[rows].Cells["code"].Value.ToString();
            txtValue.Text = dgvVoucher.Rows[rows].Cells["value"].Value.ToString();
                lockControl();
            }
            catch { }
        }
        void lockControl()
        {
            btnCreate.Enabled = false;
            btnDelete.Enabled = true;

            txtNumberofVoucher.ReadOnly = true;
            txtEvents.ReadOnly = true;
            txtValue.ReadOnly = true;
            cbbEffTime.Enabled = false;
        }
        void unlockControl()
        {
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;

            txtID.Text = "";
            txtNumberofVoucher.Text = "";
            txtEvents.Text = "";
            txtValue.Text = "";

            txtNumberofVoucher.ReadOnly = !true;
            txtEvents.ReadOnly = !true;
            txtValue.ReadOnly = !true;
            cbbEffTime.Enabled = !false;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try { 
            int numberofVou = Convert.ToInt32(txtNumberofVoucher.Text);            
            int value = Convert.ToInt32(txtValue.Text);
           if(txtEvents.Text == "")
                {
                    MessageBox.Show("Events must not be left blank ");
                    return;
                }
            DateTime time = DateTime.Today.AddDays(getEffectivetime());
            for (int i = 0; i < numberofVou; i++)
            {
                String events = txtEvents.Text + "-";
                Voucher v = new Voucher();
                events += randcode();
                v.code = events;
                v.exprityDate = time;
                v.value = value;
                v.status = "false";
                db.Vouchers.Add(v);
                db.SaveChanges();
            }
            }
            catch
            {
                MessageBox.Show("Please check! \n Number of voucher & Value must is integer number \n must not be left blank");

            }

            loadData();
        }
        //get Time in Cbb
        public int getEffectivetime()
        {
            try
            {
                String time = cbbEffTime.SelectedItem.ToString();
                string[] timeArr = time.Split(' ');
                return Convert.ToInt32(timeArr[0]);
            }
            catch { }
            return -1;
        }
        //Random Code
        public String randcode()
        {
            Random rand = new Random();
            String randomString;
            String characters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ9876543210";
            int charactersLength = characters.Length;
            randomString = "";
            for (int i = 0; i < 8; i++)
            {
                randomString += characters[rand.Next(charactersLength)];
            }
            return randomString;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            Voucher v = db.Vouchers.Find(ID);
            if(v != null)
            {
                db.Vouchers.Remove(v);
                db.SaveChanges();
                loadData();
                unlockControl();
            }
            else
            {
                MessageBox.Show("Voucher not exits");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            unlockControl();
        }

        private void dgvVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                addBinding(e.RowIndex);
            
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you delete all expired & had used vouchers?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var list = db.Vouchers.ToList();
                DateTime current = DateTime.Today;
                foreach (var item in list)
                {
                    if(DateTime.Compare(current, (DateTime)item.exprityDate) > 0 || item.status == "true")
                    {
                        db.Vouchers.Remove(item);                     
                    }               
                }
                db.SaveChanges();
                loadData();
                unlockControl();
            }
           
        }
    }
}
