namespace WildanInventory
{
    partial class formCashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridCashier = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCashier)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCashier
            // 
            this.dataGridCashier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Nama,
            this.Qty,
            this.Harga,
            this.Sub});
            this.dataGridCashier.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridCashier.Location = new System.Drawing.Point(0, 210);
            this.dataGridCashier.Name = "dataGridCashier";
            this.dataGridCashier.RowHeadersWidth = 62;
            this.dataGridCashier.RowTemplate.Height = 28;
            this.dataGridCashier.Size = new System.Drawing.Size(1317, 412);
            this.dataGridCashier.TabIndex = 0;
            this.dataGridCashier.ColumnToolTipTextChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridCashier_ColumnToolTipTextChanged);
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 8;
            this.Barcode.Name = "Barcode";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Produk";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 8;
            this.Qty.Name = "Qty";
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 8;
            this.Harga.Name = "Harga";
            // 
            // Sub
            // 
            this.Sub.HeaderText = "Sub Total";
            this.Sub.MinimumWidth = 8;
            this.Sub.Name = "Sub";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(1144, 7);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(162, 52);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "Bayar";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 43);
            this.panel1.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTime.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(1212, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(105, 33);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Bayar";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(488, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 26);
            this.textBox1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.Controls.Add(this.btnPay, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 622);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1317, 67);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(957, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 52);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // formCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 689);
            this.Controls.Add(this.dataGridCashier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formCashier";
            this.Text = "Kasir ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCashier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCashier;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub;
    }
}