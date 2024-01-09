namespace QuanLyNhaSach.Pages
{
    partial class FrmQlyDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQlyDoanhThu));
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            panel1 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lbtongdoanhthu = new ToolStripStatusLabel();
            dgvProducts = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tensanphamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soluongbanduocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tongtienbanduocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            doanhthuDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            btntangdan = new ToolStripButton();
            btngiamdan = new ToolStripButton();
            avtBook = new PictureBox();
            lbId = new Label();
            lbName = new Label();
            lbPrice = new Label();
            btnOK = new Button();
            lbSumDoanhThu = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doanhthuDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avtBook).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "dd/MM/yyyy";
            dtpStart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(53, 42);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 31);
            dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd/MM/yyyy";
            dtpEnd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(327, 42);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 31);
            dtpEnd.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(dgvProducts);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(12, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 612);
            panel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lbtongdoanhthu });
            statusStrip1.Location = new Point(0, 581);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(932, 31);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(149, 25);
            toolStripStatusLabel1.Text = "Tổng doanh thu:";
            // 
            // lbtongdoanhthu
            // 
            lbtongdoanhthu.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbtongdoanhthu.ForeColor = Color.Red;
            lbtongdoanhthu.Name = "lbtongdoanhthu";
            lbtongdoanhthu.Size = new Size(22, 25);
            lbtongdoanhthu.Text = "0";
            // 
            // dgvProducts
            // 
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tensanphamDataGridViewTextBoxColumn, soluongbanduocDataGridViewTextBoxColumn, tongtienbanduocDataGridViewTextBoxColumn });
            dgvProducts.DataSource = doanhthuDTOBindingSource;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 28);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(932, 584);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 130;
            // 
            // tensanphamDataGridViewTextBoxColumn
            // 
            tensanphamDataGridViewTextBoxColumn.DataPropertyName = "tensanpham";
            tensanphamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            tensanphamDataGridViewTextBoxColumn.MinimumWidth = 6;
            tensanphamDataGridViewTextBoxColumn.Name = "tensanphamDataGridViewTextBoxColumn";
            tensanphamDataGridViewTextBoxColumn.Width = 450;
            // 
            // soluongbanduocDataGridViewTextBoxColumn
            // 
            soluongbanduocDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            soluongbanduocDataGridViewTextBoxColumn.DataPropertyName = "soluongbanduoc";
            soluongbanduocDataGridViewTextBoxColumn.HeaderText = "Số lượng bán được";
            soluongbanduocDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongbanduocDataGridViewTextBoxColumn.Name = "soluongbanduocDataGridViewTextBoxColumn";
            // 
            // tongtienbanduocDataGridViewTextBoxColumn
            // 
            tongtienbanduocDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tongtienbanduocDataGridViewTextBoxColumn.DataPropertyName = "tongtienbanduoc";
            tongtienbanduocDataGridViewTextBoxColumn.HeaderText = "Tổng tiền bán được";
            tongtienbanduocDataGridViewTextBoxColumn.MinimumWidth = 6;
            tongtienbanduocDataGridViewTextBoxColumn.Name = "tongtienbanduocDataGridViewTextBoxColumn";
            // 
            // doanhthuDTOBindingSource
            // 
            doanhthuDTOBindingSource.DataSource = typeof(DTO.doanhthuDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, btntangdan, btngiamdan });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(932, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(92, 25);
            toolStripLabel1.Text = "Sản phẩm";
            // 
            // btntangdan
            // 
            btntangdan.Alignment = ToolStripItemAlignment.Right;
            btntangdan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btntangdan.Image = (Image)resources.GetObject("btntangdan.Image");
            btntangdan.ImageTransparentColor = Color.Magenta;
            btntangdan.Name = "btntangdan";
            btntangdan.Size = new Size(29, 25);
            btntangdan.Text = "toolStripButton1";
            btntangdan.Click += btntangdan_Click;
            // 
            // btngiamdan
            // 
            btngiamdan.Alignment = ToolStripItemAlignment.Right;
            btngiamdan.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btngiamdan.Image = (Image)resources.GetObject("btngiamdan.Image");
            btngiamdan.ImageTransparentColor = Color.Magenta;
            btngiamdan.Name = "btngiamdan";
            btngiamdan.Size = new Size(29, 25);
            btngiamdan.Text = "toolStripButton1";
            btngiamdan.Click += btngiamdan_Click;
            // 
            // avtBook
            // 
            avtBook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            avtBook.BorderStyle = BorderStyle.FixedSingle;
            avtBook.Location = new Point(142, 16);
            avtBook.Name = "avtBook";
            avtBook.Size = new Size(275, 275);
            avtBook.SizeMode = PictureBoxSizeMode.StretchImage;
            avtBook.TabIndex = 10;
            avtBook.TabStop = false;
            // 
            // lbId
            // 
            lbId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbId.Location = new Point(301, 370);
            lbId.Name = "lbId";
            lbId.Size = new Size(38, 38);
            lbId.TabIndex = 11;
            lbId.Text = "...";
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(301, 414);
            lbName.Name = "lbName";
            lbName.Size = new Size(38, 38);
            lbName.TabIndex = 12;
            lbName.Text = "...";
            // 
            // lbPrice
            // 
            lbPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrice.Location = new Point(301, 458);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(38, 38);
            lbPrice.TabIndex = 13;
            lbPrice.Text = "...";
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Location = new Point(607, 42);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 31);
            btnOK.TabIndex = 14;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lbSumDoanhThu
            // 
            lbSumDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSumDoanhThu.AutoSize = true;
            lbSumDoanhThu.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbSumDoanhThu.ForeColor = Color.Red;
            lbSumDoanhThu.Location = new Point(301, 502);
            lbSumDoanhThu.Name = "lbSumDoanhThu";
            lbSumDoanhThu.Size = new Size(38, 38);
            lbSumDoanhThu.TabIndex = 15;
            lbSumDoanhThu.Text = "...";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbSumDoanhThu);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(avtBook);
            panel2.Controls.Add(lbId);
            panel2.Controls.Add(lbName);
            panel2.Controls.Add(lbPrice);
            panel2.Location = new Point(977, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 612);
            panel2.TabIndex = 16;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 502);
            label4.Name = "label4";
            label4.Size = new Size(273, 38);
            label4.TabIndex = 17;
            label4.Text = "Tổng tiền bán được:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 370);
            label3.Name = "label3";
            label3.Size = new Size(197, 38);
            label3.TabIndex = 16;
            label3.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 458);
            label2.Name = "label2";
            label2.Size = new Size(124, 38);
            label2.TabIndex = 15;
            label2.Text = "Đơn giá:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 414);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 14;
            label1.Text = "Tên sản phẩm:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(807, 92);
            button1.Name = "button1";
            button1.Size = new Size(137, 31);
            button1.TabIndex = 17;
            button1.Text = "Xuất hóa đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmQlyDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 753);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Name = "FrmQlyDoanhThu";
            Text = "FrmQlyDoanhThu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)doanhthuDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avtBook).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Panel panel1;
        private DataGridView dgvProducts;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private PictureBox avtBook;
        private Label lbId;
        private Label lbName;
        private Label lbPrice;
        private BindingSource doanhthuDTOBindingSource;
        private Button btnOK;
        private ToolStripButton btntangdan;
        private ToolStripButton btngiamdan;
        private Label lbSumDoanhThu;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tensanphamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongbanduocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongtienbanduocDataGridViewTextBoxColumn;
        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lbtongdoanhthu;
    }
}