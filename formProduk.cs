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
        int currentRecord = 0;
        int totalRecord = 0;
        int Barcode = 0;
        public formProduk()
        {
            InitializeComponent();
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wildaninventoryDataProduk.product' table. You can move, or remove it, as needed.
            /*this.productTableAdapter.Fill(this.wildaninventoryDataProduk.product);*/
            GridFill();
        }

        private void GridFill()
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    db.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("ProductView", db);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGWP.DataSource = dt;
                    currentRecord = 0;
                    totalRecord = dt.Rows.Count;
                    label5.Text = totalRecord.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAdd fA = new formAdd();
            fA.Show();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

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
        }

        private void dataGWP_DoubleClick(object sender, EventArgs e)
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                if(dataGWP.CurrentRow.Index != -1)
                {
                    txtBar.Text = dataGWP.CurrentRow.Cells[0].Value.ToString();
                    txtCat.Text = dataGWP.CurrentRow.Cells[1].Value.ToString();
                    txtName.Text = dataGWP.CurrentRow.Cells[2].Value.ToString();
                    txtUom.Text = dataGWP.CurrentRow.Cells[3].Value.ToString();
                    txtStock.Text = dataGWP.CurrentRow.Cells[4].Value.ToString();
                    txtSell.Text = dataGWP.CurrentRow.Cells[5].Value.ToString();
                    txtBuy.Text = dataGWP.CurrentRow.Cells[6].Value.ToString();
                    txtPrice.Text = dataGWP.CurrentRow.Cells[7].Value.ToString();
                    btnCancel.Enabled = Enabled;
                    btnDel.Enabled = Enabled;
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtBar.Text = txtBuy.Text = txtCat.Text = txtName.Text = txtUom.Text = txtStock.Text = txtPrice.Text = txtSell.Text = "";
            Barcode = 0;
            btnAdd.Text = "Save";
            btnDel.Enabled = false;
        }
    }
}