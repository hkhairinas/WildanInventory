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
        public formAdd()
        {
            InitializeComponent();
        }

        private void formAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wildaninventoryDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.wildaninventoryDataSet.category);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter.FillBy(this.wildaninventoryDataSet.category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
