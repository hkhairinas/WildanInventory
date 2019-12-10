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
        public formCashier()
        {
            InitializeComponent();
            this.labelTime.Text = DateTime.Now.ToString();
            timer1.Tick += new EventHandler(timer1_Tick);
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString();
        }

        private void dataGridCashier_ColumnToolTipTextChanged(object sender, DataGridViewColumnEventArgs e)
        {
            using (MySqlConnection db = new MySqlConnection(conn.connect()))
                try
                {
                    String bc = dataGridCashier.CurrentRow.Cells[0].Value.ToString();
                    db.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SearchByValue", db);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("_SearchValue", bc);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridCashier.DataSource = dt;
                    dataGridCashier.Rows.Add(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    db.Close();
                }
        }
    }
}
