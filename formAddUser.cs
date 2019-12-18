using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace WildanInventory
{
    public partial class formAddUser : Form
    {
        MySqlDataReader mr;
        Connection conn = new Connection();
        string stitle = "Wildan Inventory";

        public formAddUser()
        {
            InitializeComponent();
            getIdUser();
            txtUser.Select();
        }

        private void getIdUser()
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    string caid;
                    int count;
                    db.Open();
                    MySqlCommand mc = new MySqlCommand("SELECT uid FROM user WHERE uid LIKE 'ID%' ORDER BY uid DESC", db);
                    mr = mc.ExecuteReader();
                    mr.Read();
                    if (mr.HasRows)
                    {
                        caid = mr[0].ToString();
                        count = int.Parse(caid.Substring(2, 3));
                        txtID.Text = "ID"+(count + 1);
                    }
                    else
                    {
                        caid = "ID101";
                        txtID.Text = caid;
                    }
                    mr.Close();
                    db.Close();
                }
                catch (Exception ex)
                {
                    db.Close();
                    MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void cclear()
        {
            txtPass.Text = "";
            txtUser.Text = "";
            cbLevel.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var id = txtID.Text;
            var user = txtUser.Text;
            var pass = txtPass.Text;
            var level = cbLevel.Text;
            int lvl = 0;
            if (level == "Administrator")
            {
                lvl = 1;
            }
            else if(level == "Kasir")
            {
                lvl = 2;
            }
            else
            {
                MessageBox.Show("Masukkan Level!", stitle, MessageBoxButtons.OK);
            }


            if (lvl == 1 || lvl == 2)
            {
                using (MySqlConnection db = new MySqlConnection(conn.connect()))
                    try
                    {
                        db.Open();
                        string Query = "INSERT INTO user(uid,uname,upass,access) VALUES ('" + id + "','" + user + "',MD5('" + pass + "')," + lvl + ") ";
                        MySqlCommand mc = new MySqlCommand(Query, db);
                        mr = mc.ExecuteReader();
                        MessageBox.Show("Sukses Menambah User Baru!");
                        db.Close();
                    }
                    catch (Exception ex)
                    {
                        db.Close();
                        MessageBox.Show(ex.Message);
                    }
                cclear();
                this.Close();
            }
            else
            {
                cclear();
            }
        }
    }
}
