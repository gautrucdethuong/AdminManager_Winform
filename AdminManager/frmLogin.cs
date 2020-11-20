using AdminManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        private String ToMD5(String s)
        {
            var bytes = Encoding.UTF8.GetBytes(s);
            var hash = MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        // check login 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String pass = ToMD5(txtPassword.Text);
            try { 
            frmMain obj = new frmMain();
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                var valid = db.Employees.Where(a => a.emailEmp.Equals(txtUsername.Text) && a.passwordEmp.Equals(pass)).FirstOrDefault();
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
            }catch(Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

    }
}
