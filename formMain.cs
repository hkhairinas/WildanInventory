﻿using System;
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
    public partial class formMain : Form
    {

        public formMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DataProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProduk fp = new formProduk();
            fp.Show();
            fp.MdiParent = this;
        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCashier fc = new formCashier();
            fc.Show();
            fc.MdiParent = this;
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void laporanProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void laporanPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}