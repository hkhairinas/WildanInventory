using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildanInventory
{
    public partial class formCashier : Form
    {
        Connection conn = new Connection();
        Timer timer1 = new Timer();
        string stitle = "Wildan Kasir";
        MySqlDataReader mr;
        
        public formCashier()
        {
            InitializeComponent();
            this.lblHari.Text = DateTime.Now.ToString("dddd");
            this.labelTime.Text = DateTime.Now.ToString();
            timer1.Tick += new EventHandler(timer1_Tick);
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
            SetStatusBar();
            getNota();
            this.txtBarID.Select();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString();
        }

        private void txtBarID_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    db.Open();
                    MySqlCommand mc = new MySqlCommand("SearchFix", db);
                    mc.CommandType = CommandType.StoredProcedure;
                    mc.Parameters.AddWithValue("_SearchFix", txtBarID.Text);
                    mr = mc.ExecuteReader();
                    int i = 0;
                    while (mr.Read())
                    {
                        i++;
                        dataGridCashier.Rows.Add(mr["pbarcode"].ToString(), mr["pname"].ToString(), mr["pprice"].ToString(), i, mr["pprice"].ToString());
                        txtBarID.Text = "";
                    }
                    mr.Close();
                    db.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void SetStatusBar()
        {
            /*var infoStatus = "F3 : Input Produk | F4 : Cari Pelanggan | F5 : Edit Jumlah | F6 : Edit Diskon | F7 : Edit Harga | F8 : Cek Nota Terakhir | F10 : Bayar" +
                             "\r\nCTRL + B : Pembatalan Transaksi | CTRL + D: Hapus Item Transaksi | CTRL + L : Laporan Penjualan " +
                             "| CTRL + N : Tanpa Nota/Struk | CTRL + P : Setting Printer | CTRL + X : Tutup Form Transaksi";*/
            var infoStatus = "Catatan Tambahan";
            lblStatus.Text = infoStatus;
        }

        private void getNota()
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    string tgl = DateTime.Now.ToString("yyyyMMdd");
                    string noNota;
                    int count;
                    db.Open();
                    MySqlCommand mc = new MySqlCommand("SELECT tid FROM transaction WHERE tid LIKE '" + tgl + "%' ",db);
                    mr = mc.ExecuteReader();
                    mr.Read();
                    if (mr.HasRows)
                    {
                        noNota = mr[0].ToString();
                        count = int.Parse(noNota.Substring(8, 4));
                        lblNota.Text = tgl + (count + 1);
                    } else
                    {
                        noNota = tgl + "1001";
                        lblNota.Text = noNota;
                    } mr.Close();
                    db.Close();
                }catch (Exception ex)
                {
                    db.Close();
                    MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridCashier.Rows.Clear();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {

        }
    }
}
