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
    public partial class frmLogin : Form
    {
        ShopWatchesContextDB db = new ShopWatchesContextDB();

        public frmLogin()
        {
            InitializeComponent();
            
            txtPassword.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtPassword.MaxLength = 14;
        }

        // check login 
        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            frmMain obj = new frmMain();
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                var valid = db.Employees.FirstOrDefault(a => a.emailEmp.Equals(txtUsername.Text) && a.passwordEmp.Equals(txtPassword.Text));
                if (valid != null)
                {
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect.", "Message");
                }
            }
            else
            {
                MessageBox.Show("Username or password not null.", "Message");
            }
        }
    }
}
