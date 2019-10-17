using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace WildanInventory
{
    public partial class formLogin : Form
    {
        Connection conn = new Connection();
        public formLogin()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }
        private void BtnCon_Click(object sender, EventArgs e)
        {
            MySqlConnection db = new MySqlConnection(conn.connect());
            try
            {
                db.Open();
                MessageBox.Show("Koneksi Berhasil!");
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection db = new MySqlConnection(conn.connect());
            db.Open();
            string uname = txtUser.Text;
            string upass = txtPass.Text;
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM user WHERE uname='" + uname + "' AND upass ='" + upass + "'", db);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    formMain fM = new formMain();
                    fM.Show();
                }
                else
                {
                    MessageBox.Show("Username atau Passowrd Salah!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Button2_Click(sender, e);
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Error!", ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Clear();
            txtUser.Focus();

        }
    }
}
