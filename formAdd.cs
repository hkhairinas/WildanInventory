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
    public partial class formAdd : Form
    {
        Connection conn = new Connection();
        MySqlDataReader mr;
        string stitle = "Wildan Inventory";
        public formAdd()
        {
            InitializeComponent();
            getId();
        }

        private void formAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wildaninventoryDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.wildaninventoryDataSet.category);

        }

        private void getId()
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    //ID-180819-170143-95
                    string tgl = DateTime.Now.ToString("yyMMdd");
                    string jam = DateTime.Now.ToString("HHmmss");
                    string caid;
                    int count;
                    db.Open();
                    MySqlCommand mc = new MySqlCommand("SELECT pid FROM product WHERE pid LIKE 'ID-" + tgl + "-"+ jam +"-%' ", db);
                    mr = mc.ExecuteReader();
                    mr.Read();
                    if (mr.HasRows)
                    {
                        caid = mr[0].ToString();
                        count = int.Parse(caid.Substring(17, 2));
                        txtPid.Text = "ID-"+ tgl +"-"+ jam + (count + 1);
                    }
                    else
                    {
                        caid = "ID-"+ tgl +"-"+ jam +"-01";
                        txtPid.Text = caid;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin akan Menambah Data?", stitle, MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (MySqlConnection db = new MySqlConnection(conn.connect()))
                    try
                    {
                        db.Open();
                        MySqlCommand msc = new MySqlCommand("AddData", db);
                        msc.CommandType = CommandType.StoredProcedure;
                        msc.Parameters.AddWithValue("_ID", txtPid.Text);
                        msc.Parameters.AddWithValue("_Barcode", txtBarcode.Text);
                        msc.Parameters.AddWithValue("_Category", cbKat.Text);
                        msc.Parameters.AddWithValue("_Name", txtName.Text);
                        msc.Parameters.AddWithValue("_Uom", txtUom.Text);
                        msc.Parameters.AddWithValue("_MinStock", txtStok.Text);
                        msc.Parameters.AddWithValue("_Disc", txtDisc.Text);
                        msc.Parameters.AddWithValue("_CashierPrice", txtKasir.Text);
                        msc.Parameters.AddWithValue("_BuyPrice", txtBeli.Text);
                        msc.Parameters.AddWithValue("_SellPrice", txtJual.Text);
                        mr = msc.ExecuteReader();
                        MessageBox.Show("Sukses Menambah");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }
    }
}