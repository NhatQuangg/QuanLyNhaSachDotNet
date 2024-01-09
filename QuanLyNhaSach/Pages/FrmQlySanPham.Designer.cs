namespace QuanLyNhaSach.Pages
{
    partial class FrmQlySanPham
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQlySanPham));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txttensanpham = new TextBox();
            txtsoluong = new TextBox();
            txtdongia = new TextBox();
            panel1 = new Panel();
            dgvProducts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            tensanphamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soluongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dongiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sanphamDTOBindingSource = new BindingSource(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtAmount = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            btnDeleteProducts = new ToolStripButton();
            btnUpdateProducts = new ToolStripButton();
            btnAddProducts = new ToolStripButton();
            btnTangDan = new ToolStripButton();
            btnGiamDan = new ToolStripButton();
            avtBook = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            toolStripLabel2 = new ToolStripLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanphamDTOBindingSource).BeginInit();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avtBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(526, 83);
            label3.Name = "label3";
            label3.Size = new Size(49, 28);
            label3.TabIndex = 2;
            label3.Text = "Ảnh";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá";
            // 
            // txttensanpham
            // 
            txttensanpham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txttensanpham.Location = new Point(181, 30);
            txttensanpham.Name = "txttensanpham";
            txttensanpham.Size = new Size(270, 27);
            txttensanpham.TabIndex = 4;
            // 
            // txtsoluong
            // 
            txtsoluong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtsoluong.Location = new Point(181, 87);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(270, 27);
            txtsoluong.TabIndex = 5;
            txtsoluong.KeyPress += txtsoluong_KeyPress;
            // 
            // txtdongia
            // 
            txtdongia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtdongia.Location = new Point(181, 142);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(270, 27);
            txtdongia.TabIndex = 7;
            txtdongia.KeyPress += txtdongia_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvProducts);
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(12, 273);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 325);
            panel1.TabIndex = 8;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, tensanphamDataGridViewTextBoxColumn, soluongDataGridViewTextBoxColumn, dongiaDataGridViewTextBoxColumn, anhDataGridViewTextBoxColumn });
            dgvProducts.DataSource = sanphamDTOBindingSource;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 27);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(955, 272);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "Mã sản phẩm";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // tensanphamDataGridViewTextBoxColumn
            // 
            tensanphamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tensanphamDataGridViewTextBoxColumn.DataPropertyName = "tensanpham";
            tensanphamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            tensanphamDataGridViewTextBoxColumn.MinimumWidth = 6;
            tensanphamDataGridViewTextBoxColumn.Name = "tensanphamDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            soluongDataGridViewTextBoxColumn.Width = 125;
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            dongiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            dongiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            dongiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // anhDataGridViewTextBoxColumn
            // 
            anhDataGridViewTextBoxColumn.DataPropertyName = "anh";
            anhDataGridViewTextBoxColumn.HeaderText = "Ảnh";
            anhDataGridViewTextBoxColumn.MinimumWidth = 6;
            anhDataGridViewTextBoxColumn.Name = "anhDataGridViewTextBoxColumn";
            anhDataGridViewTextBoxColumn.Width = 125;
            // 
            // sanphamDTOBindingSource
            // 
            sanphamDTOBindingSource.DataSource = typeof(DTO.sanphamDTO);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtAmount });
            statusStrip1.Location = new Point(0, 299);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(955, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(114, 20);
            toolStripStatusLabel1.Text = "Tổng sản phẩm:";
            // 
            // txtAmount
            // 
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(17, 20);
            txtAmount.Text = "0";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2, btnDeleteProducts, btnUpdateProducts, btnAddProducts, btnTangDan, btnGiamDan });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(955, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(145, 24);
            toolStripLabel1.Text = "Danh sách sản phẩm";
            // 
            // btnDeleteProducts
            // 
            btnDeleteProducts.Alignment = ToolStripItemAlignment.Right;
            btnDeleteProducts.Image = (Image)resources.GetObject("btnDeleteProducts.Image");
            btnDeleteProducts.ImageTransparentColor = Color.Magenta;
            btnDeleteProducts.Name = "btnDeleteProducts";
            btnDeleteProducts.Size = new Size(59, 24);
            btnDeleteProducts.Text = "Xóa";
            btnDeleteProducts.Click += btnDeleteProducts_Click;
            // 
            // btnUpdateProducts
            // 
            btnUpdateProducts.Alignment = ToolStripItemAlignment.Right;
            btnUpdateProducts.Image = (Image)resources.GetObject("btnUpdateProducts.Image");
            btnUpdateProducts.ImageTransparentColor = Color.Magenta;
            btnUpdateProducts.Name = "btnUpdateProducts";
            btnUpdateProducts.Size = new Size(92, 24);
            btnUpdateProducts.Text = "Cập nhật";
            btnUpdateProducts.Click += btnUpdateProducts_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.Alignment = ToolStripItemAlignment.Right;
            btnAddProducts.Image = (Image)resources.GetObject("btnAddProducts.Image");
            btnAddProducts.ImageTransparentColor = Color.Magenta;
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(70, 24);
            btnAddProducts.Text = "Thêm";
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // btnTangDan
            // 
            btnTangDan.AccessibleDescription = "";
            btnTangDan.Alignment = ToolStripItemAlignment.Right;
            btnTangDan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnTangDan.Image = (Image)resources.GetObject("btnTangDan.Image");
            btnTangDan.ImageTransparentColor = Color.Magenta;
            btnTangDan.Name = "btnTangDan";
            btnTangDan.Size = new Size(29, 24);
            btnTangDan.Text = "toolStripButton1";
            btnTangDan.Click += btnTangDan_Click;
            // 
            // btnGiamDan
            // 
            btnGiamDan.AccessibleDescription = "";
            btnGiamDan.Alignment = ToolStripItemAlignment.Right;
            btnGiamDan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGiamDan.ForeColor = SystemColors.ControlLight;
            btnGiamDan.Image = (Image)resources.GetObject("btnGiamDan.Image");
            btnGiamDan.ImageTransparentColor = Color.Magenta;
            btnGiamDan.Name = "btnGiamDan";
            btnGiamDan.Size = new Size(29, 24);
            btnGiamDan.Text = "toolStripButton2";
            btnGiamDan.Click += btnGiamDan_Click;
            // 
            // avtBook
            // 
            avtBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            avtBook.BorderStyle = BorderStyle.FixedSingle;
            avtBook.Location = new Point(624, 30);
            avtBook.Name = "avtBook";
            avtBook.Size = new Size(187, 201);
            avtBook.SizeMode = PictureBoxSizeMode.StretchImage;
            avtBook.TabIndex = 9;
            avtBook.TabStop = false;
            avtBook.Click += avtBook_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 10;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(237, 241);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Toàn bộ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(98, 24);
            toolStripLabel2.Text = "Đơn giá: VNĐ";
            // 
            // FrmQlySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 610);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(avtBook);
            Controls.Add(panel1);
            Controls.Add(txtdongia);
            Controls.Add(txtsoluong);
            Controls.Add(txttensanpham);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmQlySanPham";
            Text = "Quản lý sản phẩm";
            Load += FrmQlySanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanphamDTOBindingSource).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avtBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txttensanpham;
        private TextBox txtsoluong;
        private TextBox txtdongia;
        private Panel panel1;
        private DataGridView dgvProducts;
        private PictureBox avtBook;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnDeleteProducts;
        private ToolStripButton btnUpdateProducts;
        private ToolStripButton btnAddProducts;
        private BindingSource sanphamDTOBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtAmount;
        private ToolStripButton btnTangDan;
        private ToolStripButton btnGiamDan;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn tensanphamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anhDataGridViewTextBoxColumn;
        private Button button1;
        private ToolStripLabel toolStripLabel2;
    }
}