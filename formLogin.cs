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
        MySqlDataReader mr;

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
                string Query = "SELECT * FROM user WHERE uname='" + uname + "' AND upass = MD5('" + upass + "')";
                MySqlCommand mc = new MySqlCommand(Query, db);
                mr = mc.ExecuteReader();
                mr.Read();
                if (mr.HasRows)
                {
                    var akses = mr[3].ToString();
                    var user = mr[1].ToString();
                    if (akses == "1")
                    {
                        MessageBox.Show("Selamat Datang Admin " + user);
                        this.Hide();
                        formMain fM = new formMain();
                        fM.Show();
                    }
                    else if(akses == "2")
                    {
                        MessageBox.Show("Selamat Datang Kasir " + user);
                        this.Hide();
                        formMain fM = new formMain();
                        fM.Show();
                    }
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
