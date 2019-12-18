namespace WildanInventory
{
    partial class formAdd
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBeli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbKat = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wildaninventoryDataSet = new WildanInventory.wildaninventoryDataSet();
            this.categoryTableAdapter = new WildanInventory.wildaninventoryDataSetTableAdapters.categoryTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiskon = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKasir = new System.Windows.Forms.TextBox();
            this.txtUom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wildaninventoryDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Produk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produk ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Produk";
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(114, 3);
            this.txtPid.Name = "txtPid";
            this.txtPid.ReadOnly = true;
            this.txtPid.Size = new System.Drawing.Size(230, 26);
            this.txtPid.TabIndex = 4;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(114, 35);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(230, 26);
            this.txtBarcode.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtBeli
            // 
            this.txtBeli.Location = new System.Drawing.Point(114, 197);
            this.txtBeli.Name = "txtBeli";
            this.txtBeli.Size = new System.Drawing.Size(230, 26);
            this.txtBeli.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga Beli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Harga Jual";
            // 
            // txtJual
            // 
            this.txtJual.Location = new System.Drawing.Point(114, 229);
            this.txtJual.Name = "txtJual";
            this.txtJual.Size = new System.Drawing.Size(230, 26);
            this.txtJual.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Minimal Stok";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(114, 133);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(230, 26);
            this.txtStok.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(56, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(259, 51);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kategori";
            // 
            // cbKat
            // 
            this.cbKat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "cname", true));
            this.cbKat.DataSource = this.categoryBindingSource;
            this.cbKat.DisplayMember = "cname";
            this.cbKat.FormattingEnabled = true;
            this.cbKat.Location = new System.Drawing.Point(114, 67);
            this.cbKat.Name = "cbKat";
            this.cbKat.Size = new System.Drawing.Size(230, 28);
            this.cbKat.TabIndex = 17;
            this.cbKat.ValueMember = "cname";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.wildaninventoryDataSet;
            // 
            // wildaninventoryDataSet
            // 
            this.wildaninventoryDataSet.DataSetName = "wildaninventoryDataSet";
            this.wildaninventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStok, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBarcode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbKat, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBeli, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDiskon, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtDisc, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtJual, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtKasir, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtUom, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 332);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // lblDiskon
            // 
            this.lblDiskon.AutoSize = true;
            this.lblDiskon.Location = new System.Drawing.Point(3, 258);
            this.lblDiskon.Name = "lblDiskon";
            this.lblDiskon.Size = new System.Drawing.Size(58, 20);
            this.lblDiskon.TabIndex = 19;
            this.lblDiskon.Text = "Diskon";
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(114, 261);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(230, 26);
            this.txtDisc.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 56);
            this.panel1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "UoM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Harga Kasir";
            // 
            // txtKasir
            // 
            this.txtKasir.Location = new System.Drawing.Point(114, 294);
            this.txtKasir.Name = "txtKasir";
            this.txtKasir.Size = new System.Drawing.Size(230, 26);
            this.txtKasir.TabIndex = 24;
            // 
            // txtUom
            // 
            this.txtUom.Location = new System.Drawing.Point(114, 165);
            this.txtUom.Name = "txtUom";
            this.txtUom.Size = new System.Drawing.Size(230, 26);
            this.txtUom.TabIndex = 25;
            // 
            // formAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(368, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Name = "formAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Produk";
            this.Load += new System.EventHandler(this.formAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wildaninventoryDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBeli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbKat;
        private wildaninventoryDataSet wildaninventoryDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private wildaninventoryDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDiskon;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKasir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUom;
    }
}