namespace WildanInventory
{
    partial class formProduk
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dataGWP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.wildaninventoryDataProduk = new WildanInventory.wildaninventoryDataProduk();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new WildanInventory.wildaninventoryDataProdukTableAdapters.productTableAdapter();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labeltext = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.txtUom = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtBuy = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGWP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wildaninventoryDataProduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 105);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Produk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrev.Location = new System.Drawing.Point(110, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(106, 49);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(1343, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(106, 49);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dataGWP
            // 
            this.dataGWP.AllowUserToAddRows = false;
            this.dataGWP.AllowUserToDeleteRows = false;
            this.dataGWP.AllowUserToOrderColumns = true;
            this.dataGWP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGWP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGWP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGWP.Location = new System.Drawing.Point(0, 538);
            this.dataGWP.Name = "dataGWP";
            this.dataGWP.ReadOnly = true;
            this.dataGWP.RowHeadersWidth = 62;
            this.dataGWP.RowTemplate.Height = 28;
            this.dataGWP.Size = new System.Drawing.Size(1576, 426);
            this.dataGWP.TabIndex = 6;
            this.dataGWP.DoubleClick += new System.EventHandler(this.dataGWP_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1117, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cari Produk";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.Location = new System.Drawing.Point(1299, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 26);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 65);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // wildaninventoryDataProduk
            // 
            this.wildaninventoryDataProduk.DataSetName = "wildaninventoryDataProduk";
            this.wildaninventoryDataProduk.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.wildaninventoryDataProduk;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(193, 108);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(255, 26);
            this.txtID.TabIndex = 23;
            // 
            // labeltext
            // 
            this.labeltext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltext.AutoSize = true;
            this.labeltext.Location = new System.Drawing.Point(161, 105);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(26, 20);
            this.labeltext.TabIndex = 22;
            this.labeltext.Text = "ID";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(193, 194);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(255, 26);
            this.txtPrice.TabIndex = 19;
            // 
            // txtSell
            // 
            this.txtSell.Location = new System.Drawing.Point(1212, 237);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(255, 26);
            this.txtSell.TabIndex = 18;
            // 
            // txtUom
            // 
            this.txtUom.Location = new System.Drawing.Point(1212, 151);
            this.txtUom.Name = "txtUom";
            this.txtUom.Size = new System.Drawing.Size(255, 26);
            this.txtUom.TabIndex = 16;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(193, 237);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(255, 26);
            this.txtCat.TabIndex = 15;
            // 
            // txtBuy
            // 
            this.txtBuy.Location = new System.Drawing.Point(1212, 194);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Size = new System.Drawing.Size(255, 26);
            this.txtBuy.TabIndex = 14;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(1212, 108);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(255, 26);
            this.txtStock.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 288);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 26);
            this.txtName.TabIndex = 11;
            // 
            // txtBar
            // 
            this.txtBar.Location = new System.Drawing.Point(193, 151);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(255, 26);
            this.txtBar.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Harga Kasir";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1120, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Harga Jual";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1160, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "UOM";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kategori";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1123, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Harga Beli";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1135, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Min Stok";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama Produk";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Barcode";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.99642F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.00359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 467);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1576, 71);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.86323F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.13677F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 358F));
            this.tableLayoutPanel2.Controls.Add(this.btnPrev, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNext, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 964);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1576, 55);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(746, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.66027F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.33973F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tableLayoutPanel3.Controls.Add(this.txtCat, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labeltext, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtBar, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtID, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtName, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtPrice, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtStock, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtUom, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtBuy, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtSell, 4, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label7, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.label11, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnEdit, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnDel, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 4, 5);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.94595F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.05405F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1552, 436);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1303, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 64);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.Enabled = false;
            this.btnDel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(998, 288);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(155, 64);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "Hapus";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEdit.BackColor = System.Drawing.Color.Blue;
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(653, 288);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 64);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // formProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1576, 1019);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGWP);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formProduk";
            this.Text = "Wildan Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProduk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGWP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wildaninventoryDataProduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dataGWP;
        private System.Windows.Forms.Button btnAdd;
        private wildaninventoryDataProduk wildaninventoryDataProduk;
        private System.Windows.Forms.BindingSource productBindingSource;
        private wildaninventoryDataProdukTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.TextBox txtUom;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtBuy;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
    }
}