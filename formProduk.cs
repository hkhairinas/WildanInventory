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
    public partial class formProduk : Form
    {
        Connection conn = new Connection();
        int totRec = 0;
        int totalRecord = 0;
        int off = 0;
        public formProduk()
        {
            InitializeComponent();
            MySqlConnection db = new MySqlConnection(conn.connect());
            db.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM product", db);
            DataTable dat = new DataTable();
            da.Fill(dat);
            totalRecord = dat.Rows.Count;
            totRec = 10;
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        private void GridFill()
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    db.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("ProductView", db);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("_OFF", off);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGWP.DataSource = dt;
                    label5.Text ="Menampilkan "+totRec+  " dari "+totalRecord.ToString()+" Data";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    db.Close();
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAdd fA = new formAdd();
            fA.Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            totRec -= 10;
            off = off - 10;
            GridFill();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            totRec += 10;
            off = off + 10;
            GridFill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    db.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SearchByValue", db);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGWP.DataSource = dt;
                    dataGWP.Columns[0].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    db.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SearchByValue", db);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGWP.DataSource = dt;
                    dataGWP.Columns[0].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            if(txtSearch.Text == "")
            {
                GridFill();
            }
        }

        private void dataGWP_DoubleClick(object sender, EventArgs e)
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                if(dataGWP.CurrentRow.Index != -1)
                {
                    txtID.Text = dataGWP.CurrentRow.Cells[0].Value.ToString();
                    txtBar.Text = dataGWP.CurrentRow.Cells[1].Value.ToString();
                    txtCat.Text = dataGWP.CurrentRow.Cells[2].Value.ToString();
                    txtName.Text = dataGWP.CurrentRow.Cells[3].Value.ToString();
                    txtUom.Text = dataGWP.CurrentRow.Cells[4].Value.ToString();
                    txtStock.Text = dataGWP.CurrentRow.Cells[5].Value.ToString();
                    txtSell.Text = dataGWP.CurrentRow.Cells[6].Value.ToString();
                    txtBuy.Text = dataGWP.CurrentRow.Cells[7].Value.ToString();
                    txtPrice.Text = dataGWP.CurrentRow.Cells[8].Value.ToString();
                    btnCancel.Enabled = Enabled;
                    btnDel.Enabled = Enabled;
                    btnAdd.Text = "Simpan";
                }
        }

        void Clear()
        {
            txtID.Text = txtBar.Text = txtBuy.Text = txtCat.Text = txtName.Text = txtUom.Text = txtStock.Text = txtPrice.Text = txtSell.Text = "";
            btnAdd.Text = "Tambah";
            btnDel.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    db.Open();
                    MySqlCommand msc = new MySqlCommand("DeleteByID", db);
                    msc.CommandType = CommandType.StoredProcedure;
                    msc.Parameters.AddWithValue("_ProductID", this.txtID.Text);
                    msc.Parameters.AddWithValue("_Barcode", this.txtBar.Text);
                    MySqlDataReader dr = msc.ExecuteReader();
                    MessageBox.Show("Sukses Menghapus");
                    Clear();
                    GridFill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}